<#
.SYNOPSIS
Builds installable wrapper modules end to end: Kiota client + generated cmdlets + compiled
dll + module manifest.

.DESCRIPTION
For each module name, reproduces the pipeline the Mail spike proved:

  1. kiota generate      -> <out>/<Module>/src/Client   (ApiClient + models)
  2. WrapperGenerator    -> <out>/<Module>/src/Cmdlets  (one *.g.cs per cmdlet)
  3. write csproj        -> <out>/<Module>/src/
  4. dotnet build        -> <out>/<Module>/src/bin/<Configuration>/net10.0/
  5. New-ModuleManifest  -> <ModuleName>.psd1 next to the dll

Both generators consume the SAME OpenAPI document, so the wrappers always match the client
they compile against.

The module is named Microsoft.Graph.Wrapper.<Module> so it imports side by side with an
installed official Microsoft.Graph.<Module> without collision.

The manifest exports EVERY cmdlet, including the internal *_Get/*_List workers: the public
Get-* dispatchers forward to the workers by name via InvokeCommand.InvokeScript, so a
manifest that hides the workers breaks dispatch ("term not recognized"). Worker visibility
needs its own dispatch design and is tracked in the module-wiring issue.

Everything is written under artifacts/ (gitignored); nothing this script produces is
committed. To check cmdlet-name parity for a built module, point the parity gate at its
cmdlets folder:
  .\tools\Compare-WrapperCmdletNames.ps1 -GeneratedPath artifacts\wrapper-modules\<Module>\src\Cmdlets

.PARAMETER Module
One or more module names, each matching an OpenAPI doc at <SpecRoot>/<ApiVersion>/<Module>.yml
(e.g. Mail, Calendar, Users.Actions).

.PARAMETER ApiVersion
v1.0 (default) or beta.

.PARAMETER SpecRoot
Root folder of the OpenAPI docs. Default: <repo>/openApiDocs_KiotaCompat — the Kiota-suitable
conversion (style=Plain, discriminators preserved). The PowerShell-profile docs under
openApiDocs flatten types like microsoft.graph.Dictionary into empty schemas, which kiota
rejects (Search, Identity.SignIns, Identity.Governance, ConfigurationManagement) or hangs on
(Sites). A module missing under SpecRoot falls back to <repo>/openApiDocs with a warning.

.PARAMETER OutputRoot
Root folder for the built modules. Default: <repo>/artifacts/wrapper-modules.

.PARAMETER Configuration
dotnet build configuration. Default: Debug.

.PARAMETER SkipKiota
Reuse the previously generated client (fast inner loop when only the wrappers changed).

.EXAMPLE
.\tools\Build-WrapperModule.ps1 -Module Mail

.EXAMPLE
.\tools\Build-WrapperModule.ps1 -Module Mail,Calendar -ApiVersion v1.0
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string[]]$Module,
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion = 'v1.0',
    [string]$SpecRoot,
    [string]$OutputRoot,
    [string]$Configuration = 'Debug',
    [switch]$SkipKiota
)

$ErrorActionPreference = 'Stop'

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $SpecRoot) { $SpecRoot = Join-Path $repoRoot 'openApiDocs_KiotaCompat' }
if (-not $OutputRoot) { $OutputRoot = Join-Path $repoRoot 'artifacts\wrapper-modules' }
$generatorProject = Join-Path $repoRoot 'tools\WrapperGenerator'
$authCsproj = Join-Path $repoRoot 'src\Authentication\Authentication\Microsoft.Graph.Authentication.csproj'

if (-not (Get-Command kiota -ErrorAction SilentlyContinue)) {
    Write-Error "kiota CLI not found on PATH. Install: dotnet tool install --global Microsoft.OpenApi.Kiota"
    exit 1
}

# Same extraction the parity gate uses: the emitted [Cmdlet(VerbsX.Verb, "Noun")] attribute
# is the source of truth for what the dll will export, without having to load the assembly.
$cmdletAttrPattern = '\[Cmdlet\(Verbs\w+\.(\w+),\s*"((?:\\.|[^"\\])*)"'
function Get-EmittedCmdletNames {
    param([string]$CmdletsDir)
    Get-ChildItem -Path $CmdletsDir -Filter '*.g.cs' -File | ForEach-Object {
        $match = [regex]::Match((Get-Content -Path $_.FullName -Raw), $cmdletAttrPattern)
        if ($match.Success) {
            "$($match.Groups[1].Value)-$([regex]::Unescape($match.Groups[2].Value))"
        }
    }
}

function Build-OneModule {
    param([string]$Name)

    $started = Get-Date
    $result = [pscustomobject]@{
        Module = $Name; Status = 'FAILED'; FailedAt = ''; CmdletCount = 0; Psd1 = ''; Seconds = 0; Error = ''
    }

    try {
        $spec = Join-Path $SpecRoot "$ApiVersion\$Name.yml"
        if (-not (Test-Path $spec)) {
            $fallback = Join-Path $repoRoot "openApiDocs\$ApiVersion\$Name.yml"
            if (Test-Path $fallback) {
                Write-Warning "$Name has no doc under $SpecRoot; falling back to $fallback"
                $spec = $fallback
            }
            else { $result.FailedAt = 'spec'; $result.Error = "no OpenAPI doc at $spec"; return $result }
        }

        $moduleName = "Microsoft.Graph.Wrapper.$Name"
        $clientNs = "Microsoft.Graph.PowerShell.$Name.Client"
        $srcDir = Join-Path $OutputRoot "$Name\src"
        $clientDir = Join-Path $srcDir 'Client'
        $cmdletsDir = Join-Path $srcDir 'Cmdlets'
        New-Item -ItemType Directory -Force -Path $srcDir | Out-Null

        if (-not $SkipKiota -or -not (Test-Path (Join-Path $clientDir 'ApiClient.cs'))) {
            # Run kiota with a hard timeout: it can hang silently on some specs (v1.0 Sites sat
            # idle for 35+ minutes with zero CPU), and a hung child must fail this module, not
            # stall the whole fan-out. Successful runs take seconds, so 5 minutes is generous.
            $kiotaErrLog = Join-Path $srcDir 'kiota-stderr.log'
            $kiotaOutLog = Join-Path $srcDir 'kiota-stdout.log'
            $kiotaProc = Start-Process kiota -PassThru -NoNewWindow -RedirectStandardError $kiotaErrLog -RedirectStandardOutput $kiotaOutLog -ArgumentList @(
                'generate', '-l', 'CSharp', '-d', $spec, '-c', 'ApiClient', '-n', $clientNs,
                '-o', $clientDir, '--clean-output', '--log-level', 'Warning')
            if (-not $kiotaProc.WaitForExit(300000)) {
                $kiotaProc.Kill()
                $result.FailedAt = 'kiota'; $result.Error = 'timed out after 300s (hung, killed)'
                return $result
            }
            if ($kiotaProc.ExitCode -ne 0) {
                $result.FailedAt = 'kiota'
                $result.Error = (Get-Content -Path $kiotaErrLog -Tail 3 -ErrorAction SilentlyContinue) -join ' | '
                return $result
            }
        }

        $wrapperOut = & dotnet run --project $generatorProject -c $Configuration -- -d $spec -o $cmdletsDir -n $clientNs --api-version $ApiVersion 2>&1
        if ($LASTEXITCODE -ne 0) {
            # Skip warnings precede the failure; the exception message is what identifies it.
            $result.FailedAt = 'wrapper-generator'
            $lines = @($wrapperOut | ForEach-Object { "$_" })
            $exception = $lines | Where-Object { $_ -match 'Unhandled exception|Exception:' } | Select-Object -First 1
            $exceptionIndex = if ($exception) { $lines.IndexOf($exception) } else { -1 }
            $result.Error = if ($exceptionIndex -ge 0) {
                ($lines[$exceptionIndex..([Math]::Min($exceptionIndex + 5, $lines.Count - 1))] | Where-Object { $_ -notmatch '^\s+at ' }) -join ' | '
            } else {
                ($lines | Where-Object { $_ -notmatch '^\s+at ' } | Select-Object -First 6) -join ' | '
            }
            return $result
        }

        # Relative to $srcDir rather than the absolute $authCsproj, so the csproj is portable
        # across clones and stays correct if a module's output folder ever moves (the eventual
        # src/<Module>/<ApiVersion>/ commit target sits at a different depth than
        # artifacts/wrapper-modules/<Module>/src/).
        $csprojPath = Join-Path $srcDir "$moduleName.csproj"
        $authCsprojRelative = [System.IO.Path]::GetRelativePath($srcDir, $authCsproj) -replace '/', '\'
        @"
<!-- Generated by tools/Build-WrapperModule.ps1 - do not edit or commit. -->
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <LangVersion>latest</LangVersion>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <AssemblyName>$moduleName</AssemblyName>
    <!-- Copy every dependency next to the module dll so Import-Module resolves them. -->
    <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
    <NoWarn>`$(NoWarn);CS1591</NoWarn>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.Kiota.Bundle" Version="2.0.0" />
    <PackageReference Include="PowerShellStandard.Library" Version="5.1.1" PrivateAssets="all" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="$authCsprojRelative" />
  </ItemGroup>

</Project>
"@ | Set-Content -Path $csprojPath -Encoding utf8

        $buildOut = & dotnet build $csprojPath -c $Configuration --nologo -v minimal 2>&1
        if ($LASTEXITCODE -ne 0) {
            $result.FailedAt = 'build'
            $result.Error = ($buildOut | Where-Object { $_ -match 'error' } | Select-Object -First 3) -join ' | '
            return $result
        }

        $cmdlets = @(Get-EmittedCmdletNames -CmdletsDir $cmdletsDir)
        if ($cmdlets.Count -eq 0) { $result.FailedAt = 'manifest'; $result.Error = 'no cmdlets emitted'; return $result }

        $binDir = Join-Path $srcDir "bin\$Configuration\net10.0"
        $psd1Path = Join-Path $binDir "$moduleName.psd1"
        New-ModuleManifest -Path $psd1Path `
            -RootModule "$moduleName.dll" `
            -ModuleVersion '0.1.0' `
            -Author 'Microsoft Graph' -CompanyName 'Microsoft' `
            -Description "Generated Kiota-based wrapper module for $Name ($ApiVersion). Test build - not for release." `
            -CmdletsToExport $cmdlets `
            -FunctionsToExport @() -AliasesToExport @() -VariablesToExport @()

        $result.Status = 'OK'
        $result.CmdletCount = $cmdlets.Count
        $result.Psd1 = $psd1Path
        return $result
    }
    catch {
        if (-not $result.FailedAt) { $result.FailedAt = 'unexpected' }
        $result.Error = $_.Exception.Message
        return $result
    }
    finally {
        $result.Seconds = [math]::Round(((Get-Date) - $started).TotalSeconds, 1)
    }
}

$results = foreach ($name in $Module) {
    Write-Host "=== $name ===" -ForegroundColor Cyan
    $r = Build-OneModule -Name $name
    if ($r.Status -eq 'OK') {
        Write-Host "  OK: $($r.CmdletCount) cmdlets -> $($r.Psd1) ($($r.Seconds)s)" -ForegroundColor Green
    }
    else {
        Write-Host "  FAILED at $($r.FailedAt): $($r.Error)" -ForegroundColor Yellow
    }
    $r
}

Write-Host ''
$results | Format-Table Module, Status, FailedAt, CmdletCount, Seconds -AutoSize | Out-Host

if ($results.Status -contains 'FAILED') { exit 1 }
exit 0

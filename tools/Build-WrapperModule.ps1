<#
.SYNOPSIS
Builds installable wrapper modules end to end: Kiota client + generated cmdlets + compiled
dll + module manifest.

.DESCRIPTION
For each module name, reproduces the pipeline the Mail spike proved:

Writing to src/<Module>/wrapper/<ApiVersion>/:

  1. kiota generate        -> Client/                    (ApiClient + models)
  2. WrapperGenerator      -> Cmdlets/                   (one *.g.cs per cmdlet)
  3. write client project  -> Client/Client.csproj
  4. write wrapper project -> <ModuleName>.csproj        (references the client)
  5. dotnet build          -> bin/<Configuration>/<TargetFramework>/
  6. New-ModuleManifest    -> <ModuleName>.psd1 next to the dll
  7. dotnet pack (-Pack)   -> <ArtifactsLocation>/<Module>/<ModuleName>.<version>.nupkg

Both generators consume the SAME OpenAPI document, so the wrappers always match the client
they compile against.

The module is named Microsoft.Graph.Wrapper.<Module> so it imports side by side with an
installed official Microsoft.Graph.<Module> without collision.

The manifest exports EVERY cmdlet, including the internal *_Get/*_List workers: the public
Get-* dispatchers forward to the workers by name via InvokeCommand.InvokeScript, so a
manifest that hides the workers breaks dispatch ("term not recognized"). Worker visibility
needs its own dispatch design and is tracked in the module-wiring issue.

Output is written to the committed layout at src/<Module>/wrapper/<ApiVersion>/, where the
client project, the wrapper project and their sources live together so the folder builds on its
own. The API version sits under wrapper/ because AutoRest owns src/<Module>/<ApiVersion>/ and
clears it on every run.
To check cmdlet-name parity for a built module, point the parity gate at its cmdlets folder:
  .\tools\Compare-WrapperCmdletNames.ps1 -GeneratedPath src\<Module>\wrapper\<ApiVersion>\Cmdlets

.PARAMETER Module
One or more module names, each matching an OpenAPI doc at <SpecRoot>/<ApiVersion>/<Module>.yml
(e.g. Mail, Calendar). Omit to build every module configured for the API version, derived from
config/ModulesMapping.jsonc intersected with the specs under <SpecRoot>/<ApiVersion>.

.PARAMETER ApiVersion
v1.0 (default) or beta.

.PARAMETER SpecRoot
Root folder of the OpenAPI docs. Default: <repo>/openApiDocs_KiotaCompat — the Kiota-suitable
conversion (style=Plain, discriminators preserved). The PowerShell-profile docs under
openApiDocs flatten types like microsoft.graph.Dictionary into empty schemas, which kiota
rejects (Search, Identity.SignIns, Identity.Governance, ConfigurationManagement) or hangs on
(Sites). A module missing under SpecRoot falls back to <repo>/openApiDocs with a warning.

.PARAMETER Configuration
dotnet build configuration. Default: Debug.

.PARAMETER SkipKiota
Reuse the previously generated client (fast inner loop when only the wrappers changed).

.PARAMETER Pack
Also produce a package per module under <ArtifactsLocation>/<Module>/.

.PARAMETER ArtifactsLocation
Where -Pack writes packages. Default: <repo>/artifacts.

.EXAMPLE
.\tools\Build-WrapperModule.ps1 -Module Mail

.EXAMPLE
.\tools\Build-WrapperModule.ps1 -Module Mail,Calendar -ApiVersion v1.0

.EXAMPLE
.\tools\Build-WrapperModule.ps1 -ApiVersion v1.0 -Pack
#>
[CmdletBinding()]
param(
    [string[]]$Module = @(),
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion = 'v1.0',
    [string]$SpecRoot,
    [string]$Configuration = 'Debug',
    [string]$ModuleMappingConfigPath,
    [string]$ArtifactsLocation,
    [switch]$SkipKiota,
    [switch]$Pack
)

$ErrorActionPreference = 'Stop'

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $SpecRoot) { $SpecRoot = Join-Path $repoRoot 'openApiDocs_KiotaCompat' }
$generatorProject = Join-Path $repoRoot 'tools\WrapperGenerator'
$authCsproj = Join-Path $repoRoot 'src\Authentication\Authentication\Microsoft.Graph.Authentication.csproj'
$runtimeCsproj = Join-Path $repoRoot 'src\GraphWrapperRuntime\Runtime\Microsoft.Graph.Wrapper.Runtime.csproj'
# The Authentication version the wrappers compile against, for the manifest's RequiredModules
# minimum. Read from the project, never written here.
$authVersion = ([xml](Get-Content $authCsproj -Raw)).Project.PropertyGroup.Version |
    Where-Object { $_ } | Select-Object -First 1
if (-not $authVersion) { throw "no Version in $authCsproj" }
$authVersion = "$authVersion".Trim()
$clientProjectTemplate = Join-Path $PSScriptRoot 'Templates\WrapperClient.csproj.template'
$moduleProjectTemplate = Join-Path $PSScriptRoot 'Templates\WrapperModule.csproj.template'

# The framework is declared once, in the template that emits the module project. Reading it back
# here is what stops this script looking for build output in a folder the compiler stopped
# writing to: a literal copy silently points at a stale path the moment the template changes.
$targetFramework = ([xml](Get-Content $moduleProjectTemplate -Raw)).Project.PropertyGroup.TargetFramework |
    Where-Object { $_ } | Select-Object -First 1
if (-not $targetFramework) { throw "no TargetFramework in $moduleProjectTemplate" }
$targetFramework = "$targetFramework".Trim()

if (-not $ModuleMappingConfigPath) { $ModuleMappingConfigPath = Join-Path $repoRoot 'config\ModulesMapping.jsonc' }
if (-not $ArtifactsLocation) { $ArtifactsLocation = Join-Path $repoRoot 'artifacts' }

# Package metadata comes from the same single source the AutoRest service modules use, so a
# wrapper package and the module it will eventually replace cannot disagree about version or
# ownership.
$moduleMetadataPath = Join-Path $repoRoot 'config\ModuleMetadata.json'
[hashtable]$moduleMetadata = Get-Content $moduleMetadataPath -Raw | ConvertFrom-Json -AsHashTable
$versionEntry = $moduleMetadata.versions[$ApiVersion]
if (-not $versionEntry -or -not $versionEntry.version) { throw "No version configured for '$ApiVersion' in $moduleMetadataPath." }
$moduleVersion = $versionEntry.version
$modulePrerelease = $versionEntry.prerelease
$fullVersion = if ($modulePrerelease) { "$moduleVersion-$modulePrerelease" } else { $moduleVersion }

# The population is the specs this generator can actually read, intersected with the modules the
# repository is configured to ship - the same two inputs tools/GenerateServiceModule.ps1 uses.
# Which of them yield CMDLETS is deliberately not decided here: a spec that generates only
# Shared.g.cs falls out downstream as "no cmdlets emitted", measured per run from the compiled
# assembly. Encoding those names as an exclusion list would keep excusing a module after the
# generator learned to handle its shape.
if (-not $Module -or $Module.Count -eq 0) {
    if (-not (Test-Path $ModuleMappingConfigPath)) { throw "Module mapping file not found: $ModuleMappingConfigPath." }
    [hashtable]$moduleMapping = Get-Content $ModuleMappingConfigPath -Raw | ConvertFrom-Json -AsHashTable
    $specDir = Join-Path $SpecRoot $ApiVersion
    $Module = @(Get-ChildItem $specDir -File -Filter '*.yml' -ErrorAction SilentlyContinue |
            ForEach-Object BaseName |
            Where-Object { $moduleMapping.ContainsKey($_) } |
            Sort-Object)
    if ($Module.Count -eq 0) { throw "No configured modules found for '$ApiVersion' under $specDir." }
    Write-Host "No -Module supplied; building all $($Module.Count) configured module(s) for $ApiVersion." -ForegroundColor DarkGray
}

if (-not (Get-Command kiota -ErrorAction SilentlyContinue)) {
    Write-Error "kiota CLI not found on PATH. Install: dotnet tool install --global Microsoft.OpenApi.Kiota"
    exit 1
}

function New-ProjectFromTemplate {
    param(
        [Parameter(Mandatory)][string]$TemplatePath,
        [Parameter(Mandatory)][string]$DestinationPath,
        [Parameter(Mandatory)][hashtable]$Replacements
    )

    $content = Get-Content -Path $TemplatePath -Raw
    foreach ($placeholder in $Replacements.Keys) {
        $content = $content.Replace("{$placeholder}", $Replacements[$placeholder])
    }
    $unresolved = [regex]::Matches($content, '\{[A-Za-z][A-Za-z0-9]*\}') | ForEach-Object Value | Sort-Object -Unique
    if ($unresolved) {
        throw "unresolved placeholder(s) in $TemplatePath`: $($unresolved -join ', ')"
    }
    Set-Content -Path $DestinationPath -Value $content -Encoding utf8
}

function Get-CompiledCmdletNames {
    param([Parameter(Mandatory)][string]$AssemblyPath)

    # Import in a child process so discovery observes the compiled binary PowerShell will load,
    # and so assemblies from one module cannot contaminate or lock the next module's build.
    # Microsoft.Graph.Authentication comes first for the same reason it is in RequiredModules:
    # the module folder deliberately carries no shared dependencies (PruneModuleBin), so kiota
    # assemblies resolve through Authentication's AssemblyResolve hook. Import-Module forces
    # some of those loads immediately - a cmdlet property typed as the Date/Time structs from
    # Microsoft.Kiota.Abstractions is a value-type field, which the loader resolves eagerly at
    # class load, before any cmdlet runs.
    $escapedAssemblyPath = $AssemblyPath.Replace("'", "''")
    $discovery = @"
`$ErrorActionPreference = 'Stop'
Import-Module Microsoft.Graph.Authentication
`$module = Import-Module -Name '$escapedAssemblyPath' -PassThru
[pscustomobject]@{ Cmdlets = @(`$module.ExportedCmdlets.Keys | Sort-Object) } |
    ConvertTo-Json -Compress
"@
    $encodedDiscovery = [Convert]::ToBase64String([Text.Encoding]::Unicode.GetBytes($discovery))
    $output = & pwsh -NoProfile -NonInteractive -EncodedCommand $encodedDiscovery 2>&1
    if ($LASTEXITCODE -ne 0) {
        throw "compiled module discovery failed: $(($output | Select-Object -Last 3) -join ' | ')"
    }
    $json = $output | Where-Object { $_ -match '^\{' } | Select-Object -Last 1
    if (-not $json) { throw 'compiled module discovery produced no result' }
    @((ConvertFrom-Json $json).Cmdlets)
}

function Build-Module {
    param([string]$Name)

    $started = Get-Date
    $result = [pscustomobject]@{
        Module = $Name; Status = 'FAILED'; FailedAt = ''; CmdletCount = 0; Psd1 = ''; Nupkg = ''; Seconds = 0; Error = ''; Detail = ''
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
        # src/<Module>/wrapper/<ApiVersion>/ - NOT src/<Module>/<ApiVersion>/wrapper/.
        # AutoRest is configured with clear-output-folder: true and an output folder of
        # src/<Module>/<ApiVersion> (src/readme.graph.md:41-42, GenerateServiceModule.ps1:53), so
        # it wipes that directory on every run. Committed wrapper source placed inside it is
        # silently deleted the next time anyone regenerates the AutoRest modules - observed:
        # generating Mail removed its wrapper tree. src/<Module>/ itself is not cleared, so
        # nesting the API version UNDER wrapper/ keeps the sources safe while both generators
        # coexist, and still satisfies "a committable project layout under src/{Module}/".
        $srcDir = Join-Path $repoRoot "src\$Name\wrapper\$ApiVersion"
        $clientDir = Join-Path $srcDir 'Client'
        $cmdletsDir = Join-Path $srcDir 'Cmdlets'
        New-Item -ItemType Directory -Force -Path $srcDir | Out-Null

        if (-not $SkipKiota -or -not (Test-Path (Join-Path $clientDir 'ApiClient.cs'))) {
            # Run kiota with a hard timeout: it can hang silently on some specs (v1.0 Sites sat
            # idle for 35+ minutes with zero CPU), and a hung child must fail this module, not
            # stall the whole fan-out. Successful runs take seconds, so 5 minutes is generous.
            $kiotaErrLog = Join-Path $srcDir 'kiota-stderr.log'
            $kiotaOutLog = Join-Path $srcDir 'kiota-stdout.log'

            # The hang is INTERMITTENT, not spec-specific: v1.0 Teams timed out here at 300s and
            # then generated in 27s from the same document on the next attempt. A single transient
            # stall must not fail a whole-population run, so the timeout is retried. A genuine
            # exit-code failure is not retried - that is deterministic and retrying only hides it.
            $kiotaAttempts = 2
            $kiotaTimedOut = $false
            for ($attempt = 1; $attempt -le $kiotaAttempts; $attempt++) {
                $kiotaProc = Start-Process kiota -PassThru -NoNewWindow -RedirectStandardError $kiotaErrLog -RedirectStandardOutput $kiotaOutLog -ArgumentList @(
                    'generate', '-l', 'CSharp', '-d', $spec, '-c', 'ApiClient', '-n', $clientNs,
                    '-o', $clientDir, '--clean-output', '--log-level', 'Warning')
                $kiotaTimedOut = -not $kiotaProc.WaitForExit(300000)
                if ($kiotaTimedOut) {
                    $kiotaProc.Kill()
                    Write-Warning "kiota timed out after 300s generating $Name (attempt $attempt of $kiotaAttempts)"
                    continue
                }
                break
            }
            if ($kiotaTimedOut) {
                $result.FailedAt = 'kiota'
                $result.Error = "timed out after 300s on all $kiotaAttempts attempt(s) (hung, killed)"
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
            $exceptionIndex = if ($exception) { [Array]::IndexOf($lines, $exception) } else { -1 }
            $result.Error = if ($exceptionIndex -ge 0) {
                ($lines[$exceptionIndex..([Math]::Min($exceptionIndex + 5, $lines.Count - 1))] | Where-Object { $_ -notmatch '^\s+at ' }) -join ' | '
            } else {
                ($lines | Where-Object { $_ -notmatch '^\s+at ' } | Select-Object -First 6) -join ' | '
            }
            return $result
        }

        $clientAssemblyName = "$moduleName.Client"
        $clientCsprojPath = Join-Path $clientDir 'Client.csproj'
        New-ProjectFromTemplate -TemplatePath $clientProjectTemplate -DestinationPath $clientCsprojPath -Replacements @{
            ClientAssemblyName = $clientAssemblyName
        }

        # Project references are relative so the committed projects build from any clone path.
        $csprojPath = Join-Path $srcDir "$moduleName.csproj"
        $authCsprojRelative = [System.IO.Path]::GetRelativePath($srcDir, $authCsproj) -replace '/', '\'
        $clientCsprojRelative = [System.IO.Path]::GetRelativePath($srcDir, $clientCsprojPath) -replace '/', '\'
        $runtimeCsprojRelative = [System.IO.Path]::GetRelativePath($srcDir, $runtimeCsproj) -replace '/', '\'
        New-ProjectFromTemplate -TemplatePath $moduleProjectTemplate -DestinationPath $csprojPath -Replacements @{
            ModuleAssemblyName = $moduleName
            ClientProjectPath = $clientCsprojRelative
            AuthenticationProjectPath = $authCsprojRelative
            RuntimeProjectPath = $runtimeCsprojRelative
        }

        $buildOut = & dotnet build $csprojPath -c $Configuration --nologo -v minimal 2>&1
        if ($LASTEXITCODE -ne 0) {
            $result.FailedAt = 'build'
            $result.Error = ($buildOut | Where-Object { $_ -match 'error' } | Select-Object -First 3) -join ' | '
            return $result
        }

        $binDir = Join-Path $srcDir "bin\$Configuration\$targetFramework"
        $assemblyPath = Join-Path $binDir "$moduleName.dll"
        $cmdlets = @(Get-CompiledCmdletNames -AssemblyPath $assemblyPath)
        if ($cmdlets.Count -eq 0) {
            # A terminal SUCCESS, not a failure. Some specs are entirely action/function shaped
            # and the generator emits only Shared.g.cs for them; the module compiles fine and
            # simply has nothing to export, so there is no manifest and no package. Which specs
            # those are is measured here from the compiled assembly on every run rather than
            # listed anywhere, so a module starts producing a module the moment the generator
            # learns its shape - and a whole-population run is not turned red by an outcome that
            # is expected and correct.
            $result.Status = 'NO-CMDLETS'
            $result.Detail = 'compiled, but the assembly exports no cmdlets'
            # Remove what was just generated. A module with nothing to export ships nothing, so
            # it must own nothing either: leaving the tree behind would commit hundreds of
            # generated client files that no assembly, manifest or package ever references.
            Remove-Item -LiteralPath $srcDir -Recurse -Force -ErrorAction SilentlyContinue
            return $result
        }

        $psd1Path = Join-Path $binDir "$moduleName.psd1"
        # RequiredModules makes PowerShell load the REAL Microsoft.Graph.Authentication module
        # before this one, so the wrapper binds to its already-loaded assemblies and shares its
        # GraphSession. Without it, Windows PowerShell's version-strict loader lazily loads the
        # module-local copy of the Authentication dll beside the installed one - two assemblies,
        # two GraphSession statics - and every cmdlet reports NoGraphSession while the user IS
        # connected. Proven by a marker-client experiment in both hosts; the module-local copies
        # are kept out of bin entirely for the same reason (PruneModuleBin in the module
        # project template), so neither the folder nor the package ever carries them.
        # The minimum version is the one this repository compiles against, read from the project
        # rather than written here, so a bump in the Authentication csproj cannot go stale.
        # ModuleVersion must equal the package version: installers lay the module out under a
        # <Name>\<Version> folder, and PowerShell refuses a manifest whose ModuleVersion does not
        # match that folder name - a hard-coded placeholder made every versioned-folder install
        # fail to import. Prerelease is carried separately, as manifests require.
        $manifestArgs = @{
            Path              = $psd1Path
            RootModule        = "$moduleName.dll"
            ModuleVersion     = $moduleVersion
            RequiredModules   = @(@{ ModuleName = 'Microsoft.Graph.Authentication'; ModuleVersion = $authVersion })
            Author            = 'Microsoft Graph'
            CompanyName       = 'Microsoft'
            Description       = "Generated Kiota-based wrapper module for $Name ($ApiVersion). Test build - not for release."
            CmdletsToExport   = $cmdlets
            FunctionsToExport = @()
            AliasesToExport   = @()
            VariablesToExport = @()
        }
        if ($modulePrerelease) { $manifestArgs.Prerelease = $modulePrerelease }
        # Std.UriTemplate is requested by the kiota HTTP library, which lives in Authentication's
        # isolated load context - a requester whose directory probing can never reach this module
        # folder, and whose request Authentication cannot serve because its Dependencies folder
        # does not ship the assembly. Preloading it here puts it in the default context, where
        # the isolated context's fallback resolution unifies with it. The Multipart serializer
        # needs no entry: its requester is the client assembly in this folder, so normal
        # module-directory probing finds it. Proven live in Test-LiveSmoke on the session path.
        $manifestArgs.RequiredAssemblies = @('Std.UriTemplate.dll')
        New-ModuleManifest @manifestArgs

        if ($Pack) {
            # The package IS the module folder: manifest plus every assembly in bin. Nothing is
            # listed or excluded by name here, because bin already contains exactly what may
            # ship: the PowerShell SDK reference assembly is kept out via ExcludeAssets="runtime"
            # and the shared Authentication/kiota closure via the PruneModuleBin target - both at
            # the project level, the only place that intent can be expressed. See
            # tools/Templates/WrapperModule.csproj.template for why the closure must not ship.
            $nuspecPath = Join-Path $binDir "$moduleName.nuspec"
            $tags = ($moduleMetadata['tags']) -join ' '
            # Native runtime payloads only exist when a dependency ships them; dotnet pack fails
            # outright on a <file> glob whose directory is absent, so the entry is emitted only
            # when the build actually produced one rather than assumed to be there.
            $runtimesEntry = if (Test-Path (Join-Path $binDir 'runtimes')) {
                "`n    <file src=`"runtimes\**\*.*`" target=`"runtimes`" />"
            } else { '' }
            @"
<?xml version="1.0" encoding="utf-8"?>
<package xmlns="http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd">
  <metadata>
    <id>$moduleName</id>
    <version>$fullVersion</version>
    <authors>$($moduleMetadata['authors'])</authors>
    <owners>$($moduleMetadata['owners'])</owners>
    <requireLicenseAcceptance>$($moduleMetadata['requireLicenseAcceptance'])</requireLicenseAcceptance>
    <licenseUrl>$($moduleMetadata['licenseUri'])</licenseUrl>
    <projectUrl>$($moduleMetadata['projectUri'])</projectUrl>
    <iconUrl>$($moduleMetadata['iconUri'])</iconUrl>
    <description>Kiota-based wrapper module for $Name ($ApiVersion).</description>
    <releaseNotes>$($moduleMetadata['releaseNotes'])</releaseNotes>
    <copyright>$($moduleMetadata['copyright'])</copyright>
    <tags>$tags</tags>
  </metadata>
  <files>
    <file src="$moduleName.psd1" />
    <file src="*.dll" />
    <file src="*.deps.json" />$runtimesEntry
  </files>
</package>
"@ | Set-Content -Path $nuspecPath -Encoding utf8

            $moduleArtifacts = Join-Path $ArtifactsLocation $Name
            New-Item -ItemType Directory -Force -Path $moduleArtifacts | Out-Null
            # NoPackageAnalysis matches the generated service-module csproj: without it NuGet
            # warns NU5100 once per assembly for not living under lib/, which is meaningless for
            # a PowerShell module package. NuspecBasePath resolves the globs against the build
            # output so the nuspec need not know how deep bin/<Config>/<TFM> is.
            $packArgs = @($csprojPath, '-c', $Configuration, '--no-build', '--nologo', '-v', 'minimal',
                "-p:NuspecFile=$nuspecPath", "-p:NuspecBasePath=$binDir", "-p:Version=$moduleVersion",
                '-p:NoPackageAnalysis=true', '-o', $moduleArtifacts)
            $packOut = & dotnet pack @packArgs 2>&1
            if ($LASTEXITCODE -ne 0) {
                $result.FailedAt = 'pack'
                $result.Error = ($packOut | Where-Object { $_ -match 'error' } | Select-Object -First 3) -join ' | '
                return $result
            }
            $nupkg = Join-Path $moduleArtifacts "$moduleName.$fullVersion.nupkg"
            if (-not (Test-Path $nupkg)) {
                $result.FailedAt = 'pack'
                $result.Error = "dotnet pack reported success but '$nupkg' is missing"
                return $result
            }
            $result.Nupkg = $nupkg
        }

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

        # A failure part-way through leaves a half-generated tree behind - kiota runs with
        # --clean-output, so a timeout wipes the previous client and then writes nothing usable.
        # Committing that is worse than having no tree at all: it looks like source but has no
        # project to build and no cmdlets to export.
        #
        # Only an UNUSABLE tree is removed, judged by what it contains rather than by which step
        # failed: a module project plus at least one emitted cmdlet is the minimum that can build,
        # so a tree holding both is left alone even on failure, and a valid committed tree is
        # never destroyed by an unrelated late-stage error.
        if ($result.Status -eq 'FAILED' -and $srcDir -and (Test-Path $srcDir)) {
            $hasProject = @(Get-ChildItem $srcDir -Filter '*.csproj' -File -ErrorAction SilentlyContinue).Count -gt 0
            $hasCmdlets = @(Get-ChildItem (Join-Path $srcDir 'Cmdlets') -Filter '*.g.cs' -File -ErrorAction SilentlyContinue |
                Where-Object Name -ne 'Shared.g.cs').Count -gt 0
            if (-not ($hasProject -and $hasCmdlets)) {
                Remove-Item -LiteralPath $srcDir -Recurse -Force -ErrorAction SilentlyContinue
                Write-Warning "removed incomplete wrapper tree for $Name after failure at '$($result.FailedAt)'"
            }
        }
    }
}

$results = foreach ($name in $Module) {
    Write-Host "=== $name ===" -ForegroundColor Cyan
    $r = Build-Module -Name $name
    switch ($r.Status) {
        'OK' { Write-Host "  OK: $($r.CmdletCount) cmdlets -> $($r.Psd1) ($($r.Seconds)s)" -ForegroundColor Green }
        'NO-CMDLETS' { Write-Host "  NO-CMDLETS: $($r.Detail) ($($r.Seconds)s)" -ForegroundColor DarkYellow }
        default { Write-Host "  FAILED at $($r.FailedAt): $($r.Error)" -ForegroundColor Yellow }
    }
    $r
}

Write-Host ''
$results | Format-Table Module, Status, FailedAt, CmdletCount, Seconds -AutoSize | Out-Host

$built = @($results | Where-Object Status -eq 'OK')
$noCmdlets = @($results | Where-Object Status -eq 'NO-CMDLETS')
$failed = @($results | Where-Object Status -eq 'FAILED')

Write-Host "$($built.Count) module(s) built, $($noCmdlets.Count) produced no cmdlets, $($failed.Count) failed." -ForegroundColor Cyan
if ($noCmdlets.Count) {
    # Named every run so a shrinking population stays visible: "all modules built" must never be
    # able to hide a module that quietly stopped producing anything.
    Write-Host "  no cmdlets: $(($noCmdlets.Module) -join ', ')" -ForegroundColor DarkYellow
}

if ($failed.Count) { exit 1 }
exit 0

<#
.SYNOPSIS
Generates Kiota builders, compiles ordinary DELETE wrappers and verifies offline PowerShell requests.

.DESCRIPTION
Run in a fresh noninteractive PowerShell 7 process with the locally packaged Authentication
module on PSModulePath. Builds the fixture with the repository's unchanged project templates.
Uses real offline Connect-MgGraph and GraphHttpClientFactory sessions with a terminal capture
handler after authentication; no live Graph/OAuth requests or dependency assembly injection.
Preserves generated sources, binaries and evidence in ArtifactRoot.

.EXAMPLE
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperRequiredDeleteQuery.ps1 -KiotaPath <kiota-1.36.1> -ArtifactRoot <new-directory>
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)][string]$KiotaPath,
    [Parameter(Mandatory)][string]$ArtifactRoot,
    [string]$BaselineCmdletsDirectory,
    [ValidateSet('v1.0', 'beta')][string]$ApiVersion = 'beta'
)

$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$generator = Join-Path $PSScriptRoot 'WrapperGenerator\bin\Debug\net10.0\WrapperGenerator.dll'
$runtimeProject = Join-Path $repo 'src\GraphWrapperRuntime\Runtime\Microsoft.Graph.Wrapper.Runtime.csproj'
$authProject = Join-Path $repo 'src\Authentication\Authentication\Microsoft.Graph.Authentication.csproj'
$fixture = Join-Path $PSScriptRoot 'WrapperGenerator.Tests\Fixtures\required-delete-query.yml'
$hostSource = Join-Path $PSScriptRoot 'WrapperGenerator.Tests\Fixtures\DeleteQueryProbeHost.cs'
function Assert-Probe([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}
function Invoke-Checked([string]$Program, [string[]]$Arguments) {
    $timer = [Diagnostics.Stopwatch]::StartNew()
    $log = Join-Path $ArtifactRoot "command-$($commandResults.Count).log"
    & $Program @Arguments 2>&1 | Tee-Object -FilePath $log | Out-Host
    $exitCode = $LASTEXITCODE
    $commandResults.Add([pscustomobject]@{
        Program = $Program; Arguments = $Arguments; ExitCode = $exitCode
        Seconds = $timer.Elapsed.TotalSeconds; Log = $log
    })
    $commandResults | ConvertTo-Json -Depth 4 | Set-Content (Join-Path $ArtifactRoot 'commands-results.json')
    if ($exitCode -ne 0) { throw "$Program exited $exitCode : $($Arguments -join ' ')" }
}
Assert-Probe ($PSEdition -eq 'Core') 'This proof requires PowerShell 7/Core.'
Assert-Probe (-not (Get-Module Microsoft.Graph.Authentication)) 'Run this proof in a fresh process.'
Assert-Probe (-not (Test-Path -LiteralPath $ArtifactRoot)) "ArtifactRoot must be new: $ArtifactRoot"
Assert-Probe (Test-Path -LiteralPath $generator) 'Build WrapperGenerator before running this probe.'
$version = & $KiotaPath --version
Assert-Probe ($LASTEXITCODE -eq 0 -and $version -like '1.36.1*') "Expected Kiota 1.36.1, got $version"
$null = New-Item -ItemType Directory -Path $ArtifactRoot
$ArtifactRoot = (Resolve-Path $ArtifactRoot).Path
$commandResults = [Collections.Generic.List[object]]::new()
$env:KIOTA_Generation__MaxDegreeOfParallelism = '1'
Import-Module Microsoft.Graph.Authentication -ErrorAction Stop
$auth = Get-Module Microsoft.Graph.Authentication
Assert-Probe ($auth.Version -ge [version]'2.41.2') 'The packaged Authentication 2.41.2 closure is required.'
Add-Type -Path $hostSource
$clientDirectory = Join-Path $ArtifactRoot 'Client'
Invoke-Checked $KiotaPath @('generate', '-d', $fixture, '-o', $clientDirectory,
    '-l', 'CSharp', '-c', 'ApiClient', '-n', 'DeleteQueryFixture.Client', '--ll', 'Warning')
$clientProject = Join-Path $clientDirectory 'Client.csproj'
$clientTemplate = Get-Content (Join-Path $PSScriptRoot 'Templates\WrapperClient.csproj.template') -Raw
$clientTemplate.Replace('{ClientAssemblyName}', 'Microsoft.Graph.PowerShell.DeleteQuery.Client') | Set-Content $clientProject
$moduleTemplate = Get-Content (Join-Path $PSScriptRoot 'Templates\WrapperModule.csproj.template') -Raw
$rootRoute = '/administrativeUnits/{administrativeUnit-id}/members/$ref'
$cases = @(
    @{ Label = 'Required'; Route = $rootRoute; Ids = @{ AdministrativeUnitId = 'unit /% space' }; Query = $true },
    @{ Label = 'Inherited'; Route = '/groups/{group-id}/members/$ref'; Ids = @{ GroupId = 'group /% space' }; Query = $true },
    @{ Label = 'Item'; Route = '/administrativeUnits/{administrativeUnit-id}/members/{directoryObject-id}/$ref';
       Ids = @{ AdministrativeUnitId = 'unit /% space'; DirectoryObjectId = 'member /% space' }; Query = $false },
    @{ Label = 'Neighbor'; Route = '/administrativeUnits/{administrativeUnit-id}';
       Ids = @{ AdministrativeUnitId = 'unit /% space' }; Query = $false }
)
if ($BaselineCmdletsDirectory) {
    $cases = @(@{ Label = 'Before'; Route = $rootRoute; Ids = @{ AdministrativeUnitId = 'unit /% space' }; Query = $false }) + $cases
}
$results = [System.Collections.Generic.List[object]]::new()
$builds = [Collections.Generic.List[object]]::new()
$null = Get-MgContext
$core = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Authentication.Core' })
Assert-Probe ($core.Count -eq 1) 'Expected a single packaged Authentication.Core assembly.'
$session = $core[0].GetType('Microsoft.Graph.PowerShell.Authentication.GraphSession', $true).GetProperty('Instance').GetValue($null)
. (Join-Path $repo 'src\Authentication\Authentication\test\TypeHelpers.ps1')
Set-MgTestDataStore
$factory = $core[0].GetType('Microsoft.Graph.PowerShell.Authentication.Core.Http.GraphHttpClientFactory', $true)
$token = 'offline-delete-query-token'
Connect-MgGraph -AccessToken (ConvertTo-SecureString $token -AsPlainText -Force) -NoWelcome -ErrorAction Stop
$handler = [DeleteQueryProbe.CaptureHandler]::new()
$client = $factory.GetMethod('Create').Invoke($null, @(
    $session.AuthContext, $session.RequestContext, [Net.Http.DelegatingHandler[]]@($handler), $null, $false
))
$session.GraphHttpClient = $client
Assert-Probe ([object]::ReferenceEquals($client, [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient())) 'Authentication did not retain the authenticated session client.'
$baseAddress = $client.BaseAddress
$endpoint = (Get-MgEnvironment -Name Global).GraphEndpoint.TrimEnd('/')
Assert-Probe ($baseAddress.AbsoluteUri -ceq "$endpoint/v1.0/") 'Expected the real session factory default v1.0 base address.'
$choiceHost = [DeleteQueryProbe.ChoiceHost]::new()
$runspace = [runspacefactory]::CreateRunspace($choiceHost)
$runspace.Open()
$engine = [powershell]::Create()
$engine.Runspace = $runspace
$module = $null

function Assert-DeleteRequest($Request, $Case, $Parameters) {
    $path = $Case.Route
    foreach ($entry in $Case.Ids.GetEnumerator()) {
        $placeholder = if ($entry.Key -eq 'DirectoryObjectId') { 'directoryObject-id' } elseif ($entry.Key -eq 'GroupId') { 'group-id' } else { 'administrativeUnit-id' }
        $path = $path.Replace("{$placeholder}", [uri]::EscapeDataString($entry.Value))
    }
    $expected = "$endpoint/$ApiVersion" + $path
    if ($Case.Query) { $expected += '?@id=' + [uri]::EscapeDataString($Parameters.Id) }
    if ($Case.Label -eq 'Before') { $expected += '?@id=' }
    Assert-Probe ($Request.Method -ceq 'DELETE' -and $Request.Uri -ceq $expected) "Exact encoded DELETE mismatch: $($Request.Uri) expected $expected"
    Assert-Probe ($Request.DecodedUri -ceq [uri]::UnescapeDataString($expected)) 'Decoded URI round trip failed.'
    if ($Case.Query) {
        Assert-Probe ([uri]::UnescapeDataString(([uri]$Request.Uri).Query.Substring(5)) -ceq $Parameters.Id) 'The full nonempty query value did not round-trip independently.'
    }
    Assert-Probe (-not $Request.HasContent -and $null -eq $Request.Body) 'DELETE introduced content/body serialization.'
    Assert-Probe ($Request.Authorization -ceq "Bearer $token") 'DELETE bypassed the real session authentication handler.'
    Assert-Probe ($Request.Headers['x-delete-query-probe'] -ceq 'custom-value') 'Custom headers were lost.'
    if ($Case.Label -ne 'Neighbor') { Assert-Probe ($Request.Headers['If-Match'] -ceq $Parameters.IfMatch) 'ETag was lost.' }
    Assert-Probe ([object]::ReferenceEquals($client, $session.GraphHttpClient) -and [object]::Equals($baseAddress, $client.BaseAddress)) 'The profile-aware DELETE mutated the authenticated session client/base address.'
}

try {
    foreach ($case in $cases) {
        $directory = Join-Path $ArtifactRoot $case.Label
        $cmdlets = Join-Path $directory 'Cmdlets'
        if ($case.Label -eq 'Before') {
            $null = New-Item -ItemType Directory -Path $cmdlets
            Copy-Item (Join-Path $BaselineCmdletsDirectory '*.g.cs') $cmdlets
        }
        else {
            Invoke-Checked 'dotnet' @($generator, '-d', $fixture, '-o', $cmdlets, '-n', 'DeleteQueryFixture.Client',
                '--api-version', $ApiVersion, '--no-collision-data', '--include-path', ($case.Route + '#DELETE'))
        }
        $assemblyName = 'Microsoft.Graph.Wrapper.DeleteQuery' + $case.Label
        $project = Join-Path $directory 'Probe.csproj'
        $moduleTemplate.Replace('{ModuleAssemblyName}', $assemblyName).
            Replace('{ClientProjectPath}', $clientProject).
            Replace('{AuthenticationProjectPath}', $authProject).
            Replace('{RuntimeProjectPath}', $runtimeProject) | Set-Content $project
        Invoke-Checked 'dotnet' @('build', $project, '-c', 'Release', '--nologo', '-v', 'quiet')
        $bin = Join-Path $directory 'bin\Release\netstandard2.0'
        $dlls = @(Get-ChildItem -LiteralPath $bin -Filter '*.dll' -File | Select-Object -ExpandProperty Name | Sort-Object)
        $expectedDlls = @('Microsoft.Graph.PowerShell.DeleteQuery.Client.dll', 'Microsoft.Graph.Wrapper.Runtime.dll', "$assemblyName.dll") | Sort-Object
        Assert-Probe (($dlls -join ',') -ceq ($expectedDlls -join ',')) "Wrapper must carry only its three owned DLLs: $($dlls -join ',')"
        $manifest = Join-Path $bin ($assemblyName + '.psd1')
        New-ModuleManifest -Path $manifest -RootModule ($assemblyName + '.dll') -ModuleVersion '1.0.0' `
            -RequiredModules @(@{ ModuleName = 'Microsoft.Graph.Authentication'; ModuleVersion = $auth.Version }) `
            -FunctionsToExport @() -AliasesToExport @()
        Assert-Probe (-not (Import-PowerShellDataFile $manifest).RequiredAssemblies) 'Wrapper manifest preloaded a dependency.'
        $builds.Add([pscustomobject]@{
            Case = $case.Label; Manifest = $manifest; Dlls = $dlls
            Artifacts = @(Get-ChildItem -LiteralPath $bin -File | ForEach-Object {
                [pscustomobject]@{ Path = $_.FullName; Sha256 = (Get-FileHash -LiteralPath $_.FullName -Algorithm SHA256).Hash }
            })
        })
        $module = Import-Module $manifest -PassThru -ErrorAction Stop
        $commands = @($module.ExportedCmdlets.Values)
        Assert-Probe ($commands.Count -eq 1) "Expected exactly one compiled command: $($case.Label)"
        $command = $commands[0]
        $name = $command.Name
        $route = @($command.ImplementingType.GetCustomAttributes($false) | Where-Object { $_ -is [Microsoft.Graph.Wrapper.Runtime.GraphRouteAttribute] })
        Assert-Probe ($route.Count -eq 1 -and $route[0].Method -ceq 'DELETE' -and $route[0].Path -ceq $case.Route) 'Compiled source route changed.'
        Assert-Probe ($command.Parameters.ContainsKey('WhatIf') -and $command.Parameters.ContainsKey('Confirm')) 'ShouldProcess parameters missing.'
        Assert-Probe (-not $command.Parameters.ContainsKey('Route') -and -not $command.Parameters.ContainsKey('BodyParameter')) 'Unexpected selector/body parameter.'
        $cmdletAttribute = $command.ImplementingType.GetCustomAttributes([System.Management.Automation.CmdletAttribute], $false)[0]
        Assert-Probe ($cmdletAttribute.ConfirmImpact -eq 'High') 'DELETE lost High ConfirmImpact.'
        $parameters = $case.Ids.Clone()
        if ($case.Label -ne 'Neighbor') { $parameters.IfMatch = 'W/"etag-probe"' }
        $parameters.Headers = @{ 'x-delete-query-probe' = 'custom-value' }
        if ($case.Query) {
            Assert-Probe ($command.Parameters.ContainsKey('Id')) 'Required native string query has no compiled -Id.'
            $attributes = $command.Parameters['Id'].Attributes
            Assert-Probe (@($attributes | Where-Object { $_ -is [System.Management.Automation.ParameterAttribute] -and $_.Mandatory }).Count -eq 1) '-Id is not mandatory.'
            foreach ($invalid in 'missing', 'empty', 'null', 'foreign-path-parameter') {
                $bad = $parameters.Clone()
                if ($invalid -eq 'empty') { $bad.Id = '' }
                if ($invalid -eq 'null') { $bad.Id = $null }
                if ($invalid -eq 'foreign-path-parameter') {
                    $bad.Id = "$endpoint/$ApiVersion/directoryObjects/member"
                    $bad.DirectoryObjectId = 'item-only-input'
                }
                $before = $handler.Requests.Count
                $failure = $null
                try { & $name @bad -Confirm:$false -ErrorAction Stop }
                catch { $failure = $_ }
                Assert-Probe ($failure -and $failure.Exception -is [System.Management.Automation.ParameterBindingException]) "Expected binder rejection: $invalid"
                Assert-Probe ($handler.Requests.Count -eq $before) "Invalid $invalid input reached transport."
                $results.Add([pscustomobject]@{ Case = $case.Label; Check = $invalid; ErrorId = $failure.FullyQualifiedErrorId; Requests = 0 })
            }
            $parameters.Id = "$endpoint/$ApiVersion/directoryObjects/member"
        }
        else { Assert-Probe (-not $command.Parameters.ContainsKey('Id')) 'No-query neighbor acquired a query parameter.' }
        $before = $handler.Requests.Count
        & $name @parameters -WhatIf -ErrorAction Stop
        Assert-Probe ($handler.Requests.Count -eq $before) 'WhatIf sent HTTP.'
        $results.Add([pscustomobject]@{ Case = $case.Label; Check = 'WhatIf'; Requests = 0 })

        $null = $engine.AddCommand('Import-Module').AddParameter('Name', $manifest).AddParameter('ErrorAction', 'Stop').Invoke()
        Assert-Probe (-not $engine.HadErrors) ($engine.Streams.Error | Out-String)
        $engine.Commands.Clear()
        foreach ($accept in $false, $true) {
            $choiceHost.Accept = $accept
            $prompts = $choiceHost.PromptCount
            $before = $handler.Requests.Count
            $null = $engine.AddCommand($name)
            foreach ($entry in $parameters.GetEnumerator()) { $null = $engine.AddParameter($entry.Key, $entry.Value) }
            $null = $engine.AddParameter('Confirm', $true).AddParameter('ErrorAction', 'Stop').Invoke()
            Assert-Probe (-not $engine.HadErrors) ($engine.Streams.Error | Out-String)
            $engine.Commands.Clear()
            Assert-Probe ($choiceHost.PromptCount -eq $prompts + 1) 'Expected exactly one genuine confirmation prompt.'
            Assert-Probe ($handler.Requests.Count -eq $before + [int]$accept) 'Confirmation did not select exactly zero/one DELETE.'
            if ($accept) { Assert-DeleteRequest $handler.Requests[$before] $case $parameters }
            $results.Add([pscustomobject]@{
                Case = $case.Label; Check = $(if ($accept) { 'accepted' } else { 'declined' })
                Prompts = 1; Requests = [int]$accept
                Request = $(if ($accept) { $handler.Requests[$before] } else { $null })
            })
        }
        $queryValues = if ($case.Query) {
            @($parameters.Id, "$endpoint/$ApiVersion/directoryObjects/member /%?#&=+'`"",
                "$endpoint/$ApiVersion/directoryObjects/$([char]0xE9)?x=%2F&y=+",
                'https://foreign.invalid/directoryObjects/member?x=%2F&y=+')
        } else { @('') }
        foreach ($value in $queryValues) {
            if ($case.Query) { $parameters.Id = $value }
            $before = $handler.Requests.Count
            & $name @parameters -Confirm:$false -ErrorAction Stop
            Assert-Probe ($handler.Requests.Count -eq $before + 1) 'Expected exactly one DELETE.'
            $request = $handler.Requests[$before]
            Assert-DeleteRequest $request $case $parameters
            $results.Add([pscustomobject]@{ Case = $case.Label; Check = 'transport'; Request = $request })
        }
        $null = $engine.AddCommand('Remove-Module').AddParameter('Name', $module.Name).Invoke()
        Assert-Probe (-not $engine.HadErrors) ($engine.Streams.Error | Out-String)
        $engine.Commands.Clear()
        Remove-Module $module
        $module = $null
    }
    $assemblies = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object {
        $_.GetName().Name -like 'Microsoft.Graph.Authentication*' -or $_.GetName().Name -like 'Microsoft.Kiota.*' -or
        $_.GetName().Name -in @('Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate')
    })
    Assert-Probe (@($assemblies | Group-Object { $_.GetName().Name } | Where-Object Count -ne 1).Count -eq 0) 'Duplicate Authentication/Kiota dependency identities.'
    $sources = foreach ($assembly in $assemblies) {
        $name = $assembly.GetName().Name
        $context = [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($assembly).Name
        $expected = if ($name -in 'Microsoft.Graph.Authentication', 'Microsoft.Graph.Authentication.Loader') { 'Default' } else { 'Microsoft.Graph.Authentication' }
        Assert-Probe ($context -ceq $expected -and $assembly.Location.StartsWith("$($auth.ModuleBase)\", [StringComparison]::OrdinalIgnoreCase)) "Wrong assembly source/context: $name $($assembly.Location) $context"
        [pscustomobject]@{ Name = $name; Version = "$($assembly.GetName().Version)"; Location = $assembly.Location; Context = $context }
    }
    foreach ($required in 'Microsoft.Graph.Authentication.Loader', 'Microsoft.Graph.Authentication.Core', 'Microsoft.Kiota.Abstractions', 'Microsoft.Kiota.Http.HttpClientLibrary', 'Std.UriTemplate') {
        Assert-Probe (@($sources | Where-Object Name -eq $required).Count -eq 1) "Missing packaged dependency: $required"
    }
    $inputs = @($generator, $KiotaPath, $fixture, $hostSource, $PSCommandPath,
        (Join-Path $PSScriptRoot 'Templates\WrapperClient.csproj.template'),
        (Join-Path $PSScriptRoot 'Templates\WrapperModule.csproj.template'),
        (Join-Path $PSScriptRoot 'WrapperGenerator\CmdletEmitter.cs'),
        (Join-Path $PSScriptRoot 'WrapperGenerator\PowerShellWrapperGenerationService.Delete.cs'),
        (Join-Path $repo 'src\GraphWrapperRuntime\Runtime\GraphClientCmdlet.cs'),
        (Join-Path $repo 'src\GraphWrapperRuntime\Runtime\SessionAdapterCache.cs'))
    if ($BaselineCmdletsDirectory) { $inputs += @(Get-ChildItem -LiteralPath $BaselineCmdletsDirectory -Filter '*.g.cs' -File | Select-Object -ExpandProperty FullName) }
    $evidence = [pscustomobject]@{
        Kiota = $version; AuthenticationVersion = $auth.Version.ToString(); AuthenticationPath = $auth.Path
        ApiVersion = $ApiVersion; PowerShellVersion = $PSVersionTable.PSVersion.ToString(); DotNet = (& dotnet --version)
        RepositoryHead = (& git -C $repo rev-parse HEAD); PSModulePath = $env:PSModulePath
        Inputs = @($inputs | ForEach-Object { [pscustomobject]@{ Path = $_; Sha256 = (Get-FileHash -LiteralPath $_ -Algorithm SHA256).Hash } })
        AuthenticationFiles = @(Get-ChildItem -LiteralPath $auth.ModuleBase -Recurse -File | ForEach-Object {
            [pscustomobject]@{ Path = $_.FullName; Sha256 = (Get-FileHash -LiteralPath $_.FullName -Algorithm SHA256).Hash }
        })
        ZeroLiveGraph = $true; SessionFactoryBaseAddress = $baseAddress.AbsoluteUri; SessionClientUnchanged = $true
        Builds = $builds; Assemblies = @($sources); CapturedRequests = $handler.Requests.Count
        GenuinePrompts = $choiceHost.PromptCount; Results = $results
    }
    $evidence | ConvertTo-Json -Depth 8 | Set-Content (Join-Path $ArtifactRoot 'evidence.json')
    $evidence | Select-Object Kiota, AuthenticationVersion, ZeroLiveGraph, CapturedRequests, GenuinePrompts
}
finally {
    Disconnect-MgGraph -ErrorAction Stop | Out-Null
    if ($module) { Remove-Module $module }
    $engine.Dispose()
    $runspace.Dispose()
    $client.Dispose()
}

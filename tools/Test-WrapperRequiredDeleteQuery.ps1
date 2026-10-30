<#
.SYNOPSIS
Generates Kiota builders, compiles ordinary DELETE wrappers and verifies offline PowerShell requests.

.DESCRIPTION
Run in a fresh noninteractive PowerShell process with the original Microsoft.Graph.Authentication
module on PSModulePath. Builds the fixture with the repository's unchanged project templates.
Uses only an in-memory GraphSession HttpClient; no Connect-MgGraph or live Graph requests.
Preserves generated sources, binaries and evidence in ArtifactRoot.

.EXAMPLE
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperRequiredDeleteQuery.ps1 -KiotaPath <kiota-1.36.1> -ArtifactRoot <new-directory>
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)][string]$KiotaPath,
    [Parameter(Mandatory)][string]$ArtifactRoot,
    [string]$BaselineCmdletsDirectory
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
    & $Program @Arguments | Out-Host
    if ($LASTEXITCODE -ne 0) { throw "$Program exited $LASTEXITCODE : $($Arguments -join ' ')" }
}
Assert-Probe (-not (Test-Path -LiteralPath $ArtifactRoot)) "ArtifactRoot must be new: $ArtifactRoot"
Assert-Probe (Test-Path -LiteralPath $generator) 'Build WrapperGenerator before running this probe.'
$version = & $KiotaPath --version
Assert-Probe ($LASTEXITCODE -eq 0 -and $version -like '1.36.1*') "Expected Kiota 1.36.1, got $version"
$null = New-Item -ItemType Directory -Path $ArtifactRoot
$ArtifactRoot = (Resolve-Path $ArtifactRoot).Path
$env:KIOTA_Generation__MaxDegreeOfParallelism = '1'
Import-Module Microsoft.Graph.Authentication -ErrorAction Stop
$auth = Get-Module Microsoft.Graph.Authentication
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
$handler = [DeleteQueryProbe.CaptureHandler]::new()
$client = [System.Net.Http.HttpClient]::new($handler)
$session = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance
$savedClient = $session.GraphHttpClient
$session.GraphHttpClient = $client
$choiceHost = [DeleteQueryProbe.ChoiceHost]::new()
$runspace = [runspacefactory]::CreateRunspace($choiceHost)
$runspace.Open()
$engine = [powershell]::Create()
$engine.Runspace = $runspace
$module = $null
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
                '--api-version', 'beta', '--no-collision-data', '--include-path', ($case.Route + '#DELETE'))
        }
        $assemblyName = 'Microsoft.Graph.Wrapper.DeleteQuery' + $case.Label
        $project = Join-Path $directory 'Probe.csproj'
        $moduleTemplate.Replace('{ModuleAssemblyName}', $assemblyName).
            Replace('{ClientProjectPath}', $clientProject).
            Replace('{AuthenticationProjectPath}', $authProject).
            Replace('{RuntimeProjectPath}', $runtimeProject) | Set-Content $project
        Invoke-Checked 'dotnet' @('build', $project, '-c', 'Release', '--nologo', '-v', 'quiet')
        $bin = Join-Path $directory 'bin\Release\netstandard2.0'
        Assert-Probe (-not (Test-Path (Join-Path $bin 'Microsoft.IO.RecyclableMemoryStream.dll'))) 'Bodyless proof unexpectedly packaged RMS.'
        Assert-Probe (-not (Test-Path (Join-Path $bin 'Microsoft.Graph.Authentication.dll'))) 'Fixture duplicated Authentication.'
        $manifest = Join-Path $bin ($assemblyName + '.psd1')
        New-ModuleManifest -Path $manifest -RootModule ($assemblyName + '.dll') -ModuleVersion '1.0.0' `
            -RequiredModules @(@{ ModuleName = 'Microsoft.Graph.Authentication'; ModuleVersion = $auth.Version }) `
            -RequiredAssemblies @('Std.UriTemplate.dll') -FunctionsToExport @() -AliasesToExport @()
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
            foreach ($invalid in 'missing', 'empty', 'null') {
                $bad = $parameters.Clone()
                if ($invalid -eq 'empty') { $bad.Id = '' }
                if ($invalid -eq 'null') { $bad.Id = $null }
                $before = $handler.Requests.Count
                $failure = $null
                try { & $name @bad -Confirm:$false -ErrorAction Stop }
                catch { $failure = $_ }
                Assert-Probe ($failure -and $failure.Exception -is [System.Management.Automation.ParameterBindingException]) "Expected binder rejection: $invalid"
                Assert-Probe ($handler.Requests.Count -eq $before) "Invalid $invalid input reached transport."
                $results.Add([pscustomobject]@{ Case = $case.Label; Check = $invalid; ErrorId = $failure.FullyQualifiedErrorId; Requests = 0 })
            }
            $parameters.Id = 'https://graph.microsoft.com/beta/directoryObjects/member'
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
            $results.Add([pscustomobject]@{
                Case = $case.Label; Check = $(if ($accept) { 'accepted' } else { 'declined' })
                Prompts = 1; Requests = [int]$accept
                Request = $(if ($accept) { $handler.Requests[$before] } else { $null })
            })
        }
        $queryValues = if ($case.Query) {
            @($parameters.Id, 'https://graph.microsoft.com/beta/directoryObjects/member /%?#&=+''"',
                "https://graph.microsoft.com/beta/directoryObjects/$([char]0xE9)?x=%2F&y=+")
        } else { @('') }
        foreach ($value in $queryValues) {
            if ($case.Query) { $parameters.Id = $value }
            $before = $handler.Requests.Count
            & $name @parameters -Confirm:$false -ErrorAction Stop
            Assert-Probe ($handler.Requests.Count -eq $before + 1) 'Expected exactly one DELETE.'
            $request = $handler.Requests[$before]
            $path = $case.Route
            foreach ($entry in $case.Ids.GetEnumerator()) {
                $placeholder = if ($entry.Key -eq 'DirectoryObjectId') { 'directoryObject-id' } elseif ($entry.Key -eq 'GroupId') { 'group-id' } else { 'administrativeUnit-id' }
                $path = $path.Replace("{$placeholder}", [uri]::EscapeDataString($entry.Value))
            }
            $expected = 'https://graph.microsoft.com/beta' + $path
            if ($case.Query) { $expected += '?@id=' + [uri]::EscapeDataString($value) }
            if ($case.Label -eq 'Before') { $expected += '?@id=' }
            Assert-Probe ($request.Method -ceq 'DELETE' -and $request.Uri -ceq $expected) "Exact encoded DELETE mismatch: $($request.Uri) expected $expected"
            Assert-Probe ($request.DecodedUri -ceq [uri]::UnescapeDataString($expected)) 'Decoded URI round trip failed.'
            Assert-Probe ($null -eq $request.Body) 'DELETE introduced body serialization.'
            Assert-Probe ($request.Headers['x-delete-query-probe'] -ceq 'custom-value') 'Custom headers were lost.'
            if ($case.Label -ne 'Neighbor') { Assert-Probe ($request.Headers['If-Match'] -ceq $parameters.IfMatch) 'ETag was lost.' }
            $results.Add([pscustomobject]@{ Case = $case.Label; Check = 'transport'; Request = $request })
        }
        $null = $engine.AddCommand('Remove-Module').AddParameter('Name', $module.Name).Invoke()
        Assert-Probe (-not $engine.HadErrors) ($engine.Streams.Error | Out-String)
        $engine.Commands.Clear()
        Remove-Module $module
        $module = $null
    }
    $evidence = [pscustomobject]@{
        Kiota = $version; AuthenticationVersion = $auth.Version.ToString(); AuthenticationPath = $auth.Path
        ZeroLiveGraph = $true; RecyclableMemoryStreamLoaded = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq 'Microsoft.IO.RecyclableMemoryStream' }).Count
        CapturedRequests = $handler.Requests.Count; GenuinePrompts = $choiceHost.PromptCount; Results = $results
    }
    Assert-Probe ($evidence.RecyclableMemoryStreamLoaded -eq 0) 'Bodyless DELETE unexpectedly loaded RMS.'
    $evidence | ConvertTo-Json -Depth 8 | Set-Content (Join-Path $ArtifactRoot 'evidence.json')
    $evidence | Select-Object Kiota, AuthenticationVersion, ZeroLiveGraph, CapturedRequests, GenuinePrompts
}
finally {
    $session.GraphHttpClient = $savedClient
    if ($module) { Remove-Module $module }
    $engine.Dispose()
    $runspace.Dispose()
    $client.Dispose()
}

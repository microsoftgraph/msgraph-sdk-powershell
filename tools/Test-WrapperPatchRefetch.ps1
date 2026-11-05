<#
.SYNOPSIS
Generates real Kiota clients and wrappers, then proves PATCH never reads back implicitly.

.DESCRIPTION
Requires built WrapperGenerator.Tests, the Kiota CLI and the normally built Authentication
package on PSModulePath. Builds and packs an isolated fixture using repository templates.
Probe imports the unpacked normal manifest in a fresh PowerShell 7 process. An offline
terminal handler follows the real Authentication factory/token pipeline. No live Graph,
OAuth, dependency injection, packaging overlays or Authentication changes are used.
FixtureRoot must be new and is kept for reproducible evidence.

.EXAMPLE
dotnet build .\tools\WrapperGenerator.Tests --nologo
pwsh -NoProfile -File .\tools\Test-WrapperPatchRefetch.ps1 -FixtureRoot <new-directory> -KiotaPath <kiota.exe> -AuthenticationModulePath <built-Authentication.psd1>
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)][string]$FixtureRoot,
    [string]$KiotaPath = 'kiota',
    [ValidateSet('v1.0', 'beta')][string]$ApiVersion = 'v1.0',
    [ValidateSet('Global', 'USGov')][string]$Environment = 'Global',
    [Parameter(Mandatory)][string]$AuthenticationModulePath,
    [string]$TestAssembly = "$PSScriptRoot\WrapperGenerator.Tests\bin\Debug\net10.0\WrapperGenerator.Tests.dll",
    [Parameter(DontShow)][switch]$Probe
)

$ErrorActionPreference = 'Stop'
if ($PSEdition -ne 'Core') { throw 'This gate requires PowerShell 7.' }
$repoRoot = (Resolve-Path "$PSScriptRoot\..").Path
$AuthenticationModulePath = (Resolve-Path -LiteralPath $AuthenticationModulePath).Path
$expectedAuthBase = Split-Path $AuthenticationModulePath
$authProject = "$repoRoot\src\Authentication\Authentication\Microsoft.Graph.Authentication.csproj"
$authVersion = ([xml](Get-Content $authProject -Raw)).Project.PropertyGroup.Version | Where-Object { $_ } | Select-Object -First 1
if (-not $Probe) {
    if (Test-Path -LiteralPath $FixtureRoot) { throw "FixtureRoot must be a new directory: $FixtureRoot" }
    $TestAssembly = (Resolve-Path -LiteralPath $TestAssembly).Path
    $null = [Reflection.Assembly]::LoadFrom($TestAssembly)
    $null = [WrapperGenerator.Tests.PatchRefetchFixture]::GenerateAsync($FixtureRoot, $ApiVersion).GetAwaiter().GetResult()
    $env:KIOTA_Generation__MaxDegreeOfParallelism = '1'
    & $KiotaPath generate -l CSharp -c ApiClient -n Microsoft.Graph.PowerShell.RefetchProbe.Client `
        -d "$FixtureRoot\openapi.json" -o "$FixtureRoot\Client" --log-level Warning
    if ($LASTEXITCODE -ne 0) { throw "Kiota exited $LASTEXITCODE." }
    $client = Get-Content "$PSScriptRoot\Templates\WrapperClient.csproj.template" -Raw
    Set-Content "$FixtureRoot\Client\Client.csproj" $client.Replace('{ClientAssemblyName}', 'Microsoft.Graph.Wrapper.RefetchProbe.Client')
    $project = Get-Content "$PSScriptRoot\Templates\WrapperModule.csproj.template" -Raw
    $replacements = @{
        ModuleAssemblyName = 'Microsoft.Graph.Wrapper.RefetchProbe'
        ClientProjectPath = 'Client\Client.csproj'
        AuthenticationProjectPath = $authProject
        RuntimeProjectPath = "$repoRoot\src\GraphWrapperRuntime\Runtime\Microsoft.Graph.Wrapper.Runtime.csproj"
    }
    foreach ($entry in $replacements.GetEnumerator()) { $project = $project.Replace("{$($entry.Key)}", $entry.Value) }
    Set-Content "$FixtureRoot\RefetchProbe.csproj" $project
    & dotnet build "$FixtureRoot\RefetchProbe.csproj" -c Release --nologo -v quiet
    if ($LASTEXITCODE -ne 0) { throw "Fixture build exited $LASTEXITCODE." }
    $bin = "$FixtureRoot\bin\Release\netstandard2.0"
    $expectedDlls = @('Microsoft.Graph.Wrapper.RefetchProbe.dll', 'Microsoft.Graph.Wrapper.RefetchProbe.Client.dll', 'Microsoft.Graph.Wrapper.Runtime.dll')
    $dlls = @(Get-ChildItem $bin -Filter '*.dll' -File | Select-Object -ExpandProperty Name)
    if (Compare-Object $expectedDlls $dlls) { throw 'Fixture bin must contain only its three wrapper DLLs.' }
    New-ModuleManifest -Path "$bin\Microsoft.Graph.Wrapper.RefetchProbe.psd1" `
        -RootModule 'Microsoft.Graph.Wrapper.RefetchProbe.dll' -ModuleVersion '0.0.1' `
        -RequiredModules @(@{ ModuleName = 'Microsoft.Graph.Authentication'; ModuleVersion = $authVersion }) `
        -CmdletsToExport '*' -FunctionsToExport @() -AliasesToExport @()
    $nuspec = "$FixtureRoot\RefetchProbe.nuspec"
    @"
<?xml version="1.0" encoding="utf-8"?>
<package xmlns="http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd">
  <metadata>
    <id>Microsoft.Graph.Wrapper.RefetchProbe</id>
    <version>0.0.1</version>
    <authors>Microsoft Graph</authors>
    <description>Offline PATCH operation semantics regression fixture.</description>
    <dependencies><dependency id="Microsoft.Graph.Authentication" version="$authVersion" /></dependencies>
  </metadata>
  <files>
    <file src="Microsoft.Graph.Wrapper.RefetchProbe.psd1" />
    <file src="*.dll" />
    <file src="*.deps.json" />
  </files>
</package>
"@ | Set-Content $nuspec
    & dotnet pack "$FixtureRoot\RefetchProbe.csproj" -c Release --no-build --no-restore --nologo -v quiet `
        "-p:NuspecFile=$nuspec" "-p:NuspecBasePath=$bin" -p:Version=0.0.1 -p:NoPackageAnalysis=true -o "$FixtureRoot\package"
    if ($LASTEXITCODE -ne 0) { throw "Fixture pack exited $LASTEXITCODE." }
    $package = "$FixtureRoot\package\Microsoft.Graph.Wrapper.RefetchProbe.0.0.1.nupkg"
    [IO.Compression.ZipFile]::ExtractToDirectory($package, "$FixtureRoot\unpacked")
    @{
        GeneratorTestAssembly = $TestAssembly
        GeneratorHash = (Get-FileHash (Join-Path (Split-Path $TestAssembly) 'WrapperGenerator.dll')).Hash
        PackagingTemplate = "$PSScriptRoot\Templates\WrapperModule.csproj.template"
        PackagingTemplateHash = (Get-FileHash "$PSScriptRoot\Templates\WrapperModule.csproj.template").Hash
        PackagingCandidate = $false
        Package = $package
        PackageHash = (Get-FileHash $package).Hash
        AuthenticationModulePath = $AuthenticationModulePath
        AuthenticationVersion = $authVersion
        Profile = $ApiVersion
    } | ConvertTo-Json | Set-Content "$FixtureRoot\provenance.json"
    & pwsh -NoProfile -NonInteractive -File $PSCommandPath -FixtureRoot $FixtureRoot -ApiVersion $ApiVersion `
        -AuthenticationModulePath $AuthenticationModulePath -Environment $Environment -Probe
    if ($LASTEXITCODE -ne 0) { throw "Fresh manifest transport probe exited $LASTEXITCODE." }
    exit 0
}

if (Get-Module Microsoft.Graph.Authentication) { throw 'Probe requires a fresh process.' }
$manifest = "$FixtureRoot\unpacked\Microsoft.Graph.Wrapper.RefetchProbe.psd1"
$manifestData = Import-PowerShellDataFile $manifest
$requiredAssemblies = @($manifestData.RequiredAssemblies | Where-Object { $_ })
if ($requiredAssemblies.Count) { throw 'Wrapper manifest must not preload Authentication-owned dependencies.' }
$packageDlls = @(Get-ChildItem (Split-Path $manifest) -Recurse -Filter '*.dll' -File | Select-Object -ExpandProperty Name)
if (Compare-Object @('Microsoft.Graph.Wrapper.RefetchProbe.dll', 'Microsoft.Graph.Wrapper.RefetchProbe.Client.dll', 'Microsoft.Graph.Wrapper.Runtime.dll') $packageDlls) {
    throw 'Unpacked wrapper must contain only its three own DLLs.'
}
$module = Import-Module $manifest -PassThru
$auth = Get-Module Microsoft.Graph.Authentication
if ($auth.Version -ne [version]$authVersion -or $auth.ModuleBase -cne $expectedAuthBase) {
    throw 'Manifest imported the wrong Authentication package version or source.'
}
Add-Type -Path "$PSScriptRoot\WrapperGenerator.Tests\Fixtures\PatchOperationTransport.cs"
$null = Get-MgContext
$handler = [PatchOperationTransport.CaptureHandler]::new()
$core = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Authentication.Core' })
if ($core.Count -ne 1) { throw 'Expected one normally loaded Authentication.Core assembly.' }
$session = $core[0].GetType('Microsoft.Graph.PowerShell.Authentication.GraphSession', $true).GetProperty('Instance').GetValue($null)
. "$repoRoot\src\Authentication\Authentication\test\TypeHelpers.ps1"
Set-MgTestDataStore
$factory = $core[0].GetType('Microsoft.Graph.PowerShell.Authentication.Core.Http.GraphHttpClientFactory', $true)
$client = $null
$token = 'offline-refetch-token'
$cacheAdapter = $null
$hostProbe = [PatchOperationTransport.ConfirmationHost]::new()
$runspace = [runspacefactory]::CreateRunspace($hostProbe)
$runspace.Open()
$engine = [powershell]::Create()
$engine.Runspace = $runspace
$checks = [Collections.Generic.List[object]]::new()
$failures = [Collections.Generic.List[string]]::new()
$endpoint = (Get-MgEnvironment -Name $Environment).GraphEndpoint.TrimEnd('/')
$baseUri = "$endpoint/$ApiVersion"
$queryTenantId = "tenant /%?#&=+'"
$queryView = "view /%?#&=+'"
$binderChecks = 0
$id = 'resource /% space'
$profileId = 'path profile /% space'
$parentId = 'parent /% space'
$escapedId = [uri]::EscapeDataString($id)
$widgetPath = "/profiles/$([uri]::EscapeDataString($profileId))/widgets"
$orphanPath = "/profiles/$([uri]::EscapeDataString($profileId))/orphanWidgets"
$cases = @(
    @{ Name = 'Update-MgAgreement'; Args = @{ AgreementId = $id }; Path = "/agreements/$escapedId"; GenericConditional = $true; RequiredQueries = $true },
    @{ Name = 'Update-MgProfileWidget'; Args = @{ ProfileId = $profileId; WidgetId = $id }; Path = "$widgetPath/$escapedId"; GenericConditional = $true },
    @{ Name = 'Update-MgProfileWidget'; Args = @{ ProfileId = $profileId; WidgetId = $parentId; ChildWidgetId = $id }; Path = "$widgetPath/$([uri]::EscapeDataString($parentId))/widgets/$escapedId"; GenericConditional = $true },
    @{ Name = 'Update-MgProfileOrphanWidget'; Args = @{ ProfileId = $profileId; OrphanWidgetId = $id }; Path = "$orphanPath/$escapedId"; GenericConditional = $true },
    @{ Name = 'Update-MgProfileOrphanWidget'; Args = @{ ProfileId = $profileId; OrphanWidgetId = $parentId; ChildWidgetId = $id }; Path = "$orphanPath/$([uri]::EscapeDataString($parentId))/orphanWidgets/$escapedId" },
    @{ Name = 'Update-MgPlace'; Args = @{ PlaceId = $id }; Path = "/places/$escapedId" },
    @{ Name = 'Set-MgAgreement'; Args = @{ AgreementId = $id }; Path = "/agreements/$escapedId" },
    @{ Name = 'Set-MgProfileWidget'; Args = @{ ProfileId = $profileId; WidgetId = $id }; Path = "$widgetPath/$escapedId" },
    @{ Name = 'Set-MgProfileWidget'; Args = @{ ProfileId = $profileId; WidgetId = $parentId; ChildWidgetId = $id }; Path = "$widgetPath/$([uri]::EscapeDataString($parentId))/widgets/$escapedId" },
    @{ Name = 'Update-MgDeviceManagementManagedDeviceHealthScriptStateIdidpolicyIdpolicyIddeviceIddeviceId'
       Args = @{ ManagedDeviceId = $parentId; Id = $id; PolicyId = 'path policy /%'; DeviceId = 'path device /%' }
       Path = "/deviceManagement/managedDevices/$([uri]::EscapeDataString($parentId))/deviceHealthScriptStates/id='$escapedId',policyId='$([uri]::EscapeDataString('path policy /%'))',deviceId='$([uri]::EscapeDataString('path device /%'))'"
       GenericConditional = $true; RequiredQueries = $true; Composite = $true }
)

function Invoke-Confirmed([string]$Name, [hashtable]$Arguments, [bool]$Accept) {
    $hostProbe.Accept = $Accept
    $prompts = $hostProbe.PromptCount
    $null = $engine.AddCommand($Name)
    foreach ($entry in $Arguments.GetEnumerator()) { $null = $engine.AddParameter($entry.Key, $entry.Value) }
    $result = $engine.AddParameter('Confirm', $true).AddParameter('ErrorAction', 'Stop').Invoke()
    if ($engine.HadErrors) { throw ($engine.Streams.Error | Out-String) }
    $engine.Commands.Clear()
    if ($hostProbe.PromptCount -ne $prompts + 1) { throw "Expected exactly one actual confirmation prompt: $Name" }
    $result
}

function Assert-Requests($Case, [int]$Before, [bool]$PatchBody, [bool]$GenericConditional = $false) {
    $method = if ($Case.Name.StartsWith('Set-')) { 'PUT' } else { 'PATCH' }
    $count = 1
    if ($handler.Requests.Count -ne $Before + $count) { throw "Incorrect request count: $($Case.Name) $($Case.Path)" }
    for ($i = 0; $i -lt $count; $i++) {
        $request = $handler.Requests[$Before + $i]
        $expectedMethod = $method
        $expectedUri = "$baseUri$($Case.Path)"
        if ($Case.RequiredQueries) {
            $expectedUri += '?tenantId=' + [uri]::EscapeDataString($queryTenantId)
        }
        if ($request.Method -cne $expectedMethod -or $request.Uri -cne $expectedUri) {
            throw "Wrong selected typed route/method: $($request.Method) $($request.Uri)"
        }
        if ($request.Authorization -cne "Bearer $token") { throw 'Request bypassed the real Authentication token handler.' }
        $status = if ($i -eq 0 -and -not $PatchBody) { 204 } else { 200 }
        if ($request.ResponseStatus -ne $status) { throw "Incorrect fixture response status: $expectedMethod $($Case.Path)" }
        if ($request.Marker -cne 'refetch-proof' -or $request.Multiple -cne 'one,two') {
            $failures.Add("Caller generic headers lost on $expectedMethod $($Case.Path)")
        }
        $expectedEtag = if ($GenericConditional) { '"generic-etag"' } elseif ($i -eq 0) { '"old-etag"' } else { '' }
        if ($request.IfMatch -cne $expectedEtag) {
            if (-not $GenericConditional) { throw "Typed mutation IfMatch leaked: $expectedMethod $($Case.Path)" }
            $failures.Add("Caller generic conditional header lost on $expectedMethod $($Case.Path)")
        }
        if ($i -eq 0) {
            $body = $request.Body | ConvertFrom-Json
            if ($body.displayName -cne 'typed body proof' -or $body.profileId -cne 'body-profile-not-path') {
                throw "Incorrect typed JSON or path/body collision: $($Case.Name)"
            }
            if ($Case.Composite -and ($body.policyId -cne 'body-policy-not-path' -or $body.deviceId -cne 'body-device-not-path')) {
                throw 'Composite PATCH lost distinct PolicyId1/DeviceId1 body bindings.'
            }
        }
    }
}

function Assert-Result($Result, [string]$ExpectedId) {
    if (-not $ExpectedId) {
        if ($null -ne $Result) { throw 'No-body/no-GET mutation unexpectedly wrote output.' }
    } elseif ($Result.Id -cne $ExpectedId -or
        $Result.GetType().FullName -cne 'Microsoft.Graph.PowerShell.RefetchProbe.Client.Models.Widget') {
        throw 'Mutation did not return the actual generated Kiota model.'
    }
}

try {
    Connect-MgGraph -AccessToken (ConvertTo-SecureString $token -AsPlainText -Force) -Environment $Environment -NoWelcome
    $client = $factory.GetMethod('Create').Invoke($null, @(
        $session.AuthContext, $session.RequestContext, [Net.Http.DelegatingHandler[]]@($handler), $null, $false
    ))
    if ($client.BaseAddress.AbsoluteUri.TrimEnd('/') -cne 'https://graph.microsoft.com/v1.0') {
        throw 'The Authentication factory did not retain its normal default v1.0 BaseAddress.'
    }
    $baseAddress = $client.BaseAddress
    $session.GraphHttpClient = $client
    $null = $engine.AddCommand('Import-Module').AddParameter('Name', $manifest).AddParameter('ErrorAction', 'Stop').Invoke()
    if ($engine.HadErrors) { throw ($engine.Streams.Error | Out-String) }
    $engine.Commands.Clear()
    if (-not [object]::ReferenceEquals($client, [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient())) {
        throw 'Authentication lost the shared authenticated terminal HttpClient.'
    }
    $runtime = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Wrapper.Runtime' })
    if ($runtime.Count -ne 1) { throw 'Expected one wrapper runtime.' }
    $cache = $runtime[0].GetType('Microsoft.Graph.Wrapper.Runtime.SessionAdapterCache', $true).
        GetField('_adapter', [Reflection.BindingFlags]'NonPublic,Static')
    foreach ($case in $cases) {
        $command = $module.ExportedCmdlets[$case.Name]
        if (-not $command) { throw "Missing compiled fixture command: $($case.Name)" }
        foreach ($unexpected in 'ReadBack', 'PassThru', 'Refetch') {
            if ($command.Parameters.ContainsKey($unexpected)) { throw "Mutation acquired a retrieval switch: $unexpected" }
        }
        $arguments = $case.Args.Clone()
        $arguments.Headers = @{ 'X-Refetch-Proof' = 'refetch-proof'; 'X-Multiple' = 'one,two' }
        $arguments.IfMatch = '"old-etag"'
        $arguments.DisplayName = 'typed body proof'
        $arguments[$(if ($arguments.ContainsKey('ProfileId')) { 'ProfileId1' } else { 'ProfileId' })] = 'body-profile-not-path'
        if ($case.Composite) {
            $arguments.PolicyId1 = 'body-policy-not-path'
            $arguments.DeviceId1 = 'body-device-not-path'
        }
        if ($case.RequiredQueries) {
            $arguments.QueryTenantId = $queryTenantId
            if ($command.Parameters.ContainsKey('QueryView')) { throw 'Mutation acquired an unrelated GET query input.' }
            foreach ($query in 'QueryTenantId') {
                if (-not @($command.Parameters[$query].Attributes | Where-Object { $_ -is [Management.Automation.ParameterAttribute] -and $_.Mandatory }).Count) {
                    throw "Independent required query is not mandatory: $($case.Name) $query"
                }
                foreach ($invalid in 'missing', 'empty', 'null') {
                    $bad = $arguments.Clone()
                    if ($invalid -eq 'missing') { $bad.Remove($query) }
                    elseif ($invalid -eq 'empty') { $bad[$query] = '' }
                    else { $bad[$query] = $null }
                    $beforeBinder = $handler.Requests.Count
                    $failure = $null
                    try { $null = & $case.Name @bad -Confirm:$false -ErrorAction Stop } catch { $failure = $_ }
                    if (-not $failure -or $failure.Exception -isnot [Management.Automation.ParameterBindingException] -or
                        $handler.Requests.Count -ne $beforeBinder) { throw "Required-query binder gate failed: $query $invalid" }
                    $binderChecks++
                }
            }
        }
        $handler.ReturnPatchBody = $false
        $handler.RejectGet = $true
        $before = $handler.Requests.Count
        $prompts = $hostProbe.PromptCount
        $null = & $case.Name @arguments -WhatIf
        if ($handler.Requests.Count -ne $before -or $hostProbe.PromptCount -ne $prompts) { throw 'WhatIf sent HTTP or prompted.' }
        $null = Invoke-Confirmed $case.Name $arguments $false
        if ($handler.Requests.Count -ne $before) { throw 'Genuinely declined Confirm sent HTTP.' }
        if (-not [object]::ReferenceEquals($cacheAdapter, $cache.GetValue($null))) { throw 'WhatIf or declined Confirm acquired transport.' }
        $result = Invoke-Confirmed $case.Name $arguments $true
        Assert-Requests $case $before $false
        Assert-Result $result ''
        $checks.Add(@{ Command = $case.Name; Path = $case.Path; Check = '204 success without output or GET, even when GET would fail; headers; WhatIf; declined/accepted single prompt'; Requests = $handler.Requests.Count - $before })
        if ($case.Name.StartsWith('Update-')) {
            $handler.ReturnPatchBody = $true
            $before = $handler.Requests.Count
            $result = & $case.Name @arguments -Confirm:$false
            Assert-Requests $case $before $true
            Assert-Result $result 'patch-body'
            $checks.Add(@{ Command = $case.Name; Path = $case.Path; Check = '200 PATCH returns its typed result with one request'; Requests = 1 })
        }
        if ($case.GenericConditional) {
            $handler.ReturnPatchBody = $false
            $arguments.Remove('IfMatch')
            $arguments.Headers['If-Match'] = '"generic-etag"'
            $before = $handler.Requests.Count
            $result = & $case.Name @arguments -Confirm:$false
            Assert-Requests $case $before $false $true
            Assert-Result $result ''
            $checks.Add(@{ Command = $case.Name; Path = $case.Path; Check = 'Explicit generic conditional header applies to PATCH without causing read-back'; Requests = 1 })
        }
        $adapter = $cache.GetValue($null)
        if ($null -eq $adapter -or $adapter.BaseUrl -cne $baseUri) { throw 'Cached adapter lost the generated profile service root.' }
        if ($null -ne $cacheAdapter -and -not [object]::ReferenceEquals($cacheAdapter, $adapter)) { throw 'Same-session profile adapter was not reused.' }
        $cacheAdapter = $adapter
        if (-not [object]::ReferenceEquals($client, $session.GraphHttpClient) -or -not [object]::Equals($baseAddress, $client.BaseAddress)) {
            throw 'Profile-specific requests changed the shared Authentication client or default BaseAddress.'
        }
    }
    foreach ($case in $cases | Where-Object RequiredQueries) {
        $name = $case.Name.Replace('Update-', 'Get-')
        $command = $module.ExportedCmdlets[$name]
        $arguments = $case.Args.Clone()
        $arguments.QueryView = $queryView
        $arguments.Headers = @{ 'X-Refetch-Proof' = 'explicit-get-proof'; 'X-Multiple' = 'one,two'; 'If-Match' = '"caller-get-etag"' }
        if (-not $command -or $command.Parameters.ContainsKey('QueryTenantId') -or
            -not @($command.Parameters['QueryView'].Attributes | Where-Object { $_ -is [Management.Automation.ParameterAttribute] -and $_.Mandatory }).Count) {
            throw 'Explicit GET did not retain its own independent required query.'
        }
        foreach ($invalid in 'missing', 'empty', 'null') {
            $bad = $arguments.Clone()
            if ($invalid -eq 'missing') { $bad.Remove('QueryView') }
            elseif ($invalid -eq 'empty') { $bad.QueryView = '' }
            else { $bad.QueryView = $null }
            $before = $handler.Requests.Count
            $failure = $null
            try { $null = & $name @bad -ErrorAction Stop } catch { $failure = $_ }
            if (-not $failure -or $failure.Exception -isnot [Management.Automation.ParameterBindingException] -or
                $handler.Requests.Count -ne $before) { throw 'Explicit GET required query binder failed.' }
            $binderChecks++
        }
        $handler.RejectGet = $false
        $before = $handler.Requests.Count
        $result = & $name @arguments -ErrorAction Stop
        Assert-Result $result 'read-by-caller'
        $request = $handler.Requests[$before]
        if ($handler.Requests.Count -ne $before + 1 -or $request.Method -cne 'GET' -or $request.ResponseStatus -ne 200 -or
            $request.Uri -cne "$baseUri$($case.Path)?view=$([uri]::EscapeDataString($queryView))" -or
            $request.Marker -cne 'explicit-get-proof' -or $request.Multiple -cne 'one,two' -or $request.IfMatch -cne '"caller-get-etag"' -or
            $request.Authorization -cne $handler.Requests[0].Authorization) {
            throw 'Caller-requested explicit GET changed route/query/header/authentication semantics.'
        }
        $checks.Add(@{ Command = $name; Path = $case.Path; Check = 'Caller explicitly retrieves with independent GET query and headers'; Requests = 1 })
    }
    $handler.RejectGet = $true
    $before = $handler.Requests.Count
    $failure = $null
    try { $null = Get-MgAgreement -AgreementId $id -QueryView $queryView -ErrorAction Stop } catch { $failure = $_ }
    if (-not $failure -or $failure.FullyQualifiedErrorId -notlike 'GraphRequestFailed,*' -or
        $handler.Requests.Count -ne $before + 1 -or $handler.Requests[$before].ResponseStatus -ne 403) {
        throw 'Explicit GET rejection did not remain a separate retrieval error.'
    }
    $checks.Add(@{ Command = 'Get-MgAgreement'; Check = 'Rejected explicit retrieval is independent of earlier successful PATCH204'; Requests = 1 })
    foreach ($name in 'Microsoft.Graph.Wrapper.Runtime', 'Microsoft.Graph.Wrapper.RefetchProbe', 'Microsoft.Graph.Wrapper.RefetchProbe.Client') {
        $assemblies = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq $name })
        if ($assemblies.Count -ne 1 -or $assemblies[0].Location -cne "$(Split-Path $manifest)\$name.dll" -or
            [Runtime.Loader.AssemblyLoadContext]::GetLoadContext($assemblies[0]).Name -cne 'Default') {
            throw "Wrapper assembly did not load once from its unpacked normal package: $name"
        }
    }
    $sources = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object {
        $_.GetName().Name -like 'Microsoft.Graph.Authentication*' -or $_.GetName().Name -like 'Microsoft.Kiota.*' -or
        $_.GetName().Name -in @('Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate')
    } | ForEach-Object {
        $name = $_.GetName().Name
        if (-not $_.Location.StartsWith("$($auth.ModuleBase)\", [StringComparison]::OrdinalIgnoreCase)) { throw "Wrong Authentication-owned assembly source: $name" }
        $context = [Runtime.Loader.AssemblyLoadContext]::GetLoadContext($_).Name
        $expectedContext = if ($name -in 'Microsoft.Graph.Authentication', 'Microsoft.Graph.Authentication.Loader') { 'Default' } else { 'Microsoft.Graph.Authentication' }
        if ($context -cne $expectedContext) { throw "Wrong assembly context: $name $context" }
        @{ Name = $name; Path = $_.Location; Context = $context }
    })
    if (@($sources | Group-Object Name | Where-Object Count -ne 1).Count) { throw 'Duplicate shared assembly identities.' }
    foreach ($required in 'Microsoft.Graph.Authentication.Loader', 'Microsoft.Graph.Authentication.Core', 'Microsoft.IO.RecyclableMemoryStream',
        'Std.UriTemplate', 'Microsoft.Kiota.Serialization.Multipart', 'Microsoft.Kiota.Serialization.Json') {
        if (@($sources | Where-Object Name -eq $required).Count -ne 1) { throw "Missing Authentication-owned identity: $required" }
    }
    if ($module.ExportedCmdlets.Count -ne 17 -or $checks.Count -ne 25 -or $hostProbe.PromptCount -ne 20 -or
        $handler.Requests.Count -ne 25 -or $binderChecks -ne 12) {
        throw "Incomplete proof: checks=$($checks.Count), prompts=$($hostProbe.PromptCount), HTTP=$($handler.Requests.Count)"
    }
    @{
        Profile = $ApiVersion; Environment = $Environment; Authentication = "$($auth.Version)"; AuthenticationPath = $auth.ModuleBase
        Provenance = Get-Content "$FixtureRoot\provenance.json" -Raw | ConvertFrom-Json
        ExportedCmdlets = $module.ExportedCmdlets.Count; Checks = $checks; ActualPrompts = $hostProbe.PromptCount
        Manifest = $manifest; WrapperDlls = $packageDlls; RequiredAssemblies = $requiredAssemblies
        FactoryDefaultBaseAddress = $baseAddress.AbsoluteUri; CachedAdapterBaseUrl = $cacheAdapter.BaseUrl; SessionAdapterReused = $true
        MissingEmptyNullQueryBinderChecks = $binderChecks
        Requests = $handler.Requests; Assemblies = $sources; Failures = $failures; LiveGraphRequests = 0
    } | ConvertTo-Json -Depth 8 | Tee-Object -FilePath "$FixtureRoot\transport-result.json"
    if ($failures.Count) { throw "$($failures.Count) real compiled request header assertions failed." }
}
finally {
    Disconnect-MgGraph -ErrorAction Stop | Out-Null
    $session.GraphHttpClient = $null
    $engine.Dispose()
    $runspace.Dispose()
    if ($null -ne $client) { $client.Dispose() }
}

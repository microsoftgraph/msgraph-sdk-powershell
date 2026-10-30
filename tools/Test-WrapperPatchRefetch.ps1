<#
.SYNOPSIS
Generates real Kiota clients and wrappers, then proves PATCH refetch headers offline.

.DESCRIPTION
Requires built WrapperGenerator.Tests, the Kiota CLI and original official Authentication
2.38.1 on PSModulePath. Builds an isolated fixture using repository project templates.
Probe imports only its normal manifest in a fresh process; no live Graph, credentials,
manual dependency injection or Authentication changes. FixtureRoot must be new and is kept
for reproducible evidence. PackagingTemplateRoot explicitly identifies a packaging candidate
when the normal target cannot yet serialize bodies; it never changes the generator source.

.EXAMPLE
dotnet build .\tools\WrapperGenerator.Tests --nologo
pwsh -NoProfile -File .\tools\Test-WrapperPatchRefetch.ps1 -FixtureRoot <new-directory> -KiotaPath <kiota.exe>
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)][string]$FixtureRoot,
    [string]$KiotaPath = 'kiota',
    [ValidateSet('v1.0', 'beta')][string]$ApiVersion = 'v1.0',
    [string]$PackagingTemplateRoot = "$PSScriptRoot\Templates",
    [string]$TestAssembly = "$PSScriptRoot\WrapperGenerator.Tests\bin\Debug\net10.0\WrapperGenerator.Tests.dll",
    [Parameter(DontShow)][switch]$Probe
)

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path "$PSScriptRoot\..").Path
if (-not $Probe) {
    if (Test-Path -LiteralPath $FixtureRoot) { throw "FixtureRoot must be a new directory: $FixtureRoot" }
    $TestAssembly = (Resolve-Path -LiteralPath $TestAssembly).Path
    $PackagingTemplateRoot = (Resolve-Path -LiteralPath $PackagingTemplateRoot).Path
    $null = [Reflection.Assembly]::LoadFrom($TestAssembly)
    $null = [WrapperGenerator.Tests.PatchRefetchFixture]::GenerateAsync($FixtureRoot, $ApiVersion).GetAwaiter().GetResult()
    $env:KIOTA_Generation__MaxDegreeOfParallelism = '1'
    & $KiotaPath generate -l CSharp -c ApiClient -n Microsoft.Graph.PowerShell.RefetchProbe.Client `
        -d "$FixtureRoot\openapi.json" -o "$FixtureRoot\Client" --log-level Warning
    if ($LASTEXITCODE -ne 0) { throw "Kiota exited $LASTEXITCODE." }
    $client = Get-Content "$PSScriptRoot\Templates\WrapperClient.csproj.template" -Raw
    Set-Content "$FixtureRoot\Client\Client.csproj" $client.Replace('{ClientAssemblyName}', 'Microsoft.Graph.Wrapper.RefetchProbe.Client')
    $project = Get-Content "$PackagingTemplateRoot\WrapperModule.csproj.template" -Raw
    $replacements = @{
        ModuleAssemblyName = 'Microsoft.Graph.Wrapper.RefetchProbe'
        ClientProjectPath = 'Client\Client.csproj'
        AuthenticationProjectPath = "$repoRoot\src\Authentication\Authentication\Microsoft.Graph.Authentication.csproj"
        RuntimeProjectPath = "$repoRoot\src\GraphWrapperRuntime\Runtime\Microsoft.Graph.Wrapper.Runtime.csproj"
    }
    foreach ($entry in $replacements.GetEnumerator()) { $project = $project.Replace("{$($entry.Key)}", $entry.Value) }
    Set-Content "$FixtureRoot\RefetchProbe.csproj" $project
    & dotnet build "$FixtureRoot\RefetchProbe.csproj" -c Release --nologo -v quiet
    if ($LASTEXITCODE -ne 0) { throw "Fixture build exited $LASTEXITCODE." }
    $bin = "$FixtureRoot\bin\Release\netstandard2.0"
    $assemblies = @('Std.UriTemplate.dll')
    # This is artifact-candidate packaging, never a hidden source overlay or manual DLL load.
    if (Test-Path "$bin\Microsoft.IO.RecyclableMemoryStream.dll") { $assemblies += 'Microsoft.IO.RecyclableMemoryStream.dll' }
    New-ModuleManifest -Path "$bin\Microsoft.Graph.Wrapper.RefetchProbe.psd1" `
        -RootModule 'Microsoft.Graph.Wrapper.RefetchProbe.dll' -ModuleVersion '0.0.1' `
        -RequiredModules @(@{ ModuleName = 'Microsoft.Graph.Authentication'; RequiredVersion = '2.38.1' }) `
        -RequiredAssemblies $assemblies -CmdletsToExport '*' -FunctionsToExport @() -AliasesToExport @()
    @{
        GeneratorTestAssembly = $TestAssembly
        GeneratorHash = (Get-FileHash (Join-Path (Split-Path $TestAssembly) 'WrapperGenerator.dll')).Hash
        PackagingTemplate = "$PackagingTemplateRoot\WrapperModule.csproj.template"
        PackagingTemplateHash = (Get-FileHash "$PackagingTemplateRoot\WrapperModule.csproj.template").Hash
        PackagingCandidate = $PackagingTemplateRoot -ne (Resolve-Path "$PSScriptRoot\Templates").Path
        RequiredAssemblies = $assemblies
        Profile = $ApiVersion
    } | ConvertTo-Json | Set-Content "$FixtureRoot\provenance.json"
    & pwsh -NoProfile -NonInteractive -File $PSCommandPath -FixtureRoot $FixtureRoot -ApiVersion $ApiVersion -Probe
    if ($LASTEXITCODE -ne 0) { throw "Fresh manifest transport probe exited $LASTEXITCODE." }
    exit 0
}

if (Get-Module Microsoft.Graph.Authentication) { throw 'Probe requires a fresh process.' }
$manifest = "$FixtureRoot\bin\Release\netstandard2.0\Microsoft.Graph.Wrapper.RefetchProbe.psd1"
$module = Import-Module $manifest -PassThru
$auth = Get-Module Microsoft.Graph.Authentication
if ($auth.Version -ne [version]'2.38.1') { throw 'Original official Authentication 2.38.1 is required.' }
Add-Type -Path "$PSScriptRoot\WrapperGenerator.Tests\Fixtures\PatchRefetchTransport.cs"
$null = Get-MgContext
$handler = [PatchRefetchTransport.CaptureHandler]::new()
$client = [Net.Http.HttpClient]::new($handler)
$session = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance
$savedClient = $session.GraphHttpClient
$session.GraphHttpClient = $client
$hostProbe = [PatchRefetchTransport.ConfirmationHost]::new()
$runspace = [runspacefactory]::CreateRunspace($hostProbe)
$runspace.Open()
$engine = [powershell]::Create()
$engine.Runspace = $runspace
$checks = [Collections.Generic.List[object]]::new()
$failures = [Collections.Generic.List[string]]::new()
$baseUri = "https://graph.microsoft.com/$ApiVersion"
$id = 'resource /% space'
$profileId = 'path profile /% space'
$parentId = 'parent /% space'
$escapedId = [uri]::EscapeDataString($id)
$widgetPath = "/profiles/$([uri]::EscapeDataString($profileId))/widgets"
$orphanPath = "/profiles/$([uri]::EscapeDataString($profileId))/orphanWidgets"
$cases = @(
    @{ Name = 'Update-MgAgreement'; Args = @{ AgreementId = $id }; Path = "/agreements/$escapedId"; Refetch = $true },
    @{ Name = 'Update-MgProfileWidget'; Args = @{ ProfileId = $profileId; WidgetId = $id }; Path = "$widgetPath/$escapedId"; Refetch = $true },
    @{ Name = 'Update-MgProfileWidget'; Args = @{ ProfileId = $profileId; WidgetId = $parentId; ChildWidgetId = $id }; Path = "$widgetPath/$([uri]::EscapeDataString($parentId))/widgets/$escapedId"; Refetch = $true },
    @{ Name = 'Update-MgProfileOrphanWidget'; Args = @{ ProfileId = $profileId; OrphanWidgetId = $id }; Path = "$orphanPath/$escapedId"; Refetch = $true },
    @{ Name = 'Update-MgProfileOrphanWidget'; Args = @{ ProfileId = $profileId; OrphanWidgetId = $parentId; ChildWidgetId = $id }; Path = "$orphanPath/$([uri]::EscapeDataString($parentId))/orphanWidgets/$escapedId"; Refetch = $false },
    @{ Name = 'Update-MgPlace'; Args = @{ PlaceId = $id }; Path = "/places/$escapedId"; Refetch = $false },
    @{ Name = 'Set-MgAgreement'; Args = @{ AgreementId = $id }; Path = "/agreements/$escapedId"; Refetch = $false },
    @{ Name = 'Set-MgProfileWidget'; Args = @{ ProfileId = $profileId; WidgetId = $id }; Path = "$widgetPath/$escapedId"; Refetch = $false },
    @{ Name = 'Set-MgProfileWidget'; Args = @{ ProfileId = $profileId; WidgetId = $parentId; ChildWidgetId = $id }; Path = "$widgetPath/$([uri]::EscapeDataString($parentId))/widgets/$escapedId"; Refetch = $false }
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
    $refetch = $Case.Refetch -and -not $PatchBody
    $count = if ($refetch) { 2 } else { 1 }
    if ($handler.Requests.Count -ne $Before + $count) { throw "Incorrect request count: $($Case.Name) $($Case.Path)" }
    for ($i = 0; $i -lt $count; $i++) {
        $request = $handler.Requests[$Before + $i]
        $expectedMethod = if ($i -eq 0) { $method } else { 'GET' }
        if ($request.Method -cne $expectedMethod -or $request.Uri -cne "$baseUri$($Case.Path)") {
            throw "Wrong selected typed route/method: $($request.Method) $($request.Uri)"
        }
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
        } elseif ($request.Body) { throw 'Refetch unexpectedly copied the mutation body.' }
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
    $null = $engine.AddCommand('Import-Module').AddParameter('Name', $manifest).AddParameter('ErrorAction', 'Stop').Invoke()
    if ($engine.HadErrors) { throw ($engine.Streams.Error | Out-String) }
    $engine.Commands.Clear()
    if (-not [object]::ReferenceEquals($client, [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient())) {
        throw 'Official Authentication lost the shared terminal HttpClient.'
    }
    foreach ($case in $cases) {
        $command = $module.ExportedCmdlets[$case.Name]
        if (-not $command) { throw "Missing compiled fixture command: $($case.Name)" }
        $arguments = $case.Args.Clone()
        $arguments.Headers = @{ 'X-Refetch-Proof' = 'refetch-proof'; 'X-Multiple' = 'one,two' }
        $arguments.IfMatch = '"old-etag"'
        $arguments.DisplayName = 'typed body proof'
        $arguments[$(if ($arguments.ContainsKey('ProfileId')) { 'ProfileId1' } else { 'ProfileId' })] = 'body-profile-not-path'
        $handler.ReturnPatchBody = $false
        $before = $handler.Requests.Count
        $prompts = $hostProbe.PromptCount
        $null = & $case.Name @arguments -WhatIf
        if ($handler.Requests.Count -ne $before -or $hostProbe.PromptCount -ne $prompts) { throw 'WhatIf sent HTTP or prompted.' }
        $null = Invoke-Confirmed $case.Name $arguments $false
        if ($handler.Requests.Count -ne $before) { throw 'Genuinely declined Confirm sent HTTP.' }
        $result = Invoke-Confirmed $case.Name $arguments $true
        Assert-Requests $case $before $false
        Assert-Result $result $(if ($case.Refetch) { 'refetched' } else { '' })
        $checks.Add(@{ Command = $case.Name; Path = $case.Path; Check = '204; typed headers PATCH-only; generic headers; WhatIf; declined/accepted single prompt'; Requests = $handler.Requests.Count - $before })
        if ($case.Name.StartsWith('Update-')) {
            $handler.ReturnPatchBody = $true
            $before = $handler.Requests.Count
            $result = & $case.Name @arguments -Confirm:$false
            Assert-Requests $case $before $true
            Assert-Result $result 'patch-body'
            $checks.Add(@{ Command = $case.Name; Path = $case.Path; Check = 'Non-null PATCH body suppresses GET'; Requests = 1 })
        }
        if ($case.Refetch) {
            $handler.ReturnPatchBody = $false
            $arguments.Remove('IfMatch')
            $arguments.Headers['If-Match'] = '"generic-etag"'
            $before = $handler.Requests.Count
            $result = & $case.Name @arguments -Confirm:$false
            Assert-Requests $case $before $false $true
            Assert-Result $result 'refetched'
            $checks.Add(@{ Command = $case.Name; Path = $case.Path; Check = 'Explicit generic conditional header remains caller-controlled on PATCH and GET'; Requests = 2 })
        }
    }
    $sources = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object {
        $_.GetName().Name -like 'Microsoft.Graph.Authentication*' -or $_.GetName().Name -like 'Microsoft.Kiota.*' -or
        $_.GetName().Name -in @('Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate')
    } | ForEach-Object {
        $name = $_.GetName().Name
        $local = $name -in @('Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate', 'Microsoft.Kiota.Serialization.Multipart')
        $expectedRoot = if ($local) { Split-Path $manifest } else { $auth.ModuleBase }
        if (-not $_.Location.StartsWith("$expectedRoot\", [StringComparison]::OrdinalIgnoreCase)) { throw "Wrong assembly source: $name" }
        $context = [Runtime.Loader.AssemblyLoadContext]::GetLoadContext($_).Name
        $expectedContext = if ($local -or $name -like 'Microsoft.Graph.Authentication*') { 'Default' } else { 'msgraph-load-context' }
        if ($context -cne $expectedContext) { throw "Wrong assembly context: $name $context" }
        @{ Name = $name; Path = $_.Location; Context = $context }
    })
    if (@($sources | Group-Object Name | Where-Object Count -ne 1).Count) { throw 'Duplicate shared assembly identities.' }
    if ($module.ExportedCmdlets.Count -ne 15 -or $checks.Count -ne 19 -or $hostProbe.PromptCount -ne 18 -or $handler.Requests.Count -ne 27) {
        throw "Incomplete proof: checks=$($checks.Count), prompts=$($hostProbe.PromptCount), HTTP=$($handler.Requests.Count)"
    }
    @{
        Profile = $ApiVersion; Authentication = "$($auth.Version)"; AuthenticationPath = $auth.ModuleBase
        Provenance = Get-Content "$FixtureRoot\provenance.json" -Raw | ConvertFrom-Json
        ExportedCmdlets = $module.ExportedCmdlets.Count; Checks = $checks; ActualPrompts = $hostProbe.PromptCount
        Requests = $handler.Requests; Assemblies = $sources; Failures = $failures; LiveGraphRequests = 0
    } | ConvertTo-Json -Depth 8 | Tee-Object -FilePath "$FixtureRoot\transport-result.json"
    if ($failures.Count) { throw "$($failures.Count) real compiled request header assertions failed." }
}
finally {
    $session.GraphHttpClient = $savedClient
    $engine.Dispose()
    $runspace.Dispose()
    $client.Dispose()
}

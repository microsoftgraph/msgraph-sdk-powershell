<#
.SYNOPSIS
Compiles required-query operation fixtures and production Bookings GETs, then invokes them offline.

.DESCRIPTION
Requires a built generator, isolated Kiota 1.36.1 and the normally packaged adapted Authentication
2.41.2 module first on PSModulePath. Run in a fresh PowerShell 7 process under the shared generation
queue. Uses the real Connect-MgGraph/GraphHttpClientFactory pipeline and test-only in-memory store.
No live Graph/OAuth, dependency injection, wrapper dependency preloads or consumer regeneration.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)][string]$KiotaPath,
    [Parameter(Mandatory)][string]$ArtifactRoot,
    [ValidateSet('v1.0', 'beta')][string]$ApiVersion = 'beta',
    [ValidateSet('Global', 'USGov')][string]$Environment = 'Global'
)
$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$generator = Join-Path $PSScriptRoot 'WrapperGenerator\bin\Debug\net10.0\WrapperGenerator.dll'
$fixture = Join-Path $PSScriptRoot 'WrapperGenerator.Tests\Fixtures\required-queries.yml'
$hostSource = Join-Path $PSScriptRoot 'WrapperGenerator.Tests\Fixtures\DeleteQueryProbeHost.cs'
$clientTemplate = Join-Path $PSScriptRoot 'Templates\WrapperClient.csproj.template'
$moduleTemplate = Join-Path $PSScriptRoot 'Templates\WrapperModule.csproj.template'
function Assert-Probe([bool]$Condition, [string]$Message) { if (-not $Condition) { throw $Message } }
Assert-Probe ($PSEdition -eq 'Core' -and -not (Get-Module Microsoft.Graph.Authentication)) 'Use a fresh PowerShell 7 process.'
Assert-Probe (-not (Test-Path -LiteralPath $ArtifactRoot)) "ArtifactRoot must be new: $ArtifactRoot"
Assert-Probe (Test-Path -LiteralPath $generator) 'Build WrapperGenerator first.'
$version = & $KiotaPath --version
Assert-Probe ($LASTEXITCODE -eq 0 -and $version -like '1.36.1*') "Expected Kiota 1.36.1, got $version"
$null = New-Item -ItemType Directory -Path $ArtifactRoot
$ArtifactRoot = (Resolve-Path -LiteralPath $ArtifactRoot).Path
$env:KIOTA_Generation__MaxDegreeOfParallelism = '1'
$commands = [Collections.Generic.List[object]]::new()
$checks = [Collections.Generic.List[object]]::new()
$builds = [Collections.Generic.List[object]]::new()
$modules = [Collections.Generic.List[object]]::new()
function Invoke-Checked([string]$Program, [string[]]$Arguments) {
    $timer = [Diagnostics.Stopwatch]::StartNew()
    $log = Join-Path $ArtifactRoot "command-$($commands.Count).log"
    & $Program @Arguments *> $log
    $code = $LASTEXITCODE
    $commands.Add([pscustomobject]@{ Program = $Program; Arguments = $Arguments; ExitCode = $code; Seconds = $timer.Elapsed.TotalSeconds; Log = $log })
    $commands | ConvertTo-Json -Depth 4 | Set-Content (Join-Path $ArtifactRoot 'commands-results.json')
    if ($code -ne 0) {
        Get-Content -LiteralPath $log -Tail 40 | Out-Host
        throw "$Program failed ($code): $($Arguments -join ' ')"
    }
    Write-Host "$Program passed in $([math]::Round($timer.Elapsed.TotalSeconds, 2))s; raw log: $log"
}
function Build-Probe([string]$Label, [string]$Spec, [string[]]$IncludePaths) {
    $directory = Join-Path $ArtifactRoot $Label
    $client = Join-Path $directory 'Client'
    $cmdlets = Join-Path $directory 'Cmdlets'
    $namespace = "RequiredQueryFixture.$Label.Client"
    $filter = @($IncludePaths | ForEach-Object { '--include-path'; $_ })
    Invoke-Checked $KiotaPath (@('generate', '-d', $Spec, '-o', $client, '-l', 'CSharp', '-c', 'ApiClient', '-n', $namespace, '--ll', 'Warning') + $filter)
    Invoke-Checked 'dotnet' (@($generator, '-d', $Spec, '-o', $cmdlets, '-n', $namespace, '--api-version', $ApiVersion, '--no-collision-data') + $filter)
    Assert-Probe (@(Get-ChildItem -LiteralPath $client -Recurse -Filter '*RequestBuilder.cs').Count -gt 0) 'Kiota produced no actual builders.'
    $clientProject = Join-Path $client 'Client.csproj'
    $clientAssembly = "Microsoft.Graph.PowerShell.RequiredQuery.$Label.Client"
    (Get-Content $clientTemplate -Raw).Replace('{ClientAssemblyName}', $clientAssembly) | Set-Content $clientProject
    $assembly = "Microsoft.Graph.Wrapper.RequiredQuery.$Label"
    $project = Join-Path $directory 'Probe.csproj'
    (Get-Content $moduleTemplate -Raw).Replace('{ModuleAssemblyName}', $assembly).
        Replace('{ClientProjectPath}', $clientProject).
        Replace('{AuthenticationProjectPath}', (Join-Path $repo 'src\Authentication\Authentication\Microsoft.Graph.Authentication.csproj')).
        Replace('{RuntimeProjectPath}', (Join-Path $repo 'src\GraphWrapperRuntime\Runtime\Microsoft.Graph.Wrapper.Runtime.csproj')) | Set-Content $project
    Invoke-Checked 'dotnet' @('build', $project, '-c', 'Release', '--nologo', '-v', 'quiet')
    $bin = Join-Path $directory 'bin\Release\netstandard2.0'
    $dlls = @(Get-ChildItem -LiteralPath $bin -Filter '*.dll' -File | Select-Object -ExpandProperty Name | Sort-Object)
    Assert-Probe (($dlls -join ',') -ceq ((@("$assembly.dll", "$clientAssembly.dll", 'Microsoft.Graph.Wrapper.Runtime.dll') | Sort-Object) -join ',')) 'Wrapper must contain exactly its three owned DLLs.'
    $manifest = Join-Path $bin "$assembly.psd1"
    New-ModuleManifest -Path $manifest -RootModule "$assembly.dll" -ModuleVersion '1.0.0' `
        -RequiredModules @(@{ ModuleName = 'Microsoft.Graph.Authentication'; ModuleVersion = $auth.Version }) `
        -FunctionsToExport @() -AliasesToExport @()
    Assert-Probe (-not (Import-PowerShellDataFile $manifest).RequiredAssemblies) 'Unexpected dependency preload.'
    $module = Import-Module $manifest -PassThru -ErrorAction Stop
    Assert-Probe ($module.ExportedCmdlets.Count -gt 0) 'Empty compiled module.'
    $null = $engine.AddCommand('Import-Module').AddParameter('Name', $manifest).AddParameter('ErrorAction', 'Stop').Invoke()
    Assert-Probe (-not $engine.HadErrors) ($engine.Streams.Error | Out-String)
    $engine.Commands.Clear()
    $modules.Add($module)
    $builds.Add([pscustomobject]@{
        Label = $Label; Spec = $Spec; SpecSha256 = (Get-FileHash -LiteralPath $Spec).Hash
        Manifest = $manifest; Exports = $module.ExportedCmdlets.Count; Dlls = $dlls
        Artifacts = @(Get-ChildItem -LiteralPath $bin -File | ForEach-Object {
            [pscustomobject]@{ Path = $_.FullName; Sha256 = (Get-FileHash -LiteralPath $_.FullName).Hash }
        })
    })
    return $module
}
Import-Module Microsoft.Graph.Authentication -ErrorAction Stop
$auth = Get-Module Microsoft.Graph.Authentication
Assert-Probe ($auth.Version -ge [version]'2.41.2') 'Adapted Authentication 2.41.2 is required.'
Add-Type -Path $hostSource
$null = Get-MgContext
$core = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Authentication.Core' })
Assert-Probe ($core.Count -eq 1) 'Expected a single packaged Authentication.Core.'
$session = $core[0].GetType('Microsoft.Graph.PowerShell.Authentication.GraphSession', $true).GetProperty('Instance').GetValue($null)
. (Join-Path $repo 'src\Authentication\Authentication\test\TypeHelpers.ps1')
Set-MgTestDataStore
$factory = $core[0].GetType('Microsoft.Graph.PowerShell.Authentication.Core.Http.GraphHttpClientFactory', $true)
$token = 'offline-required-query-token'
Connect-MgGraph -AccessToken (ConvertTo-SecureString $token -AsPlainText -Force) -Environment $Environment -NoWelcome -ErrorAction Stop
$handler = [DeleteQueryProbe.FamilyCaptureHandler]::new()
$client = $factory.GetMethod('Create').Invoke($null, @(
    $session.AuthContext, $session.RequestContext, [Net.Http.DelegatingHandler[]]@($handler), $null, $false
))
$session.GraphHttpClient = $client
$baseAddress = $client.BaseAddress
$endpoint = (Get-MgEnvironment -Name $Environment).GraphEndpoint.TrimEnd('/')
Assert-Probe ($baseAddress.AbsoluteUri -ceq "$endpoint/v1.0/") 'The real factory must retain its v1.0 default.'
$choiceHost = [DeleteQueryProbe.ChoiceHost]::new()
$runspace = [runspacefactory]::CreateRunspace($choiceHost)
$runspace.Open()
$engine = [powershell]::Create()
$engine.Runspace = $runspace
function Assert-Request($Request, [string]$Method, [string]$Path, [hashtable]$Query, [hashtable]$Body, [switch]$Refetch) {
    $uri = [uri]$Request.Uri
    Assert-Probe ($Request.Method -ceq $Method -and $uri.GetLeftPart([UriPartial]::Authority) -ceq $endpoint `
        -and $uri.AbsolutePath -ceq "/$ApiVersion$Path") "Wrong request destination/method: $($Request.Uri)"
    $pairs = @{}
    if ($uri.Query) {
        foreach ($part in $uri.Query.Substring(1).Split('&')) {
            $keyValue = $part.Split('=', 2)
            $key = [uri]::UnescapeDataString($keyValue[0])
            if (-not $pairs.ContainsKey($key)) { $pairs[$key] = [Collections.Generic.List[string]]::new() }
            $pairs[$key].Add($keyValue[1])
        }
    }
    Assert-Probe ($pairs.Count -eq $Query.Count) "Query key set mismatch: $($uri.Query)"
    foreach ($entry in $Query.GetEnumerator()) {
        $encoded = @(if ($entry.Value -is [hashtable]) { $entry.Value.Encoded } else { $entry.Value | ForEach-Object { [uri]::EscapeDataString([string]$_) } })
        Assert-Probe ($pairs.ContainsKey($entry.Key) -and $pairs[$entry.Key].Count -eq $encoded.Count `
            -and ($pairs[$entry.Key] -join '|') -ceq ($encoded -join '|')) "Encoded query mismatch for $($entry.Key): $($uri.Query), expected $($encoded -join '|')"
        for ($i = 0; $i -lt $encoded.Count; $i++) {
            Assert-Probe ([uri]::UnescapeDataString($pairs[$entry.Key][$i]) -ceq [uri]::UnescapeDataString($encoded[$i])) 'Decoded query mismatch.'
        }
    }
    Assert-Probe ($Request.Authorization -ceq "Bearer $token") 'Authentication was lost.'
    if ($Refetch) {
        Assert-Probe (-not $Request.Headers.ContainsKey('x-query-probe') -and -not $Request.Headers.ContainsKey('If-Match')) 'Required queries changed the existing independent refetch header behavior.'
    }
    else { Assert-Probe ($Request.Headers['x-query-probe'] -ceq 'custom-value') 'Generic headers were lost.' }
    if ($Body) {
        Assert-Probe $Request.HasContent 'Typed body was not sent.'
        $actual = $Request.Body | ConvertFrom-Json
        foreach ($entry in $Body.GetEnumerator()) {
            Assert-Probe (($actual.($entry.Key) | ConvertTo-Json -Compress -Depth 5) -ceq ($entry.Value | ConvertTo-Json -Compress -Depth 5)) "Typed body mismatch for $($entry.Key): $($Request.Body)"
        }
    }
    elseif ($Method -ne 'PUT' -or -not $Path.EndsWith('/content')) {
        Assert-Probe (-not $Request.HasContent -and $null -eq $Request.Body) 'Unexpected HTTP content/body.'
    }
    Assert-Probe ([object]::ReferenceEquals($client, $session.GraphHttpClient) -and [object]::Equals($baseAddress, $client.BaseAddress)) 'Required-query invocation mutated the shared session transport.'
}
function Assert-Binder([string]$Name, [hashtable]$Arguments, [string]$Description) {
    $before = $handler.Requests.Count
    $failure = $null
    try { & $Name @Arguments -ErrorAction Stop | Out-Null } catch { $failure = $_ }
    Assert-Probe ($failure -and $failure.Exception -is [Management.Automation.ParameterBindingException]) "Expected binder rejection: $Name $Description"
    Assert-Probe ($handler.Requests.Count -eq $before) "Invalid input reached HTTP: $Description"
    $checks.Add([pscustomobject]@{ Command = $Name; Check = $Description; ErrorId = $failure.FullyQualifiedErrorId; Requests = 0 })
}
function Assert-Output([object[]]$Output, [string]$Name, [string]$Method, [string]$Path, [hashtable]$Body) {
    if ($Path.EndsWith('/$count')) { Assert-Probe ($Output.Count -eq 1 -and $Output[0] -eq 2) 'Count result changed.' }
    elseif ($Path.EndsWith('/content')) { Assert-Probe ($Output.Count -eq 1 -and ($Output[0] -join ',') -ceq '1,2,3') 'Stream result changed.' }
    elseif ($Method -eq 'GET' -and $Path.EndsWith('/owner/$ref')) { Assert-Probe ($Output.Count -eq 1 -and $Output[0] -eq 'https://graph.microsoft.com/directoryObjects/owner') 'Scalar reference result changed.' }
    elseif ($Method -eq 'GET' -or ($Body -and -not $Path.EndsWith('/$ref') -and -not $Path.EndsWith('/promote'))) {
        Assert-Probe ($Output.Count -eq 1 -and $Output[0].Id -ceq 'offline-proof') "Typed result changed for $Name"
    }
    else { Assert-Probe ($Output.Count -eq 0) "Void operation acquired output: $Name" }
}
function Invoke-Case([string]$Name, [hashtable]$Arguments, [string]$Method, [string]$Path,
    [hashtable]$Query, [hashtable]$Body, [hashtable]$RefetchQuery) {
    $arguments = $Arguments.Clone()
    $arguments.Headers = @{ 'x-query-probe' = 'custom-value' }
    $mutation = $Method -ne 'GET'
    $expectedCount = if ($RefetchQuery) { 2 } else { 1 }
    if ($mutation) {
        $before = $handler.Requests.Count
        & $Name @arguments -WhatIf -ErrorAction Stop | Out-Null
        Assert-Probe ($handler.Requests.Count -eq $before) 'WhatIf sent HTTP.'
        $checks.Add([pscustomobject]@{ Command = $Name; Check = 'WhatIf'; Requests = 0 })
        foreach ($accept in $false, $true) {
            $choiceHost.Accept = $accept
            $prompts = $choiceHost.PromptCount
            $before = $handler.Requests.Count
            $null = $engine.AddCommand($Name)
            foreach ($entry in $arguments.GetEnumerator()) { $null = $engine.AddParameter($entry.Key, $entry.Value) }
            $confirmedOutput = @($engine.AddParameter('Confirm', $true).AddParameter('ErrorAction', 'Stop').Invoke())
            Assert-Probe (-not $engine.HadErrors) ($engine.Streams.Error | Out-String)
            $engine.Commands.Clear()
            Assert-Probe ($choiceHost.PromptCount -eq $prompts + 1 -and $handler.Requests.Count -eq $before + $(if ($accept) { $expectedCount } else { 0 })) 'Confirmation count/request contract failed.'
            if ($accept) {
                Assert-Request $handler.Requests[$before] $Method $Path $Query $Body
                if ($RefetchQuery) { Assert-Request $handler.Requests[$before + 1] 'GET' $Path $RefetchQuery $null -Refetch }
                Assert-Output $confirmedOutput $Name $Method $Path $Body
            }
            $checks.Add([pscustomobject]@{ Command = $Name; Check = $(if ($accept) { 'accepted' } else { 'declined' }); Prompts = 1; Requests = $handler.Requests.Count - $before })
        }
        $arguments.Confirm = $false
    }
    $before = $handler.Requests.Count
    $output = @(& $Name @arguments -ErrorAction Stop)
    Assert-Probe ($handler.Requests.Count -eq $before + $expectedCount) "Unexpected HTTP count for $Name"
    Assert-Request $handler.Requests[$before] $Method $Path $Query $Body
    if ($arguments.ContainsKey('IfMatch')) { Assert-Probe ($handler.Requests[$before].Headers['If-Match'] -ceq $arguments.IfMatch) 'Mutation ETag was lost.' }
    if ($RefetchQuery) { Assert-Request $handler.Requests[$before + 1] 'GET' $Path $RefetchQuery $null -Refetch }
    Assert-Output $output $Name $Method $Path $Body
    $checks.Add([pscustomobject]@{ Command = $Name; Check = 'transport'; Requests = $expectedCount; OutputCount = $output.Count })
}
try {
    $family = Build-Probe 'Families' $fixture @()
    $module = $family
    $adversarial = "tenant /%?#&=+'`"$([char]0xE9)"
    $widget = 'widget /% space'
    $widgetPath = '/widgets/' + [uri]::EscapeDataString($widget)
    $body = @{ displayName = 'typed-name'; enabled = $false; detail = @{ description = 'nested' } }
    $post = @{ QueryInherited = 'path-default'; QueryTenantId = $adversarial; QueryAttempt = [long]0; QueryForce = $false; DisplayName = 'typed-name'; Enabled = $false; Detail = @{ Description = 'nested' } }
    Invoke-Case 'New-MgWidget' $post POST '/widgets' @{ inherited = 'path-default'; tenantId = $adversarial; attempt = '0'; force = 'false' } $body $null
    $patch = @{ WidgetId = $widget; QueryTenantId = $adversarial; QueryView = 'get-only'; DisplayName = 'typed-name'; IfMatch = 'W/"query-proof"' }
    # Generic headers on PATCH refetch remain the separate existing refetch-header prerequisite.
    # Assert refetch's query isolation without requiring that unrelated missing header behavior.
    Invoke-Case 'Update-MgWidget' $patch PATCH $widgetPath @{ tenantId = $adversarial } @{ displayName = 'typed-name' } @{ view = 'get-only' }
    Invoke-Case 'Set-MgWidget' @{ WidgetId = $widget; QueryTenantId = $adversarial; DisplayName = 'typed-name' } PUT $widgetPath @{ tenantId = $adversarial } @{ displayName = 'typed-name' } $null
    Invoke-Case 'Get-MgWidget' @{ QueryTop = 0; QueryEnabled = $false; QueryCount = $false; Select = @('id'); Filter = 'active' } GET '/widgets' @{ '$top' = '0'; enabled = 'false'; '$count' = 'false'; inherited = ''; '$select' = 'id'; '$filter' = 'active' } $null $null
    Invoke-Case 'Get-MgWidget' @{ WidgetId = $widget; QueryView = $adversarial; Select = @('id') } GET $widgetPath @{ view = $adversarial; '$select' = 'id' } $null $null
    $before = $handler.Requests.Count
    $pages = @(Get-MgWidget -QueryTop 10 -QueryEnabled:$false -QueryCount:$false -Filter pages -All -Headers @{ 'x-query-probe' = 'custom-value' } -ErrorAction Stop)
    Assert-Probe ($handler.Requests.Count -eq $before + 2 -and $pages.Count -eq 2) 'Required-query list paging failed.'
    Assert-Request $handler.Requests[$before] GET '/widgets' @{ '$top' = '10'; enabled = 'false'; '$count' = 'false'; inherited = ''; '$filter' = 'pages' } $null
    Assert-Request $handler.Requests[$before + 1] GET '/widgets' @{ continued = '1' } $null
    $checks.Add([pscustomobject]@{ Command = 'Get-MgWidget'; Check = 'continuation-query-isolation'; Requests = 2; OutputCount = $pages.Count })
    Invoke-Case 'Get-MgWidgetCount' @{ QueryFilter = $adversarial } GET '/widgets/$count' @{ '$filter' = $adversarial } $null $null
    Invoke-Case 'Invoke-MgWidgetPromote' @{ WidgetId = $widget; QueryThreshold = [double]0; Title = 'promote' } POST "$widgetPath/promote" @{ threshold = '0' } @{ title = 'promote' } $null
    $code = 'inline /% space'
    Invoke-Case 'Get-MgWidgetLookupWithCode' @{ WidgetId = $widget; Code = $code; QueryLocale = $adversarial } GET "$widgetPath/lookup(code='$([uri]::EscapeDataString($code))')" @{ locale = $adversarial } $null $null
    $reference = 'https://foreign.invalid/directoryObjects/member?x=%2F&y=+'
    Invoke-Case 'Remove-MgWidgetMemberByRef' @{ WidgetId = $widget; QueryId = $reference; IfMatch = 'W/"query-proof"' } DELETE "$widgetPath/members/`$ref" @{ '@id' = $reference } $null $null
    foreach ($verb in 'New', 'Set') {
        Invoke-Case "$verb-MgWidgetMemberByRef" @{ WidgetId = $widget; QueryId = $reference; OdataId = 'https://graph.microsoft.com/directoryObjects/body-target' } $(if ($verb -eq 'New') { 'POST' } else { 'PUT' }) "$widgetPath/members/`$ref" @{ '@id' = $reference } @{ '@odata.id' = 'https://graph.microsoft.com/directoryObjects/body-target' } $null
    }
    Invoke-Case 'Get-MgWidgetOwnerByRef' @{ WidgetId = $widget; QueryTenantId = $adversarial } GET "$widgetPath/owner/`$ref" @{ tenantId = $adversarial } $null $null
    Invoke-Case 'Get-MgWidgetContent' @{ WidgetId = $widget; QueryRevision = 0 } GET "$widgetPath/content" @{ revision = '0' } $null $null
    $upload = Join-Path $ArtifactRoot 'upload.txt'
    [IO.File]::WriteAllText($upload, 'typed-upload')
    Invoke-Case 'Set-MgWidgetContent' @{ WidgetId = $widget; QueryRevision = 0; InFile = $upload } PUT "$widgetPath/content" @{ revision = '0' } $null $null
    Assert-Probe ($handler.Requests[$handler.Requests.Count - 1].Body -ceq 'typed-upload') 'Media query binding changed uploaded content.'
    Invoke-Case 'Get-MgWidgetDelta' @{ QueryTenantId = $adversarial; Top = 2 } GET '/widgets/delta()' @{ tenantId = $adversarial; '$top' = '2' } $null $null
    Invoke-Case 'Get-MgWidgetDelta' @{ DeltaLink = "$endpoint/$ApiVersion/widgets/delta()?serverState=next" } GET '/widgets/delta()' @{ serverState = 'next' } $null $null
    Invoke-Case 'Get-MgSelectedWidget' @{ QuerySelect = @('id', 'displayName') } GET '/selectedWidgets' @{ '$select' = @{ Encoded = 'id,displayName' } } $null $null

    $typeCommand = Get-Command Get-MgQueryType
    $day = [Activator]::CreateInstance($typeCommand.Parameters['QueryDay'].ParameterType, [object[]]@([int]2026, [int]11, [int]4))
    $clock = [Activator]::CreateInstance($typeCommand.Parameters['QueryClock'].ParameterType, [object[]]@([int]1, [int]2, [int]3))
    $types = @{ QueryTenantId = $adversarial; QueryTenantName = 'dot'; QueryUnderscoreName = 'underscore'; QueryEnabled = $false; QueryIndex = 0; QuerySize = [long]0; QueryRatio = [double]0; QuerySingle = [float]0; QueryAmount = [decimal]0; QueryGuid = [guid]'00000000-0000-0000-0000-000000000001'; QueryTimestamp = [datetimeoffset]'2026-11-04T00:00:00Z'; QueryDay = $day; QueryClock = $clock; QueryNames = @('one /%', 'two'); QueryCounts = @(0, 2) }
    Invoke-Case 'Get-MgQueryType' $types GET '/queryTypes' @{ 'tenant-id' = $adversarial; 'tenant.name' = 'dot'; underscore_name = 'underscore'; enabled = 'false'; index = '0'; size = '0'; ratio = '0'; single = '0'; amount = '0'; guid = '00000000-0000-0000-0000-000000000001'; timestamp = '2026-11-04T00:00:00.0000000+00:00'; day = '2026-11-04'; clock = '01:02:03'; names = @('one /%', 'two'); counts = @('0', '2') } $null $null
    foreach ($bad in 'missing', 'empty', 'null', 'invalid-type', 'legacy-Id') {
        $arguments = @{ WidgetId = $widget; QueryId = $reference; Confirm = $false }
        if ($bad -eq 'missing') { $arguments.Remove('QueryId') }
        if ($bad -eq 'empty') { $arguments.QueryId = '' }
        if ($bad -eq 'null') { $arguments.QueryId = $null }
        if ($bad -eq 'invalid-type') {
            $arguments = @{ WidgetId = $widget; QueryRevision = 'not-an-integer' }
            Assert-Binder 'Get-MgWidgetContent' $arguments $bad
            continue
        }
        if ($bad -eq 'legacy-Id') { $arguments.Id = 'not-a-query-alias' }
        Assert-Binder 'Remove-MgWidgetMemberByRef' $arguments $bad
    }
    $missingPost = $post.Clone()
    $missingPost.Remove('QueryForce')
    $missingPost.Confirm = $false
    Assert-Binder 'New-MgWidget' $missingPost 'missing-required-bool'
    $invalidBool = $post.Clone()
    $invalidBool.QueryForce = 'not-a-bool'
    $invalidBool.Confirm = $false
    Assert-Binder 'New-MgWidget' $invalidBool 'invalid-required-bool'
    Assert-Binder 'Get-MgWidget' @{ WidgetId = $widget; QueryView = 'view'; QueryTop = 1; QueryEnabled = $false; QueryCount = $false } 'mixed-list-item-inputs'
    $nullBool = $post.Clone()
    $nullBool.QueryForce = $null
    $nullBool.Confirm = $false
    Assert-Binder 'New-MgWidget' $nullBool 'null-required-bool'
    foreach ($invalidArray in @(@(), @(''))) {
        Assert-Binder 'Get-MgSelectedWidget' @{ QuerySelect = $invalidArray } 'empty-required-array'
    }
    $bookingRoot = '/solutions/bookingBusinesses/{bookingBusiness-id}/calendarView'
    $bookings = Build-Probe 'Bookings' (Join-Path $repo "openApiDocs_KiotaCompat\$ApiVersion\Bookings.yml") @("$bookingRoot#GET", "$bookingRoot/{bookingAppointment-id}#GET")
    $bookingName = @($bookings.ExportedCmdlets.Values | Where-Object { $_.Name -notmatch '_(List|Get)$' })[0].Name
    $range = @{ BookingBusinessId = 'business /% space'; QueryStart = '2026-11-04T00:00:00+00:00'; QueryEnd = '2026-11-05T00:00:00+00:00'; Select = @('id'); Top = 1 }
    $bookingPath = '/solutions/bookingBusinesses/' + [uri]::EscapeDataString($range.BookingBusinessId) + '/calendarView'
    Invoke-Case $bookingName $range GET $bookingPath @{ start = $range.QueryStart; end = $range.QueryEnd; '$select' = 'id'; '$top' = '1' } $null $null
    $range.Remove('Top')
    $range.BookingAppointmentId = 'appointment'
    Invoke-Case $bookingName $range GET "$bookingPath/appointment" @{ start = $range.QueryStart; end = $range.QueryEnd; '$select' = 'id' } $null $null
    $range.Remove('QueryEnd')
    Assert-Binder $bookingName $range 'production-Bookings-missing-end'
    $assemblies = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object {
        $_.GetName().Name -like 'Microsoft.Graph.Authentication*' -or $_.GetName().Name -like 'Microsoft.Kiota.*' -or $_.GetName().Name -in @('Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate')
    })
    Assert-Probe (@($assemblies | Group-Object { $_.GetName().Name } | Where-Object Count -ne 1).Count -eq 0) 'Duplicate Authentication/Kiota identities.'
    $sources = foreach ($assembly in $assemblies) {
        $name = $assembly.GetName().Name
        $context = [Runtime.Loader.AssemblyLoadContext]::GetLoadContext($assembly).Name
        $expected = if ($name -in 'Microsoft.Graph.Authentication', 'Microsoft.Graph.Authentication.Loader') { 'Default' } else { 'Microsoft.Graph.Authentication' }
        Assert-Probe ($context -ceq $expected -and $assembly.Location.StartsWith("$($auth.ModuleBase)\", [StringComparison]::OrdinalIgnoreCase)) "Wrong source/context for $name"
        [pscustomobject]@{ Name = $name; Context = $context; Path = $assembly.Location }
    }
    foreach ($required in 'Microsoft.Graph.Authentication.Loader', 'Microsoft.Graph.Authentication.Core',
        'Microsoft.Kiota.Abstractions', 'Microsoft.Kiota.Http.HttpClientLibrary',
        'Microsoft.Kiota.Serialization.Json', 'Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate') {
        Assert-Probe (@($sources | Where-Object Name -eq $required).Count -eq 1) "Missing required packaged dependency: $required"
    }
    $inputs = @($generator, $KiotaPath, $fixture, $hostSource, $PSCommandPath, $clientTemplate, $moduleTemplate) `
        + @(Get-ChildItem (Join-Path $PSScriptRoot 'WrapperGenerator') -Filter '*.cs' -File | Select-Object -ExpandProperty FullName)
    $evidence = [pscustomobject]@{
        Head = (& git -C $repo rev-parse HEAD); Profile = $ApiVersion; Environment = $Environment; Kiota = $version
        AuthenticationVersion = "$($auth.Version)"; AuthenticationPath = $auth.Path; SessionFactoryBaseAddress = $baseAddress.AbsoluteUri
        PowerShell = "$($PSVersionTable.PSVersion)"; DotNet = (& dotnet --version); PSModulePath = $env:PSModulePath
        Inputs = @($inputs | ForEach-Object { [pscustomobject]@{ Path = $_; Sha256 = (Get-FileHash -LiteralPath $_).Hash } })
        AuthenticationFiles = @(Get-ChildItem -LiteralPath $auth.ModuleBase -Recurse -File | ForEach-Object { [pscustomobject]@{ Path = $_.FullName; Sha256 = (Get-FileHash -LiteralPath $_.FullName).Hash } })
        Builds = $builds; Checks = $checks; Assemblies = @($sources); Requests = $handler.Requests
        CapturedRequests = $handler.Requests.Count; GenuinePrompts = $choiceHost.PromptCount; LiveGraphRequests = 0
    }
    $evidence | ConvertTo-Json -Depth 10 | Set-Content (Join-Path $ArtifactRoot 'evidence.json')
    $evidence | Select-Object Profile, Environment, AuthenticationVersion, CapturedRequests, GenuinePrompts, LiveGraphRequests
}
finally {
    $handler.Requests | ConvertTo-Json -Depth 6 | Set-Content (Join-Path $ArtifactRoot 'requests.json')
    $checks | ConvertTo-Json -Depth 6 | Set-Content (Join-Path $ArtifactRoot 'checks.json')
    Disconnect-MgGraph -ErrorAction Stop | Out-Null
    $engine.Dispose()
    $runspace.Dispose()
    foreach ($module in $modules) { Remove-Module $module }
    $client.Dispose()
}

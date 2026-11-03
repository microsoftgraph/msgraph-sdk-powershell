<#
.SYNOPSIS
Checks the complete compiled Search module's migration outcomes using an in-memory HTTP transport.

.DESCRIPTION
Run separately in a fresh pwsh for each profile/cloud after its full Release build.
The normal manifest imports adapted Authentication 2.41.2. Real Connect-MgGraph sessions,
an in-memory data store and the actual GraphHttpClientFactory pipeline terminate in an
offline handler. No live Graph, credentials store or dependency injection is used.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion,
    [string]$Configuration = 'Release',
    [ValidateSet('Global', 'USGov')]
    [string]$Environment = 'Global'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path $PSScriptRoot -Parent
$manifest = Join-Path $repoRoot "src\Search\wrapper\$ApiVersion\bin\$Configuration\netstandard2.0\Microsoft.Graph.Wrapper.Search.psd1"
if (-not (Test-Path -LiteralPath $manifest)) { throw "Full Search build required: $manifest" }
if (Get-Module Microsoft.Graph.Wrapper.Search) { throw 'Run this gate in a fresh pwsh process.' }
$module = Import-Module $manifest -PassThru
$auth = Get-Module Microsoft.Graph.Authentication
if ($auth.Version -ne [version]'2.41.2') {
    throw 'This gate requires the normally packaged adapted Authentication 2.41.2 module.'
}
$script:checks = 0
$failures = [System.Collections.Generic.List[string]]::new()
function Assert-Search([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
    $script:checks++
}
function Assert-Route([string]$Name, [string]$Method, [string]$Path) {
    $command = $module.ExportedCmdlets[$Name]
    Assert-Search ($null -ne $command) "Missing compiled export: $Name"
    $routes = @($command.ImplementingType.GetCustomAttributes($true) |
        Where-Object { $_.GetType().Name -eq 'GraphRouteAttribute' })
    Assert-Search (@($routes | Where-Object { $_.Method -ceq $Method -and $_.Path -ceq $Path }).Count -eq 1) "Missing exact compiled route: $Name $Method $Path"
}
function Assert-Mandatory([string]$Name, [string]$Parameter) {
    $sets = @($module.ExportedCmdlets[$Name].ParameterSets)
    Assert-Search ($sets.Count -gt 0) "Missing compiled parameter sets: $Name"
    Assert-Search (@($sets | Where-Object {
        @($_.Parameters | Where-Object { $_.Name -eq $Parameter -and $_.IsMandatory }).Count -ne 1
    }).Count -eq 0) "Expected mandatory $Parameter on every $Name parameter set."
}

Assert-Search ($module.ExportedCmdlets.Count -gt 0) 'Compiled Search module has no exports.'
$manifestData = Import-PowerShellDataFile $manifest
Assert-Search (@($manifestData.RequiredAssemblies).Count -eq 0) 'Wrapper manifest must not preload Authentication-owned dependencies.'
Assert-Search ($manifestData.RequiredModules[0].ModuleVersion -eq '2.41.2') 'Wrapper manifest requires stale Authentication.'
$dllNames = @((Get-ChildItem (Split-Path $manifest) -File -Filter '*.dll').Name | Sort-Object)
Assert-Search (($dllNames -join ',') -ceq 'Microsoft.Graph.PowerShell.Search.Client.dll,Microsoft.Graph.Wrapper.Runtime.dll,Microsoft.Graph.Wrapper.Search.dll') 'Wrapper bin must contain exactly its three owned DLLs.'
$specOperations = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::Ordinal)
$currentPath = $null
$currentMethod = $null
foreach ($line in Get-Content (Join-Path $repoRoot "openApiDocs_KiotaCompat\$ApiVersion\Search.yml")) {
    if ($line -match "^  (?:'(?<quoted>/.*)'|(?<plain>/.*)):\s*$") {
        $currentPath = if ($Matches.quoted) { $Matches.quoted.Replace("''", "'") } else { $Matches.plain }
        $currentMethod = $null
    }
    elseif ($currentPath -and $line -match '^    (?<method>get|post|patch|put|delete|head|options|trace):\s*$') {
        $currentMethod = $Matches.method.ToUpperInvariant()
    }
    elseif ($currentMethod -and $line -match '^      operationId:') {
        $null = $specOperations.Add("$currentMethod $currentPath")
        $currentMethod = $null
    }
}
$compiledOperations = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::Ordinal)
foreach ($command in $module.ExportedCmdlets.Values) {
    foreach ($attribute in $command.ImplementingType.GetCustomAttributes($true)) {
        if ($attribute.GetType().Name -eq 'GraphRouteAttribute') {
            $null = $compiledOperations.Add("$($attribute.Method) $($attribute.Path)")
        }
    }
}
Assert-Search ($specOperations.Count -eq $(if ($ApiVersion -eq 'v1.0') { 63 } else { 145 })) 'Unexpected compatible operation inventory.'
Assert-Search ($specOperations.SetEquals($compiledOperations)) "Compiled route coverage differs from the compatible spec: $(Compare-Object @($specOperations) @($compiledOperations) | Out-String)"
Assert-Route 'Get-MgExternalConnection_List' 'GET' '/external/connections'
Assert-Route 'Get-MgExternalConnection_Get' 'GET' '/external/connections/{externalConnection-id}'
Assert-Route 'Get-MgSearchBookmark_List' 'GET' '/search/bookmarks'
Assert-Route 'Get-MgSearchBookmark_Get' 'GET' '/search/bookmarks/{bookmark-id}'
Assert-Route 'Get-MgExternalConnectionSchema' 'GET' '/external/connections/{externalConnection-id}/schema'
Assert-Route 'Set-MgExternalConnectionItem' 'PUT' '/external/connections/{externalConnection-id}/items/{externalItem-id}'
$queryName = if ($ApiVersion -eq 'v1.0') { 'Invoke-MgQuerySearch' } else { 'Invoke-MgSearchQuery' }
Assert-Route $queryName 'POST' '/search/query'
Assert-Search ($module.ExportedCmdlets['Get-MgExternalConnection'].DefaultParameterSet -eq 'List') 'Connection default must remain List.'

Add-Type -TypeDefinition @'
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
public sealed class SearchMigrationRequest
{
    public string Method, Uri, Body, Marker, Authorization;
}
public sealed class SearchMigrationTransport : DelegatingHandler
{
    public readonly Queue<string> Responses = new Queue<string>();
    public readonly List<string> Requests = new List<string>();
    public readonly List<SearchMigrationRequest> Captures = new List<SearchMigrationRequest>();
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
    {
        if (Responses.Count == 0)
            throw new InvalidOperationException("Unexpected Search request: " + request.Method + " " + request.RequestUri);
        Requests.Add(request.Method + " " + Uri.UnescapeDataString(request.RequestUri.AbsolutePath));
        IEnumerable<string> values;
        Captures.Add(new SearchMigrationRequest {
            Method = request.Method.Method, Uri = request.RequestUri.AbsoluteUri,
            Body = request.Content == null ? "" : await request.Content.ReadAsStringAsync(),
            Marker = request.Headers.TryGetValues("x-search-marker", out values) ? string.Join(",", values) : "",
            Authorization = request.Headers.Authorization == null ? "" : request.Headers.Authorization.Scheme
        });
        var response = Responses.Dequeue();
        return response == "204" ? new HttpResponseMessage(HttpStatusCode.NoContent)
            : new HttpResponseMessage(HttpStatusCode.OK) {
                Content = new StringContent(response, Encoding.UTF8, "application/json")
            };
    }
}
public sealed class SearchDeclineHost : PSHost
{
    private readonly SearchDeclineUI ui = new SearchDeclineUI();
    private readonly Guid id = Guid.NewGuid();
    public int PromptCount { get { return ui.PromptCount; } }
    public override Guid InstanceId { get { return id; } }
    public override string Name { get { return "SearchOfflineDecline"; } }
    public override Version Version { get { return new Version(1, 0); } }
    public override PSHostUserInterface UI { get { return ui; } }
    public override CultureInfo CurrentCulture { get { return CultureInfo.InvariantCulture; } }
    public override CultureInfo CurrentUICulture { get { return CultureInfo.InvariantCulture; } }
    public override void EnterNestedPrompt() { throw new NotSupportedException(); }
    public override void ExitNestedPrompt() { throw new NotSupportedException(); }
    public override void NotifyBeginApplication() { }
    public override void NotifyEndApplication() { }
    public override void SetShouldExit(int code) { throw new InvalidOperationException("Unexpected exit."); }
}
public sealed class SearchDeclineUI : PSHostUserInterface
{
    public int PromptCount { get; private set; }
    public override PSHostRawUserInterface RawUI { get { return null; } }
    public override int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice)
    {
        for (var i = 0; i < choices.Count; i++)
            if (choices[i].Label.Replace("&", "") == "No") { PromptCount++; return i; }
        throw new InvalidOperationException("Expected a genuine No choice.");
    }
    public override Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> fields)
        { throw new InvalidOperationException("Unexpected mandatory parameter prompt."); }
    public override PSCredential PromptForCredential(string caption, string message, string user, string target)
        { throw new InvalidOperationException("Unexpected credentials prompt."); }
    public override PSCredential PromptForCredential(string caption, string message, string user, string target, PSCredentialTypes types, PSCredentialUIOptions options)
        { throw new InvalidOperationException("Unexpected credentials prompt."); }
    public override string ReadLine() { throw new InvalidOperationException("Unexpected input."); }
    public override SecureString ReadLineAsSecureString() { throw new InvalidOperationException("Unexpected input."); }
    public override void Write(string value) { }
    public override void Write(ConsoleColor foreground, ConsoleColor background, string value) { }
    public override void WriteLine(string value) { }
    public override void WriteDebugLine(string value) { }
    public override void WriteErrorLine(string value) { }
    public override void WriteProgress(long source, ProgressRecord record) { }
    public override void WriteVerboseLine(string value) { }
    public override void WriteWarningLine(string value) { }
}
'@
$null = Get-MgContext
. (Join-Path $PSScriptRoot '..\src\Authentication\Authentication\test\TypeHelpers.ps1')
Set-MgTestDataStore
$core = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Authentication.Core' })
Assert-Search ($core.Count -eq 1) 'Expected a single Authentication.Core identity.'
$session = $core[0].GetType('Microsoft.Graph.PowerShell.Authentication.GraphSession', $true).GetProperty('Instance').GetValue($null)
$factory = $core[0].GetType('Microsoft.Graph.PowerShell.Authentication.Core.Http.GraphHttpClientFactory', $true)
$clients = [System.Collections.Generic.List[object]]::new()
$handlers = [System.Collections.Generic.List[object]]::new()
$endpoint = (Get-MgEnvironment -Name $Environment).GraphEndpoint.TrimEnd('/')
function Set-OfflineClient {
    $script:handler = [SearchMigrationTransport]::new()
    $script:client = $factory.GetMethod('Create').Invoke($null, @(
        $session.AuthContext, $session.RequestContext, [Net.Http.DelegatingHandler[]]@($handler), $null, $false
    ))
    $clients.Add($client)
    $handlers.Add($handler)
    $session.GraphHttpClient = $client
    Assert-Search ([object]::ReferenceEquals($client, [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient())) 'Real authenticated factory client was not retained.'
    Assert-Search ($client.BaseAddress.AbsoluteUri.TrimEnd('/') -ceq 'https://graph.microsoft.com/v1.0') 'Expected the real factory global v1.0 BaseAddress regression condition.'
}
function Assert-Request([string]$Path) {
    Assert-Search ($handler.Responses.Count -eq 0) "Command did not consume its expected response: $Path"
    Assert-Search ($handler.Requests[$handler.Requests.Count - 1] -ceq "GET /$ApiVersion$Path") "Wrong actual HTTP operation: $($handler.Requests[$handler.Requests.Count - 1])"
    $capture = $handler.Captures[$handler.Captures.Count - 1]
    Assert-Search ($capture.Uri -ceq "$endpoint/$ApiVersion$Path") "Wrong actual cloud/profile URI: $($capture.Uri)"
    Assert-Search ($capture.Authorization -ceq 'Bearer') 'Request did not traverse real Authentication handler.'
}
function Assert-Rejected([scriptblock]$Action) {
    $before = $handler.Requests.Count
    $rejected = $false
    try { & $Action }
    catch [System.Management.Automation.ParameterBindingException] { $rejected = $true }
    Assert-Search $rejected 'Expected real PowerShell parameter binding rejection.'
    Assert-Search ($handler.Requests.Count -eq $before) 'Invalid binding issued an HTTP request.'
}
try {
    Connect-MgGraph -AccessToken (ConvertTo-SecureString 'offline-search-token' -AsPlainText -Force) -Environment $Environment -NoWelcome
    Set-OfflineClient
    $runtime = $module.ExportedCmdlets['Get-MgExternalConnection_Get'].ImplementingType.BaseType.Assembly
    $cacheType = $runtime.GetType('Microsoft.Graph.Wrapper.Runtime.SessionAdapterCache', $true)
    $cacheField = $cacheType.GetField('_adapter', [Reflection.BindingFlags]'Static,NonPublic')
    $baseAddress = $client.BaseAddress
    $handler.Responses.Enqueue('{"value":[{"id":"connection-1"}]}')
    $items = @(Get-MgExternalConnection)
    Assert-Request '/external/connections'
    Assert-Search ($items.Count -eq 1 -and $items[0].Id -eq 'connection-1') 'Connection List did not return the actual typed response.'
    $firstAdapter = $cacheField.GetValue($null)
    $handler.Responses.Enqueue('{"id":"connection-1"}')
    $item = Get-MgExternalConnection -ExternalConnectionId 'connection-1' -Headers @{ 'x-search-marker' = 'bound-get' }
    Assert-Request '/external/connections/connection-1'
    Assert-Search ($item.Id -eq 'connection-1') 'Connection Get did not use the ID-selected worker.'
    Assert-Search ($handler.Captures[$handler.Captures.Count - 1].Marker -ceq 'bound-get') 'Bound generic GET header was lost.'
    Assert-Search ([object]::ReferenceEquals($firstAdapter, $cacheField.GetValue($null))) 'Same session/profile adapter was not reused.'
    $handler.Responses.Enqueue('{"value":[{"id":"bookmark-1"}]}')
    $items = @(Get-MgSearchBookmark)
    Assert-Request '/search/bookmarks'
    Assert-Search ($items.Count -eq 1 -and $items[0].Id -eq 'bookmark-1') 'Bookmark List neighbor changed.'
    $handler.Responses.Enqueue('{"id":"bookmark-1"}')
    $item = Get-MgSearchBookmark -BookmarkId 'bookmark-1'
    Assert-Request '/search/bookmarks/bookmark-1'
    Assert-Search ($item.Id -eq 'bookmark-1') 'Bookmark Get neighbor changed.'
    $handler.Responses.Enqueue('{"baseType":"microsoft.graph.externalItem"}')
    $null = Get-MgExternalConnectionSchema -ExternalConnectionId 'connection-1'
    Assert-Request '/external/connections/connection-1/schema'

    if ($ApiVersion -eq 'beta') {
        $run = '/external/industryData/runs/{industryDataRun-id}'
        Assert-Route 'Get-MgExternalIndustryDataRunStatistics' 'GET' "$run/microsoft.graph.industryData.getStatistics()"
        Assert-Route 'Get-MgExternalIndustryDataRunGetStatistics' 'GET' '/external/industryData/runs/microsoft.graph.industryData.getStatistics()'
        Assert-Route 'Get-MgExternalIndustryDataRunActivity_List' 'GET' "$run/activities"
        Assert-Route 'Get-MgExternalIndustryDataRunActivity_Get' 'GET' "$run/activities/{industryDataRunActivity-id}"
        Assert-Route 'Get-MgExternalIndustryDataRunActivityFlow' 'GET' "$run/activities/{industryDataRunActivity-id}/activity"
        Assert-Search ($module.ExportedCmdlets['Get-MgExternalIndustryDataRunActivity'].DefaultParameterSet -eq 'List') 'Run Activity default must remain List.'
        Assert-Mandatory 'Get-MgExternalIndustryDataRunStatistics' 'IndustryDataRunId'
        Assert-Mandatory 'Get-MgExternalIndustryDataRunActivityFlow' 'IndustryDataRunId'
        Assert-Mandatory 'Get-MgExternalIndustryDataRunActivityFlow' 'IndustryDataRunActivityId'
        Assert-Search (-not $module.ExportedCmdlets['Get-MgExternalIndustryDataRunGetStatistics'].Parameters.ContainsKey('IndustryDataRunId')) 'Collection-bound function unexpectedly requires a run ID.'
        foreach ($name in @('Get-MgExternalIndustryDataRunStatistics', 'Get-MgExternalIndustryDataRunGetStatistics', 'Get-MgExternalIndustryDataRunActivity', 'Get-MgExternalIndustryDataRunActivityFlow')) {
            Assert-Search (-not $module.ExportedCmdlets[$name].Parameters.ContainsKey('Route')) "Unexpected endpoint selector: $name"
        }
        $handler.Responses.Enqueue('{"runId":"run-1"}')
        $statistics = Get-MgExternalIndustryDataRunStatistics -IndustryDataRunId 'run-1'
        Assert-Request '/external/industryData/runs/run-1/microsoft.graph.industryData.getStatistics()'
        Assert-Search ($statistics.RunId -eq 'run-1') 'Kiota statistics response was not preserved.'
        $handler.Responses.Enqueue('{"runId":"run-collection"}')
        $collectionStatistics = Get-MgExternalIndustryDataRunGetStatistics
        Assert-Request '/external/industryData/runs/microsoft.graph.industryData.getStatistics()'
        Assert-Search ($collectionStatistics.RunId -eq 'run-collection' -and $collectionStatistics.GetType() -eq $statistics.GetType()) 'Collection function changed the actual Kiota statistics result.'
        $handler.Responses.Enqueue('{"value":[{"id":"activity-1","@odata.type":"#microsoft.graph.industryData.inboundFlowActivity"}]}')
        $items = @(Get-MgExternalIndustryDataRunActivity -IndustryDataRunId 'run-1')
        Assert-Request '/external/industryData/runs/run-1/activities'
        Assert-Search ($items.Count -eq 1 -and $items[0].Id -eq 'activity-1') 'Run Activity List default changed.'
        $handler.Responses.Enqueue('{"id":"activity-1","@odata.type":"#microsoft.graph.industryData.inboundFlowActivity"}')
        $item = Get-MgExternalIndustryDataRunActivity -IndustryDataRunId 'run-1' -IndustryDataRunActivityId 'activity-1'
        Assert-Request '/external/industryData/runs/run-1/activities/activity-1'
        Assert-Search ($item.Id -eq 'activity-1') 'Run Activity Get no longer selects its ordinary item worker.'
        $handler.Responses.Enqueue('{"id":"flow-1","@odata.type":"#microsoft.graph.industryData.inboundFlow"}')
        $flow = Get-MgExternalIndustryDataRunActivityFlow -IndustryDataRunId 'run-1' -IndustryDataRunActivityId 'activity-1'
        Assert-Request '/external/industryData/runs/run-1/activities/activity-1/activity'
        Assert-Search ($flow.Id -eq 'flow-1' -and $flow.GetType() -ne $item.GetType()) 'Nested flow response was confused with the run activity model.'
        Assert-Rejected { Get-MgExternalIndustryDataRunStatistics -IndustryDataRunId '' }
        Assert-Rejected { Get-MgExternalIndustryDataRunActivityFlow -IndustryDataRunId 'run-1' -IndustryDataRunActivityId '' }
        Assert-Rejected { Get-MgExternalIndustryDataRunActivity -IndustryDataRunId 'run-1' -Route 'Activity' }
    }
    else {
        Assert-Search (@($module.ExportedCmdlets.Keys | Where-Object { $_ -like '*ExternalIndustryData*' }).Count -eq 0) 'Beta-only operations leaked into v1.0.'
    }
    $declineHost = [SearchDeclineHost]::new()
    $runspace = [runspacefactory]::CreateRunspace($declineHost)
    $runspace.Open()
    $engine = [powershell]::Create()
    $engine.Runspace = $runspace
    try {
        $null = $engine.AddCommand('Import-Module').AddParameter('Name', $manifest).AddParameter('ErrorAction', 'Stop').Invoke()
        if ($engine.HadErrors) { throw ($engine.Streams.Error | Out-String) }
        $engine.Commands.Clear()
        $mutations = @(
            @{ Name = 'New-MgExternalConnection'; Arguments = @{ Name = 'offline-new'; Description = 'typed Search body' }; Method = 'POST'; Path = '/external/connections'; Response = '{"id":"created","name":"offline-new"}' },
            @{ Name = 'Update-MgExternalConnection'; Arguments = @{ ExternalConnectionId = 'connection-1'; Name = 'offline-update'; Description = 'typed Search body' }; Method = 'PATCH'; Path = '/external/connections/connection-1'; Response = '204' },
            @{ Name = 'Remove-MgExternalConnection'; Arguments = @{ ExternalConnectionId = 'connection-1' }; Method = 'DELETE'; Path = '/external/connections/connection-1'; Response = '204' },
            @{ Name = $queryName; Arguments = @{ Requests = @(@{ EntityTypes = @('externalItem'); Query = @{ QueryString = 'offline search' } }) }; Method = 'POST'; Path = '/search/query'; Response = '{"value":[]}' }
        )
        if ($ApiVersion -eq 'beta') {
            $mutations += @{ Name = 'Invoke-MgExternalIndustryDataRunStart'; Arguments = @{}; Method = 'POST'; Path = '/external/industryData/runs/microsoft.graph.industryData.start'; Response = '204' }
        }
        foreach ($mutation in $mutations) {
            $name = $mutation.Name
            $arguments = $mutation.Arguments
            $before = $handler.Requests.Count
            $null = & $name @arguments -WhatIf
            Assert-Search ($handler.Requests.Count -eq $before) "$name WhatIf issued HTTP."
            $null = $engine.AddCommand($name)
            foreach ($argument in $arguments.GetEnumerator()) { $null = $engine.AddParameter($argument.Key, $argument.Value) }
            $prompts = $declineHost.PromptCount
            $null = $engine.AddParameter('Confirm', $true).Invoke()
            if ($engine.HadErrors) { throw ($engine.Streams.Error | Out-String) }
            $engine.Commands.Clear()
            Assert-Search ($declineHost.PromptCount -eq $prompts + 1) "$name did not present exactly one genuine declined confirmation."
            Assert-Search ($handler.Requests.Count -eq $before) "$name declined confirmation issued HTTP."
            $handler.Responses.Enqueue($mutation.Response)
            if ($mutation.Method -eq 'PATCH') { $handler.Responses.Enqueue('{"id":"connection-1","name":"offline-update"}') }
            $result = & $name @arguments -Headers @{ 'x-search-marker' = 'bound-mutation' } -Confirm:$false
            $expectedCount = if ($mutation.Method -eq 'PATCH') { 2 } else { 1 }
            Assert-Search ($handler.Requests.Count -eq $before + $expectedCount) "$name issued an unexpected number of requests."
            $capture = $handler.Captures[$before]
            Assert-Search ($capture.Method -ceq $mutation.Method -and $capture.Uri -ceq "$endpoint/$ApiVersion$($mutation.Path)") "$name selected the wrong real HTTP method/cloud/profile/path."
            Assert-Search ($capture.Authorization -ceq 'Bearer' -and $capture.Marker -ceq 'bound-mutation') "$name lost authentication or the bound generic mutation header."
            if ($name -in @('New-MgExternalConnection', 'Update-MgExternalConnection')) {
                $body = $capture.Body | ConvertFrom-Json
                Assert-Search ($body.name -ceq $arguments.Name -and $body.description -ceq $arguments.Description) "$name did not serialize its actual typed JSON body."
                Assert-Search ($null -ne $result -and $result.GetType().FullName -eq 'Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.ExternalConnection') "$name did not return the actual typed result."
            }
            elseif ($name -eq $queryName) {
                $body = $capture.Body | ConvertFrom-Json
                Assert-Search ($body.requests.Count -eq 1 -and $body.requests[0].query.queryString -ceq 'offline search' -and $body.requests[0].entityTypes[0] -ceq 'externalItem') 'Search action lost its typed nested JSON request.'
                Assert-Search ($null -ne $result) 'Search action did not return its typed response envelope.'
            }
            else {
                Assert-Search ([string]::IsNullOrEmpty($capture.Body) -and $null -eq $result) "$name must be a bodyless request without result."
            }
            if ($mutation.Method -eq 'PATCH') {
                Assert-Request '/external/connections/connection-1'
                Assert-Search ($result.Id -ceq 'connection-1' -and $result.Name -ceq 'offline-update') '204 PATCH did not re-fetch the selected connection.'
                if ($handler.Captures[$before + 1].Marker -cne 'bound-mutation') {
                    $failures.Add('FAIL #3886: selected PATCH carries bound x-search-marker, but its 204 follow-up GET drops that generic header.')
                }
                else { $script:checks++ }
            }
        }
        Assert-Rejected { Get-MgExternalConnection -ExternalConnectionId '' }
    }
    finally {
        $engine.Dispose()
        $runspace.Dispose()
    }

    foreach ($profile in @('v1.0', 'beta', 'v1.0', 'beta')) {
        $root = [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphServiceRoot($profile)
        $adapter = $cacheType.GetMethod('GetOrCreate').Invoke($null, @($client, $root))
        $same = $cacheType.GetMethod('GetOrCreate').Invoke($null, @($client, $root))
        Assert-Search ([object]::ReferenceEquals($adapter, $same)) 'Profile-specific adapter was not reused.'
        $typedClient = [Microsoft.Graph.PowerShell.Search.Client.ApiClient]::new($adapter)
        $handler.Responses.Enqueue('{"id":"cache-proof"}')
        $result = $typedClient.External.Connections['cache-proof'].GetAsync().GetAwaiter().GetResult()
        $capture = $handler.Captures[$handler.Captures.Count - 1]
        Assert-Search ($result.Id -ceq 'cache-proof' -and $capture.Uri -ceq "$endpoint/$profile/external/connections/cache-proof") 'Alternating profiles used the factory default root instead of their explicit cloud/profile.'
        Assert-Search ([object]::ReferenceEquals($client, $session.GraphHttpClient) -and [object]::Equals($baseAddress, $client.BaseAddress)) 'Profile switch mutated the shared authenticated HttpClient or BaseAddress.'
    }
    $previousAdapter = $cacheField.GetValue($null)
    Set-MgRequestContext -ClientTimeout 42
    Assert-Search ($null -eq $session.GraphHttpClient) 'Request-context change did not invalidate the client.'
    Set-OfflineClient
    $handler.Responses.Enqueue('{"id":"context-proof"}')
    $null = Get-MgExternalConnection -ExternalConnectionId 'context-proof'
    Assert-Request '/external/connections/context-proof'
    Assert-Search (-not [object]::ReferenceEquals($previousAdapter, $cacheField.GetValue($null)) -and $client.Timeout.TotalSeconds -eq 42) 'Context change retained a stale adapter or timeout.'
    $previousAdapter = $cacheField.GetValue($null)
    Connect-MgGraph -AccessToken (ConvertTo-SecureString 'offline-search-reconnected' -AsPlainText -Force) -Environment $Environment -NoWelcome
    Assert-Search ($null -eq $session.GraphHttpClient) 'Reconnect did not invalidate the session client.'
    Set-OfflineClient
    $handler.Responses.Enqueue('{"id":"reconnected"}')
    $null = Get-MgExternalConnection -ExternalConnectionId 'reconnected'
    Assert-Request '/external/connections/reconnected'
    Assert-Search (-not [object]::ReferenceEquals($previousAdapter, $cacheField.GetValue($null))) 'Reconnect retained a stale adapter.'
    Disconnect-MgGraph | Out-Null
    Assert-Search ($null -eq $session.GraphHttpClient -and $null -eq (Get-MgContext)) 'Disconnect retained a session.'
    $noSession = $false
    $before = $handler.Requests.Count
    try { Get-MgExternalConnection -ExternalConnectionId 'no-session' | Out-Null }
    catch {
        if ($_.FullyQualifiedErrorId -notlike 'NoGraphSession,*') { throw }
        $noSession = $true
    }
    Assert-Search ($noSession -and $handler.Requests.Count -eq $before) 'Disconnected invocation did not fail before HTTP.'
    $assemblies = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object {
        $_.GetName().Name -like 'Microsoft.Graph.Authentication*' -or $_.GetName().Name -like 'Microsoft.Kiota.*' -or
        $_.GetName().Name -in @('Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate')
    })
    Assert-Search (@($assemblies | Group-Object { $_.GetName().Name } | Where-Object Count -ne 1).Count -eq 0) 'Duplicate Authentication/Kiota assembly identities.'
    $sources = foreach ($assembly in $assemblies) {
        $name = $assembly.GetName().Name
        $context = [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($assembly).Name
        $expected = if ($name -in @('Microsoft.Graph.Authentication', 'Microsoft.Graph.Authentication.Loader')) { 'Default' } else { 'Microsoft.Graph.Authentication' }
        Assert-Search ($context -ceq $expected -and $assembly.Location.StartsWith("$($auth.ModuleBase)\", [StringComparison]::OrdinalIgnoreCase)) "Wrong packaged assembly source/context: $name"
        [pscustomobject]@{ Name = $name; Version = "$($assembly.GetName().Version)"; Location = $assembly.Location; Context = $context }
    }
    foreach ($required in @('Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate', 'Microsoft.Kiota.Serialization.Multipart', 'Microsoft.Kiota.Serialization.Json', 'Microsoft.Graph.Authentication.Core')) {
        Assert-Search (@($sources | Where-Object Name -eq $required).Count -eq 1) "Missing required Auth-owned dependency: $required"
    }
    [pscustomobject]@{
        ApiVersion = $ApiVersion
        Environment = $Environment
        Exports = $module.ExportedCmdlets.Count
        Assertions = $script:checks
        HttpRequests = @($handlers | ForEach-Object { $_.Requests } | ForEach-Object { $_ }).Count
        CoveredOperations = $compiledOperations.Count
        ClientOnlyOperations = @($specOperations | Where-Object { -not $compiledOperations.Contains($_) }).Count
        AuthVersion = $auth.Version.ToString()
        AuthPath = $auth.ModuleBase
        DeclinedPrompts = $declineHost.PromptCount
        FactoryBaseAddress = $baseAddress.AbsoluteUri
        Captures = @($handlers | ForEach-Object { $_.Captures } | ForEach-Object { $_ })
        Assemblies = @($sources)
        Failures = @($failures)
        LiveGraphRequests = 0
        ModulePath = $module.Path
    } | ConvertTo-Json -Depth 7
    if ($failures.Count) { throw ($failures -join [Environment]::NewLine) }
}
finally {
    $session.GraphHttpClient = $null
    foreach ($ownedClient in $clients) { $ownedClient.Dispose() }
}

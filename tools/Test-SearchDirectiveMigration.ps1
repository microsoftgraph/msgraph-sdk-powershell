<#
.SYNOPSIS
Checks the complete compiled Search module's migration outcomes using an in-memory HTTP transport.

.DESCRIPTION
Run separately in a fresh pwsh for each profile after its full Release build. Imports the
real module and original Authentication 2.38.1, checks compiled route metadata and binding,
then drives real commands through a stub HttpClient without connecting to a tenant.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion,
    [string]$Configuration = 'Release'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path $PSScriptRoot -Parent
$manifest = Join-Path $repoRoot "src\Search\wrapper\$ApiVersion\bin\$Configuration\netstandard2.0\Microsoft.Graph.Wrapper.Search.psd1"
if (-not (Test-Path -LiteralPath $manifest)) { throw "Full Search build required: $manifest" }
if (Get-Module Microsoft.Graph.Wrapper.Search) { throw 'Run this gate in a fresh pwsh process.' }
Import-Module Microsoft.Graph.Authentication
if ((Get-Module Microsoft.Graph.Authentication).Version -ne [version]'2.38.1') {
    throw 'This gate requires the original official Authentication 2.38.1 module.'
}
$module = Import-Module $manifest -PassThru
$script:checks = 0
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
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
public sealed class SearchMigrationTransport : HttpMessageHandler
{
    public readonly Queue<string> Responses = new Queue<string>();
    public readonly List<string> Requests = new List<string>();
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
    {
        if (Responses.Count == 0)
            throw new InvalidOperationException("Unexpected Search request: " + request.Method + " " + request.RequestUri);
        Requests.Add(request.Method + " " + Uri.UnescapeDataString(request.RequestUri.AbsolutePath));
        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK) {
            Content = new StringContent(Responses.Dequeue(), Encoding.UTF8, "application/json")
        });
    }
}
'@
$handler = [SearchMigrationTransport]::new()
$client = [System.Net.Http.HttpClient]::new($handler)
$session = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance
$originalClient = $session.GraphHttpClient
$session.GraphHttpClient = $client
function Assert-Request([string]$Path) {
    Assert-Search ($handler.Responses.Count -eq 0) "Command did not consume its expected response: $Path"
    Assert-Search ($handler.Requests[$handler.Requests.Count - 1] -ceq "GET /$ApiVersion$Path") "Wrong actual HTTP operation: $($handler.Requests[$handler.Requests.Count - 1])"
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
    $handler.Responses.Enqueue('{"value":[{"id":"connection-1"}]}')
    $items = @(Get-MgExternalConnection)
    Assert-Request '/external/connections'
    Assert-Search ($items.Count -eq 1 -and $items[0].Id -eq 'connection-1') 'Connection List did not return the actual typed response.'
    $handler.Responses.Enqueue('{"id":"connection-1"}')
    $item = Get-MgExternalConnection -ExternalConnectionId 'connection-1'
    Assert-Request '/external/connections/connection-1'
    Assert-Search ($item.Id -eq 'connection-1') 'Connection Get did not use the ID-selected worker.'
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
    $before = $handler.Requests.Count
    Update-MgExternalConnection -ExternalConnectionId 'connection-1' -Name 'unchanged-neighbor' -WhatIf
    Assert-Search ($handler.Requests.Count -eq $before) 'Neighbor WhatIf unexpectedly acquired transport.'
    [pscustomobject]@{
        ApiVersion = $ApiVersion
        Exports = $module.ExportedCmdlets.Count
        Assertions = $script:checks
        HttpRequests = $handler.Requests.Count
        CoveredOperations = $compiledOperations.Count
        ClientOnlyOperations = @($specOperations | Where-Object { -not $compiledOperations.Contains($_) }).Count
        AuthVersion = (Get-Module Microsoft.Graph.Authentication).Version.ToString()
        ModulePath = $module.Path
    } | ConvertTo-Json
}
finally {
    $session.GraphHttpClient = $originalClient
    $client.Dispose()
}

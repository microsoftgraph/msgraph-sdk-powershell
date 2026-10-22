<#
.SYNOPSIS
Runs the actual three-operation Teams mixed-read fixture against an in-memory HTTP transport.

.DESCRIPTION
The fixture uses the genuine beta Teams chat-message list/item/getAllMessages Kiota builders,
production list/item workers, and production dispatcher. It needs no authentication or network.

.EXAMPLE
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperMixedReadRoutes.ps1 -FixtureAssembly <fixture-dll>
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string]$FixtureAssembly
)
$ErrorActionPreference = 'Stop'
$FixtureAssembly = (Resolve-Path $FixtureAssembly).Path
$module = Import-Module $FixtureAssembly -PassThru -ErrorAction Stop
$assemblyRoot = Split-Path $FixtureAssembly -Parent
Add-Type -Path (Join-Path $assemblyRoot 'Microsoft.Graph.Authentication.Core.dll')
Add-Type -Path (Join-Path $assemblyRoot 'Microsoft.Graph.Authentication.dll')

Add-Type -TypeDefinition @'
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public sealed class MixedReadRequest
{
    public string Method;
    public string Url;
    public Dictionary<string, string> Headers;
    public MixedReadRequest(HttpRequestMessage request)
    {
        Method = request.Method.Method;
        Url = request.RequestUri.AbsoluteUri;
        Headers = request.Headers.ToDictionary(header => header.Key,
            header => string.Join(",", header.Value), StringComparer.OrdinalIgnoreCase);
    }
}

public sealed class MixedReadHandler : HttpMessageHandler
{
    public const string NextLink = "https://graph.microsoft.com/beta/continuation?$skiptoken=page2&opaque=model-token";
    public readonly ConcurrentQueue<MixedReadRequest> Requests = new ConcurrentQueue<MixedReadRequest>();
    public readonly ManualResetEventSlim Started = new ManualResetEventSlim(false);
    public readonly ManualResetEventSlim Cancelled = new ManualResetEventSlim(false);
    public string Mode = "Pages";
    public int RequestCount { get { return Requests.Count; } }
    public MixedReadRequest LastRequest { get { return Requests.Last(); } }
    public void Reset()
    {
        MixedReadRequest ignored;
        while (Requests.TryDequeue(out ignored)) { }
        Started.Reset();
        Cancelled.Reset();
    }
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
    {
        Requests.Enqueue(new MixedReadRequest(request));
        if (Mode == "CancelContinuation" && request.RequestUri.AbsoluteUri.Contains("skiptoken"))
        {
            Started.Set();
            try { await Task.Delay(Timeout.Infinite, token).ConfigureAwait(false); }
            catch (OperationCanceledException) { Cancelled.Set(); throw; }
            throw new InvalidOperationException("The cancellation-only continuation cannot finish normally.");
        }
        if (Mode == "Error")
            return Json(HttpStatusCode.BadRequest,
                "{\"error\":{\"code\":\"MixedFixtureFailure\",\"message\":\"synthetic mixed-read failure\"}}");
        if (request.RequestUri.AbsolutePath.EndsWith("/messages/message-id", StringComparison.Ordinal))
            return Json(HttpStatusCode.OK, "{\"id\":\"message-id\",\"body\":{\"content\":\"item\"}}");
        if (request.RequestUri.AbsoluteUri.Contains("skiptoken"))
            return Json(HttpStatusCode.OK, "{\"value\":[{\"id\":\"m3\"}]}");
        return Json(HttpStatusCode.OK, "{\"value\":[{\"id\":\"m1\"},{\"id\":\"m2\"}],\"@odata.nextLink\":\"" + NextLink + "\"}");
    }
    private static HttpResponseMessage Json(HttpStatusCode status, string body)
    {
        return new HttpResponseMessage(status) { Content = new StringContent(body, Encoding.UTF8, "application/json") };
    }
}
'@

function Assert-Mixed([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

function Assert-MixedRejected([scriptblock]$Invocation, [string]$ErrorId = 'InvalidGraphRouteParameters') {
    $before = $handler.RequestCount
    $failure = $null
    try { $null = & $Invocation }
    catch { $failure = $_ }
    Assert-Mixed ($null -ne $failure -and $failure.FullyQualifiedErrorId -like "$ErrorId,*") `
        "Expected real rejection $ErrorId, got: $failure"
    Assert-Mixed ($handler.RequestCount -eq $before) 'A rejected parameter combination reached a worker/HTTP transport.'
}

function Assert-MixedItems($Items, [string[]]$Ids) {
    Assert-Mixed (($Items.Id -join ',') -eq ($Ids -join ',')) "Wrong typed message ids: $($Items.Id -join ',')"
    foreach ($item in $Items) {
        Assert-Mixed ($item.GetType().FullName -eq 'Microsoft.Graph.PowerShell.MixedRead.Client.Models.ChatMessage') `
            'A mixed-read worker emitted a response envelope instead of a typed chatMessage.'
    }
}

function Assert-MixedPath([string]$Path) {
    Assert-Mixed ($handler.LastRequest.Method -eq 'GET') 'A read worker issued a non-GET request.'
    Assert-Mixed (([uri]$handler.LastRequest.Url).AbsolutePath -eq $Path) "Incorrect route: $($handler.LastRequest.Url)"
}

$handler = [MixedReadHandler]::new()
$http = [Net.Http.HttpClient]::new($handler)
$oldSession = $null
$pipeline = $null
try {
    if ([Microsoft.Graph.PowerShell.Authentication.GraphSession]::Exists) {
        $oldSession = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.GraphHttpClient
    }
    else {
        [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Initialize(
            [Func[Microsoft.Graph.PowerShell.Authentication.GraphSession]]{ [Microsoft.Graph.PowerShell.Authentication.GraphSession]::new() })
    }
    [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.GraphHttpClient = $http
    Assert-Mixed ([object]::ReferenceEquals(
        [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient(), $http)) `
        'The actual runtime transport seam must point exclusively at the mock before invoking workers.'

    $command = Get-Command Get-MgAllUserChatMessage -Module $module.Name
    Assert-Mixed ($command.DefaultParameterSet -eq 'Route' -and $command.ParameterSets.Count -eq 1) `
        'Mixed reads require exactly one explicit public Route parameter set.'
    $parameters = $command.ParameterSets[0].Parameters
    Assert-Mixed (($parameters | Where-Object Name -eq UserId).IsMandatory) 'Common UserId must remain mandatory.'
    foreach ($name in 'ChatId', 'ChatMessageId', 'Model', 'All', 'Top') {
        Assert-Mixed (-not ($parameters | Where-Object Name -eq $name).IsMandatory) "$name must be optional public metadata."
    }
    $routeValidation = $command.Parameters.Route.Attributes | Where-Object { $_ -is [Management.Automation.ValidateSetAttribute] }
    Assert-Mixed (($routeValidation.ValidValues -join ',') -eq 'Published,Aggregate,Chat') 'The selector lost a reviewed route label.'
    Assert-Mixed ($command.Parameters.Property.Aliases -contains 'Select') 'Select must remain an alias for Property.'
    Assert-Mixed ($command.Parameters.ExpandProperty.Aliases -contains 'Expand') 'Expand must remain an alias for ExpandProperty.'
    $routes = @($command.ImplementingType.GetCustomAttributes($false) | Where-Object { $_.GetType().Name -eq 'GraphRouteAttribute' })
    $expectedPaths = @(
        '/users/{user-id}/chats/getAllMessages()',
        '/users/{user-id}/chats/{chat-id}/messages',
        '/users/{user-id}/chats/{chat-id}/messages/{chatMessage-id}'
    )
    Assert-Mixed ($routes.Count -eq 3) 'The dispatcher must preserve all three SourceGraphRoute tuples.'
    foreach ($path in $expectedPaths) {
        Assert-Mixed (@($routes | Where-Object { $_.Method -eq 'GET' -and $_.Path -eq $path -and $_.ParameterSetName -eq 'Route' }).Count -eq 1) `
            "Missing exact public GET/Route metadata for $path"
    }
    Assert-Mixed (@($command.OutputType | Where-Object { $_.Type.FullName -eq 'Microsoft.Graph.PowerShell.MixedRead.Client.Models.ChatMessage' }).Count -eq 1) `
        'Public output metadata must describe chatMessage, not either paged response envelope.'

    $information = [Microsoft.Graph.PowerShell.MixedRead.MixedReadRequestProbe]::Aggregate()
    Assert-Mixed ($information.HttpMethod.ToString() -eq 'GET') 'The genuine function RequestInformation must be GET.'
    Assert-Mixed ($information.QueryParameters['model'] -eq 'A') 'The genuine function RequestInformation dropped Model.'
    Assert-Mixed ($information.Headers['x-mixed-probe'] -contains 'yes') 'The genuine function RequestInformation dropped headers.'
    Assert-Mixed ($information.QueryParameters.Count -eq 9) 'The genuine function RequestInformation lost an OData query option.'
    Assert-Mixed ($handler.RequestCount -eq 0) 'Constructing typed RequestInformation must not issue HTTP.'

    $aggregatePath = '/beta/users/user-id/chats/getAllMessages()'
    $chatPath = '/beta/users/user-id/chats/chat-id/messages'
    $itemPath = $chatPath + '/message-id'
    foreach ($selector in $null, 'Published', 'Aggregate') {
        $handler.Reset()
        $warnings = @()
        $arguments = @{ UserId = 'user-id'; WarningVariable = 'warnings'; WarningAction = 'SilentlyContinue' }
        if ($selector) { $arguments.Route = $selector }
        $items = @(Get-MgAllUserChatMessage @arguments)
        Assert-MixedItems $items @('m1', 'm2')
        Assert-MixedPath $aggregatePath
        Assert-Mixed ($handler.RequestCount -eq 1 -and $warnings.Count -eq 1) 'Default/explicit Aggregate without All must return one page and one truncation warning.'
    }

    $handler.Reset()
    $queryArguments = @{
        UserId = 'user-id'; Model = 'A'; Top = 7; Skip = 2; Search = 'needle'
        Filter = 'id ne null'; Count = $true; OrderBy = @('createdDateTime desc')
        Select = @('id', 'body'); Expand = @('replies'); All = $true
        Headers = @{ 'x-mixed-test' = 'aggregate-pages' }
    }
    $warnings = @()
    $items = @(Get-MgAllUserChatMessage @queryArguments -WarningVariable warnings -WarningAction SilentlyContinue)
    Assert-MixedItems $items @('m1', 'm2', 'm3')
    Assert-Mixed ($handler.RequestCount -eq 2 -and $warnings.Count -eq 0) 'Aggregate All must enumerate both genuine typed pages without warning.'
    $requests = @($handler.Requests.ToArray())
    Assert-Mixed (([uri]$requests[0].Url).AbsolutePath -eq $aggregatePath) 'Model/OData selected a resource route.'
    $query = [System.Web.HttpUtility]::ParseQueryString(([uri]$requests[0].Url).Query)
    $expectedQuery = @{
        model = 'A'; '$top' = '7'; '$skip' = '2'; '$search' = 'needle'; '$filter' = 'id ne null'
        '$count' = 'true'; '$orderby' = 'createdDateTime desc'; '$select' = 'id,body'; '$expand' = 'replies'
    }
    foreach ($name in $expectedQuery.Keys) {
        Assert-Mixed ($query[$name] -eq $expectedQuery[$name]) "The first aggregate request lost query $name ($($query[$name]))."
    }
    Assert-Mixed ($requests[1].Url -eq [MixedReadHandler]::NextLink) 'Continuation must use the exact nextLink without re-applying Model/OData.'
    foreach ($request in $requests) {
        Assert-Mixed ($request.Headers['x-mixed-test'] -eq 'aggregate-pages') 'Generic headers must be re-applied to every aggregate page.'
    }

    foreach ($selector in $null, 'Published', 'Chat') {
        $handler.Reset()
        $arguments = @{ UserId = 'user-id'; ChatId = 'chat-id'; All = $true; Headers = @{ 'x-mixed-test' = 'chat-pages' } }
        if ($selector) { $arguments.Route = $selector }
        $items = @(Get-MgAllUserChatMessage @arguments)
        Assert-MixedItems $items @('m1', 'm2', 'm3')
        $requests = @($handler.Requests.ToArray())
        Assert-Mixed ($requests.Count -eq 2 -and ([uri]$requests[0].Url).AbsolutePath -eq $chatPath) 'ChatId must choose the unique Chat list, never silently drop the bound id.'
        Assert-Mixed ($requests[1].Url -eq [MixedReadHandler]::NextLink) 'Resource list must also follow nextLink.'
        Assert-Mixed ($requests[1].Headers['x-mixed-test'] -eq 'chat-pages') 'Resource-list continuation lost generic headers.'
        $handler.Reset()
        $arguments.Remove('All')
        $arguments.ChatMessageId = 'message-id'
        $arguments.Property = @('id', 'body')
        $arguments.Expand = @('replies')
        $items = @(Get-MgAllUserChatMessage @arguments)
        Assert-MixedItems $items @('message-id')
        Assert-MixedPath $itemPath
        Assert-Mixed ($handler.RequestCount -eq 1) 'Chat item must issue exactly one typed item request.'
        $query = [System.Web.HttpUtility]::ParseQueryString(([uri]$handler.LastRequest.Url).Query)
        Assert-Mixed ($query['$select'] -eq 'id,body') 'The item request dropped its actual $select option.'
        Assert-Mixed ($query['$expand'] -eq 'replies') 'The item request dropped its actual $expand option.'
    }

    $handler.Reset()
    $chatQueryArguments = @{} + $queryArguments
    $chatQueryArguments.Remove('Model')
    $chatQueryArguments.ChatId = 'chat-id'
    $items = @(Get-MgAllUserChatMessage @chatQueryArguments)
    Assert-MixedItems $items @('m1', 'm2', 'm3')
    $requests = @($handler.Requests.ToArray())
    Assert-Mixed (([uri]$requests[0].Url).AbsolutePath -eq $chatPath) 'List OData must retain the bound ChatId.'
    $query = [System.Web.HttpUtility]::ParseQueryString(([uri]$requests[0].Url).Query)
    foreach ($name in $expectedQuery.Keys | Where-Object { $_ -ne 'model' }) {
        Assert-Mixed ($query[$name] -eq $expectedQuery[$name]) "The resource list dropped query $name."
    }
    Assert-Mixed ($null -eq $query['model']) 'The resource list invented an aggregate-only Model query.'

    foreach ($chat in $false, $true) {
        foreach ($top in 1, 2, 3) {
            $handler.Reset()
            $arguments = @{ UserId = 'user-id'; All = $true; Top = $top }
            if ($chat) { $arguments.ChatId = 'chat-id' } else { $arguments.Model = 'B' }
            $items = @(Get-MgAllUserChatMessage @arguments)
            $expectedCount = if ($top -le 2) { 2 } else { 3 }
            $expectedRequests = if ($top -le 2) { 1 } else { 2 }
            Assert-Mixed ($items.Count -eq $expectedCount -and $handler.RequestCount -eq $expectedRequests) `
                'All/Top must preserve the existing total-cap, whole-final-page behavior on both list workers.'
        }
    }

    Assert-MixedRejected { Get-MgAllUserChatMessage -UserId user-id -Route Aggregate -ChatId chat-id }
    Assert-MixedRejected { Get-MgAllUserChatMessage -UserId user-id -Route Aggregate -ChatMessageId message-id }
    Assert-MixedRejected { Get-MgAllUserChatMessage -UserId user-id -Route Chat }
    Assert-MixedRejected { Get-MgAllUserChatMessage -UserId user-id -Route Chat -ChatId chat-id -Model A }
    Assert-MixedRejected { Get-MgAllUserChatMessage -UserId user-id -ChatId chat-id -Model A }
    Assert-MixedRejected { Get-MgAllUserChatMessage -UserId user-id -ChatMessageId message-id }
    Assert-MixedRejected { Get-MgAllUserChatMessage -UserId user-id -ChatId chat-id -ChatMessageId message-id -All }
    Assert-MixedRejected { Get-MgAllUserChatMessage -UserId user-id -ChatId chat-id -ChatMessageId message-id -Top 2 }
    Assert-MixedRejected { Get-MgAllUserChatMessage -UserId user-id -ChatId chat-id -ChatMessageId message-id -Model A }
    Assert-MixedRejected { Get-MgAllUserChatMessage -UserId user-id -Route Unknown } 'ParameterArgumentValidationError'
    Assert-MixedRejected { Get-MgAllUserChatMessage -ChatId chat-id } 'MissingMandatoryParameter'

    $handler.Mode = 'Error'
    foreach ($arguments in @(
        @{ UserId = 'user-id'; Model = 'A' },
        @{ UserId = 'user-id'; ChatId = 'chat-id' },
        @{ UserId = 'user-id'; ChatId = 'chat-id'; ChatMessageId = 'message-id' }
    )) {
        $failure = $null
        try { Get-MgAllUserChatMessage @arguments }
        catch { $failure = $_ }
        Assert-Mixed ($null -ne $failure -and $failure.FullyQualifiedErrorId -like 'GraphRequestFailed,*') `
            'HTTP failures must retain the production GraphRequestFailed surface through the dispatcher.'
    }

    foreach ($chat in $false, $true) {
        $handler.Reset()
        $handler.Mode = 'CancelContinuation'
        $pipeline = [PowerShell]::Create()
        $null = $pipeline.AddCommand('Import-Module').AddParameter('Name', $FixtureAssembly).Invoke()
        Assert-Mixed (-not $pipeline.HadErrors) 'The cancellation runspace could not load the genuine typed fixture.'
        $pipeline.Commands.Clear()
        $null = $pipeline.AddCommand('Get-MgAllUserChatMessage').AddParameter('UserId', 'user-id').AddParameter('All')
        if ($chat) { $null = $pipeline.AddParameter('ChatId', 'chat-id') }
        else { $null = $pipeline.AddParameter('Model', 'A') }
        $invocation = $pipeline.BeginInvoke()
        Assert-Mixed ($handler.Started.Wait(10000)) 'The actual list worker did not reach the cancellation-only continuation.'
        $stop = $pipeline.BeginStop($null, $null)
        Assert-Mixed ($stop.AsyncWaitHandle.WaitOne(10000)) 'Stopping the public mixed-read pipeline did not complete promptly.'
        $pipeline.EndStop($stop)
        Assert-Mixed ($handler.Cancelled.Wait(10000)) 'The typed paged worker failed to pass StoppingToken into the continuation request.'
        try { $null = $pipeline.EndInvoke($invocation) } catch {
            Assert-Mixed ($_.Exception.GetBaseException() -is [Management.Automation.PipelineStoppedException]) 'Cancellation became an unrelated Graph failure.'
        }
        Assert-Mixed (@($pipeline.Streams.Error | Where-Object FullyQualifiedErrorId -like 'GraphRequestFailed,*').Count -eq 0) 'Cancellation must not be converted to GraphRequestFailed.'
        Assert-Mixed ($pipeline.InvocationStateInfo.State -eq 'Stopped') 'The cancelled mixed-read pipeline did not remain stopped.'
        $pipeline.Dispose()
        $pipeline = $null
    }
    Write-Host 'PASS: genuine three-operation Teams mixed-read fixture: typed Model/OData RequestInformation, default/explicit/inferred routes, strict rejection before workers, paging/Top/headers, metadata, HTTP errors and continuation cancellation; zero network.'
}
finally {
    if ($pipeline) { $pipeline.Dispose() }
    [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.GraphHttpClient = $oldSession
    $http.Dispose()
    Remove-Module $module -ErrorAction SilentlyContinue
}

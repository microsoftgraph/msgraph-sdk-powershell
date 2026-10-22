<#
.SYNOPSIS
Validates six real compiled recording GETs with an in-memory HTTP transport.

.DESCRIPTION
The fixture must contain the reviewed communications/user recording binary, JSON list
and JSON item operations. No Graph connection, token or network is used. The public
GraphSession.GraphHttpClient slot is assigned a mock-only HttpMessageHandler. Binary
output files are retained under FixtureRoot for inspection.

.EXAMPLE
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperMixedMediaReads.ps1 -FixtureAssembly <fixture-dll>
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string]$FixtureAssembly,
    [string]$FixtureRoot
)
$ErrorActionPreference = 'Stop'
$FixtureAssembly = (Resolve-Path $FixtureAssembly).Path
$assemblyRoot = Split-Path $FixtureAssembly -Parent
if (-not $FixtureRoot) { $FixtureRoot = Join-Path $assemblyRoot 'MixedMediaRuntimeOutput' }
$null = New-Item $FixtureRoot -ItemType Directory -Force
$module = Import-Module $FixtureAssembly -PassThru -ErrorAction Stop
Add-Type -Path (Join-Path $assemblyRoot 'Microsoft.Graph.Authentication.Core.dll')
Add-Type -Path (Join-Path $assemblyRoot 'Microsoft.Graph.Authentication.dll')

Add-Type -TypeDefinition @'
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public sealed class MixedMediaRequest
{
    public string Method;
    public string Url;
    public Dictionary<string, string> Headers;
    public MixedMediaRequest(HttpRequestMessage request)
    {
        Method = request.Method.Method;
        Url = request.RequestUri.AbsoluteUri;
        Headers = request.Headers.ToDictionary(header => header.Key,
            header => string.Join(",", header.Value), StringComparer.OrdinalIgnoreCase);
    }
}

public sealed class MixedMediaStream : Stream
{
    private readonly MemoryStream inner;
    public bool Disposed;
    public MixedMediaStream(byte[] bytes) { inner = new MemoryStream(bytes, false); }
    public override bool CanRead { get { return inner.CanRead; } }
    public override bool CanSeek { get { return inner.CanSeek; } }
    public override bool CanWrite { get { return false; } }
    public override long Length { get { return inner.Length; } }
    public override long Position { get { return inner.Position; } set { inner.Position = value; } }
    public override int Read(byte[] buffer, int offset, int count) { return inner.Read(buffer, offset, count); }
    public override long Seek(long offset, SeekOrigin origin) { return inner.Seek(offset, origin); }
    public override void Flush() { inner.Flush(); }
    public override void SetLength(long value) { throw new NotSupportedException(); }
    public override void Write(byte[] buffer, int offset, int count) { throw new NotSupportedException(); }
    protected override void Dispose(bool disposing)
    {
        Disposed = true;
        if (disposing) inner.Dispose();
        base.Dispose(disposing);
    }
}

public sealed class MixedMediaHandler : HttpMessageHandler
{
    public static readonly byte[] Bytes = new byte[] { 0, 1, 2, 127, 128, 254, 255 };
    public readonly ConcurrentQueue<MixedMediaRequest> Requests = new ConcurrentQueue<MixedMediaRequest>();
    public readonly ConcurrentQueue<MixedMediaStream> Streams = new ConcurrentQueue<MixedMediaStream>();
    public readonly ManualResetEventSlim Started = new ManualResetEventSlim(false);
    public readonly ManualResetEventSlim Cancelled = new ManualResetEventSlim(false);
    public string Mode = "Auto";
    public int RequestCount { get { return Requests.Count; } }
    public MixedMediaRequest LastRequest { get { return Requests.Last(); } }
    public MixedMediaStream LastStream { get { return Streams.Last(); } }
    private static HttpResponseMessage Json(HttpStatusCode status, string body)
    {
        return new HttpResponseMessage(status) { Content = new StringContent(body, Encoding.UTF8, "application/json") };
    }
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
    {
        Requests.Enqueue(new MixedMediaRequest(request));
        if (request.Method != HttpMethod.Get)
            throw new InvalidOperationException("The exact-six fixture must only issue GET requests.");
        if (Mode == "Cancel")
        {
            Started.Set();
            try { await Task.Delay(Timeout.Infinite, token).ConfigureAwait(false); }
            catch (OperationCanceledException) { Cancelled.Set(); throw; }
            throw new InvalidOperationException("The cancellation-only request must never complete.");
        }
        if (Mode == "Error")
            return Json(HttpStatusCode.BadRequest,
                "{\"error\":{\"code\":\"MixedMediaFixtureFailure\",\"message\":\"synthetic mixed media failure\"}}");
        var path = request.RequestUri.AbsolutePath;
        if (path.EndsWith("/recording", StringComparison.Ordinal))
        {
            var stream = new MixedMediaStream(Bytes);
            Streams.Enqueue(stream);
            var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StreamContent(stream) };
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
            return response;
        }
        if (path.EndsWith("/recordings", StringComparison.Ordinal))
        {
            if (request.RequestUri.Query.Contains("page2"))
                return Json(HttpStatusCode.OK, "{\"value\":[{\"id\":\"r3\"}]}");
            var next = "https://graph.microsoft.com" + path + "?$skiptoken=page2";
            return Json(HttpStatusCode.OK,
                "{\"value\":[{\"id\":\"r1\"},{\"id\":\"r2\"}],\"@odata.nextLink\":\"" + next + "\"}");
        }
        if (path.EndsWith("/recordings/recording-id", StringComparison.Ordinal))
            return Json(HttpStatusCode.OK, "{\"id\":\"recording-id\",\"recordingContentUrl\":\"https://example.invalid/content\"}");
        throw new InvalidOperationException("Unreviewed mock request URL: " + request.RequestUri);
    }
}
'@

$script:mixedAssertions = 0
function Assert-Mixed([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
    $script:mixedAssertions++
}

function Get-MixedQuery([string]$Url) {
    $result = @{}
    foreach ($part in ([Uri]$Url).Query.TrimStart('?') -split '&') {
        if (-not $part) { continue }
        $pair = $part -split '=', 2
        $result[[Uri]::UnescapeDataString($pair[0])] = $(if ($pair.Count -eq 2) { [Uri]::UnescapeDataString($pair[1]) } else { '' })
    }
    $result
}

function Assert-MixedRejected([string]$Command, [hashtable]$Parameters, [string]$ErrorId) {
    $before = $handler.RequestCount
    $failure = $null
    try { $null = & $Command @Parameters }
    catch { $failure = $_ }
    Assert-Mixed ($null -ne $failure -and $failure.FullyQualifiedErrorId -like "$ErrorId,*") `
        "Expected $ErrorId for $Command, got: $failure"
    Assert-Mixed ($handler.RequestCount -eq $before) 'An invalid selection reached a worker HTTP request.'
}

function Assert-MixedBinary($Output, [string]$Url) {
    Assert-Mixed ($Output.Count -eq 1 -and $Output[0] -is [byte[]]) 'Binary without OutFile must emit one byte array.'
    Assert-Mixed ([Convert]::ToBase64String($Output[0]) -eq $expectedBytes) 'Binary output changed the payload.'
    Assert-Mixed ($handler.LastRequest.Url -eq $Url) 'Binary route selected the wrong actual URL.'
    Assert-Mixed $handler.LastStream.Disposed 'Binary output leaked the response stream.'
}

function Assert-MixedEntities($Output, [string[]]$Ids) {
    Assert-Mixed ($Output.Count -eq $Ids.Count) 'JSON output has the wrong entity count.'
    Assert-Mixed (($Output.Id -join ',') -eq ($Ids -join ',')) 'JSON entity ids changed or list/item selection is wrong.'
    foreach ($entity in $Output) {
        Assert-Mixed ($entity.GetType().FullName -eq 'Microsoft.Graph.PowerShell.MixedMedia.Client.Models.CallRecording') `
            'JSON routes must emit real typed CallRecording entities, not bytes or raw response wrappers.'
    }
}

$handler = [MixedMediaHandler]::new()
$http = [Net.Http.HttpClient]::new($handler)
$oldHttp = $null
$pipeline = $null
try {
    if ([Microsoft.Graph.PowerShell.Authentication.GraphSession]::Exists) {
        $oldHttp = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.GraphHttpClient
    }
    else {
        [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Initialize(
            [Func[Microsoft.Graph.PowerShell.Authentication.GraphSession]]{ [Microsoft.Graph.PowerShell.Authentication.GraphSession]::new() })
    }
    [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.GraphHttpClient = $http
    Assert-Mixed ([object]::ReferenceEquals(
        [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient(), $http)) `
        'The mock-only GraphSession client must be installed before invoking a worker.'
    $expectedBytes = [Convert]::ToBase64String([MixedMediaHandler]::Bytes)
    $seenRoutes = [Collections.Generic.HashSet[string]]::new([StringComparer]::Ordinal)
    $groups = @(
        @{ Command = 'Get-MgCommunicationOnlineMeetingRecording'; Prefix = '/communications/onlineMeetings/meeting-id';
            Template = '/communications/onlineMeetings/{onlineMeeting-id}'; Parameters = @{ OnlineMeetingId = 'meeting-id' }; Tag = 'communications' },
        @{ Command = 'Get-MgUserOnlineMeetingRecording'; Prefix = '/users/user-id/onlineMeetings/meeting-id';
            Template = '/users/{user-id}/onlineMeetings/{onlineMeeting-id}'; Parameters = @{ UserId = 'user-id'; OnlineMeetingId = 'meeting-id' }; Tag = 'user' }
    )
    foreach ($group in $groups) {
        $command = Get-Command $group.Command -Module $module.Name
        $base = $group.Parameters
        $binaryUrl = 'https://graph.microsoft.com/beta' + $group.Prefix + '/recording'
        $listUrl = 'https://graph.microsoft.com/beta' + $group.Prefix + '/recordings'
        $itemUrl = $listUrl + '/recording-id'
        $routeAttributes = @($command.Parameters['Route'].Attributes | Where-Object { $_ -is [System.Management.Automation.ParameterAttribute] })
        Assert-Mixed ($routeAttributes.Count -gt 0 -and @($routeAttributes | Where-Object { -not $_.Mandatory }).Count -eq 0) 'Route must be genuinely mandatory in PowerShell.'
        $validate = $command.Parameters['Route'].Attributes | Where-Object { $_ -is [System.Management.Automation.ValidateSetAttribute] }
        Assert-Mixed (($validate.ValidValues | Sort-Object) -join ',' -eq 'Binary,Recordings') 'Route must accept only Binary/Recordings, never Published.'
        Assert-Mixed ($command.Parameters['OutFile'].ParameterType -eq [string]) 'The binary OutFile contract must remain a string.'
        Assert-Mixed (@($command.Parameters['OutFile'].Attributes | Where-Object { $_ -is [System.Management.Automation.ParameterAttribute] -and $_.Mandatory }).Count -eq 0) 'OutFile must remain optional.'
        Assert-Mixed ($command.Parameters.ContainsKey('Headers') -and $command.Parameters.ContainsKey('AccessToken')) 'Authentication/header parameters must be inherited unchanged.'
        Assert-Mixed ($command.Parameters.ContainsKey('CallRecordingId')) 'The actual item path id must remain CallRecordingId.'
        $types = @($command.OutputType | ForEach-Object Name)
        Assert-Mixed ($types -contains 'System.Byte[]' -and $types -contains 'Microsoft.Graph.PowerShell.MixedMedia.Client.Models.CallRecording') 'The output-type union must accurately include bytes and CallRecording.'
        Assert-Mixed (@($types | Where-Object { $_ -like '*Stream*' -or $_ -like '*CollectionResponse*' }).Count -eq 0) 'Public output metadata must not advertise streams or response wrappers.'
        $routes = @($command.ImplementingType.GetCustomAttributes([Microsoft.Graph.Wrapper.Runtime.GraphRouteAttribute], $false))
        Assert-Mixed ($routes.Count -eq 3) 'Each public dispatcher must expose exactly three real GraphRoute records.'
        foreach ($suffix in '/recording', '/recordings', '/recordings/{callRecording-id}') {
            $path = $group.Template + $suffix
            Assert-Mixed (@($routes | Where-Object { $_.Method -eq 'GET' -and $_.Path -ceq $path }).Count -eq 1) 'GraphRoute metadata omitted or duplicated a surviving exact GET.'
            Assert-Mixed ($seenRoutes.Add($path)) 'A GraphRoute path appeared in both groups.'
        }

        Assert-MixedRejected $group.Command (@{} + $base) 'MissingMandatoryParameter'
        Assert-MixedRejected $group.Command (@{ Route = 'Published' } + $base) 'ParameterArgumentValidationError'
        foreach ($extra in @(
            @{ Top = 1 }, @{ All = $true }, @{ All = $false }, @{ Property = @('id') },
            @{ ExpandProperty = @('meetingOrganizer') }, @{ CallRecordingId = 'recording-id' },
            @{ Filter = "id eq 'r1'" }, @{ Count = $false }
        )) {
            Assert-MixedRejected $group.Command (@{ Route = 'Binary' } + $base + $extra) 'InvalidGraphRouteParameters'
        }
        Assert-MixedRejected $group.Command (@{ Route = 'Recordings'; OutFile = (Join-Path $FixtureRoot 'forbidden.bin') } + $base) 'InvalidGraphRouteParameters'
        Assert-MixedRejected $group.Command (@{ Route = 'Recordings'; CallRecordingId = 'recording-id'; All = $true } + $base) 'InvalidGraphRouteParameters'
        Assert-MixedRejected $group.Command (@{ Route = 'Recordings'; CallRecordingId = 'recording-id'; Top = 1 } + $base) 'InvalidGraphRouteParameters'

        $binaryParameters = @{ Route = 'Binary'; Headers = @{ 'x-mixed-media' = $group.Tag } } + $base
        $bytes = @(& $group.Command @binaryParameters)
        Assert-MixedBinary $bytes $binaryUrl
        Assert-Mixed ($handler.LastRequest.Headers['x-mixed-media'] -eq $group.Tag) 'Binary GET dropped generic headers.'
        $file = Join-Path $FixtureRoot ($group.Tag + '.bin')
        $output = @(& $group.Command @binaryParameters -OutFile $file)
        Assert-Mixed ($output.Count -eq 0) 'Binary OutFile must not also emit bytes.'
        Assert-Mixed ([Convert]::ToBase64String([IO.File]::ReadAllBytes($file)) -eq $expectedBytes) 'OutFile changed the recording bytes.'
        Assert-Mixed ($handler.LastRequest.Url -eq $binaryUrl -and $handler.LastStream.Disposed) 'OutFile changed route selection or leaked the response stream.'
        $failure = $null
        try { $null = & $group.Command @binaryParameters -OutFile (Join-Path $FixtureRoot 'missing\recording.bin') }
        catch { $failure = $_ }
        Assert-Mixed ($null -ne $failure -and $handler.LastStream.Disposed) 'A failed binary file write must report an error and dispose the response stream.'

        $before = $handler.RequestCount
        $warnings = @()
        $listParameters = @{ Route = 'Recordings'; Headers = @{ 'x-mixed-media' = $group.Tag } } + $base
        $page = @(& $group.Command @listParameters -WarningVariable warnings -WarningAction SilentlyContinue)
        Assert-MixedEntities $page @('r1', 'r2')
        Assert-Mixed ($handler.RequestCount -eq $before + 1 -and $handler.LastRequest.Url -eq $listUrl) 'Recordings without an id must choose the JSON list.'
        Assert-Mixed ($warnings.Count -eq 1 -and "$($warnings[0])" -like '*Use -All*') 'An unpaged list must forward exactly one truncation warning.'

        $before = $handler.RequestCount
        $warnings = @()
        $all = @(& $group.Command @listParameters -All -Top 10 -Skip 2 -Search recording -Filter "id ne 'none'" `
            -Count -Sort 'id desc' -Property id,recordingContentUrl -ExpandProperty meetingOrganizer `
            -WarningVariable warnings -WarningAction SilentlyContinue)
        Assert-MixedEntities $all @('r1', 'r2', 'r3')
        Assert-Mixed ($handler.RequestCount -eq $before + 2 -and $warnings.Count -eq 0) 'All must page the genuine JSON collection without a truncation warning.'
        $requests = $handler.Requests.ToArray()
        $first = $requests[$before]
        $query = Get-MixedQuery $first.Url
        Assert-Mixed ($query.Count -eq 8) 'The actual list request must bind all eight declared OData options.'
        foreach ($entry in @{
            '$top' = '10'; '$skip' = '2'; '$search' = 'recording'; '$filter' = "id ne 'none'";
            '$count' = 'true'; '$orderby' = 'id desc'; '$select' = 'id,recordingContentUrl'; '$expand' = 'meetingOrganizer'
        }.GetEnumerator()) {
            Assert-Mixed ($query[$entry.Key] -ceq $entry.Value) "Typed query binding changed $($entry.Key)."
        }
        Assert-Mixed (([Uri]$handler.LastRequest.Url).AbsolutePath -eq ([Uri]$listUrl).AbsolutePath -and (Get-MixedQuery $handler.LastRequest.Url)['$skiptoken'] -eq 'page2') 'Paging did not use the actual JSON nextLink.'
        Assert-Mixed ($handler.LastRequest.Headers['x-mixed-media'] -eq $group.Tag) 'Paging dropped generic headers.'

        $before = $handler.RequestCount
        $capped = @(& $group.Command @listParameters -All -Top 2)
        Assert-MixedEntities $capped @('r1', 'r2')
        Assert-Mixed ($handler.RequestCount -eq $before + 1) 'All/Top must preserve the existing whole-page total cap.'
        $before = $handler.RequestCount
        $itemParameters = @{ Route = 'Recordings'; CallRecordingId = 'recording-id'; Property = @('id'); ExpandProperty = @('meetingOrganizer'); Headers = @{ 'x-mixed-media' = $group.Tag } } + $base
        $item = @(& $group.Command @itemParameters)
        Assert-MixedEntities $item @('recording-id')
        Assert-Mixed ($handler.RequestCount -eq $before + 1 -and ([Uri]$handler.LastRequest.Url).GetLeftPart([UriPartial]::Path) -eq $itemUrl) 'Recordings plus id must select the real JSON item builder.'
        $query = Get-MixedQuery $handler.LastRequest.Url
        Assert-Mixed ($query.Count -eq 2 -and $query['$select'] -eq 'id' -and $query['$expand'] -eq 'meetingOrganizer') 'The item route lost its actual select/expand query contract.'
        Assert-Mixed ($handler.LastRequest.Headers['x-mixed-media'] -eq $group.Tag) 'The JSON item dropped generic headers.'

        $handler.Mode = 'Error'
        foreach ($parameters in @($binaryParameters, $listParameters, $itemParameters)) {
            $failure = $null
            try { $null = & $group.Command @parameters }
            catch { $failure = $_ }
            Assert-Mixed ($null -ne $failure -and $failure.FullyQualifiedErrorId -like 'GraphRequestFailed,*') 'A typed HTTP failure lost its worker identity through dispatch.'
            Assert-Mixed ($failure.Exception.Message -match 'synthetic mixed media failure') 'Typed Kiota error content was not forwarded.'
            Assert-Mixed ($failure.TargetObject -eq $(if ($parameters.ContainsKey('CallRecordingId')) { 'recording-id' } else { 'meeting-id' })) 'HTTP failure lost the selected worker target.'
        }
        $handler.Mode = 'Cancel'
        $handler.Started.Reset()
        $handler.Cancelled.Reset()
        $pipeline = [PowerShell]::Create()
        $null = $pipeline.AddCommand('Import-Module').AddParameter('Name', $FixtureAssembly).Invoke()
        Assert-Mixed (-not $pipeline.HadErrors) 'The cancellation runspace could not import the real fixture.'
        $pipeline.Commands.Clear()
        $null = $pipeline.AddCommand($group.Command).AddParameter('Route', 'Binary')
        foreach ($entry in $base.GetEnumerator()) { $null = $pipeline.AddParameter($entry.Key, $entry.Value) }
        $invocation = $pipeline.BeginInvoke()
        Assert-Mixed ($handler.Started.Wait(10000)) 'The actual binary worker did not reach the mock HTTP handler.'
        $stop = $pipeline.BeginStop($null, $null)
        Assert-Mixed ($stop.AsyncWaitHandle.WaitOne(10000)) 'Stopping the public mixed-media pipeline did not finish promptly.'
        $pipeline.EndStop($stop)
        Assert-Mixed ($handler.Cancelled.Wait(10000)) 'The actual binary worker did not pass its stopping token through Kiota to HTTP.'
        try { $null = $pipeline.EndInvoke($invocation) } catch {
            Assert-Mixed ($_.Exception.GetBaseException() -is [System.Management.Automation.PipelineStoppedException]) 'Cancellation was converted into an unrelated error.'
        }
        Assert-Mixed (@($pipeline.Streams.Error | Where-Object FullyQualifiedErrorId -like 'GraphRequestFailed,*').Count -eq 0) 'Cancellation must not become GraphRequestFailed.'
        Assert-Mixed ($pipeline.InvocationStateInfo.State -eq 'Stopped') 'The cancelled public pipeline did not remain stopped.'
        $pipeline.Dispose()
        $pipeline = $null
        $handler.Mode = 'Auto'
    }
    Assert-Mixed ($seenRoutes.Count -eq 6) 'The actual metadata union must contain exactly six unique surviving resource GETs.'
    Assert-Mixed (-not (Test-Path (Join-Path $FixtureRoot 'forbidden.bin'))) 'An incompatible route created a binary output file.'
    $report = [ordered]@{ Assertions = $script:mixedAssertions; Routes = $seenRoutes.Count; Requests = $handler.RequestCount; BinaryFiles = @('communications.bin', 'user.bin'); Network = $false }
    $report | ConvertTo-Json | Set-Content (Join-Path $FixtureRoot 'results.json')
    Write-Host "PASS: $($script:mixedAssertions) assertions; six actual mixed-media GETs, required explicit Route, bytes/OutFile/disposal, typed JSON list/item/paging and eight query options, metadata union, rejected combinations, HTTP errors and both binary cancellations; zero network."
}
finally {
    if ($pipeline) { $pipeline.Dispose() }
    [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.GraphHttpClient = $oldHttp
    $http.Dispose()
    Remove-Module $module -ErrorAction SilentlyContinue
}

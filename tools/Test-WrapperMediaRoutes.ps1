<#
.SYNOPSIS
Runs real compiled media dispatchers and workers against an in-memory HTTP transport.

.DESCRIPTION
Requires a typed fixture containing the exact beta Users singleton/photo-id GET and
DELETE /$value operations. No Connect-MgGraph, access token, live HTTP or module build
is used. GraphSession.GraphHttpClient is assigned a mock-only HttpMessageHandler.

.EXAMPLE
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperMediaRoutes.ps1 -FixtureAssembly <fixture-dll>
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string]$FixtureAssembly,
    [string]$FixtureRoot
)
$ErrorActionPreference = 'Stop'
$FixtureAssembly = (Resolve-Path $FixtureAssembly).Path
if (-not $FixtureRoot) {
    $FixtureRoot = Join-Path (Split-Path $PSScriptRoot -Parent) ".media-runtime-tests-$PID-$([guid]::NewGuid().ToString('N'))"
}
$null = New-Item $FixtureRoot -ItemType Directory -Force
$module = Import-Module $FixtureAssembly -PassThru -ErrorAction Stop
$assemblyRoot = Split-Path $FixtureAssembly -Parent
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
using System.Threading;
using System.Threading.Tasks;

public sealed class MediaRouteRequest
{
    public string Method;
    public string Url;
    public Dictionary<string, string> Headers;
    public MediaRouteRequest(HttpRequestMessage request)
    {
        Method = request.Method.Method;
        Url = request.RequestUri.AbsoluteUri;
        Headers = request.Headers.ToDictionary(header => header.Key,
            header => string.Join(",", header.Value), StringComparer.OrdinalIgnoreCase);
    }
}

public sealed class MediaRouteStream : Stream
{
    private readonly MemoryStream inner;
    public bool Disposed;
    public MediaRouteStream(byte[] bytes) { inner = new MemoryStream(bytes, false); }
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

public sealed class MediaRouteHandler : HttpMessageHandler
{
    public static readonly byte[] Bytes = new byte[] { 0, 1, 2, 127, 128, 254, 255 };
    public readonly ConcurrentQueue<MediaRouteRequest> Requests = new ConcurrentQueue<MediaRouteRequest>();
    public readonly ConcurrentQueue<MediaRouteStream> Streams = new ConcurrentQueue<MediaRouteStream>();
    public readonly ManualResetEventSlim Started = new ManualResetEventSlim(false);
    public readonly ManualResetEventSlim Cancelled = new ManualResetEventSlim(false);
    public string Mode = "Bytes";
    public int RequestCount { get { return Requests.Count; } }
    public MediaRouteRequest LastRequest { get { return Requests.Last(); } }
    public MediaRouteStream LastStream { get { return Streams.Last(); } }
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
    {
        Requests.Enqueue(new MediaRouteRequest(request));
        if (Mode == "Cancel")
        {
            Started.Set();
            try { await Task.Delay(Timeout.Infinite, token).ConfigureAwait(false); }
            catch (OperationCanceledException) { Cancelled.Set(); throw; }
            throw new InvalidOperationException("The cancellation-only request must never complete normally.");
        }
        if (Mode == "Error")
        {
            var error = new HttpResponseMessage(HttpStatusCode.BadRequest);
            error.Content = new StringContent("{\"error\":{\"code\":\"MediaFixtureFailure\",\"message\":\"synthetic media failure\"}}",
                System.Text.Encoding.UTF8, "application/json");
            return error;
        }
        if (request.Method == HttpMethod.Delete)
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        var stream = new MediaRouteStream(Bytes);
        Streams.Enqueue(stream);
        var response = new HttpResponseMessage(HttpStatusCode.OK);
        response.Content = new StreamContent(stream);
        response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
        return response;
    }
}
'@

function Assert-Media([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

function Assert-MediaRejected([scriptblock]$Invocation, [string]$ErrorId) {
    $before = $handler.RequestCount
    $failure = $null
    try { $null = & $Invocation }
    catch { $failure = $_ }
    Assert-Media ($null -ne $failure -and $failure.FullyQualifiedErrorId -like "$ErrorId,*") `
        "Expected real binder rejection $ErrorId, got: $failure"
    Assert-Media ($handler.RequestCount -eq $before) 'A rejected binding reached the mock transport.'
}

function Assert-MediaBytes($Output, [string]$Url) {
    Assert-Media ($Output.Count -eq 1 -and $Output[0] -is [byte[]]) 'Unbound OutFile must emit exactly one byte array.'
    Assert-Media ([Convert]::ToBase64String($Output[0]) -eq $expected) 'The emitted byte array changed the binary payload.'
    Assert-Media ($handler.LastRequest.Url -eq $Url -and $handler.LastRequest.Method -eq 'GET') 'The media GET selected the wrong URL or method.'
    Assert-Media $handler.LastStream.Disposed 'The response stream was not disposed after byte output.'
}

$handler = [MediaRouteHandler]::new()
$http = [Net.Http.HttpClient]::new($handler)
$oldSession = $null
$pipeline = $null
try {
    # This public session slot is the same transport seam the authentication module uses.
    if ([Microsoft.Graph.PowerShell.Authentication.GraphSession]::Exists) {
        $oldSession = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.GraphHttpClient
    }
    else {
        [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Initialize(
            [Func[Microsoft.Graph.PowerShell.Authentication.GraphSession]]{ [Microsoft.Graph.PowerShell.Authentication.GraphSession]::new() })
    }
    [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.GraphHttpClient = $http
    Assert-Media ([object]::ReferenceEquals(
        [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient(), $http)) `
        'The transport seam must be the mock client before invoking any worker.'

    $get = Get-Command Get-MgUserPhotoContent -Module $module.Name
    $delete = Get-Command Remove-MgUserPhotoContent -Module $module.Name
    Assert-Media ($get.DefaultParameterSet -eq 'SingletonGet') 'Singleton GET must remain the published default.'
    Assert-Media ($delete.DefaultParameterSet -eq 'SingletonInvoke') 'Singleton DELETE must remain the published default.'
    Assert-Media ($get.ParameterSets.Count -eq 2 -and $delete.ParameterSets.Count -eq 2) 'Each media command requires exactly two parameter sets.'
    foreach ($set in $get.ParameterSets) {
        Assert-Media (-not ($set.Parameters | Where-Object Name -eq 'OutFile').IsMandatory) 'OutFile must remain optional on both GET routes.'
    }
    foreach ($set in @($get.ParameterSets) + @($delete.ParameterSets)) {
        Assert-Media (($set.Parameters | Where-Object Name -eq 'UserId').IsMandatory) 'UserId must remain mandatory on every media route.'
        if ($set.Name -like 'Photos*') {
            Assert-Media (($set.Parameters | Where-Object Name -eq 'ProfilePhotoId').IsMandatory) 'The Photos route must require its profile-photo id.'
        }
        else {
            Assert-Media ($set.Parameters.Name -notcontains 'ProfilePhotoId') 'Singleton routes must not accept a profile-photo id.'
        }
    }
    Assert-Media (-not $delete.Parameters.ContainsKey('OutFile')) 'DELETE must not expose OutFile.'
    Assert-Media (-not $get.Parameters.ContainsKey('IfMatch')) 'GET must not invent a declared If-Match parameter.'
    Assert-Media (-not $get.Parameters.ContainsKey('Route') -and -not $delete.Parameters.ContainsKey('Route')) 'Media routes must not acquire a selector.'
    Assert-Media (($get.ParameterSets | Where-Object Name -eq 'PhotosGet').Parameters.Name -contains 'ProfilePhotoId') 'Photos GET lost its route discriminator.'
    Assert-Media (($get.ParameterSets | Where-Object Name -eq 'SingletonGet').Parameters.Name -notcontains 'ProfilePhotoId') 'Singleton GET must not accept a photo id.'

    $expected = [Convert]::ToBase64String([MediaRouteHandler]::Bytes)
    $singletonUrl = 'https://graph.microsoft.com/beta/users/user-id/photo/$value'
    $photosUrl = 'https://graph.microsoft.com/beta/users/user-id/photos/size-id/$value'
    $bytes = @(Get-MgUserPhotoContent -UserId user-id -Headers @{ 'x-media-test' = 'singleton' })
    Assert-MediaBytes $bytes $singletonUrl
    Assert-Media ($handler.LastRequest.Headers['x-media-test'] -eq 'singleton') 'The singleton GET dropped generic headers.'
    $bytes = @(Get-MgUserPhotoContent -UserId user-id -ProfilePhotoId size-id -Headers @{ 'x-media-test' = 'photos' })
    Assert-MediaBytes $bytes $photosUrl
    Assert-Media ($handler.LastRequest.Headers['x-media-test'] -eq 'photos') 'The Photos GET dropped generic headers.'

    foreach ($photos in $false, $true) {
        $path = Join-Path $FixtureRoot "$(if ($photos) { 'photos' } else { 'singleton' }).bin"
        $parameters = @{ UserId = 'user-id'; OutFile = $path; Headers = @{ 'x-media-test' = 'outfile' } }
        if ($photos) { $parameters.ProfilePhotoId = 'size-id' }
        $output = @(Get-MgUserPhotoContent @parameters)
        Assert-Media ($output.Count -eq 0) 'Bound OutFile must not also write bytes to the pipeline.'
        Assert-Media ([Convert]::ToBase64String([IO.File]::ReadAllBytes($path)) -eq $expected) 'OutFile did not contain the exact media bytes.'
        Assert-Media $handler.LastStream.Disposed 'The response stream was not disposed after OutFile.'
        Assert-Media ($handler.LastRequest.Url -eq $(if ($photos) { $photosUrl } else { $singletonUrl })) 'OutFile changed route selection.'
        Assert-Media ($handler.LastRequest.Headers['x-media-test'] -eq 'outfile') 'OutFile lost generic headers.'
    }

    $failure = $null
    try { Get-MgUserPhotoContent -UserId user-id -OutFile (Join-Path $FixtureRoot 'missing\media.bin') }
    catch { $failure = $_ }
    Assert-Media ($null -ne $failure) 'An invalid output directory must report an error.'
    Assert-Media $handler.LastStream.Disposed 'A failed file write leaked the response stream.'

    foreach ($photos in $false, $true) {
        $before = $handler.RequestCount
        $parameters = @{ UserId = 'user-id'; IfMatch = '"etag"'; Headers = @{ 'x-media-test' = 'delete' }; Confirm = $false }
        if ($photos) { $parameters.ProfilePhotoId = 'size-id' }
        Remove-MgUserPhotoContent @parameters -WhatIf
        Assert-Media ($handler.RequestCount -eq $before) 'DELETE WhatIf must not reach the mock transport.'
        $output = @(Remove-MgUserPhotoContent @parameters)
        Assert-Media ($output.Count -eq 0 -and $handler.RequestCount -eq $before + 1) 'A successful DELETE must issue one request and emit no object.'
        Assert-Media ($handler.LastRequest.Method -eq 'DELETE' -and $handler.LastRequest.Url -eq $(if ($photos) { $photosUrl } else { $singletonUrl })) 'DELETE chose the wrong route.'
        Assert-Media ($handler.LastRequest.Headers['If-Match'] -eq '"etag"') 'DELETE lost its declared If-Match header.'
        Assert-Media ($handler.LastRequest.Headers['x-media-test'] -eq 'delete') 'DELETE lost generic headers.'
    }

    Assert-MediaRejected { Get-MgUserPhotoContent -UserId user-id -ProfilePhotoId '' } 'ParameterArgumentValidationErrorEmptyStringNotAllowed'
    Assert-MediaRejected { Get-MgUserPhotoContent -ProfilePhotoId size-id } 'MissingMandatoryParameter'
    Assert-MediaRejected { Get-MgUserPhotoContent -UserId user-id -Route Photos } 'NamedParameterNotFound'
    Assert-MediaRejected { Get-MgUserPhotoContent -UserId user-id -IfMatch etag } 'NamedParameterNotFound'
    Assert-MediaRejected { Remove-MgUserPhotoContent -UserId user-id -OutFile unused -WhatIf } 'NamedParameterNotFound'
    Assert-MediaRejected { Remove-MgUserPhotoContent -UserId user-id -Route Photos -WhatIf } 'NamedParameterNotFound'

    $handler.Mode = 'Error'
    foreach ($command in 'Get-MgUserPhotoContent', 'Remove-MgUserPhotoContent') {
        foreach ($photos in $false, $true) {
            $parameters = @{ UserId = 'user-id' }
            if ($photos) { $parameters.ProfilePhotoId = 'size-id' }
            if ($command -like 'Remove-*') { $parameters.Confirm = $false }
            $failure = $null
            try { $null = & $command @parameters }
            catch { $failure = $_ }
            Assert-Media ($null -ne $failure -and $failure.FullyQualifiedErrorId -like 'GraphRequestFailed,*') 'HTTP failure lost the worker GraphRequestFailed identity through dispatch.'
            Assert-Media ($failure.TargetObject -eq $(if ($photos) { 'size-id' } else { 'user-id' })) 'HTTP failure lost the selected worker target.'
            Assert-Media ($failure.Exception.Message -match 'synthetic media failure') 'The typed Kiota error message did not survive forwarding.'
        }
    }

    $handler.Mode = 'Cancel'
    $pipeline = [PowerShell]::Create()
    $null = $pipeline.AddCommand('Import-Module').AddParameter('Name', $FixtureAssembly).Invoke()
    Assert-Media (-not $pipeline.HadErrors) 'The cancellation runspace could not load the actual fixture.'
    $pipeline.Commands.Clear()
    $null = $pipeline.AddCommand('Get-MgUserPhotoContent').AddParameter('UserId', 'cancel-user')
    $invocation = $pipeline.BeginInvoke()
    Assert-Media ($handler.Started.Wait(10000)) 'The actual media worker did not reach the cancellation-only mock handler.'
    $stop = $pipeline.BeginStop($null, $null)
    Assert-Media ($stop.AsyncWaitHandle.WaitOne(10000)) 'Stopping the public media pipeline did not complete promptly.'
    $pipeline.EndStop($stop)
    Assert-Media ($handler.Cancelled.Wait(10000)) 'The real media worker did not pass its stopping token to Kiota/HTTP.'
    try { $null = $pipeline.EndInvoke($invocation) } catch {
        Assert-Media ($_.Exception.GetBaseException() -is [System.Management.Automation.PipelineStoppedException]) 'Cancellation was converted into an unrelated Graph failure.'
    }
    Assert-Media (@($pipeline.Streams.Error | Where-Object FullyQualifiedErrorId -like 'GraphRequestFailed,*').Count -eq 0) 'Cancellation must not be translated to GraphRequestFailed.'
    Assert-Media ($pipeline.InvocationStateInfo.State -eq 'Stopped') 'The cancelled pipeline did not remain stopped.'
    Write-Host 'PASS: actual four-operation media fixture: both GET/DELETE URLs, optional OutFile and bytes, stream disposal including failed writes, headers, binder, HTTP errors, WhatIf and in-flight cancellation; zero network.'
}
finally {
    if ($pipeline) { $pipeline.Dispose() }
    [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.GraphHttpClient = $oldSession
    $http.Dispose()
    Remove-Module $module -ErrorAction SilentlyContinue
    Remove-Item $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue
}

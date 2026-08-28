<#
.SYNOPSIS
Deterministic pagination gate (#3706). Drives the REAL compiled Get-MgUser_List through a stub
transport that fabricates a two-page collection - no tenant data is read beyond one /me call.

.DESCRIPTION
The runtime's session adapter cache is pre-seeded with an adapter whose HttpClient returns two
fabricated pages - the same internal cache tools/Test-WrapperLive.ps1 reflects on, but where
that gate only READS the _adapter slot to observe reuse, this one WRITES both _key and _adapter
to inject the stub. The active Connect-MgGraph session is used only as the cache KEY - the
exact reference-equality contract the cache was built on; every list request hits the stub.

Proves, deterministically:
  1. -All follows the @odata.nextLink and streams both pages (2 requests; request 2 hits the
     literal nextLink URL)
  2. without -All: first page only, exactly ONE truncation warning, no extra request
  3. -All -Top N: the total cap stops the loop at whole-page granularity

Requires an active or cached Graph session (any scopes - only /me is actually requested).

.EXAMPLE
pwsh -NoProfile -File .\tools\Test-WrapperPaging.ps1
#>
param([string]$Configuration = 'Release')
$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path $PSScriptRoot -Parent
$wrapperPsd1 = Join-Path $repoRoot "src\Users\wrapper\v1.0\bin\$Configuration\netstandard2.0\Microsoft.Graph.Wrapper.Users.psd1"
if (-not (Test-Path $wrapperPsd1)) {
    throw "no built module manifest at $wrapperPsd1 - run tools\Build-WrapperModule.ps1 -Module Users -Configuration $Configuration first"
}

$fail = [System.Collections.Generic.List[string]]::new()
function Assert([bool]$ok, [string]$what) {
    $tag = if ($ok) { 'PASS' } else { $script:fail.Add($what); 'FAIL' }
    Write-Host "$tag $what"
}

$probe = @"
`$ErrorActionPreference = 'Stop'
Import-Module Microsoft.Graph.Authentication
Import-Module '$wrapperPsd1'
Connect-MgGraph -NoWelcome
# Authentication.Core loads lazily on the first real request; one /me GET forces it so the
# reflection below can find HttpHelpers. The only network call this gate makes.
`$null = Invoke-MgGraphRequest -Method GET -Uri 'https://graph.microsoft.com/v1.0/me'

Add-Type -TypeDefinition @'
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
public class PagingStubHandler : HttpMessageHandler
{
    public System.Collections.Generic.List<string> Urls = new System.Collections.Generic.List<string>();
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
    {
        Urls.Add(request.RequestUri.ToString());
        string body = Urls.Count == 1
            ? "{\"value\":[{\"id\":\"u1\"},{\"id\":\"u2\"}],\"@odata.nextLink\":\"https://graph.microsoft.com/v1.0/users?`$skiptoken=page2\"}"
            : "{\"value\":[{\"id\":\"u3\"}]}";
        var resp = new HttpResponseMessage(HttpStatusCode.OK);
        resp.Content = new StringContent(body, Encoding.UTF8, "application/json");
        return Task.FromResult(resp);
    }
}
'@

function Get-LoadedAssembly([string]`$name) {
    `$found = [System.AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { `$_.GetName().Name -eq `$name } | Select-Object -First 1
    if (-not `$found) { throw "assembly not loaded: `$name" }
    `$found
}
`$runtimeAsm = Get-LoadedAssembly 'Microsoft.Graph.Wrapper.Runtime'
`$kiotaHttp = Get-LoadedAssembly 'Microsoft.Kiota.Http.HttpClientLibrary'
`$kiotaAbs = Get-LoadedAssembly 'Microsoft.Kiota.Abstractions'

# The real session client is only the cache key; requests go to the stub. Auth.Core sits in the
# default context after the /me call, so the type literal resolves directly.
`$real = [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient()
`$handler = [PagingStubHandler]::new()
`$stubClient = [System.Net.Http.HttpClient]::new(`$handler)
`$anon = `$kiotaAbs.GetType('Microsoft.Kiota.Abstractions.Authentication.AnonymousAuthenticationProvider').
    GetConstructor([type[]]@()).Invoke(@())
`$adapterType = `$kiotaHttp.GetType('Microsoft.Kiota.Http.HttpClientLibrary.HttpClientRequestAdapter')
`$adapter = `$adapterType.GetConstructors() | Where-Object { `$_.GetParameters().Count -eq 5 } |
    ForEach-Object { `$_.Invoke(@(`$anon, `$null, `$null, `$stubClient, `$null)) } | Select-Object -First 1
# Without this guard a kiota constructor change would seed a null adapter, the cache would
# rebuild a REAL one over the session client, and the gate would silently read live tenant data.
if (-not `$adapter) { throw 'no 5-parameter HttpClientRequestAdapter constructor - kiota surface changed' }

`$cache = `$runtimeAsm.GetType('Microsoft.Graph.Wrapper.Runtime.SessionAdapterCache', `$true)
`$flags = [System.Reflection.BindingFlags]'NonPublic,Static'
`$cache.GetField('_key', `$flags).SetValue(`$null, `$real)
`$cache.GetField('_adapter', `$flags).SetValue(`$null, `$adapter)

# Warnings are CAPTURED on every case, never suppressed: under -All the warning branch must be
# unreachable, and asserting zero converts what would be a blind redirect into coverage.
# --- 1. -All follows the nextLink ---
`$handler.Urls.Clear()
`$w1 = @()
`$all = @(Get-MgUser_List -All -WarningVariable w1 -WarningAction SilentlyContinue)
`$r1 = [pscustomobject]@{ Test = 'all'; Items = `$all.Count; Requests = `$handler.Urls.Count; Warnings = `$w1.Count; SecondUrl = if (`$handler.Urls.Count -gt 1) { `$handler.Urls[1] } else { '' } }

# --- 2. worker without -All: one page + one warning ---
`$handler.Urls.Clear()
`$w2 = @()
`$page1 = @(Get-MgUser_List -WarningVariable w2 -WarningAction SilentlyContinue)
`$r2 = [pscustomobject]@{ Test = 'warn'; Items = `$page1.Count; Requests = `$handler.Urls.Count; Warnings = `$w2.Count; Text = if (`$w2) { "`$(`$w2[0])" } else { '' } }

# --- 3. -All -Top 2: total cap stops after page 1 ---
`$handler.Urls.Clear()
`$w3 = @()
`$capped = @(Get-MgUser_List -All -Top 2 -WarningVariable w3 -WarningAction SilentlyContinue)
`$r3 = [pscustomobject]@{ Test = 'cap'; Items = `$capped.Count; Requests = `$handler.Urls.Count; Warnings = `$w3.Count }

# --- 4. the PUBLIC dispatcher forwards -All (declaration alone is not proof) ---
`$handler.Urls.Clear()
`$w4 = @()
`$viaDispatcher = @(Get-MgUser -All -WarningVariable w4 -WarningAction SilentlyContinue)
`$r4 = [pscustomobject]@{ Test = 'dispatcher'; Items = `$viaDispatcher.Count; Requests = `$handler.Urls.Count; Warnings = `$w4.Count }

# --- 5. the PUBLIC dispatcher without -All: warning must cross InvokeScript to the caller ---
`$handler.Urls.Clear()
`$w5 = @()
`$viaDispatcherPage1 = @(Get-MgUser -WarningVariable w5 -WarningAction SilentlyContinue)
`$r5 = [pscustomobject]@{ Test = 'dispwarn'; Items = `$viaDispatcherPage1.Count; Requests = `$handler.Urls.Count; Warnings = `$w5.Count }

@(`$r1, `$r2, `$r3, `$r4, `$r5) | ConvertTo-Json -Compress
"@
$enc = [Convert]::ToBase64String([Text.Encoding]::Unicode.GetBytes($probe))
$out = & pwsh -NoProfile -NonInteractive -EncodedCommand $enc 2>&1
$json = $out | Where-Object { $_ -match '^\[' } | Select-Object -Last 1
if (-not $json) { Assert $false "probe produced no result: $(($out | Select-Object -Last 3) -join ' | ')" }
else {
    $r = $json | ConvertFrom-Json
    $all = $r | Where-Object Test -eq 'all'
    Assert ($all.Items -eq 3) "-All returned all 3 items across pages (got $($all.Items))"
    Assert ($all.Requests -eq 2) "-All made exactly 2 requests (got $($all.Requests))"
    Assert ($all.SecondUrl -like '*skiptoken=page2*') "request 2 hit the literal nextLink ($($all.SecondUrl))"
    Assert ($all.Warnings -eq 0) "-All emits no warning (got $($all.Warnings))"
    $warn = $r | Where-Object Test -eq 'warn'
    Assert ($warn.Items -eq 2 -and $warn.Requests -eq 1) "worker without -All: first page only, 1 request (items=$($warn.Items) req=$($warn.Requests))"
    Assert ($warn.Warnings -eq 1 -and $warn.Text -like '*Use -All*') "exactly one truncation warning with -All guidance (n=$($warn.Warnings))"
    $cap = $r | Where-Object Test -eq 'cap'
    Assert ($cap.Items -eq 2 -and $cap.Requests -eq 1 -and $cap.Warnings -eq 0) "-All -Top 2: cap stops after page 1, no warning (items=$($cap.Items) req=$($cap.Requests) warn=$($cap.Warnings))"
    $disp = $r | Where-Object Test -eq 'dispatcher'
    Assert ($disp.Items -eq 3 -and $disp.Requests -eq 2 -and $disp.Warnings -eq 0) "dispatcher forwards -All end to end (items=$($disp.Items) req=$($disp.Requests) warn=$($disp.Warnings))"
    $dw = $r | Where-Object Test -eq 'dispwarn'
    Assert ($dw.Items -eq 2 -and $dw.Requests -eq 1) "dispatcher without -All: first page only, 1 request (items=$($dw.Items) req=$($dw.Requests))"
    Assert ($dw.Warnings -eq 1) "the truncation warning crosses InvokeScript to the dispatcher caller (n=$($dw.Warnings))"
}

''
if ($fail.Count -eq 0) { 'RESULT: ALL PASS' } else { "RESULT: $($fail.Count) FAILURE(S)" }
exit $fail.Count

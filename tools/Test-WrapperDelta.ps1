<#
.SYNOPSIS
Deterministic delta-pagination gate (#3742). Drives a REAL compiled delta cmdlet through a stub
transport that fabricates a change set - no tenant data is read beyond one /me call.

.DESCRIPTION
The runtime's session adapter cache is pre-seeded with an adapter whose HttpClient returns a
scripted change set: two @odata.nextLink pages, then a page carrying @odata.deltaLink. A separate
scripted response answers a resume request and returns a replacement link. The active
Connect-MgGraph session is used only as the cache KEY.

Proves, deterministically:
  1. -All walks the change set to its terminal page and publishes the deltaLink
  2. without -All: first page only, exactly one warning, no link published
  3. -DeltaLink resumes from the literal link and publishes the replacement
  4. the variable is cleared at invocation start, so a run that ends without a terminal page
     cannot leave a previous run's link readable
  5. no *DeltaWithToken command exists - the token form is a parameter set, not a command

Requires an active or cached Graph session (any scopes - only /me is requested).

.EXAMPLE
pwsh -NoProfile -File .\tools\Test-WrapperDelta.ps1
#>
param([string]$Configuration = 'Release')
$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path $PSScriptRoot -Parent
$psd1 = Join-Path $repoRoot "src\Files\wrapper\v1.0\bin\$Configuration\netstandard2.0\Microsoft.Graph.Wrapper.Files.psd1"
if (-not (Test-Path $psd1)) {
    throw "no built module at $psd1 - run tools\Build-WrapperModule.ps1 -Module Files -Configuration $Configuration first"
}

$fail = [System.Collections.Generic.List[string]]::new()
function Assert([bool]$ok, [string]$what) {
    $tag = if ($ok) { 'PASS' } else { $script:fail.Add($what); 'FAIL' }
    Write-Host "$tag $what"
}

$probe = @"
`$ErrorActionPreference = 'Stop'
Import-Module Microsoft.Graph.Authentication
Import-Module '$psd1'
Connect-MgGraph -NoWelcome
`$null = Invoke-MgGraphRequest -Method GET -Uri 'https://graph.microsoft.com/v1.0/me'

Add-Type -TypeDefinition @'
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
public class DeltaStubHandler : HttpMessageHandler
{
    public System.Collections.Generic.List<string> Urls = new System.Collections.Generic.List<string>();
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
    {
        string url = request.RequestUri.ToString();
        Urls.Add(url);
        string body;
        if (url.Contains("RESUMELINK"))
            body = "{\"value\":[{\"id\":\"r1\"}],\"@odata.deltaLink\":\"https://graph.microsoft.com/v1.0/drives/d/items/i/delta?`$deltatoken=SECOND\"}";
        else if (url.Contains("PAGE3"))
            body = "{\"value\":[{\"id\":\"c1\"}],\"@odata.deltaLink\":\"https://graph.microsoft.com/v1.0/drives/d/items/i/delta?`$deltatoken=FIRST\"}";
        else if (url.Contains("PAGE2"))
            body = "{\"value\":[{\"id\":\"b1\"},{\"id\":\"b2\"}],\"@odata.nextLink\":\"https://graph.microsoft.com/v1.0/drives/d/items/i/delta?`$skiptoken=PAGE3\"}";
        else
            body = "{\"value\":[{\"id\":\"a1\"},{\"id\":\"a2\"}],\"@odata.nextLink\":\"https://graph.microsoft.com/v1.0/drives/d/items/i/delta?`$skiptoken=PAGE2\"}";
        var resp = new HttpResponseMessage(HttpStatusCode.OK);
        resp.Content = new StringContent(body, Encoding.UTF8, "application/json");
        return Task.FromResult(resp);
    }
}
'@

function Get-LoadedAssembly([string]`$name) {
    `$a = [System.AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { `$_.GetName().Name -eq `$name } | Select-Object -First 1
    if (-not `$a) { throw "assembly not loaded: `$name" }
    `$a
}
`$runtimeAsm = Get-LoadedAssembly 'Microsoft.Graph.Wrapper.Runtime'
`$kiotaHttp = Get-LoadedAssembly 'Microsoft.Kiota.Http.HttpClientLibrary'
`$kiotaAbs = Get-LoadedAssembly 'Microsoft.Kiota.Abstractions'

`$real = [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient()
`$handler = [DeltaStubHandler]::new()
`$stub = [System.Net.Http.HttpClient]::new(`$handler)
`$anon = `$kiotaAbs.GetType('Microsoft.Kiota.Abstractions.Authentication.AnonymousAuthenticationProvider').GetConstructor([type[]]@()).Invoke(@())
`$adapterType = `$kiotaHttp.GetType('Microsoft.Kiota.Http.HttpClientLibrary.HttpClientRequestAdapter')
`$adapter = `$adapterType.GetConstructors() | Where-Object { `$_.GetParameters().Count -eq 5 } |
    ForEach-Object { `$_.Invoke(@(`$anon, `$null, `$null, `$stub, `$null)) } | Select-Object -First 1
if (-not `$adapter) { throw 'no 5-parameter HttpClientRequestAdapter constructor - kiota surface changed' }

`$cache = `$runtimeAsm.GetType('Microsoft.Graph.Wrapper.Runtime.SessionAdapterCache', `$true)
`$flags = [System.Reflection.BindingFlags]'NonPublic,Static'
`$cache.GetField('_key', `$flags).SetValue(`$null, `$real)
`$cache.GetField('_adapter', `$flags).SetValue(`$null, `$adapter)

# --- 1. -All walks to the terminal page and publishes the link ---
`$handler.Urls.Clear()
`$dl = 'PRESET-STALE'
`$w1 = @()
`$all = @(Get-MgDriveItemDelta -DriveId d -DriveItemId i -All -DeltaLinkVariable dl -WarningVariable w1 -WarningAction SilentlyContinue)
`$r1 = [pscustomobject]@{ Test='all'; Items=`$all.Count; Requests=`$handler.Urls.Count; Warnings=`$w1.Count; Link="`$dl" }

# --- 2. without -All: one page, one warning, nothing published ---
`$handler.Urls.Clear()
`$dl2 = 'PRESET-STALE'
`$w2 = @()
`$page1 = @(Get-MgDriveItemDelta -DriveId d -DriveItemId i -DeltaLinkVariable dl2 -WarningVariable w2 -WarningAction SilentlyContinue)
`$r2 = [pscustomobject]@{ Test='nopage'; Items=`$page1.Count; Requests=`$handler.Urls.Count; Warnings=`$w2.Count; Link="`$dl2" }

# --- 3. resume from a link ---
`$handler.Urls.Clear()
`$dl3 = ''
`$w3 = @()
`$res = @(Get-MgDriveItemDelta -DeltaLink 'https://graph.microsoft.com/v1.0/drives/d/items/i/delta?RESUMELINK' -DeltaLinkVariable dl3 -WarningVariable w3 -WarningAction SilentlyContinue)
`$r3 = [pscustomobject]@{ Test='resume'; Items=`$res.Count; Requests=`$handler.Urls.Count; Warnings=`$w3.Count; Link="`$dl3"; FirstUrl=`$handler.Urls[0] }

# --- 5. the token form is not a command ---
`$tokenCmds = @(Get-Command -Module Microsoft.Graph.Wrapper.Files -Name '*DeltaWithToken*' -ErrorAction SilentlyContinue).Count
`$r5 = [pscustomobject]@{ Test='notoken'; Count=`$tokenCmds }

@(`$r1, `$r2, `$r3, `$r5) | ConvertTo-Json -Compress
"@
$enc = [Convert]::ToBase64String([Text.Encoding]::Unicode.GetBytes($probe))
$out = & pwsh -NoProfile -NonInteractive -EncodedCommand $enc 2>&1
$json = $out | Where-Object { $_ -match '^\[' } | Select-Object -Last 1
if (-not $json) { Assert $false "probe produced no result: $(($out | Select-Object -Last 3) -join ' | ')" }
else {
    $r = $json | ConvertFrom-Json
    $a = $r | Where-Object Test -eq 'all'
    Assert ($a.Items -eq 5) "-All returned the whole change set across 3 pages (got $($a.Items))"
    Assert ($a.Requests -eq 3) "-All made exactly 3 requests (got $($a.Requests))"
    Assert ($a.Warnings -eq 0) "-All emitted no warning (got $($a.Warnings))"
    Assert ($a.Link -like '*deltatoken=FIRST*') "terminal deltaLink published to the variable (got '$($a.Link)')"

    $n = $r | Where-Object Test -eq 'nopage'
    Assert ($n.Items -eq 2 -and $n.Requests -eq 1) "without -All: first page only, 1 request (items=$($n.Items) req=$($n.Requests))"
    Assert ($n.Warnings -eq 1) "exactly one truncation warning (got $($n.Warnings))"
    Assert ([string]::IsNullOrEmpty($n.Link)) "no terminal page reached: variable cleared, not left stale (got '$($n.Link)')"

    $s = $r | Where-Object Test -eq 'resume'
    Assert ($s.FirstUrl -like '*RESUMELINK*') "resume issued the literal link supplied (got '$($s.FirstUrl)')"
    Assert ($s.Items -eq 1 -and $s.Requests -eq 1) "resume returned its page in 1 request (items=$($s.Items) req=$($s.Requests))"
    Assert ($s.Link -like '*deltatoken=SECOND*') "replacement deltaLink published (got '$($s.Link)')"

    $t = $r | Where-Object Test -eq 'notoken'
    Assert ($t.Count -eq 0) "no *DeltaWithToken command exists (found $($t.Count))"
}

''
if ($fail.Count -eq 0) { 'RESULT: ALL PASS' } else { "RESULT: $($fail.Count) FAILURE(S)" }
exit $fail.Count

<#
.SYNOPSIS
Live-tenant runtime gate for wrapper modules. READ-ONLY: every Graph call is a GET of the
signed-in user's own object; nothing in the tenant is created, changed, or deleted.

.DESCRIPTION
The one gate that runs a wrapper cmdlet against real Graph. It exists because offline gates
are structurally blind to runtime assembly-resolution defects: the cross-load-context type
split (two identities of a kiota assembly, one in the module folder, one in Authentication's
isolated context) only manifests on a real request through the real session pipeline.

Proves, in order:
  1. session path      - a worker cmdlet reads live data through the Connect-MgGraph session
  2. dispatcher path   - the public dispatcher forwards to its worker against live Graph
  3. adapter cache     - the SAME request adapter serves consecutive calls, and a mid-session
                        reconnect (the real invalidation path) produces a NEW adapter
  4. parallel          - 16 concurrent runspaces through the one shared session client
  5. token path        - only when -AccessToken is supplied: the shared-HttpClient bearer path

Exercises the Users module deliberately: its worker/dispatcher pair (Get-MgUser_Get /
Get-MgUser) reads the caller's OWN object, so any connected account can run the gate with
no more consent than User.Read. The resolution machinery being proven is identical in every
module - same template, same runtime, same manifest shape.

Consent floor: User.Read. Host: pwsh 7+ (ForEach-Object -Parallel).

.PARAMETER Configuration
Build configuration whose bin to import. Default Release.

.PARAMETER AccessToken
Optional bearer token; adds the token-path check.

.PARAMETER SkipReconnect
Skip the disconnect/reconnect leg (it prompts for interactive sign-in a second time).

.PARAMETER UseDeviceCode
Device-code sign-in instead of the browser popup - required when this script runs from a
process with no window (background shells fail WAM's parent-window-handle requirement).

.EXAMPLE
pwsh -NoProfile -File .\tools\Test-WrapperLive.ps1

.EXAMPLE
pwsh -NoProfile -File .\tools\Test-WrapperLive.ps1 -SkipReconnect -UseDeviceCode
#>
param(
    [string]$ApiVersion = 'v1.0',
    [string]$Configuration = 'Release',
    [string]$AccessToken,
    [switch]$SkipReconnect,
    [switch]$UseDeviceCode
)
$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path $PSScriptRoot -Parent
$binDir = Join-Path $repoRoot "src\Users\wrapper\$ApiVersion\bin\$Configuration\netstandard2.0"
$wrapperPsd1 = Join-Path $binDir 'Microsoft.Graph.Wrapper.Users.psd1'
if (-not (Test-Path $wrapperPsd1)) {
    throw "no built module manifest at $wrapperPsd1 - run tools\Build-WrapperModule.ps1 -Module Users -Configuration $Configuration first"
}

$results = [System.Collections.Generic.List[string]]::new()
function Report([string]$name, [bool]$ok, [string]$detail = '') {
    $line = "{0} {1}{2}" -f ($(if ($ok) { 'PASS' } else { 'FAIL' })), $name, $(if ($detail) { " - $detail" } else { '' })
    $results.Add($line); Write-Host $line -ForegroundColor $(if ($ok) { 'Green' } else { 'Red' })
}

Import-Module Microsoft.Graph.Authentication
Import-Module $wrapperPsd1
$connectArgs = @{ Scopes = 'User.Read'; NoWelcome = $true }
if ($UseDeviceCode) { $connectArgs.UseDeviceCode = $true }
if (-not (Get-MgContext)) {
    Write-Host 'No session - connecting (User.Read only)...' -ForegroundColor Yellow
    Connect-MgGraph @connectArgs
}
$me = Invoke-MgGraphRequest -Method GET -Uri 'https://graph.microsoft.com/v1.0/me'
"me: $($me.userPrincipalName) ($($me.id))"

# Reaches the runtime's internal single-slot adapter cache so reuse/rebuild is observed, not
# assumed. Internal by design; this gate is exactly why the reflection is acceptable here.
$runtimeAsm = [System.AppDomain]::CurrentDomain.GetAssemblies() |
    Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Wrapper.Runtime' } | Select-Object -First 1
$cacheField = $runtimeAsm.GetType('Microsoft.Graph.Wrapper.Runtime.SessionAdapterCache', $true).
    GetField('_adapter', [System.Reflection.BindingFlags]'NonPublic,Static')

# --- 1. session path -----------------------------------------------------------------------
$u1 = Get-MgUser_Get -UserId $me.id
Report 'session path (worker cmdlet)' ($u1.Id -eq $me.id) "returned $($u1.UserPrincipalName)"

# --- 2. dispatcher path --------------------------------------------------------------------
$u2 = Get-MgUser -UserId $me.id
Report 'dispatcher path (dispatcher -> worker)' ($u2.Id -eq $me.id)

# --- 3a. adapter reuse across calls --------------------------------------------------------
$a1 = $cacheField.GetValue($null)
$null = Get-MgUser_Get -UserId $me.id
$a2 = $cacheField.GetValue($null)
Report 'adapter reused across calls' ([object]::ReferenceEquals($a1, $a2))

# --- 3b. reconnect invalidation (the one thing no stub can prove) --------------------------
if (-not $SkipReconnect) {
    Write-Host 'Reconnecting to prove cache invalidation (you will authenticate once more)...' -ForegroundColor Yellow
    $before = $cacheField.GetValue($null)
    Disconnect-MgGraph | Out-Null
    Connect-MgGraph @connectArgs
    $u3 = Get-MgUser_Get -UserId $me.id
    $after = $cacheField.GetValue($null)
    Report 'reconnect -> call still works' ($u3.Id -eq $me.id)
    Report 'reconnect -> NEW adapter (cache rebuilt)' (-not [object]::ReferenceEquals($before, $after))
}
else { $results.Add('SKIP reconnect (requested)') }

# --- 4. parallel burst through the shared session client -----------------------------------
$burst = 1..16 | ForEach-Object -Parallel {
    Import-Module Microsoft.Graph.Authentication -ErrorAction Stop
    Import-Module $using:wrapperPsd1 -ErrorAction Stop
    try { (Get-MgUser_Get -UserId $using:me.id).Id } catch { "ERR: $($_.Exception.Message)" }
} -ThrottleLimit 16
$good = @($burst | Where-Object { $_ -eq $me.id }).Count
Report 'parallel 16x through shared session' ($good -eq 16) "$good/16 returned the right object"

# --- 5. token path (optional) --------------------------------------------------------------
if ($AccessToken) {
    $u4 = Get-MgUser_Get -UserId $me.id -AccessToken $AccessToken
    Report 'token path (-AccessToken, shared HttpClient)' ($u4.Id -eq $me.id)
}
else { $results.Add('SKIP token path (no -AccessToken supplied)') }

''
'================ SUMMARY ================'
$results | ForEach-Object { $_ }
$failed = @($results | Where-Object { $_ -like 'FAIL*' }).Count
"result: $(if ($failed -eq 0) { 'ALL PASS' } else { "$failed FAILURE(S)" })"
exit $failed

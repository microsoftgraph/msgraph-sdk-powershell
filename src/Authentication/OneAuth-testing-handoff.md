# OneAuth / DPoP testing handoff

## Goal and current status

Compare these modes on another Windows machine using the same account, tenant,
Graph endpoint, and default Microsoft Graph PowerShell application:

| Mode | OneAuth | DPoP | What success establishes |
| --- | --- | --- | --- |
| MSAL bearer | Off | Off | Account, consent, and Graph access work |
| OneAuth bearer | On | Off | OneAuth can use the default app ID |
| OneAuth DPoP | On | On | The broker issues a DPoP token and Graph accepts a signed request |

Default app ID: `14d82eec-204b-4c2f-b7e8-296a70dab67e`.
Its eligibility for this private preview has not been confirmed.
Do not create a replacement third-party app registration: the OneAuth preview
documents support for first-party client IDs only.

The experiment is opt-in. The same preview build supports all three modes.
Earlier local checks passed: 45 focused preview tests, 28 stable-path regression
tests, and six build-switch forwarding tests. The staged module imported and its
managed/native OneAuth libraries loaded in the private assembly context; packed
assets were also checked. These are historical offline results, not evidence that
live OneAuth sign-in or Graph DPoP succeeded. No live success has been established.

**Important blocker:** the current module sets `DisableAutomaticAuthentication = true`
for OneAuth. It does not expose an interactive-bootstrap option. The preview
package README warns that default-account discovery can report no account.
An `AuthenticationRequiredException` is therefore **blocked/inconclusive**, not
proof that the app or DPoP is unsupported. MSAL sign-in does not guarantee that
OneAuth silent authentication will work.

## 1. Prepare the receiving machine

- Use Windows with an organizational WAM account and a broker supporting DPoP
  token binding. Windows alone does not guarantee this preview capability.
- Use a fresh PowerShell 7 process, not Windows PowerShell 5.1, for every test.
  PowerShell 7.4 or newer is a practical baseline for this handoff.
- Use the same authorized work account and tenant in all modes. Start with an
  approved test tenant/account that already has the required Graph consent.
  `.default` uses existing delegated grants; it does not mean only `User.Read`.
- Do not use a production automation host or publish this private-preview build
  to PowerShell Gallery. Share binaries only with package-owner approval and
  through an approved internal channel.

For source builds, also install Git, an SDK capable of building the repository's
targets, and the .NET 8 runtime for the `net8.0` offline tests. The earlier local
build used .NET SDK `11.0.100`; this is an observation, not a minimum requirement.
The module currently builds `netstandard2.0`, `net6.0`, and `net472` targets.
NuGet must be able to restore their targeting/reference packages.

Source builds need Feed Reader access and an approved local authentication setup
(for example, Azure Artifacts Credential Provider) for both feeds:

```text
https://pkgs.dev.azure.com/azure-sdk/internal/_packaging/azure-sdk-for-net-pr/nuget/v3/index.json
https://office.pkgs.visualstudio.com/_packaging/OneAuth/nuget/v3/index.json
```

`--interactive` permits the installed provider to prompt; it does not itself
install a provider or grant feed permissions. Never put access tokens in scripts,
source files, or this handoff.

## 2. Obtain the actual experiment

Choose either a source build or an approved prebuilt module transfer.

### Route A: source build

The experiment is on working branch `gavinbarron-oneauth-wam-experiment`,
based on commit `2ed77c0425`. After the source owner confirms the push, obtain it
on the receiving machine with:

```powershell
git clone --branch gavinbarron-oneauth-wam-experiment --single-branch `
    https://github.com/microsoftgraph/msgraph-sdk-powershell.git `
    msgraph-sdk-powershell-oneauth
if ($LASTEXITCODE -ne 0) { throw 'Experiment clone failed.' }
Set-Location .\msgraph-sdk-powershell-oneauth
git rev-parse HEAD
```

Compare the commit ID with the sender's handoff confirmation. A checkout of the
default branch will not contain the experiment. Source files are committed;
private-preview binaries and feed credentials are not.

In the receiving checkout, verify these new files exist:

```text
src\Authentication\Directory.Build.props
src\Authentication\NuGet.OneAuthPreview.Config
src\Authentication\Authentication.Core\Utilities\OneAuthPreview.cs
src\Authentication\Authentication.Core\Http\DPoPAuthenticationHandler.cs
src\Authentication\Authentication.Test\Handlers\DPoPAuthenticationHandlerTests.cs
src\Authentication\Authentication.Test\Helpers\OneAuthPreviewTests.cs
tools\Tests\GenerateAuthenticationModule.Tests.ps1
```

Also transfer the modified Core project, authentication helpers, HTTP factory,
module build script/nuspec, `tools\BuildModule.ps1`, and
`tools\GenerateAuthenticationModule.ps1`. Transfer the complete reviewed experiment,
not just the new files above. Include this document and `OneAuth-preview.md`.
Do not copy the sender's token caches, user NuGet configuration, or credentials.

From the receiving repository root in PowerShell 7:

```powershell
$ErrorActionPreference = 'Stop'
dotnet --info
dotnet --list-runtimes

dotnet restore .\src\Authentication\Authentication.sln `
    --configfile .\src\Authentication\NuGet.OneAuthPreview.Config `
    --interactive -p:EnableOneAuthPreview=true
if ($LASTEXITCODE -ne 0) { throw 'Preview restore failed.' }

# Direct build avoids generator metadata changes and gallery lookups.
& .\src\Authentication\Authentication\build-module.ps1 -OneAuthPreview -Isolated
if ($LASTEXITCODE -ne 0) { throw 'Preview build failed.' }

$moduleRoot = (Resolve-Path .\src\Authentication\Authentication\artifacts).Path
if (-not (Test-Path (Join-Path $moduleRoot 'Microsoft.Graph.Authentication.psd1'))) {
    throw 'The preview module was not staged.'
}
$moduleRoot
```

The higher-level entry point also forwards the switch:

```powershell
.\tools\GenerateAuthenticationModule.ps1 -Build -OneAuthPreview
```

It updates project/module metadata and uses the shared generation helpers; the
direct build above is sufficient for the three runtime comparisons.
Do not rebuild between modes. Close any process holding the module before rebuilding.

### Route B: approved prebuilt module transfer

The sender first builds the preview using Route A. If authorized to share these
private binaries, archive the **entire** module directory, including Dependencies
and native runtime subdirectories:

```powershell
# Sender: run from the source repository root. Choose a new destination file.
$zipPath = Join-Path $env:TEMP 'GraphAuthentication-OneAuthPreview.zip'
Compress-Archive -Path .\src\Authentication\Authentication\artifacts\* `
    -DestinationPath $zipPath
Get-FileHash -Path $zipPath -Algorithm SHA256
```

Share this document, the ZIP, and its SHA-256 through approved channels. The receiver
compares the hash and extracts the module to a dedicated test directory:

```powershell
# Receiver: replace these paths with your downloaded ZIP and a new test directory.
$zipPath = 'C:\OneAuthTest\GraphAuthentication-OneAuthPreview.zip'
Get-FileHash -Path $zipPath -Algorithm SHA256
# Stop if this does not match the sender's hash.
Expand-Archive -Path $zipPath `
    -DestinationPath 'C:\OneAuthTest\Microsoft.Graph.Authentication'
```

Feed access and the .NET SDK are not needed just to run the prebuilt module.
Use PowerShell 7 and a matching-architecture native library. Do not copy individual
DLLs into an installed Graph module or change the machine-wide `PSModulePath`.
Do not bypass execution policy or unblock untrusted downloads; follow local policy.

## 3. Check package identity before testing

In a PowerShell 7 process, set `$moduleRoot` to the built or extracted directory:

```powershell
# Source-build receiver:
$moduleRoot = (Resolve-Path .\src\Authentication\Authentication\artifacts).Path

# OR prebuilt receiver:
# $moduleRoot = 'C:\OneAuthTest\Microsoft.Graph.Authentication'

foreach ($name in @('Azure.Core', 'Azure.Identity.Broker', 'Microsoft.Authentication.Client')) {
    $path = Join-Path $moduleRoot "Dependencies\Core\$name.dll"
    if (-not (Test-Path $path)) { throw "Missing preview dependency: $name" }
    [pscustomobject]@{
        Assembly = $name
        ProductVersion = [Diagnostics.FileVersionInfo]::GetVersionInfo($path).ProductVersion
    }
}

$rid = 'win-' + [Runtime.InteropServices.RuntimeInformation]::ProcessArchitecture.ToString().ToLowerInvariant()
$nativePath = Join-Path $moduleRoot "Dependencies\Core\runtimes\$rid\native\OneAuthInterop.dll"
if (-not (Test-Path $nativePath)) { throw "Missing native runtime for $rid" }
```

Expected package identities:

| Package | Version |
| --- | --- |
| Azure.Core | `1.64.0-beta.20261105.101` |
| Azure.Identity.Broker | `1.8.0-beta.20261105.101` |
| Microsoft.Authentication.Client | `12.1.0-rc1` |

Product versions may include commit suffixes. The OneAuth DLL reported `12.1.0+...`
in the earlier build; its package identity is `12.1.0-rc1`.
Preview dependencies also require Microsoft.Bcl.AsyncInterfaces and System.Text.Json
`10.0.10`. This Azure.Core build contains the Azure.Identity types, so a separate
Azure.Identity DLL is intentionally omitted from the preview build.

## 4. Run each mode in its own process

For **each** mode, start `pwsh -NoLogo -NoProfile`, set the module path and tenant,
then run exactly one mode's configuration followed by the common test below.
Use a regular Windows terminal rather than a reused IDE runspace.

```powershell
$ErrorActionPreference = 'Stop'
$moduleRoot = 'C:\OneAuthTest\Microsoft.Graph.Authentication' # Or the source-build artifacts path.
$tenantId = '<tenant-guid>' # Same tenant in all three runs.
```

Do not import Graph before setting the switches. Explicit AppContext values below
override inherited environment variables.

### Mode 1: MSAL bearer

```powershell
$mode = 'MSAL bearer'
[AppContext]::SetSwitch('Azure.Identity.Broker.EnableOneAuthRuntime', $false)
[AppContext]::SetSwitch('Azure.Identity.Broker.EnableOneAuthDPoP', $false)
```

If prompted, choose the work account intended for OneAuth. MSAL may reuse an
existing account record; confirm locally that it selected the intended account.
This keeps WAM enabled: it compares MSAL versus OneAuth, not WAM versus browser.

### Mode 2: OneAuth bearer

```powershell
$mode = 'OneAuth bearer'
[AppContext]::SetSwitch('Azure.Identity.Broker.EnableOneAuthRuntime', $true)
[AppContext]::SetSwitch('Azure.Identity.Broker.EnableOneAuthDPoP', $false)
```

### Mode 3: OneAuth DPoP

```powershell
$mode = 'OneAuth DPoP'
[AppContext]::SetSwitch('Azure.Identity.Broker.EnableOneAuthRuntime', $true)
[AppContext]::SetSwitch('Azure.Identity.Broker.EnableOneAuthDPoP', $true)
```

### Common test: run after configuring the mode

This deliberately omits `-ClientId` and `-LoginHint` to test the shipped app ID
and the default account path. Do not add `-UseDeviceCode` or `-AccessToken`;
they would test a different flow and are rejected when OneAuth is active.

```powershell
if (Get-Module Microsoft.Graph*) {
    throw 'Graph is already loaded. Start a fresh pwsh -NoProfile process.'
}
$manifest = Join-Path $moduleRoot 'Microsoft.Graph.Authentication.psd1'
Import-Module $manifest -ErrorAction Stop
Get-Module Microsoft.Graph.Authentication | Select-Object Name, Version, Path
# Confirm the path is the experiment, not an installed gallery copy.

$response = $null
$connected = $false
try {
    Connect-MgGraph -TenantId $tenantId `
        -Scopes 'https://graph.microsoft.com/.default' `
        -ContextScope Process -NoWelcome -ErrorAction Stop
    $connected = $true

    $context = Get-MgContext
    if ($context.ClientId -ne '14d82eec-204b-4c2f-b7e8-296a70dab67e') {
        throw 'Unexpected app ID; this is not the default-app comparison.'
    }
    # Inspect $context.Account locally to confirm the same account in every run.
    # Do not include account details in shared results.

    $response = Invoke-MgGraphRequest -Method GET `
        -Uri 'https://graph.microsoft.com/v1.0/me?$select=id' `
        -OutputType HttpResponseMessage -ErrorAction Stop

    $scheme = $response.RequestMessage.Headers.Authorization.Scheme
    $hasProof = $response.RequestMessage.Headers.Contains('DPoP')
    $expectedScheme = if ($mode -eq 'OneAuth DPoP') { 'DPoP' } else { 'Bearer' }
    $expectedProof = $mode -eq 'OneAuth DPoP'

    [pscustomobject]@{
        Mode = $mode
        ClientId = $context.ClientId
        HttpStatus = [int]$response.StatusCode
        AuthorizationScheme = $scheme
        DPoPProofPresent = $hasProof
        Passed = ([int]$response.StatusCode -eq 200 -and
                  $scheme -eq $expectedScheme -and $hasProof -eq $expectedProof)
    }
}
finally {
    if ($null -ne $response) { $response.Dispose() }
    if ($connected) {
        Disconnect-MgGraph -ErrorAction Continue | Out-Null
    }
}
```

Copy only the summary into the result record. For failures, retain a sanitized
exception type/code/message and the phase that failed (import, connect, or GET).
Do not print the whole response, request, token, proof, or raw headers.
Close the process after each mode, including failed runs.

| Mode | HTTP | Authorization scheme | DPoP header | Expected result |
| --- | --- | --- | --- | --- |
| MSAL bearer | 200 | Bearer | Absent | Pass |
| OneAuth bearer | 200 | Bearer | Absent | Pass |
| OneAuth DPoP | 200 | DPoP | Present | Pass |

DPoP connect additionally checks token type and the presence of a proof provider.
The request handler fails before sending if the token/proof is unusable.
A 200 with a proof establishes an accepted signed request, **not** rejection of
invalid proofs. Missing/tampered-proof enforcement testing is a separate task for
an approved test harness and tenant; it is not implemented by this procedure.

## 5. Diagnose failures without changing app registration prematurely

| Symptom | Interpretation / next action |
| --- | --- |
| Restore 401/403 or private-feed service-index failure | Check feed access, connectivity, and local credential provider; this says nothing about runtime DPoP support. |
| Missing DLL, native-library failure, or architecture mismatch | Confirm the complete preview module was transferred and the runtime matches the PowerShell process. |
| `AuthenticationRequiredException` | Silent sign-in needs help. Mark blocked; ask the experiment owner for an interactive-bootstrap path. Do not assume the MSAL cache is reusable by OneAuth. |
| `IncorrectConfiguration`, `TokenBindingNotSupportedByBroker`, code `2002` / substatus `6707` | This machine's broker lacks required DPoP token binding. Confirm the preview broker/OS prerequisites with the OneAuth owners. |
| MSAL passes but OneAuth bearer fails | Investigate OneAuth account/onboarding/default-app support before blaming DPoP. |
| OneAuth bearer passes but DPoP token acquisition fails | Investigate broker capability and app/tenant preview eligibility; collect sanitized runtime error codes. |
| Connect succeeds but GET returns 401 | Investigate the Graph challenge, proof handling, and resource support; token issuance alone is insufficient. |
| Graph returns 403 | Check consent, permissions, and tenant policy. This is not by itself evidence that DPoP is unsupported. |
| A known-supported first-party app works but the default app fails | Evidence of app-specific differences; have the preview owners confirm onboarding/configuration. Use a separate process for each app ID. |

The gist does not document a standard "enable DPoP" app-registration toggle.
Do not modify registration or tenant policy on speculation.
OneAuth uses one client ID per process. Never switch modes/app IDs in-process;
`Remove-Module` or `Disconnect-MgGraph` does not reset the native runtime.
Disconnect clears the Graph session, not the shared OneAuth/WAM cache.
Do not use `Disconnect-MgGraph -SignOutFromBroker` in this experiment.

## 6. Optional offline checks for source-build receivers

Use a separate process with both OneAuth environment flags disabled and no
AppContext overrides. These tests use mocks; no live account should be needed.

```powershell
$env:AZURE_IDENTITY_BROKER_ENABLE_ONEAUTH = 'false'
$env:AZURE_IDENTITY_BROKER_ENABLE_ONEAUTH_DPOP = 'false'

dotnet test .\src\Authentication\Authentication.Test\Microsoft.Graph.Authentication.Test.csproj `
    -f net8.0 -p:EnableOneAuthPreview=true `
    --filter 'FullyQualifiedName~DPoPAuthenticationHandlerTests|FullyQualifiedName~OneAuthPreviewTests|FullyQualifiedName~AuthenticationHelpersTests|FullyQualifiedName~AssemblyIsolationTests'
if ($LASTEXITCODE -ne 0) { throw 'Focused preview tests failed.' }

# Requires Pester 5 installed through your approved package source.
Import-Module Pester -MinimumVersion 5.0
$result = Invoke-Pester -Path .\tools\Tests\GenerateAuthenticationModule.Tests.ps1 -PassThru
if ($result.Result -ne 'Passed') { throw 'Build-switch forwarding tests failed.' }
```

Retry/proof freshness, nonce/claims challenges, fail-closed behavior, HTTPS/host
restrictions, streaming-body replay limits, and pipeline placement are covered by
the focused tests. They do not prove broker issuance or Graph enforcement.
If you also run stable builds/tests without the preview property, rebuild the
preview before producing a new binary handoff.

## 7. Return results and clean up

Return this compact record through the approved channel:

```text
Source commit/snapshot identifier or ZIP SHA-256:
Windows version/build and PowerShell version/architecture:
Preview dependency versions:
Same account/tenant verified locally: yes / no

Mode             Connect          GET status   Scheme   Proof present   Outcome
MSAL bearer      pass/fail        ...          ...      ...             ...
OneAuth bearer   pass/fail        ...          ...      ...             ...
OneAuth DPoP     pass/fail        ...          ...      ...             ...

Failure phase and sanitized exception/error/substatus:
Interactive authentication required: yes / no
```

Do not attach access tokens, DPoP proofs, account/tenant identifiers, Graph response
bodies, raw debug traces, or authentication caches. Review diagnostics for
sensitive data before sharing.

Exit all test processes. Switch settings used here are process-local. If you also
set user/machine-wide environment variables outside these instructions, restore
their previous values. The test module was imported by path and need not be
installed or uninstalled globally; return to a fresh session with your normal SDK.
Do not clear shared WAM accounts or caches as cleanup.

## References

- [Experiment overview](OneAuth-preview.md)
- [Original preview quick start](https://gist.github.com/g2vinay/9d85a9384fad6e39ddd0227f6719adb2)
- The restored `Azure.Identity.Broker` preview package README documents runtime
  limits and `TokenBindingNotSupportedByBroker`.

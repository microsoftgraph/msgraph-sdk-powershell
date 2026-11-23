# OneAuth/WAM private-preview experiment

This is an opt-in experiment for Windows and PowerShell 7, not a production release.
Normal builds retain their existing packages and authentication pipeline.
The setup follows [IdentityBrokersOneAuthWam.md](https://gist.github.com/g2vinay/9d85a9384fad6e39ddd0227f6719adb2).

For source/binary transfer and copy-paste instructions for all three authentication
modes on another machine, see the [testing handoff](OneAuth-testing-handoff.md).

## Build

You need Feed Reader access to both private feeds and a team-approved client ID.
No feed credentials are checked in. From the repository root, restore interactively
with your authorized work account, then build:

```powershell
dotnet restore .\src\Authentication\Authentication.sln --configfile .\src\Authentication\NuGet.OneAuthPreview.Config --interactive -p:EnableOneAuthPreview=true
.\tools\GenerateAuthenticationModule.ps1 -Build -OneAuthPreview
```

The switch is forwarded through the shared build helper to Authentication's build script.
It also applies to the build performed by `-Run` and to `dotnet test` when using `-Test`.
For a direct build without the generation/metadata steps, use
`.\src\Authentication\Authentication\build-module.ps1 -OneAuthPreview`.

The preview pins Azure.Core `1.64.0-beta.20261105.101`,
Azure.Identity.Broker `1.8.0-beta.20261105.101`, and
Microsoft.Authentication.Client `12.1.0-rc1`. This Azure.Core build also contains
the Azure.Identity types, so preview builds omit the separate Azure.Identity package.
Its dependencies require Microsoft.Bcl.AsyncInterfaces and System.Text.Json `10.0.10`.
The experimental proof APIs are enabled only in preview builds (`AZID0005`).
The module preserves the OneAuth native runtime folders for each Windows architecture;
the existing private assembly loader selects the runtime matching the PowerShell process.
Do not redistribute the private-preview binaries without the package owners' approval.

## Run

Start a fresh Windows PowerShell **7** process. Set these before importing the built module
or creating a credential. Use `false` for OneAuth bearer or `true` for DPoP:

```powershell
$env:AZURE_IDENTITY_BROKER_ENABLE_ONEAUTH = 'true'
$env:AZURE_IDENTITY_BROKER_ENABLE_ONEAUTH_DPOP = 'true'
Import-Module .\src\Authentication\Authentication\artifacts\Microsoft.Graph.Authentication.psd1
Connect-MgGraph -ClientId '<approved-client-id>' -TenantId '<tenant-id>' `
    -Scopes 'https://graph.microsoft.com/.default' -ContextScope Process -NoWelcome
Invoke-MgGraphRequest -Method GET -Uri 'https://graph.microsoft.com/v1.0/me'
Disconnect-MgGraph
```

WAM must be enabled in the Graph options (`Get-MgGraphOption` / `Set-MgGraphOption`).
For a custom client ID, use `Set-MgGraphOption -DisableLoginByWAM $false` if needed.
The experiment uses the default Windows account when no login hint is supplied.
Automatic interactive authentication is disabled, as in the gist: a silent sign-in
that needs user interaction throws `AuthenticationRequiredException`. It does not
silently fall back to another authentication flow. Use a client/account with consent
already granted. No live sign-in is performed by the automated tests.

DPoP also opts into OneAuth. An explicit AppContext switch value takes precedence over
the corresponding environment variable, even when the switch is `false`.
Do not change either mode in a running process. To return to MSAL, disable **both**
settings and restart; rebuild without `-OneAuthPreview` to restore stable dependencies.

## Request behavior and limits

DPoP requests require HTTPS and a trusted Graph host. Every outgoing attempt gets a
new proof bound to its HTTP method, URI, and access token, including throttling retries.
If the proof provider renews its access token, the request uses that token.
Missing proof providers, non-DPoP tokens, and empty proofs fail before transmission.
HTTP redirects are not followed in DPoP mode.

The pipeline remembers resource nonces per authority and handles one 401 nonce or CAE
claims challenge. Challenge replay is limited to requests with no body or a
`ByteArrayContent` body (including `StringContent`); streaming bodies are not replayed.
Device-code, app-only, managed-identity, environment-variable, and user-provided-token
flows are rejected while OneAuth is opted in. Disable both switches to use those flows.

OneAuth owns its cache; MSAL authentication records and persistence options are not reused.
Disconnect clears the Graph session, not the shared OneAuth/WAM account or token cache.
`Disconnect-MgGraph -SignOutFromBroker` is explicitly unsupported during this experiment.

## Focused offline checks

```powershell
dotnet test .\src\Authentication\Authentication.Test\Microsoft.Graph.Authentication.Test.csproj -f net8.0 -p:EnableOneAuthPreview=true --filter 'FullyQualifiedName~DPoPAuthenticationHandlerTests|FullyQualifiedName~OneAuthPreviewTests|FullyQualifiedName~AuthenticationHelpersTests|FullyQualifiedName~AssemblyIsolationTests'
```

Offline checks do not establish that the approved client, WAM account, tenant policies,
or Graph deployment supports DPoP. Complete the live smoke test above in the authorized
Windows session before treating the experiment as end-to-end validated.

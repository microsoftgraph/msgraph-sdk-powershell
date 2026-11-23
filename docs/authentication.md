# Auth with Microsoft Graph PowerShell

The Microsoft Graph PowerShell module supports two types of authentication:

- Delegated Access
- App-only Access

## Delegated Access

Delegated access uses a public client to get an access token and consume Microsoft Graph resources on behalf of the signed-in user.

Microsoft Graph PowerShell module supports the following delegated access scenarios:

### Interactive Browser

On Windows, interactive authentication uses Web Account Manager (WAM) by default. On other platforms, it uses the browser. Request only the delegated permissions required for your operations; some permissions require administrator consent. If you omit `-Scopes`, the default is `User.Read`.

```PowerShell
Connect-MgGraph -Scopes "User.ReadBasic.All", "Calendars.Read.Shared"
```

Use `-LoginHint` to pre-populate a known account during browser or WAM sign-in:

```PowerShell
Connect-MgGraph -Scopes "User.ReadBasic.All" -LoginHint "user@contoso.com"
```

A matching cached authentication record can be reused for that account. An account picker, consent, or other authentication prompt may still be required by the identity provider or tenant policy; `-LoginHint` does not guarantee silent sign-in. It is not used by device code authentication.

### Custom application

To use your own application registration instead of the default Microsoft Graph PowerShell application:

```PowerShell
Connect-MgGraph -ClientId "YOUR_APP_CLIENT_ID" -TenantId "YOUR_TENANT_ID" -Scopes "User.ReadBasic.All"
```

Configure a public client application with `http://localhost` as a redirect URI for browser sign-in. For WAM sign-in on Windows, also register `ms-appx-web://Microsoft.AAD.BrokerPlugin/<YOUR_APP_CLIENT_ID>`. See [Use delegated access with a custom application](https://learn.microsoft.com/en-us/powershell/microsoftgraph/authentication-commands?view=graph-powershell-1.0#use-delegated-access-with-a-custom-application-for-microsoft-graph-powershell) for registration and access assignment steps.

### Device Code

Use device code authentication when interactive browser or WAM sign-in is unsuitable, provided your tenant's policies allow this flow.

```PowerShell
Connect-MgGraph -Scopes "User.ReadBasic.All", "Calendars.Read.Shared" -UseDeviceCode
```

## App-only Access

App-only access uses a confidential client to get an access token and consume Microsoft Graph resources without a user context (uses an app's context).

Configure Microsoft Graph application permissions and grant administrator consent before connecting. `-Scopes` is for delegated access and is not used with app-only credentials.

Microsoft Graph PowerShell module supports the following app-only access scenarios:

### Client credential via a certificate

Load a certificate with its private key from `Cert:\CurrentUser\My` or `Cert:\LocalMachine\My` using its thumbprint. The current user's store is searched first.

```PowerShell
Connect-MgGraph -ClientId "Client_Id" -TenantId "Tenant_Id" -CertificateThumbprint "Cert_Thumbprint"
```

Load certificate from store using a certificate's subject name.

```PowerShell
Connect-MgGraph -ClientId "Client_Id" -TenantId "Tenant_Id" -CertificateSubjectName "Cert_Subject_Name"
```

Pass a certificate object explicitly, for example from the local machine certificate store.

```PowerShell
$Cert = Get-ChildItem Cert:\LocalMachine\My\$CertThumbprint
Connect-MgGraph -ClientId "Client_Id" -TenantId "Tenant_Id" -Certificate $Cert
```

Using environment variables.

```PowerShell
# Add environment variables to be used by Connect-MgGraph.
$Env:AZURE_CLIENT_ID = "application id of the client app"
$Env:AZURE_TENANT_ID = "Id of your tenant"
$Env:AZURE_CLIENT_CERTIFICATE_PATH = "path to a PFX or PEM-encoded certificate file including private key"

# Tell Connect-MgGraph to use your environment variables.
Connect-MgGraph -EnvironmentVariable
```

### Client credential via client secret

Using a PSCredential object. Supply the application (client) ID as the username and the client secret as the password. Do not store secrets in scripts or source control.

```PowerShell
$ClientSecretCredential = Get-Credential -Username "Client_Id"
# Enter client_secret in the password prompt.
Connect-MgGraph -TenantId "Tenant_Id" -ClientSecretCredential $ClientSecretCredential
```

Using environment variables.

```PowerShell
# Add environment variables to be used by Connect-MgGraph.
$Env:AZURE_CLIENT_ID = "application id of the client app"
$Env:AZURE_TENANT_ID = "Id of your tenant"
$Env:AZURE_CLIENT_SECRET = "secret of the client app"

# Tell Connect-MgGraph to use your environment variables.
Connect-MgGraph -EnvironmentVariable
```

### Managed Identity

Run these commands on an Azure resource configured with the corresponding managed identity. Grant that identity the Microsoft Graph application permissions required by your operations.

System-assigned managed identity

```PowerShell
Connect-MgGraph -Identity
```

User-assigned managed identity

```PowerShell
Connect-MgGraph -Identity -ClientId "User_Assigned_Managed_identity_Client_Id"
```

## Bring Your Own Token

Customers can acquire an access token using their preferred auth library and pass the access token to the Microsoft Graph PowerShell module using `-AccessToken` parameter on `Connect-MgGraph`. The module will then use the provided access token to consume Microsoft Graph resources.

`-AccessToken` requires a `SecureString` and accepts either a delegated or app-only Microsoft Graph token. If your authentication library returns a plain-text token in `$AccessToken`, convert it before connecting:

```PowerShell
$SecureAccessToken = ConvertTo-SecureString -String $AccessToken -AsPlainText -Force
Connect-MgGraph -AccessToken $SecureAccessToken
```

The following considerations should be made before using `-AccessToken`:

### Access Token Expiry

When using `-AccessToken`, we won't have access to the refresh token and the client id needed to refresh an access token when it has expired. Customers should ensure that the task they are running using the provided access token will finish within the access token's `exp` claim (expiry time). This is typically 60 minutes for most access tokens. The expiry time may vary depending on the CAE policy in place.

### Access Token Scopes (scp) Claims

Before using the provided `-AccessToken` to get Microsoft Graph resources, customers should ensure that the access token has the necessary scopes/ permissions needed to access/modify a resource.

## Environments and sovereign clouds

`Connect-MgGraph` targets the global public cloud by default. Use `Get-MgEnvironment` to list available environments and `-Environment` to select one:

```PowerShell
Get-MgEnvironment
Connect-MgGraph -Environment USGov -Scopes "User.ReadBasic.All"
```

BleuCloud, DelosCloud, and GovSGCloud require a custom application registration in the target cloud and Microsoft.Graph.Authentication v2.36.1 or later. Azure China also requires an application registered in that cloud.

```PowerShell
Connect-MgGraph -ClientId "YOUR_APP_CLIENT_ID" -TenantId "YOUR_TENANT_ID" -Environment BleuCloud -Scopes "User.ReadBasic.All"
```

If WAM sign-in hangs in a sovereign cloud, use the custom-application browser sign-in configuration described below.

## Sign out and token caching

Delegated authentication defaults to `-ContextScope CurrentUser`, which securely caches tokens for reuse across PowerShell sessions. Use `-ContextScope Process` to keep tokens in memory for the current PowerShell process. On Windows Subsystem for Linux (WSL), delegated authentication uses `Process` scope. Certificate, client secret, managed identity, and environment-variable authentication default to `Process`; caller-provided access tokens always use `Process`.

`-ContextScope` controls token persistence, not account selection. Use `-LoginHint` to hint at a particular account during interactive sign-in, and verify the connected identity and permissions:

```PowerShell
Get-MgContext
Get-MgContext | Select-Object -ExpandProperty Scopes
Disconnect-MgGraph
```

`Disconnect-MgGraph` clears the SDK's in-memory cache and authentication context and removes the session's authentication record. With `CurrentUser` scope, it also clears persisted MSAL tokens for the session's account when it can be identified; cache clearing can fall back to the full SDK token cache when no matching account is found. Cache-clearing failures are reported as warnings.

The Windows WAM broker cache is not cleared by default, so a subsequent connection may still use Windows single sign-on. To also remove the cached broker account, opt in explicitly:

```PowerShell
Disconnect-MgGraph -SignOutFromBroker
```

**Caution:** The broker store is shared at the operating-system level. This can affect other broker-enabled applications using the same Windows account, and removal can fall back to all accounts for this module if the session's account cannot be identified. The switch only takes effect on Windows when WAM is in use.

## Web Account Manager (WAM)

WAM is a Windows 10+ component that acts as an authentication broker allowing the users of an app benefit from integration with accounts known to Windows, such as the account already signed into an active Windows session.

WAM is enabled by default for interactive sign-in on Windows and cannot be disabled for the default Microsoft Graph PowerShell client ID. Starting with v2.35.1, you can disable WAM for a custom application. Register `http://localhost` as a redirect URI for browser sign-in, then set the option before connecting:

```PowerShell
Set-MgGraphOption -DisableLoginByWAM $true
Connect-MgGraph -ClientId "YOUR_APP_CLIENT_ID" -TenantId "YOUR_TENANT_ID" -Scopes "User.ReadBasic.All"
```

The option persists across PowerShell sessions and applies to subsequent connections. It does not disable WAM for other applications and has no effect on non-Windows platforms or device code authentication.

To re-enable WAM for subsequent interactive connections:

```PowerShell
Set-MgGraphOption -DisableLoginByWAM $false
```

Ensure the custom application's WAM redirect URI is registered as described in [Custom application](#custom-application). In embedded terminals, the WAM sign-in window can appear behind other windows.

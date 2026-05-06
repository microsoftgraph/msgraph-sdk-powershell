### Example 1: Delegated access: Using interactive authentication, where you provide the scopes that you require during your session
```powershell
PS C:\> Connect-MgGraph -Scopes "User.Read.All", "Group.ReadWrite.All"
```
This example shows how to authenticate to graph with scopes.

### Example 2: Delegated access: Using device code flow
```powershell
PS C:\> Connect-MgGraph -Scopes "User.Read.All", "Group.ReadWrite.All" -UseDeviceAuthentication
```
This example shows how to authenticate to graph with scopes and device.

### Example 3: Delegated access: Using your own access token
```powershell
PS C:\> Connect-MgGraph -AccessToken $AccessToken
```
This example shows how to authenticate to graph using an access token.

### Example 4: Delegated access: custom application for Microsoft Graph PowerShell
```powershell
PS C:\> Connect-MgGraph -ClientId <YOUR_NEW_APP_ID> -TenantId <YOUR_TENANT_ID>
```
Follow this [link](https://learn.microsoft.com/en-us/powershell/microsoftgraph/authentication-commands?view=graph-powershell-1.0#using-connect-mggraph) for more information on the steps for creating custom applications.

### Example 5: App-only access: Using client credential with a certificate - Certificate Thumbprint
```powershell
PS C:\> Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -CertificateThumbprint "YOUR_CERT_THUMBPRINT"
```
Follow this [link](https://learn.microsoft.com/en-us/powershell/microsoftgraph/authentication-commands?view=graph-powershell-1.0#using-connect-mggraph) for more information on how to load the certificate.

### Example 6: App-only access: Using client credential with a certificate - Certificate name
```powershell
PS C:\> Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -CertificateName "YOUR_CERT_SUBJECT"
```
Follow this [link](https://learn.microsoft.com/en-us/powershell/microsoftgraph/authentication-commands?view=graph-powershell-1.0#using-connect-mggraph) for more information on how to load the certificate.

### Example 7: App-only access: Using client credential with a certificate - Certificate
```powershell
PS C:\> $Cert = Get-ChildItem Cert:\LocalMachine\My\$CertThumbprint
PS C:\> Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -Certificate $Cert
```
Follow this [link](https://learn.microsoft.com/en-us/powershell/microsoftgraph/authentication-commands?view=graph-powershell-1.0#using-connect-mggraph) for more information on how to load the certificate.


### Example 8: Using client secret credentials
```powershell
PS C:\> $ClientSecretCredential = Get-Credential -Credential "Client_Id"
# Enter client_secret in the password prompt.
PS C:\> Connect-MgGraph -TenantId "Tenant_Id" -ClientSecretCredential $ClientSecretCredential
```
This authentication method is ideal for background interactions. It does not require a user to physically sign in.

### Example 9: Using managed identity: System-assigned managed identity
```powershell
PS C:\> Connect-MgGraph -Identity
```
Uses an automatically managed identity on a service instance. The identity is tied to the lifecycle of a service instance.

### Example 10: Using managed identity: User-assigned managed identity
```powershell
PS C:\> Connect-MgGraph -Identity -ClientId "User_Assigned_Managed_identity_Client_Id"
```
Uses a user created managed identity as a standalone Azure resource.

### Example 11: Connecting to an environment or cloud
```powershell
PS C:\> Get-MgEnvironment
Name         AzureADEndpoint                        GraphEndpoint                           Type
----         ---------------                        -------------                           ----
BleuCloud    https://login.sovcloud-identity.fr     https://graph.svc.sovcloud.fr           Built-in
China        https://login.chinacloudapi.cn         https://microsoftgraph.chinacloudapi.cn Built-in
DelosCloud   https://login.sovcloud-identity.de     https://graph.svc.sovcloud.de           Built-in
Global       https://login.microsoftonline.com      https://graph.microsoft.com             Built-in
GovSGCloud   https://login.sovcloud-identity.sg     https://graph.svc.sovcloud.sg           Built-in
USGov        https://login.microsoftonline.us       https://graph.microsoft.us              Built-in
USGovDoD     https://login.microsoftonline.us       https://dod-graph.microsoft.us          Built-in
PS C:\> Connect-MgGraph -Environment USGov
```
When you use Connect-MgGraph, you can choose to target other environments. By default, Connect-MgGraph targets the global public cloud.

### Example 12: Connecting to a sovereign cloud with a custom application
```powershell
PS C:\> Connect-MgGraph -ClientId "YOUR_APP_CLIENT_ID" -TenantId "YOUR_TENANT_ID" -Environment BleuCloud -Scopes "User.Read.All"
```
Sovereign cloud environments (BleuCloud, DelosCloud, GovSGCloud) require a custom application registration. You cannot use the default Microsoft Graph PowerShell application in these environments. When registering your application, add an additional redirect URI of `ms-appx-web://Microsoft.AAD.BrokerPlugin/<YOUR_APP_CLIENT_ID>` to support WAM broker-based authentication. Requires Microsoft.Graph.Authentication v2.36.1 or later.

### Example 13: Connecting to a sovereign cloud when WAM authentication hangs
```powershell
PS C:\> Set-MgGraphOption -DisableLoginByWAM $true
PS C:\> Connect-MgGraph -ClientId "YOUR_APP_CLIENT_ID" -TenantId "YOUR_TENANT_ID" -Environment BleuCloud
```
If the authentication popup hangs or times out when connecting to a sovereign cloud (for example, from a jumpbox), WAM broker-based login may not work in that environment. Disable WAM to use interactive browser sign-in instead. You only need to run `Set-MgGraphOption -DisableLoginByWAM $true` once; the setting persists across sessions.

### Example 14: Connecting to an environment as a different identity
```powershell
PS C:\> Connect-MgGraph -ContextScope Process
```
To connect as a different identity other than CurrentUser, specify the -ContextScope parameter with the value Process.

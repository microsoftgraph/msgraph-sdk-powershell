---
external help file: Microsoft.Graph.Authentication.dll-Help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/connect-mggraph
schema: 2.0.0
---

# Connect-MgGraph

## SYNOPSIS
Microsoft Graph PowerShell supports two types of authentication: delegated and app-only access. There are a number of cmdlets that can be used to manage the different parameters required during authentication, for example, environment, application ID, and certificate.

## SYNTAX

### UserParameterSet (Default)
```
Connect-MgGraph [[-Scopes] <String[]>] [[-ClientId] <String>] [-TenantId <String>]
 [-ContextScope <ContextScope>] [-Environment <String>] [-UseDeviceCode] [-ClientTimeout <Double>] [-NoWelcome]
 [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

### AppCertificateParameterSet
```
Connect-MgGraph [-ClientId] <String> [[-CertificateSubjectName] <String>] [[-CertificateThumbprint] <String>]
 [-Certificate <X509Certificate2>] [-TenantId <String>] [-ContextScope <ContextScope>] [-Environment <String>]
 [-ClientTimeout <Double>] [-NoWelcome] [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

### IdentityParameterSet
```
Connect-MgGraph [[-ClientId] <String>] [-ContextScope <ContextScope>] [-Environment <String>]
 [-ClientTimeout <Double>] [-Identity] [-NoWelcome] [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

### AppSecretCredentialParameterSet
```
Connect-MgGraph [-ClientSecretCredential <PSCredential>] [-TenantId <String>] [-ContextScope <ContextScope>]
 [-Environment <String>] [-ClientTimeout <Double>] [-NoWelcome] [-ProgressAction <ActionPreference>]
 [<CommonParameters>]
```

### AccessTokenParameterSet
```
Connect-MgGraph [-AccessToken] <SecureString> [-Environment <String>] [-ClientTimeout <Double>] [-NoWelcome]
 [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

### EnvironmentVariableParameterSet
```
Connect-MgGraph [-ContextScope <ContextScope>] [-Environment <String>] [-ClientTimeout <Double>]
 [-EnvironmentVariable] [-NoWelcome] [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

## DESCRIPTION
You must invoke Connect-MgGraph before any commands that access Microsoft Graph. This cmdlet gets the access token using the Microsoft Authentication Library

## EXAMPLES

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
Name     AzureADEndpoint                   GraphEndpoint                           Type
----     ---------------                   -------------                           ----
China    https://login.chinacloudapi.cn    https://microsoftgraph.chinacloudapi.cn Built-in
Global   https://login.microsoftonline.com https://graph.microsoft.com             Built-in
USGov    https://login.microsoftonline.us  https://graph.microsoft.us              Built-in
USGovDoD https://login.microsoftonline.us  https://dod-graph.microsoft.us          Built-in
PS C:\> Connect-MgGraph -Environment USGov
```

When you use Connect-MgGraph, you can choose to target other environments. By default, Connect-MgGraph targets the global public cloud.

### Example 12: Connecting to an environment as a different identity
```powershell
PS C:\> Connect-MgGraph -ContextScope Process
```

To connect as a different identity other than CurrentUser, specify the -ContextScope parameter with the value Process.

## PARAMETERS

### -AccessToken
Specifies a bearer token for Microsoft Graph service.
Access tokens do timeout and you'll have to handle their refresh.

```yaml
Type: SecureString
Parameter Sets: AccessTokenParameterSet
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Certificate
An X.509 certificate supplied during invocation.

```yaml
Type: X509Certificate2
Parameter Sets: AppCertificateParameterSet
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificateSubjectName
The subject distinguished name of a certificate.
The Certificate will be retrieved from the current user's certificate store.

```yaml
Type: String
Parameter Sets: AppCertificateParameterSet
Aliases: CertificateSubject, CertificateName

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificateThumbprint
The thumbprint of your certificate.
The Certificate will be retrieved from the current user's certificate store.

```yaml
Type: String
Parameter Sets: AppCertificateParameterSet
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientId
The client id of your application.

```yaml
Type: String
Parameter Sets: UserParameterSet, IdentityParameterSet
Aliases: AppId, ApplicationId

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: String
Parameter Sets: AppCertificateParameterSet
Aliases: AppId, ApplicationId

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientSecretCredential
The PSCredential object provides the application ID and client secret for service principal credentials.
For more information about the PSCredential object, type Get-Help Get-Credential.

```yaml
Type: PSCredential
Parameter Sets: AppSecretCredentialParameterSet
Aliases: SecretCredential, Credential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientTimeout
Sets the HTTP client timeout in seconds.

```yaml
Type: Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContextScope
Determines the scope of authentication context.
This accepts \`Process\` for the current process, or \`CurrentUser\` for all sessions started by user.

```yaml
Type: ContextScope
Parameter Sets: UserParameterSet, AppCertificateParameterSet, IdentityParameterSet, AppSecretCredentialParameterSet, EnvironmentVariableParameterSet
Aliases:
Accepted values: Process, CurrentUser

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Environment
The name of the national cloud environment to connect to.
By default global cloud is used.

```yaml
Type: String
Parameter Sets: (All)
Aliases: EnvironmentName, NationalCloud

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnvironmentVariable
Allows for authentication using environment variables configured on the host machine.
See https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/identity/Azure.Identity#environment-variables.

```yaml
Type: SwitchParameter
Parameter Sets: EnvironmentVariableParameterSet
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Login using a Managed Identity.

```yaml
Type: SwitchParameter
Parameter Sets: IdentityParameterSet
Aliases: ManagedIdentity, ManagedServiceIdentity, MSI

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWelcome
Hides the welcome message.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scopes
An array of delegated permissions to consent to.

```yaml
Type: String[]
Parameter Sets: UserParameterSet
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantId
The id of the tenant to connect to.
You can also use this parameter to specify your sign-in audience.
i.e., common, organizations, or consumers.
See https://docs.microsoft.com/en-us/azure/active-directory/develop/msal-client-application-configuration#authority.

```yaml
Type: String
Parameter Sets: UserParameterSet, AppCertificateParameterSet, AppSecretCredentialParameterSet
Aliases: Audience, Tenant

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UseDeviceCode
Use device code authentication instead of a browser control.

```yaml
Type: SwitchParameter
Parameter Sets: UserParameterSet
Aliases: UseDeviceAuthentication, DeviceCode, DeviceAuth, Device

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None
## OUTPUTS

### System.Object
## NOTES

## RELATED LINKS

[https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/connect-mggraph](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/connect-mggraph)


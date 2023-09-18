---
external help file: Microsoft.Graph.Authentication.dll-Help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/connect-mggraph
schema: 2.0.0
---

# Connect-MgGraph

## SYNOPSIS
{{ Fill in the Synopsis }}

## SYNTAX

### UserParameterSet (Default)
```
Connect-MgGraph [[-Scopes] <String[]>] [[-ClientId] <String>] [-TenantId <String>]
 [-ContextScope <ContextScope>] [-Environment <String>] [-UseDeviceCode] [-ClientTimeout <Double>] [-NoWelcome]
 [-Break] [<CommonParameters>]
```

### AppCertificateParameterSet
```
Connect-MgGraph [-ClientId] <String> [[-CertificateSubjectName] <String>] [[-CertificateThumbprint] <String>]
 [-Certificate <X509Certificate2>] [-TenantId <String>] [-ContextScope <ContextScope>] [-Environment <String>]
 [-ClientTimeout <Double>] [-NoWelcome] [-Break] [<CommonParameters>]
```

### IdentityParameterSet
```
Connect-MgGraph [[-ClientId] <String>] [-ContextScope <ContextScope>] [-Environment <String>]
 [-ClientTimeout <Double>] [-Identity] [-NoWelcome] [-Break] [<CommonParameters>]
```

### AppSecretCredentialParameterSet
```
Connect-MgGraph [-ClientSecretCredential <PSCredential>] [-TenantId <String>] [-ContextScope <ContextScope>]
 [-Environment <String>] [-ClientTimeout <Double>] [-NoWelcome] [-Break] [<CommonParameters>]
```

### AccessTokenParameterSet
```
Connect-MgGraph [-AccessToken] <SecureString> [-Environment <String>] [-ClientTimeout <Double>] [-NoWelcome]
 [-Break] [<CommonParameters>]
```

### EnvironmentVariableParameterSet
```
Connect-MgGraph [-ContextScope <ContextScope>] [-Environment <String>] [-ClientTimeout <Double>]
 [-EnvironmentVariable] [-NoWelcome] [-Break] [<CommonParameters>]
```

## DESCRIPTION
{{ Fill in the Description }}

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

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

### -Break
Wait for .NET debugger to attach

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


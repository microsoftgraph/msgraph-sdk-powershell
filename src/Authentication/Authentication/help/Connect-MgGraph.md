---
external help file: Microsoft.Graph.Authentication.dll-Help.xml
Module Name: Microsoft.Graph.Authentication
online version:
schema: 2.0.0
---

# Connect-MgGraph

## SYNOPSIS
{{ Fill in the Synopsis }}

## SYNTAX

### UserParameterSet (Default)
```
Connect-MgGraph [[-Scopes] <String[]>] [[-TenantId] <String>] [-ForceRefresh] [-ContextScope <ContextScope>]
 [-Environment <String>] [<CommonParameters>]
```

### AppParameterSet
```
Connect-MgGraph [-ClientId] <String> [[-CertificateName] <String>] [[-CertificateThumbprint] <String>]
 [[-TenantId] <String>] [-ForceRefresh] [-ContextScope <ContextScope>] [-Environment <String>]
 [-Certificate <X509Certificate2>] [<CommonParameters>]
```

### AccessTokenParameterSet
```
Connect-MgGraph [[-AccessToken] <String>] [[-TenantId] <String>] [-ForceRefresh] [-ContextScope <ContextScope>]
 [-Environment <String>] [<CommonParameters>]
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
Type: String
Parameter Sets: AccessTokenParameterSet
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Certificate
An x509 Certificate supplied during invocation

```yaml
Type: X509Certificate2
Parameter Sets: AppParameterSet
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificateName
The name of your certificate.
The Certificate will be retrieved from the current user's certificate store.

```yaml
Type: String
Parameter Sets: AppParameterSet
Aliases: CertificateSubject

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
Parameter Sets: AppParameterSet
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
Parameter Sets: AppParameterSet
Aliases: AppId

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContextScope
Determines the scope of authentication context.
This accepts \`Process\` for the current process, or \`CurrentUser\` for all sessions started by user.

```yaml
Type: ContextScope
Parameter Sets: (All)
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

### -ForceRefresh
Forces the command to get a new access token silently.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
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

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
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

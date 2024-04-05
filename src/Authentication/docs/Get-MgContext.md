---
external help file: Microsoft.Graph.Authentication.dll-Help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mgcontext
schema: 2.0.0
---

# Get-MgContext

## SYNOPSIS
Get-MgContext is used to retrieve the details about your current session, which include:  - ClientID - TenantID - Certificate Thumbprint - Scopes consented to - AuthType: Delegated or app-only - AuthProviderType - CertificateName - Account - AppName - ContextScope - Certificate - PSHostVersion - ClientTimeOut.

## SYNTAX

```
Get-MgContext [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

## DESCRIPTION
Retrieves session details.

## EXAMPLES

### Example 1: Using Get-MgContext
```powershell
PS C:\> Get-MgContext
ClientId              : 615e6e7c-aa11-4402-91a1-6234967405d5
TenantId              : 9f32a42e-6782-4b96-a4d3-e0828a292569
CertificateThumbprint :
Scopes                : {AppRoleAssignment.ReadWrite.All, Directory.AccessAsUser.All, Directory.ReadWrite.All, EntitlementManagement.ReadWrite.All...}
AuthType              : Delegated
AuthProviderType      : InteractiveAuthenticationProvider
CertificateName       :
Account               : admin@Contoso.com
AppName               : Microsoft Graph PowerShell
ContextScope          : CurrentUser
Certificate           :
PSHostVersion         : 5.1.17763.1
ClientTimeout         : 00:05:00
```

Retrieves session details.

### Example 2: Using Get-MgContext: Retrieve all scopes you've consented to
```powershell
PS C:\> Get-MgContext | Select -ExpandProperty Scopes
AppRoleAssignment.ReadWrite.All
Directory.AccessAsUser.All
Directory.ReadWrite.All
EntitlementManagement.ReadWrite.All
Group.ReadWrite.All
openid
Organization.Read.All
profile
RoleManagement.ReadWrite.Directory
User.Read
User.ReadWrite.All
```

Retrieves all scopes.

## PARAMETERS

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None
## OUTPUTS

### Microsoft.Graph.PowerShell.Authentication.IAuthContext
## NOTES

## RELATED LINKS

[https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mgcontext](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mgcontext)


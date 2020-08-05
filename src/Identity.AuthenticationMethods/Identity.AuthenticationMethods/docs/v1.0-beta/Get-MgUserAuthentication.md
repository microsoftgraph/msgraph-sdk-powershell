---
external help file:
Module Name: Microsoft.Graph.Identity.AuthenticationMethods
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.authenticationmethods/get-mguserauthentication
schema: 2.0.0
---

# Get-MgUserAuthentication

## SYNOPSIS
Get authentication from users

## SYNTAX

### Get (Default)
```
Get-MgUserAuthentication -UserId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserAuthentication -InputObject <IIdentityAuthenticationMethodsIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get authentication from users

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityAuthenticationMethodsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityAuthenticationMethodsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthentication

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IIdentityAuthenticationMethodsIdentity>: Identity Parameter
  - `[AuthenticationMethodId <String>]`: key: authenticationMethod-id of authenticationMethod
  - `[LongRunningOperationId <String>]`: key: longRunningOperation-id of longRunningOperation
  - `[PasswordAuthenticationMethodId <String>]`: key: passwordAuthenticationMethod-id of passwordAuthenticationMethod
  - `[PhoneAuthenticationMethodId <String>]`: key: phoneAuthenticationMethod-id of phoneAuthenticationMethod
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS


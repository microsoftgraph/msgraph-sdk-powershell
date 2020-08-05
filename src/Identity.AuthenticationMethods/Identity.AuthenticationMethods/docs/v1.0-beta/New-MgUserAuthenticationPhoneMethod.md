---
external help file:
Module Name: Microsoft.Graph.Identity.AuthenticationMethods
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.authenticationmethods/new-mguserauthenticationphonemethod
schema: 2.0.0
---

# New-MgUserAuthenticationPhoneMethod

## SYNOPSIS
Create new navigation property to phoneMethods for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserAuthenticationPhoneMethod -UserId <String> [-Id <String>] [-PhoneNumber <String>]
 [-PhoneType <String>] [-SmsSignInState <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserAuthenticationPhoneMethod -UserId <String> -BodyParameter <IMicrosoftGraphPhoneAuthenticationMethod>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserAuthenticationPhoneMethod -InputObject <IIdentityAuthenticationMethodsIdentity>
 -BodyParameter <IMicrosoftGraphPhoneAuthenticationMethod> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserAuthenticationPhoneMethod -InputObject <IIdentityAuthenticationMethodsIdentity> [-Id <String>]
 [-PhoneNumber <String>] [-PhoneType <String>] [-SmsSignInState <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to phoneMethods for users

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

### -BodyParameter
phoneAuthenticationMethod
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhoneAuthenticationMethod
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PhoneNumber
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PhoneType
authenticationPhoneType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SmsSignInState
authenticationMethodSignInState

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

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
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityAuthenticationMethodsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhoneAuthenticationMethod

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhoneAuthenticationMethod

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPhoneAuthenticationMethod>: phoneAuthenticationMethod
  - `[Id <String>]`: Read-only.
  - `[PhoneNumber <String>]`: 
  - `[PhoneType <String>]`: authenticationPhoneType
  - `[SmsSignInState <String>]`: authenticationMethodSignInState

INPUTOBJECT <IIdentityAuthenticationMethodsIdentity>: Identity Parameter
  - `[AuthenticationMethodId <String>]`: key: authenticationMethod-id of authenticationMethod
  - `[LongRunningOperationId <String>]`: key: longRunningOperation-id of longRunningOperation
  - `[PasswordAuthenticationMethodId <String>]`: key: passwordAuthenticationMethod-id of passwordAuthenticationMethod
  - `[PhoneAuthenticationMethodId <String>]`: key: phoneAuthenticationMethod-id of phoneAuthenticationMethod
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS


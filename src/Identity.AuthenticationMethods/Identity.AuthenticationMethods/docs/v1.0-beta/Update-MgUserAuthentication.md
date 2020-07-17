---
external help file:
Module Name: Microsoft.Graph.Identity.AuthenticationMethods
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.authenticationmethods/update-mguserauthentication
schema: 2.0.0
---

# Update-MgUserAuthentication

## SYNOPSIS
Update the navigation property authentication in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserAuthentication -UserId <String> [-Id <String>] [-Methods <IMicrosoftGraphAuthenticationMethod[]>]
 [-Operations <IMicrosoftGraphLongRunningOperation[]>]
 [-PasswordMethods <IMicrosoftGraphPasswordAuthenticationMethod[]>]
 [-PhoneMethods <IMicrosoftGraphPhoneAuthenticationMethod[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgUserAuthentication -UserId <String> -BodyParameter <IMicrosoftGraphAuthentication> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserAuthentication -InputObject <IIdentityAuthenticationMethodsIdentity>
 -BodyParameter <IMicrosoftGraphAuthentication> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserAuthentication -InputObject <IIdentityAuthenticationMethodsIdentity> [-Id <String>]
 [-Methods <IMicrosoftGraphAuthenticationMethod[]>] [-Operations <IMicrosoftGraphLongRunningOperation[]>]
 [-PasswordMethods <IMicrosoftGraphPasswordAuthenticationMethod[]>]
 [-PhoneMethods <IMicrosoftGraphPhoneAuthenticationMethod[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property authentication in users

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
authentication
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthentication
Parameter Sets: Update, UpdateViaIdentity
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Methods
.
To construct, see NOTES section for METHODS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationMethod[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Operations
.
To construct, see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLongRunningOperation[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PasswordMethods
.
To construct, see NOTES section for PASSWORDMETHODS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPasswordAuthenticationMethod[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PhoneMethods
.
To construct, see NOTES section for PHONEMETHODS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhoneAuthenticationMethod[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthentication

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAuthentication>: authentication
  - `[Id <String>]`: Read-only.
  - `[Methods <IMicrosoftGraphAuthenticationMethod[]>]`: 
    - `[Id <String>]`: Read-only.
  - `[Operations <IMicrosoftGraphLongRunningOperation[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[ResourceLocation <String>]`: 
    - `[Status <String>]`: longRunningOperationStatus
    - `[StatusDetail <String>]`: 
  - `[PasswordMethods <IMicrosoftGraphPasswordAuthenticationMethod[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreationDateTime <DateTime?>]`: 
    - `[Password <String>]`: 
  - `[PhoneMethods <IMicrosoftGraphPhoneAuthenticationMethod[]>]`: 
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

METHODS <IMicrosoftGraphAuthenticationMethod[]>: .
  - `[Id <String>]`: Read-only.

OPERATIONS <IMicrosoftGraphLongRunningOperation[]>: .
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[ResourceLocation <String>]`: 
  - `[Status <String>]`: longRunningOperationStatus
  - `[StatusDetail <String>]`: 

PASSWORDMETHODS <IMicrosoftGraphPasswordAuthenticationMethod[]>: .
  - `[Id <String>]`: Read-only.
  - `[CreationDateTime <DateTime?>]`: 
  - `[Password <String>]`: 

PHONEMETHODS <IMicrosoftGraphPhoneAuthenticationMethod[]>: .
  - `[Id <String>]`: Read-only.
  - `[PhoneNumber <String>]`: 
  - `[PhoneType <String>]`: authenticationPhoneType
  - `[SmsSignInState <String>]`: authenticationMethodSignInState

## RELATED LINKS


---
external help file:
Module Name: Microsoft.Graph.Identity.AuthenticationMethods
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.authenticationmethods/new-mguserauthenticationoperation
schema: 2.0.0
---

# New-MgUserAuthenticationOperation

## SYNOPSIS
Create new navigation property to operations for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserAuthenticationOperation -UserId <String> [-CreatedDateTime <DateTime>] [-Id <String>]
 [-LastActionDateTime <DateTime>] [-ResourceLocation <String>] [-Status <String>] [-StatusDetail <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserAuthenticationOperation -UserId <String> -BodyParameter <IMicrosoftGraphLongRunningOperation>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserAuthenticationOperation -InputObject <IIdentityAuthenticationMethodsIdentity>
 -BodyParameter <IMicrosoftGraphLongRunningOperation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserAuthenticationOperation -InputObject <IIdentityAuthenticationMethodsIdentity>
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastActionDateTime <DateTime>] [-ResourceLocation <String>]
 [-Status <String>] [-StatusDetail <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to operations for users

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
longRunningOperation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLongRunningOperation
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -LastActionDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceLocation
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

### -Status
longRunningOperationStatus

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

### -StatusDetail
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLongRunningOperation

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLongRunningOperation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphLongRunningOperation>: longRunningOperation
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[ResourceLocation <String>]`: 
  - `[Status <String>]`: longRunningOperationStatus
  - `[StatusDetail <String>]`: 

INPUTOBJECT <IIdentityAuthenticationMethodsIdentity>: Identity Parameter
  - `[AuthenticationMethodId <String>]`: key: authenticationMethod-id of authenticationMethod
  - `[LongRunningOperationId <String>]`: key: longRunningOperation-id of longRunningOperation
  - `[PasswordAuthenticationMethodId <String>]`: key: passwordAuthenticationMethod-id of passwordAuthenticationMethod
  - `[PhoneAuthenticationMethodId <String>]`: key: phoneAuthenticationMethod-id of phoneAuthenticationMethod
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS


---
external help file: Microsoft.Graph.DeviceManagement.Administration-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementexchangeonpremispolicy
schema: 2.0.0
---

# New-MgDeviceManagementExchangeOnPremisPolicy

## SYNOPSIS
The list of Exchange On Premisis policies configured by the tenant.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementExchangeOnPremisPolicy
 [-AccessRules <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>] [-AdditionalProperties <Hashtable>]
 [-ConditionalAccessSettings <IMicrosoftGraphOnPremisesConditionalAccessSettings>]
 [-DefaultAccessLevel <String>] [-Id <String>]
 [-KnownDeviceClasses <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>]
 [-NotificationContentInputFile <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementExchangeOnPremisPolicy
 -BodyParameter <IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
The list of Exchange On Premisis policies configured by the tenant.

## EXAMPLES

## PARAMETERS

### -AccessRules
The list of device access rules in Exchange.
The access rules apply globally to the entire Exchange organization
To construct, see NOTES section for ACCESSRULES properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementExchangeAccessRule[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Singleton entity which represents the Exchange OnPremises policy configured for a tenant.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConditionalAccessSettings
Singleton entity which represents the Exchange OnPremises Conditional Access Settings for a tenant.
To construct, see NOTES section for CONDITIONALACCESSSETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphOnPremisesConditionalAccessSettings
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultAccessLevel
deviceManagementExchangeAccessLevel

```yaml
Type: String
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KnownDeviceClasses
The list of device classes known to Exchange
To construct, see NOTES section for KNOWNDEVICECLASSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementExchangeDeviceClass[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationContentInputFile
Input File for NotificationContent (Notification text that will be sent to users quarantined by this policy.
This is UTF8 encoded byte array HTML.)

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSRULES <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>: The list of device access rules in Exchange. The access rules apply globally to the entire Exchange organization
  - `[AccessLevel <String>]`: deviceManagementExchangeAccessLevel
  - `[DeviceClass <IMicrosoftGraphDeviceManagementExchangeDeviceClass>]`: Device Class in Exchange.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: Name of the device class which will be impacted by this rule.
    - `[Type <String>]`: deviceManagementExchangeAccessRuleType

BODYPARAMETER <IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy>: Singleton entity which represents the Exchange OnPremises policy configured for a tenant.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AccessRules <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>]`: The list of device access rules in Exchange. The access rules apply globally to the entire Exchange organization
    - `[AccessLevel <String>]`: deviceManagementExchangeAccessLevel
    - `[DeviceClass <IMicrosoftGraphDeviceManagementExchangeDeviceClass>]`: Device Class in Exchange.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: Name of the device class which will be impacted by this rule.
      - `[Type <String>]`: deviceManagementExchangeAccessRuleType
  - `[ConditionalAccessSettings <IMicrosoftGraphOnPremisesConditionalAccessSettings>]`: Singleton entity which represents the Exchange OnPremises Conditional Access Settings for a tenant.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Enabled <Boolean?>]`: Indicates if on premises conditional access is enabled for this organization
    - `[ExcludedGroups <String[]>]`: User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.
    - `[IncludedGroups <String[]>]`: User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.
    - `[OverrideDefaultRule <Boolean?>]`: Override the default access rule when allowing a device to ensure access is granted.
  - `[DefaultAccessLevel <String>]`: deviceManagementExchangeAccessLevel
  - `[KnownDeviceClasses <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>]`: The list of device classes known to Exchange
  - `[NotificationContent <Byte[]>]`: Notification text that will be sent to users quarantined by this policy. This is UTF8 encoded byte array HTML.

CONDITIONALACCESSSETTINGS <IMicrosoftGraphOnPremisesConditionalAccessSettings>: Singleton entity which represents the Exchange OnPremises Conditional Access Settings for a tenant.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Enabled <Boolean?>]`: Indicates if on premises conditional access is enabled for this organization
  - `[ExcludedGroups <String[]>]`: User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.
  - `[IncludedGroups <String[]>]`: User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.
  - `[OverrideDefaultRule <Boolean?>]`: Override the default access rule when allowing a device to ensure access is granted.

KNOWNDEVICECLASSES <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>: The list of device classes known to Exchange
  - `[Name <String>]`: Name of the device class which will be impacted by this rule.
  - `[Type <String>]`: deviceManagementExchangeAccessRuleType

## RELATED LINKS

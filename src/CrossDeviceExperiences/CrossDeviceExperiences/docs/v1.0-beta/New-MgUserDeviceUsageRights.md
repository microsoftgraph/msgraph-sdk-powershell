---
external help file:
Module Name: Microsoft.Graph.Beta.CrossDeviceExperiences
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.crossdeviceexperiences/new-mguserdeviceusagerights
schema: 2.0.0
---

# New-MgBetaUserDeviceUsageRights

## SYNOPSIS
Create new navigation property to usageRights for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaUserDeviceUsageRights -DeviceId <String> -UserId <String> [-AdditionalProperties <Hashtable>]
 [-CatalogId <String>] [-Id <String>] [-ServiceIdentifier <String>] [-State <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaUserDeviceUsageRights -DeviceId <String> -UserId <String> -BodyParameter <IMicrosoftGraphUsageRight>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaUserDeviceUsageRights -InputObject <ICrossDeviceExperiencesIdentity>
 -BodyParameter <IMicrosoftGraphUsageRight> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaUserDeviceUsageRights -InputObject <ICrossDeviceExperiencesIdentity> [-AdditionalProperties <Hashtable>]
 [-CatalogId <String>] [-Id <String>] [-ServiceIdentifier <String>] [-State <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to usageRights for users

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
usageRight
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUsageRight
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CatalogId
Product id corresponding to the usage right.

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

### -DeviceId
key: id of device

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

### -Id
The unique idenfier for an entity.
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ICrossDeviceExperiencesIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ServiceIdentifier
Identifier of the service corresponding to the usage right.

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

### -State
usageRightState

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
key: id of user

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

### Microsoft.Graph.Beta.PowerShell.Models.ICrossDeviceExperiencesIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUsageRight

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUsageRight

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUsageRight>: usageRight
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CatalogId <String>]`: Product id corresponding to the usage right.
  - `[ServiceIdentifier <String>]`: Identifier of the service corresponding to the usage right.
  - `[State <String>]`: usageRightState

INPUTOBJECT <ICrossDeviceExperiencesIdentity>: Identity Parameter
  - `[ActivityHistoryItemId <String>]`: key: id of activityHistoryItem
  - `[CommandId <String>]`: key: id of command
  - `[DeviceId <String>]`: key: id of device
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[ExtensionId <String>]`: key: id of extension
  - `[UsageRightId <String>]`: key: id of usageRight
  - `[UserActivityId <String>]`: key: id of userActivity
  - `[UserId <String>]`: key: id of user

## RELATED LINKS


---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/search-mgdevicemanagementimporteddeviceidentityexistingidentity
schema: 2.0.0
---

# Search-MgDeviceManagementImportedDeviceIdentityExistingIdentity

## SYNOPSIS
Invoke action searchExistingIdentities

## SYNTAX

### SearchExpanded (Default)
```
Search-MgDeviceManagementImportedDeviceIdentityExistingIdentity [-AdditionalProperties <Hashtable>]
 [-ImportedDeviceIdentities <IMicrosoftGraphImportedDeviceIdentity[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Search
```
Search-MgDeviceManagementImportedDeviceIdentityExistingIdentity
 -BodyParameter <IPathsHi19O6DevicemanagementImporteddeviceidentitiesMicrosoftGraphSearchexistingidentitiesPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action searchExistingIdentities

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: SearchExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsHi19O6DevicemanagementImporteddeviceidentitiesMicrosoftGraphSearchexistingidentitiesPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Search
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ImportedDeviceIdentities
.
To construct, please use Get-Help -Online and see NOTES section for IMPORTEDDEVICEIDENTITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImportedDeviceIdentity[]
Parameter Sets: SearchExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsHi19O6DevicemanagementImporteddeviceidentitiesMicrosoftGraphSearchexistingidentitiesPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImportedDeviceIdentity

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsHi19O6DevicemanagementImporteddeviceidentitiesMicrosoftGraphSearchexistingidentitiesPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ImportedDeviceIdentities <IMicrosoftGraphImportedDeviceIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreatedDateTime <DateTime?>]`: Created Date Time of the device
    - `[Description <String>]`: The description of the device
    - `[EnrollmentState <String>]`: enrollmentState
    - `[ImportedDeviceIdentifier <String>]`: Imported Device Identifier
    - `[ImportedDeviceIdentityType <String>]`: importedDeviceIdentityType
    - `[LastContactedDateTime <DateTime?>]`: Last Contacted Date Time of the device
    - `[LastModifiedDateTime <DateTime?>]`: Last Modified DateTime of the description
    - `[Platform <String>]`: platform

IMPORTEDDEVICEIDENTITIES <IMicrosoftGraphImportedDeviceIdentity[]>: .
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: Created Date Time of the device
  - `[Description <String>]`: The description of the device
  - `[EnrollmentState <String>]`: enrollmentState
  - `[ImportedDeviceIdentifier <String>]`: Imported Device Identifier
  - `[ImportedDeviceIdentityType <String>]`: importedDeviceIdentityType
  - `[LastContactedDateTime <DateTime?>]`: Last Contacted Date Time of the device
  - `[LastModifiedDateTime <DateTime?>]`: Last Modified DateTime of the description
  - `[Platform <String>]`: platform

## RELATED LINKS


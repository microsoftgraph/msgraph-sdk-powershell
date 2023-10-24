---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.actions/import-mgbetadevicemanagementimporteddeviceidentitylist
schema: 2.0.0
---

# Import-MgBetaDeviceManagementImportedDeviceIdentityList

## SYNOPSIS
Invoke action importDeviceIdentityList

## SYNTAX

### ImportExpanded (Default)
```
Import-MgBetaDeviceManagementImportedDeviceIdentityList [-AdditionalProperties <Hashtable>]
 [-ImportedDeviceIdentities <IMicrosoftGraphImportedDeviceIdentity[]>] [-OverwriteImportedDeviceIdentities]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Import
```
Import-MgBetaDeviceManagementImportedDeviceIdentityList
 -BodyParameter <IPaths19M2JbiDevicemanagementImporteddeviceidentitiesMicrosoftGraphImportdeviceidentitylistPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action importDeviceIdentityList

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ImportExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths19M2JbiDevicemanagementImporteddeviceidentitiesMicrosoftGraphImportdeviceidentitylistPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Import
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ImportedDeviceIdentities
.
To construct, see NOTES section for IMPORTEDDEVICEIDENTITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphImportedDeviceIdentity[]
Parameter Sets: ImportExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverwriteImportedDeviceIdentities
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ImportExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths19M2JbiDevicemanagementImporteddeviceidentitiesMicrosoftGraphImportdeviceidentitylistPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphImportedDeviceIdentityResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths19M2JbiDevicemanagementImporteddeviceidentitiesMicrosoftGraphImportdeviceidentitylistPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ImportedDeviceIdentities <IMicrosoftGraphImportedDeviceIdentity[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: Created Date Time of the device
    - `[Description <String>]`: The description of the device
    - `[EnrollmentState <EnrollmentState?>]`: enrollmentState
    - `[ImportedDeviceIdentifier <String>]`: Imported Device Identifier
    - `[ImportedDeviceIdentityType <ImportedDeviceIdentityType?>]`: importedDeviceIdentityType
    - `[LastContactedDateTime <DateTime?>]`: Last Contacted Date Time of the device
    - `[LastModifiedDateTime <DateTime?>]`: Last Modified DateTime of the description
    - `[Platform <Platform?>]`: platform
  - `[OverwriteImportedDeviceIdentities <Boolean?>]`: 

`IMPORTEDDEVICEIDENTITIES <IMicrosoftGraphImportedDeviceIdentity[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: Created Date Time of the device
  - `[Description <String>]`: The description of the device
  - `[EnrollmentState <EnrollmentState?>]`: enrollmentState
  - `[ImportedDeviceIdentifier <String>]`: Imported Device Identifier
  - `[ImportedDeviceIdentityType <ImportedDeviceIdentityType?>]`: importedDeviceIdentityType
  - `[LastContactedDateTime <DateTime?>]`: Last Contacted Date Time of the device
  - `[LastModifiedDateTime <DateTime?>]`: Last Modified DateTime of the description
  - `[Platform <Platform?>]`: platform

## RELATED LINKS


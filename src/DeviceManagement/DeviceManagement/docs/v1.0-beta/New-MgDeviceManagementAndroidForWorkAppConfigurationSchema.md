---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementandroidforworkappconfigurationschema
schema: 2.0.0
---

# New-MgDeviceManagementAndroidForWorkAppConfigurationSchema

## SYNOPSIS
Create new navigation property to androidForWorkAppConfigurationSchemas for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementAndroidForWorkAppConfigurationSchema [-AdditionalProperties <Hashtable>]
 [-ExampleJsonInputFile <String>] [-Id <String>]
 [-SchemaItems <IMicrosoftGraphAndroidForWorkAppConfigurationSchemaItem[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementAndroidForWorkAppConfigurationSchema
 -BodyParameter <IMicrosoftGraphAndroidForWorkAppConfigurationSchema> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to androidForWorkAppConfigurationSchemas for deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Schema describing an Android for Work application's custom configurations.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidForWorkAppConfigurationSchema
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExampleJsonInputFile
Input File for ExampleJson (UTF8 encoded byte array containing example JSON string conforming to this schema that demonstrates how to set the configuration for this app)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchemaItems
Collection of items each representing a named configuration option in the schema
To construct, please use Get-Help -Online and see NOTES section for SCHEMAITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidForWorkAppConfigurationSchemaItem[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidForWorkAppConfigurationSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidForWorkAppConfigurationSchema

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAndroidForWorkAppConfigurationSchema>: Schema describing an Android for Work application's custom configurations.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ExampleJson <Byte[]>]`: UTF8 encoded byte array containing example JSON string conforming to this schema that demonstrates how to set the configuration for this app
  - `[SchemaItems <IMicrosoftGraphAndroidForWorkAppConfigurationSchemaItem[]>]`: Collection of items each representing a named configuration option in the schema
    - `[DataType <String>]`: Data type for a configuration item inside an Android for Work application's custom configuration schema
    - `[DefaultBoolValue <Boolean?>]`: Default value for boolean type items, if specified by the app developer
    - `[DefaultIntValue <Int32?>]`: Default value for integer type items, if specified by the app developer
    - `[DefaultStringArrayValue <String[]>]`: Default value for string array type items, if specified by the app developer
    - `[DefaultStringValue <String>]`: Default value for string type items, if specified by the app developer
    - `[Description <String>]`: Description of what the item controls within the application
    - `[DisplayName <String>]`: Human readable name
    - `[SchemaItemKey <String>]`: Unique key the application uses to identify the item
    - `[Selections <IMicrosoftGraphKeyValuePair[]>]`: List of human readable name/value pairs for the valid values that can be set for this item (Choice and Multiselect items only)
      - `[Name <String>]`: Name for this key-value pair
      - `[Value <String>]`: Value for this key-value pair

SCHEMAITEMS <IMicrosoftGraphAndroidForWorkAppConfigurationSchemaItem[]>: Collection of items each representing a named configuration option in the schema
  - `[DataType <String>]`: Data type for a configuration item inside an Android for Work application's custom configuration schema
  - `[DefaultBoolValue <Boolean?>]`: Default value for boolean type items, if specified by the app developer
  - `[DefaultIntValue <Int32?>]`: Default value for integer type items, if specified by the app developer
  - `[DefaultStringArrayValue <String[]>]`: Default value for string array type items, if specified by the app developer
  - `[DefaultStringValue <String>]`: Default value for string type items, if specified by the app developer
  - `[Description <String>]`: Description of what the item controls within the application
  - `[DisplayName <String>]`: Human readable name
  - `[SchemaItemKey <String>]`: Unique key the application uses to identify the item
  - `[Selections <IMicrosoftGraphKeyValuePair[]>]`: List of human readable name/value pairs for the valid values that can be set for this item (Choice and Multiselect items only)
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair

## RELATED LINKS


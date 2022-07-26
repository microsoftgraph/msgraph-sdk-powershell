---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementandroidmanagedstoreappconfigurationschema
schema: 2.0.0
---

# New-MgDeviceManagementAndroidManagedStoreAppConfigurationSchema

## SYNOPSIS
Create new navigation property to androidManagedStoreAppConfigurationSchemas for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementAndroidManagedStoreAppConfigurationSchema [-AdditionalProperties <Hashtable>]
 [-ExampleJsonInputFile <String>] [-Id <String>]
 [-NestedSchemaItems <IMicrosoftGraphAndroidManagedStoreAppConfigurationSchemaItem[]>]
 [-SchemaItems <IMicrosoftGraphAndroidManagedStoreAppConfigurationSchemaItem[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementAndroidManagedStoreAppConfigurationSchema
 -BodyParameter <IMicrosoftGraphAndroidManagedStoreAppConfigurationSchema> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to androidManagedStoreAppConfigurationSchemas for deviceManagement

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
Schema describing an Android application's custom configurations.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedStoreAppConfigurationSchema
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

### -NestedSchemaItems
Collection of items each representing a named configuration option in the schema.
It contains a flat list of all configuration.
To construct, please use Get-Help -Online and see NOTES section for NESTEDSCHEMAITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedStoreAppConfigurationSchemaItem[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchemaItems
Collection of items each representing a named configuration option in the schema.
It only contains the root-level configuration.
To construct, please use Get-Help -Online and see NOTES section for SCHEMAITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedStoreAppConfigurationSchemaItem[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedStoreAppConfigurationSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedStoreAppConfigurationSchema

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAndroidManagedStoreAppConfigurationSchema>: Schema describing an Android application's custom configurations.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ExampleJson <Byte[]>]`: UTF8 encoded byte array containing example JSON string conforming to this schema that demonstrates how to set the configuration for this app
  - `[NestedSchemaItems <IMicrosoftGraphAndroidManagedStoreAppConfigurationSchemaItem[]>]`: Collection of items each representing a named configuration option in the schema. It contains a flat list of all configuration.
    - `[DataType <String>]`: Data type for a configuration item inside an Android application's custom configuration schema
    - `[DefaultBoolValue <Boolean?>]`: Default value for boolean type items, if specified by the app developer
    - `[DefaultIntValue <Int32?>]`: Default value for integer type items, if specified by the app developer
    - `[DefaultStringArrayValue <String[]>]`: Default value for string array type items, if specified by the app developer
    - `[DefaultStringValue <String>]`: Default value for string type items, if specified by the app developer
    - `[Description <String>]`: Description of what the item controls within the application
    - `[DisplayName <String>]`: Human readable name
    - `[Index <Int32?>]`: Unique index the application uses to maintain nested schema items
    - `[ParentIndex <Int32?>]`: Index of parent schema item to track nested schema items
    - `[SchemaItemKey <String>]`: Unique key the application uses to identify the item
    - `[Selections <IMicrosoftGraphKeyValuePair[]>]`: List of human readable name/value pairs for the valid values that can be set for this item (Choice and Multiselect items only)
      - `[Name <String>]`: Name for this key-value pair
      - `[Value <String>]`: Value for this key-value pair
  - `[SchemaItems <IMicrosoftGraphAndroidManagedStoreAppConfigurationSchemaItem[]>]`: Collection of items each representing a named configuration option in the schema. It only contains the root-level configuration.

NESTEDSCHEMAITEMS <IMicrosoftGraphAndroidManagedStoreAppConfigurationSchemaItem[]>: Collection of items each representing a named configuration option in the schema. It contains a flat list of all configuration.
  - `[DataType <String>]`: Data type for a configuration item inside an Android application's custom configuration schema
  - `[DefaultBoolValue <Boolean?>]`: Default value for boolean type items, if specified by the app developer
  - `[DefaultIntValue <Int32?>]`: Default value for integer type items, if specified by the app developer
  - `[DefaultStringArrayValue <String[]>]`: Default value for string array type items, if specified by the app developer
  - `[DefaultStringValue <String>]`: Default value for string type items, if specified by the app developer
  - `[Description <String>]`: Description of what the item controls within the application
  - `[DisplayName <String>]`: Human readable name
  - `[Index <Int32?>]`: Unique index the application uses to maintain nested schema items
  - `[ParentIndex <Int32?>]`: Index of parent schema item to track nested schema items
  - `[SchemaItemKey <String>]`: Unique key the application uses to identify the item
  - `[Selections <IMicrosoftGraphKeyValuePair[]>]`: List of human readable name/value pairs for the valid values that can be set for this item (Choice and Multiselect items only)
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair

SCHEMAITEMS <IMicrosoftGraphAndroidManagedStoreAppConfigurationSchemaItem[]>: Collection of items each representing a named configuration option in the schema. It only contains the root-level configuration.
  - `[DataType <String>]`: Data type for a configuration item inside an Android application's custom configuration schema
  - `[DefaultBoolValue <Boolean?>]`: Default value for boolean type items, if specified by the app developer
  - `[DefaultIntValue <Int32?>]`: Default value for integer type items, if specified by the app developer
  - `[DefaultStringArrayValue <String[]>]`: Default value for string array type items, if specified by the app developer
  - `[DefaultStringValue <String>]`: Default value for string type items, if specified by the app developer
  - `[Description <String>]`: Description of what the item controls within the application
  - `[DisplayName <String>]`: Human readable name
  - `[Index <Int32?>]`: Unique index the application uses to maintain nested schema items
  - `[ParentIndex <Int32?>]`: Index of parent schema item to track nested schema items
  - `[SchemaItemKey <String>]`: Unique key the application uses to identify the item
  - `[Selections <IMicrosoftGraphKeyValuePair[]>]`: List of human readable name/value pairs for the valid values that can be set for this item (Choice and Multiselect items only)
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair

## RELATED LINKS


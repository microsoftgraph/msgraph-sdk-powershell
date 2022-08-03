---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementgrouppolicyconfiguration
schema: 2.0.0
---

# New-MgDeviceManagementGroupPolicyConfiguration

## SYNOPSIS
Create new navigation property to groupPolicyConfigurations for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementGroupPolicyConfiguration [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphGroupPolicyConfigurationAssignment[]>] [-CreatedDateTime <DateTime>]
 [-DefinitionValues <IMicrosoftGraphGroupPolicyDefinitionValue[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementGroupPolicyConfiguration -BodyParameter <IMicrosoftGraphGroupPolicyConfiguration>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to groupPolicyConfigurations for deviceManagement

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

### -Assignments
The list of group assignments for the configuration.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyConfigurationAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The group policy configuration entity contains the configured values for one or more group policy definitions.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyConfiguration
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the object was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefinitionValues
The list of enabled or disabled group policy definition values for the configuration.
To construct, please use Get-Help -Online and see NOTES section for DEFINITIONVALUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinitionValue[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
User provided description for the resource object.

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

### -DisplayName
User provided name for the resource object.

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

### -LastModifiedDateTime
The date and time the entity was last modified.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTagIds
The list of scope tags for the configuration.

```yaml
Type: System.String[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyConfiguration

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyConfiguration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphGroupPolicyConfigurationAssignment[]>: The list of group assignments for the configuration.
  - `[Id <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

BODYPARAMETER <IMicrosoftGraphGroupPolicyConfiguration>: The group policy configuration entity contains the configured values for one or more group policy definitions.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphGroupPolicyConfigurationAssignment[]>]`: The list of group assignments for the configuration.
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
  - `[DefinitionValues <IMicrosoftGraphGroupPolicyDefinitionValue[]>]`: The list of enabled or disabled group policy definition values for the configuration.
    - `[Id <String>]`: 
    - `[ConfigurationType <GroupPolicyConfigurationType?>]`: Group Policy Configuration Type
    - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
    - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
        - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
          - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
          - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
          - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
          - `[FileName <String>]`: The file name of the ADMX file without the path. For example: edge.admx
          - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
          - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
          - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
          - `[Revision <String>]`: The revision version associated with the file.
          - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
          - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.
        - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The immediate GroupPolicyDefinition children of the category
        - `[DisplayName <String>]`: The string id of the category's display name
        - `[IsRoot <Boolean?>]`: Defines if the category is a root category
        - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
        - `[Parent <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
      - `[CategoryPath <String>]`: The localized full category path for the policy.
      - `[ClassType <GroupPolicyDefinitionClassType?>]`: Group Policy Definition Class Type.
      - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
      - `[DisplayName <String>]`: The localized policy name.
      - `[ExplainText <String>]`: The localized explanation or help text associated with the policy. The default value is empty.
      - `[GroupPolicyCategoryId <String>]`: The category id of the parent category
      - `[HasRelatedDefinitions <Boolean?>]`: Signifies whether or not there are related definitions to this definition
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[MinDeviceCspVersion <String>]`: Minimum required CSP version for device configuration in this definition
      - `[MinUserCspVersion <String>]`: Minimum required CSP version for user configuration in this definition
      - `[NextVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
      - `[Presentations <IMicrosoftGraphGroupPolicyPresentation[]>]`: The group policy presentations associated with the definition.
        - `[Id <String>]`: 
        - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
        - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[PreviousVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
      - `[Version <String>]`: Setting definition version
    - `[Enabled <Boolean?>]`: Enables or disables the associated group policy definition.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PresentationValues <IMicrosoftGraphGroupPolicyPresentationValue[]>]`: The associated group policy presentation values with the definition value.
      - `[Id <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
      - `[DefinitionValue <IMicrosoftGraphGroupPolicyDefinitionValue>]`: The definition value entity stores the value for a single group policy definition.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the object was last modified.
      - `[Presentation <IMicrosoftGraphGroupPolicyPresentation>]`: The base entity for the display presentation of any of the additional options in a group policy definition.
  - `[Description <String>]`: User provided description for the resource object.
  - `[DisplayName <String>]`: User provided name for the resource object.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[RoleScopeTagIds <String[]>]`: The list of scope tags for the configuration.

DEFINITIONVALUES <IMicrosoftGraphGroupPolicyDefinitionValue[]>: The list of enabled or disabled group policy definition values for the configuration.
  - `[Id <String>]`: 
  - `[ConfigurationType <GroupPolicyConfigurationType?>]`: Group Policy Configuration Type
  - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
  - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
      - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
        - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
        - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
        - `[FileName <String>]`: The file name of the ADMX file without the path. For example: edge.admx
        - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
        - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
        - `[Revision <String>]`: The revision version associated with the file.
        - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
        - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.
      - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The immediate GroupPolicyDefinition children of the category
      - `[DisplayName <String>]`: The string id of the category's display name
      - `[IsRoot <Boolean?>]`: Defines if the category is a root category
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[Parent <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
    - `[CategoryPath <String>]`: The localized full category path for the policy.
    - `[ClassType <GroupPolicyDefinitionClassType?>]`: Group Policy Definition Class Type.
    - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
    - `[DisplayName <String>]`: The localized policy name.
    - `[ExplainText <String>]`: The localized explanation or help text associated with the policy. The default value is empty.
    - `[GroupPolicyCategoryId <String>]`: The category id of the parent category
    - `[HasRelatedDefinitions <Boolean?>]`: Signifies whether or not there are related definitions to this definition
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[MinDeviceCspVersion <String>]`: Minimum required CSP version for device configuration in this definition
    - `[MinUserCspVersion <String>]`: Minimum required CSP version for user configuration in this definition
    - `[NextVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
    - `[Presentations <IMicrosoftGraphGroupPolicyPresentation[]>]`: The group policy presentations associated with the definition.
      - `[Id <String>]`: 
      - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PreviousVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
    - `[Version <String>]`: Setting definition version
  - `[Enabled <Boolean?>]`: Enables or disables the associated group policy definition.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[PresentationValues <IMicrosoftGraphGroupPolicyPresentationValue[]>]`: The associated group policy presentation values with the definition value.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
    - `[DefinitionValue <IMicrosoftGraphGroupPolicyDefinitionValue>]`: The definition value entity stores the value for a single group policy definition.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the object was last modified.
    - `[Presentation <IMicrosoftGraphGroupPolicyPresentation>]`: The base entity for the display presentation of any of the additional options in a group policy definition.

## RELATED LINKS


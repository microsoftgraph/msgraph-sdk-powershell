---
external help file: Microsoft.Graph.DeviceManagement.Administration-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementgrouppolicydefinition
schema: 2.0.0
---

# New-MgDeviceManagementGroupPolicyDefinition

## SYNOPSIS
The available group policy definitions for this account.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementGroupPolicyDefinition [-AdditionalProperties <Hashtable>]
 [-Category <IMicrosoftGraphGroupPolicyCategory>] [-CategoryPath <String>] [-ClassType <String>]
 [-DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>] [-DisplayName <String>] [-ExplainText <String>]
 [-GroupPolicyCategoryId <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-PolicyType <String>]
 [-Presentations <IMicrosoftGraphGroupPolicyPresentation[]>] [-SupportedOn <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementGroupPolicyDefinition -BodyParameter <IMicrosoftGraphGroupPolicyDefinition> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The available group policy definitions for this account.

## EXAMPLES

## PARAMETERS

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
The entity describes all of the information about a single group policy.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphGroupPolicyDefinition
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
The category entity stores the category of a group policy definition
To construct, see NOTES section for CATEGORY properties and create a hash table.

```yaml
Type: IMicrosoftGraphGroupPolicyCategory
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CategoryPath
The localized full category path for the policy.

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

### -ClassType
groupPolicyDefinitionClassType

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

### -DefinitionFile
The entity represents an ADMX (Administrative Template) XML file.
The ADMX file contains a collection of group policy definitions and their locations by category path.
The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
To construct, see NOTES section for DEFINITIONFILE properties and create a hash table.

```yaml
Type: IMicrosoftGraphGroupPolicyDefinitionFile
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The localized policy name.

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

### -ExplainText
The localized explanation or help text associated with the policy.
The default value is empty.

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

### -GroupPolicyCategoryId
The category id of the parent category

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

### -LastModifiedDateTime
The date and time the entity was last modified.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyType
groupPolicyType

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

### -Presentations
The group policy presentations associated with the definition.
To construct, see NOTES section for PRESENTATIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphGroupPolicyPresentation[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SupportedOn
Localized string used to specify what operating system or application version is affected by the policy.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinition
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinition
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphGroupPolicyDefinition>: The entity describes all of the information about a single group policy.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
    - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
      - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
      - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
      - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[PolicyType <String>]`: groupPolicyType
      - `[Revision <String>]`: The revision version associated with the file.
      - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
      - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.
    - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The immediate GroupPolicyDefinition children of the category
    - `[DisplayName <String>]`: The string id of the category's display name
    - `[IsRoot <Boolean?>]`: Defines if the category is a root category
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[Parent <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
  - `[CategoryPath <String>]`: The localized full category path for the policy.
  - `[ClassType <String>]`: groupPolicyDefinitionClassType
  - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
  - `[DisplayName <String>]`: The localized policy name.
  - `[ExplainText <String>]`: The localized explanation or help text associated with the policy. The default value is empty.
  - `[GroupPolicyCategoryId <String>]`: The category id of the parent category
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[PolicyType <String>]`: groupPolicyType
  - `[Presentations <IMicrosoftGraphGroupPolicyPresentation[]>]`: The group policy presentations associated with the definition.
    - `[Id <String>]`: Read-only.
    - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.

CATEGORY <IMicrosoftGraphGroupPolicyCategory>: The category entity stores the category of a group policy definition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
  - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
      - `[Id <String>]`: Read-only.
      - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
      - `[CategoryPath <String>]`: The localized full category path for the policy.
      - `[ClassType <String>]`: groupPolicyDefinitionClassType
      - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
      - `[DisplayName <String>]`: The localized policy name.
      - `[ExplainText <String>]`: The localized explanation or help text associated with the policy. The default value is empty.
      - `[GroupPolicyCategoryId <String>]`: The category id of the parent category
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[PolicyType <String>]`: groupPolicyType
      - `[Presentations <IMicrosoftGraphGroupPolicyPresentation[]>]`: The group policy presentations associated with the definition.
        - `[Id <String>]`: Read-only.
        - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
        - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
    - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
    - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
    - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PolicyType <String>]`: groupPolicyType
    - `[Revision <String>]`: The revision version associated with the file.
    - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
    - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.
  - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The immediate GroupPolicyDefinition children of the category
  - `[DisplayName <String>]`: The string id of the category's display name
  - `[IsRoot <Boolean?>]`: Defines if the category is a root category
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[Parent <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition

DEFINITIONFILE <IMicrosoftGraphGroupPolicyDefinitionFile>: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
    - `[Id <String>]`: Read-only.
    - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
      - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
      - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The immediate GroupPolicyDefinition children of the category
      - `[DisplayName <String>]`: The string id of the category's display name
      - `[IsRoot <Boolean?>]`: Defines if the category is a root category
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[Parent <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
    - `[CategoryPath <String>]`: The localized full category path for the policy.
    - `[ClassType <String>]`: groupPolicyDefinitionClassType
    - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
    - `[DisplayName <String>]`: The localized policy name.
    - `[ExplainText <String>]`: The localized explanation or help text associated with the policy. The default value is empty.
    - `[GroupPolicyCategoryId <String>]`: The category id of the parent category
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PolicyType <String>]`: groupPolicyType
    - `[Presentations <IMicrosoftGraphGroupPolicyPresentation[]>]`: The group policy presentations associated with the definition.
      - `[Id <String>]`: Read-only.
      - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
  - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
  - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
  - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[PolicyType <String>]`: groupPolicyType
  - `[Revision <String>]`: The revision version associated with the file.
  - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
  - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.

PRESENTATIONS <IMicrosoftGraphGroupPolicyPresentation[]>: The group policy presentations associated with the definition.
  - `[Id <String>]`: Read-only.
  - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
      - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
        - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
        - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
        - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
        - `[PolicyType <String>]`: groupPolicyType
        - `[Revision <String>]`: The revision version associated with the file.
        - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
        - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.
      - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The immediate GroupPolicyDefinition children of the category
      - `[DisplayName <String>]`: The string id of the category's display name
      - `[IsRoot <Boolean?>]`: Defines if the category is a root category
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[Parent <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
    - `[CategoryPath <String>]`: The localized full category path for the policy.
    - `[ClassType <String>]`: groupPolicyDefinitionClassType
    - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
    - `[DisplayName <String>]`: The localized policy name.
    - `[ExplainText <String>]`: The localized explanation or help text associated with the policy. The default value is empty.
    - `[GroupPolicyCategoryId <String>]`: The category id of the parent category
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PolicyType <String>]`: groupPolicyType
    - `[Presentations <IMicrosoftGraphGroupPolicyPresentation[]>]`: The group policy presentations associated with the definition.
    - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
  - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.

## RELATED LINKS

## RELATED LINKS

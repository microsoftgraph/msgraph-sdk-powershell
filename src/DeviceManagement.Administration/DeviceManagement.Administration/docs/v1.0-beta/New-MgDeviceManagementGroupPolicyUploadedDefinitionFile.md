---
external help file: Microsoft.Graph.DeviceManagement.Administration-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementgrouppolicyuploadeddefinitionfile
schema: 2.0.0
---

# New-MgDeviceManagementGroupPolicyUploadedDefinitionFile

## SYNOPSIS
The available group policy uploaded definition files for this account.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementGroupPolicyUploadedDefinitionFile [-AdditionalProperties <Hashtable>]
 [-ContentInputFile <String>] [-DefaultLanguageCode <String>]
 [-Definitions <IMicrosoftGraphGroupPolicyDefinition[]>] [-Description <String>] [-DisplayName <String>]
 [-FileName <String>] [-GroupPolicyOperations <IMicrosoftGraphGroupPolicyOperation[]>]
 [-GroupPolicyUploadedLanguageFiles <IMicrosoftGraphGroupPolicyUploadedLanguageFile[]>] [-Id <String>]
 [-LanguageCodes <String[]>] [-LastModifiedDateTime <DateTime>] [-PolicyType <String>] [-Revision <String>]
 [-Status <String>] [-TargetNamespace <String>] [-TargetPrefix <String>] [-UploadDateTime <DateTime>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementGroupPolicyUploadedDefinitionFile
 -BodyParameter <IMicrosoftGraphGroupPolicyUploadedDefinitionFile> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The available group policy uploaded definition files for this account.

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
The entity represents an ADMX (Administrative Template) XML file uploaded by Administrator.
The ADMX file contains a collection of group policy definitions and their locations by category path.
The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphGroupPolicyUploadedDefinitionFile
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentInputFile
Input File for Content (The contents of the uploaded ADMX file.)

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

### -DefaultLanguageCode
The default language of the uploaded ADMX file.

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

### -Definitions
The group policy definitions associated with the file.
To construct, see NOTES section for DEFINITIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphGroupPolicyDefinition[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The localized description of the policy settings in the ADMX file.
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

### -DisplayName
The localized friendly name of the ADMX file.

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

### -FileName
The file name of the uploaded ADML file.

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

### -GroupPolicyOperations
The list of operations on the uploaded ADMX file.
To construct, see NOTES section for GROUPPOLICYOPERATIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphGroupPolicyOperation[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupPolicyUploadedLanguageFiles
The list of ADML files associated with the uploaded ADMX file.
To construct, see NOTES section for GROUPPOLICYUPLOADEDLANGUAGEFILES properties and create a hash table.

```yaml
Type: IMicrosoftGraphGroupPolicyUploadedLanguageFile[]
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

### -LanguageCodes
The supported language codes for the ADMX file.

```yaml
Type: String[]
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

### -Revision
The revision version associated with the file.

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

### -Status
groupPolicyUploadedDefinitionFileStatus

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

### -TargetNamespace
Specifies the URI used to identify the namespace within the ADMX file.

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

### -TargetPrefix
Specifies the logical name that refers to the namespace within the ADMX file.

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

### -UploadDateTime
The uploaded time of the uploaded ADMX file.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyUploadedDefinitionFile
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyUploadedDefinitionFile
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphGroupPolicyUploadedDefinitionFile>: The entity represents an ADMX (Administrative Template) XML file uploaded by Administrator. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
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
  - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
  - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
  - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[PolicyType <String>]`: groupPolicyType
  - `[Revision <String>]`: The revision version associated with the file.
  - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
  - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.
  - `[Id <String>]`: Read-only.
  - `[Content <Byte[]>]`: The contents of the uploaded ADMX file.
  - `[DefaultLanguageCode <String>]`: The default language of the uploaded ADMX file.
  - `[FileName <String>]`: The file name of the uploaded ADML file.
  - `[GroupPolicyOperations <IMicrosoftGraphGroupPolicyOperation[]>]`: The list of operations on the uploaded ADMX file.
    - `[Id <String>]`: Read-only.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[OperationStatus <String>]`: groupPolicyOperationStatus
    - `[OperationType <String>]`: groupPolicyOperationType
    - `[StatusDetails <String>]`: The group policy operation status detail.
  - `[GroupPolicyUploadedLanguageFiles <IMicrosoftGraphGroupPolicyUploadedLanguageFile[]>]`: The list of ADML files associated with the uploaded ADMX file.
    - `[Content <Byte[]>]`: The contents of the uploaded ADML file.
    - `[FileName <String>]`: The file name of the uploaded ADML file.
    - `[Id <String>]`: Key of the entity.
    - `[LanguageCode <String>]`: The language code of the uploaded ADML file.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[Status <String>]`: groupPolicyUploadedDefinitionFileStatus
  - `[UploadDateTime <DateTime?>]`: The uploaded time of the uploaded ADMX file.

DEFINITIONS <IMicrosoftGraphGroupPolicyDefinition[]>: The group policy definitions associated with the file.
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

GROUPPOLICYOPERATIONS <IMicrosoftGraphGroupPolicyOperation[]>: The list of operations on the uploaded ADMX file.
  - `[Id <String>]`: Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[OperationStatus <String>]`: groupPolicyOperationStatus
  - `[OperationType <String>]`: groupPolicyOperationType
  - `[StatusDetails <String>]`: The group policy operation status detail.

GROUPPOLICYUPLOADEDLANGUAGEFILES <IMicrosoftGraphGroupPolicyUploadedLanguageFile[]>: The list of ADML files associated with the uploaded ADMX file.
  - `[Content <Byte[]>]`: The contents of the uploaded ADML file.
  - `[FileName <String>]`: The file name of the uploaded ADML file.
  - `[Id <String>]`: Key of the entity.
  - `[LanguageCode <String>]`: The language code of the uploaded ADML file.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.

## RELATED LINKS

## RELATED LINKS

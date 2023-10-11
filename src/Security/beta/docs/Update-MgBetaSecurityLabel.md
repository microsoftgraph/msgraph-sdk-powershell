---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/update-mgbetasecuritylabel
schema: 2.0.0
---

# Update-MgBetaSecurityLabel

## SYNOPSIS
Update the navigation property labels in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaSecurityLabel [-AdditionalProperties <Hashtable>]
 [-Authorities <IMicrosoftGraphSecurityAuthorityTemplate[]>]
 [-Categories <IMicrosoftGraphSecurityCategoryTemplate[]>]
 [-Citations <IMicrosoftGraphSecurityCitationTemplate[]>]
 [-Departments <IMicrosoftGraphSecurityDepartmentTemplate[]>]
 [-FilePlanReferences <IMicrosoftGraphSecurityFilePlanReferenceTemplate[]>] [-Id <String>]
 [-RetentionLabels <IMicrosoftGraphSecurityRetentionLabel[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaSecurityLabel -BodyParameter <IMicrosoftGraphSecurityLabelsRoot> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property labels in security

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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Authorities
Specifies the underlying authority that describes the type of content to be retained and its retention schedule.
To construct, see NOTES section for AUTHORITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAuthorityTemplate[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
labelsRoot
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityLabelsRoot
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
Specifies a group of similar types of content in a particular department.
To construct, see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityCategoryTemplate[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Citations
The specific rule or regulation created by a jurisdiction used to determine whether certain labels and content should be retained or deleted.
To construct, see NOTES section for CITATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityCitationTemplate[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Departments
Specifies the department or business unit of an organization to which a label belongs.
To construct, see NOTES section for DEPARTMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityDepartmentTemplate[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilePlanReferences
Specifies a unique alpha-numeric identifier for an organization’s retention schedule.
To construct, see NOTES section for FILEPLANREFERENCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityFilePlanReferenceTemplate[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetentionLabels
Represents how customers can manage their data, whether and for how long to retain or delete it.
To construct, see NOTES section for RETENTIONLABELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityRetentionLabel[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityLabelsRoot

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityLabelsRoot

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AUTHORITIES <IMicrosoftGraphSecurityAuthorityTemplate[]>`: Specifies the underlying authority that describes the type of content to be retained and its retention schedule.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
  - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`BODYPARAMETER <IMicrosoftGraphSecurityLabelsRoot>`: labelsRoot
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Authorities <IMicrosoftGraphSecurityAuthorityTemplate[]>]`: Specifies the underlying authority that describes the type of content to be retained and its retention schedule.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
    - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Categories <IMicrosoftGraphSecurityCategoryTemplate[]>]`: Specifies a group of similar types of content in a particular department.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
    - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[SubCategories <IMicrosoftGraphSecuritySubCategoryTemplate[]>]`: Represents all subcategories under a particular category.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
      - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Citations <IMicrosoftGraphSecurityCitationTemplate[]>]`: The specific rule or regulation created by a jurisdiction used to determine whether certain labels and content should be retained or deleted.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
    - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CitationJurisdiction <String>]`: Represents the jurisdiction or agency that published the citation.
    - `[CitationUrl <String>]`: Represents the URL to the published citation.
  - `[Departments <IMicrosoftGraphSecurityDepartmentTemplate[]>]`: Specifies the department or business unit of an organization to which a label belongs.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
    - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[FilePlanReferences <IMicrosoftGraphSecurityFilePlanReferenceTemplate[]>]`: Specifies a unique alpha-numeric identifier for an organization’s retention schedule.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
    - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[RetentionLabels <IMicrosoftGraphSecurityRetentionLabel[]>]`: Represents how customers can manage their data, whether and for how long to retain or delete it.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ActionAfterRetentionPeriod <String>]`: actionAfterRetentionPeriod
    - `[BehaviorDuringRetentionPeriod <String>]`: behaviorDuringRetentionPeriod
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the retentionLabel is created.
    - `[DefaultRecordBehavior <String>]`: defaultRecordBehavior
    - `[DescriptionForAdmins <String>]`: Provides label information for the admin. Optional.
    - `[DescriptionForUsers <String>]`: Provides the label information for the user. Optional.
    - `[Descriptors <IMicrosoftGraphSecurityFilePlanDescriptor>]`: filePlanDescriptor
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Authority <IMicrosoftGraphSecurityAuthority>]`: authority
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
      - `[AuthorityTemplate <IMicrosoftGraphSecurityAuthorityTemplate>]`: authorityTemplate
      - `[Category <IMicrosoftGraphSecurityAppliedCategory>]`: appliedCategory
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
        - `[SubCategory <IMicrosoftGraphSecuritySubCategory>]`: subCategory
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
      - `[CategoryTemplate <IMicrosoftGraphSecurityCategoryTemplate>]`: categoryTemplate
      - `[Citation <IMicrosoftGraphSecurityCitation>]`: citation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
        - `[CitationJurisdiction <String>]`: Represents the jurisdiction or agency that published the citation.
        - `[CitationUrl <String>]`: Represents the URL to the published citation.
      - `[CitationTemplate <IMicrosoftGraphSecurityCitationTemplate>]`: citationTemplate
      - `[Department <IMicrosoftGraphSecurityDepartment>]`: department
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
      - `[DepartmentTemplate <IMicrosoftGraphSecurityDepartmentTemplate>]`: departmentTemplate
      - `[FilePlanReference <IMicrosoftGraphSecurityFilePlanReference>]`: filePlanReference
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
      - `[FilePlanReferenceTemplate <IMicrosoftGraphSecurityFilePlanReferenceTemplate>]`: filePlanReferenceTemplate
    - `[DisplayName <String>]`: Unique string that defines a label name.
    - `[DispositionReviewStages <IMicrosoftGraphSecurityDispositionReviewStage[]>]`: When action at the end of retention is chosen as 'dispositionReview', dispositionReviewStages specifies a sequential set of stages with at least one reviewer in each stage.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Name <String>]`: Name representing each stage within a collection.
      - `[ReviewersEmailAddresses <String[]>]`: A collection of reviewers at each stage.
      - `[StageNumber <Int32?>]`: The sequence number for each stage of the disposition review.
    - `[IsInUse <Boolean?>]`: Specifies whether the label is currently being used.
    - `[LabelToBeApplied <String>]`: Specifies the replacement label to be applied automatically after the retention period of the current label ends.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The latest date time when the retentionLabel was modified.
    - `[RetentionDuration <IMicrosoftGraphSecurityRetentionDuration>]`: retentionDuration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RetentionEventType <IMicrosoftGraphSecurityRetentionEventType>]`: retentionEventType
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date time when the retentionEventType was created.
      - `[Description <String>]`: Optional information about the event type.
      - `[DisplayName <String>]`: Name of the event type.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The latest date time when the retentionEventType was modified.
    - `[RetentionTrigger <String>]`: retentionTrigger

`CATEGORIES <IMicrosoftGraphSecurityCategoryTemplate[]>`: Specifies a group of similar types of content in a particular department.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
  - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[SubCategories <IMicrosoftGraphSecuritySubCategoryTemplate[]>]`: Represents all subcategories under a particular category.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
    - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.

`CITATIONS <IMicrosoftGraphSecurityCitationTemplate[]>`: The specific rule or regulation created by a jurisdiction used to determine whether certain labels and content should be retained or deleted.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
  - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CitationJurisdiction <String>]`: Represents the jurisdiction or agency that published the citation.
  - `[CitationUrl <String>]`: Represents the URL to the published citation.

`DEPARTMENTS <IMicrosoftGraphSecurityDepartmentTemplate[]>`: Specifies the department or business unit of an organization to which a label belongs.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
  - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`FILEPLANREFERENCES <IMicrosoftGraphSecurityFilePlanReferenceTemplate[]>`: Specifies a unique alpha-numeric identifier for an organization’s retention schedule.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
  - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`RETENTIONLABELS <IMicrosoftGraphSecurityRetentionLabel[]>`: Represents how customers can manage their data, whether and for how long to retain or delete it.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActionAfterRetentionPeriod <String>]`: actionAfterRetentionPeriod
  - `[BehaviorDuringRetentionPeriod <String>]`: behaviorDuringRetentionPeriod
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the retentionLabel is created.
  - `[DefaultRecordBehavior <String>]`: defaultRecordBehavior
  - `[DescriptionForAdmins <String>]`: Provides label information for the admin. Optional.
  - `[DescriptionForUsers <String>]`: Provides the label information for the user. Optional.
  - `[Descriptors <IMicrosoftGraphSecurityFilePlanDescriptor>]`: filePlanDescriptor
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Authority <IMicrosoftGraphSecurityAuthority>]`: authority
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
    - `[AuthorityTemplate <IMicrosoftGraphSecurityAuthorityTemplate>]`: authorityTemplate
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
      - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Category <IMicrosoftGraphSecurityAppliedCategory>]`: appliedCategory
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
      - `[SubCategory <IMicrosoftGraphSecuritySubCategory>]`: subCategory
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
    - `[CategoryTemplate <IMicrosoftGraphSecurityCategoryTemplate>]`: categoryTemplate
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
      - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[SubCategories <IMicrosoftGraphSecuritySubCategoryTemplate[]>]`: Represents all subcategories under a particular category.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
        - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Citation <IMicrosoftGraphSecurityCitation>]`: citation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
      - `[CitationJurisdiction <String>]`: Represents the jurisdiction or agency that published the citation.
      - `[CitationUrl <String>]`: Represents the URL to the published citation.
    - `[CitationTemplate <IMicrosoftGraphSecurityCitationTemplate>]`: citationTemplate
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
      - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CitationJurisdiction <String>]`: Represents the jurisdiction or agency that published the citation.
      - `[CitationUrl <String>]`: Represents the URL to the published citation.
    - `[Department <IMicrosoftGraphSecurityDepartment>]`: department
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
    - `[DepartmentTemplate <IMicrosoftGraphSecurityDepartmentTemplate>]`: departmentTemplate
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
      - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[FilePlanReference <IMicrosoftGraphSecurityFilePlanReference>]`: filePlanReference
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: Unique string that defines the name for each file plan descriptor associated with a particular retention label.
    - `[FilePlanReferenceTemplate <IMicrosoftGraphSecurityFilePlanReferenceTemplate>]`: filePlanReferenceTemplate
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the filePlanDescriptorTemplate is created.
      - `[DisplayName <String>]`: Unique string that defines a filePlanDescriptorTemplate name.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: Unique string that defines a label name.
  - `[DispositionReviewStages <IMicrosoftGraphSecurityDispositionReviewStage[]>]`: When action at the end of retention is chosen as 'dispositionReview', dispositionReviewStages specifies a sequential set of stages with at least one reviewer in each stage.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Name <String>]`: Name representing each stage within a collection.
    - `[ReviewersEmailAddresses <String[]>]`: A collection of reviewers at each stage.
    - `[StageNumber <Int32?>]`: The sequence number for each stage of the disposition review.
  - `[IsInUse <Boolean?>]`: Specifies whether the label is currently being used.
  - `[LabelToBeApplied <String>]`: Specifies the replacement label to be applied automatically after the retention period of the current label ends.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The latest date time when the retentionLabel was modified.
  - `[RetentionDuration <IMicrosoftGraphSecurityRetentionDuration>]`: retentionDuration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RetentionEventType <IMicrosoftGraphSecurityRetentionEventType>]`: retentionEventType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date time when the retentionEventType was created.
    - `[Description <String>]`: Optional information about the event type.
    - `[DisplayName <String>]`: Name of the event type.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The latest date time when the retentionEventType was modified.
  - `[RetentionTrigger <String>]`: retentionTrigger

## RELATED LINKS


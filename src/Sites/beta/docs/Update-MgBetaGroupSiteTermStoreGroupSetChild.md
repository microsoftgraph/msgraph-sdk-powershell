---
external help file:
Module Name: Microsoft.Graph.Beta.Sites
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.sites/update-mgbetagroupsitetermstoregroupsetchild
schema: 2.0.0
---

# Update-MgBetaGroupSiteTermStoreGroupSetChild

## SYNOPSIS
Update the navigation property children in groups

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaGroupSiteTermStoreGroupSetChild -GroupId <String> -GroupId1 <String> -SetId <String>
 -SiteId <String> -TermId <String> [-AdditionalProperties <Hashtable>]
 [-Children <IMicrosoftGraphTermStoreTerm[]>] [-CreatedDateTime <DateTime>]
 [-Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>] [-Id <String>]
 [-Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>] [-LastModifiedDateTime <DateTime>]
 [-Properties <IMicrosoftGraphKeyValue[]>] [-Relations <IMicrosoftGraphTermStoreRelation[]>]
 [-Set <IMicrosoftGraphTermStoreSet>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaGroupSiteTermStoreGroupSetChild -GroupId <String> -GroupId1 <String> -SetId <String>
 -SiteId <String> -TermId <String> -BodyParameter <IMicrosoftGraphTermStoreTerm> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgBetaGroupSiteTermStoreGroupSetChild -GroupId <String> -GroupId1 <String> -SetId <String>
 -SiteId <String> -TermId <String> -TermId1 <String> -BodyParameter <IMicrosoftGraphTermStoreTerm> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Update-MgBetaGroupSiteTermStoreGroupSetChild -GroupId <String> -GroupId1 <String> -SetId <String>
 -SiteId <String> -TermId <String> -TermId1 <String> [-AdditionalProperties <Hashtable>]
 [-Children <IMicrosoftGraphTermStoreTerm[]>] [-CreatedDateTime <DateTime>]
 [-Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>] [-Id <String>]
 [-Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>] [-LastModifiedDateTime <DateTime>]
 [-Properties <IMicrosoftGraphKeyValue[]>] [-Relations <IMicrosoftGraphTermStoreRelation[]>]
 [-Set <IMicrosoftGraphTermStoreSet>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaGroupSiteTermStoreGroupSetChild -InputObject <ISitesIdentity>
 -BodyParameter <IMicrosoftGraphTermStoreTerm> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgBetaGroupSiteTermStoreGroupSetChild -InputObject <ISitesIdentity>
 -BodyParameter <IMicrosoftGraphTermStoreTerm> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaGroupSiteTermStoreGroupSetChild -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-Children <IMicrosoftGraphTermStoreTerm[]>] [-CreatedDateTime <DateTime>]
 [-Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>] [-Id <String>]
 [-Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>] [-LastModifiedDateTime <DateTime>]
 [-Properties <IMicrosoftGraphKeyValue[]>] [-Relations <IMicrosoftGraphTermStoreRelation[]>]
 [-Set <IMicrosoftGraphTermStoreSet>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgBetaGroupSiteTermStoreGroupSetChild -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-Children <IMicrosoftGraphTermStoreTerm[]>] [-CreatedDateTime <DateTime>]
 [-Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>] [-Id <String>]
 [-Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>] [-LastModifiedDateTime <DateTime>]
 [-Properties <IMicrosoftGraphKeyValue[]>] [-Relations <IMicrosoftGraphTermStoreRelation[]>]
 [-Set <IMicrosoftGraphTermStoreSet>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property children in groups

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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
term
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTermStoreTerm
Parameter Sets: Update, Update1, UpdateViaIdentity, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Children
Children of current term.
To construct, see NOTES section for CHILDREN properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTermStoreTerm[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Date and time of term creation.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Descriptions
Description about term that is dependent on the languageTag.
To construct, see NOTES section for DESCRIPTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTermStoreLocalizedDescription[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
The unique identifier of group

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId1
The unique identifier of group

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ISitesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentity1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Labels
Label metadata for a term.
To construct, see NOTES section for LABELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTermStoreLocalizedLabel[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Last date and time of term modification.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Properties
Collection of properties on the term.
To construct, see NOTES section for PROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphKeyValue[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Relations
To indicate which terms are related to the current term as either pinned or reused.
To construct, see NOTES section for RELATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTermStoreRelation[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Set
set
To construct, see NOTES section for SET properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTermStoreSet
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SetId
The unique identifier of set

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteId
The unique identifier of site

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermId
The unique identifier of term

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermId1
The unique identifier of term

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTermStoreTerm

### Microsoft.Graph.Beta.PowerShell.Models.ISitesIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTermStoreTerm

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphTermStoreTerm>`: term
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children of current term.
  - `[CreatedDateTime <DateTime?>]`: Date and time of term creation. Read-only.
  - `[Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>]`: Description about term that is dependent on the languageTag.
    - `[Description <String>]`: The description in the localized language.
    - `[LanguageTag <String>]`: The language tag for the label.
  - `[Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>]`: Label metadata for a term.
    - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
    - `[LanguageTag <String>]`: The language tag for the label.
    - `[Name <String>]`: The name of the label.
  - `[LastModifiedDateTime <DateTime?>]`: Last date and time of term modification. Read-only.
  - `[Properties <IMicrosoftGraphKeyValue[]>]`: Collection of properties on the term.
    - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
    - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
  - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: To indicate which terms are related to the current term as either pinned or reused.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
    - `[Relationship <String>]`: relationType
    - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
      - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
      - `[Description <String>]`: Description giving details on the term usage.
      - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
        - `[LanguageTag <String>]`: The language tag for the label.
        - `[Name <String>]`: The name in the localized language.
      - `[ParentGroup <IMicrosoftGraphTermStoreGroup>]`: group
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
        - `[Description <String>]`: Description that gives details on the term usage.
        - `[DisplayName <String>]`: Name of the group.
        - `[ParentSiteId <String>]`: ID of the parent site of this group.
        - `[Scope <String>]`: termGroupScope
        - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
      - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
      - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: Indicates which terms have been pinned or reused directly under the set.
      - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
    - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
  - `[Set <IMicrosoftGraphTermStoreSet>]`: set

`CHILDREN <IMicrosoftGraphTermStoreTerm[]>`: Children of current term.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children of current term.
  - `[CreatedDateTime <DateTime?>]`: Date and time of term creation. Read-only.
  - `[Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>]`: Description about term that is dependent on the languageTag.
    - `[Description <String>]`: The description in the localized language.
    - `[LanguageTag <String>]`: The language tag for the label.
  - `[Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>]`: Label metadata for a term.
    - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
    - `[LanguageTag <String>]`: The language tag for the label.
    - `[Name <String>]`: The name of the label.
  - `[LastModifiedDateTime <DateTime?>]`: Last date and time of term modification. Read-only.
  - `[Properties <IMicrosoftGraphKeyValue[]>]`: Collection of properties on the term.
    - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
    - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
  - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: To indicate which terms are related to the current term as either pinned or reused.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
    - `[Relationship <String>]`: relationType
    - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
      - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
      - `[Description <String>]`: Description giving details on the term usage.
      - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
        - `[LanguageTag <String>]`: The language tag for the label.
        - `[Name <String>]`: The name in the localized language.
      - `[ParentGroup <IMicrosoftGraphTermStoreGroup>]`: group
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
        - `[Description <String>]`: Description that gives details on the term usage.
        - `[DisplayName <String>]`: Name of the group.
        - `[ParentSiteId <String>]`: ID of the parent site of this group.
        - `[Scope <String>]`: termGroupScope
        - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
      - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
      - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: Indicates which terms have been pinned or reused directly under the set.
      - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
    - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
  - `[Set <IMicrosoftGraphTermStoreSet>]`: set

`DESCRIPTIONS <IMicrosoftGraphTermStoreLocalizedDescription[]>`: Description about term that is dependent on the languageTag.
  - `[Description <String>]`: The description in the localized language.
  - `[LanguageTag <String>]`: The language tag for the label.

`INPUTOBJECT <ISitesIdentity>`: Identity Parameter
  - `[BaseItemId <String>]`: The unique identifier of baseItem
  - `[BitlockerRecoveryKeyId <String>]`: The unique identifier of bitlockerRecoveryKey
  - `[ColumnDefinitionId <String>]`: The unique identifier of columnDefinition
  - `[ColumnLinkId <String>]`: The unique identifier of columnLink
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ContentTypeId1 <String>]`: The unique identifier of contentType
  - `[DataLossPreventionPolicyId <String>]`: The unique identifier of dataLossPreventionPolicy
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: The unique identifier of group
  - `[GroupId1 <String>]`: The unique identifier of group
  - `[HorizontalSectionColumnId <String>]`: The unique identifier of horizontalSectionColumn
  - `[HorizontalSectionId <String>]`: The unique identifier of horizontalSection
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[InformationProtectionLabelId <String>]`: The unique identifier of informationProtectionLabel
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ItemActivityId <String>]`: The unique identifier of itemActivity
  - `[ItemActivityOldId <String>]`: The unique identifier of itemActivityOLD
  - `[ItemActivityStatId <String>]`: The unique identifier of itemActivityStat
  - `[ListId <String>]`: The unique identifier of list
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenoteOperationId <String>]`: The unique identifier of onenoteOperation
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteResourceId <String>]`: The unique identifier of onenoteResource
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[RelationId <String>]`: The unique identifier of relation
  - `[RichLongRunningOperationId <String>]`: The unique identifier of richLongRunningOperation
  - `[SectionGroupId <String>]`: The unique identifier of sectionGroup
  - `[SectionGroupId1 <String>]`: The unique identifier of sectionGroup
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SensitivityLabelId1 <String>]`: The unique identifier of sensitivityLabel
  - `[SetId <String>]`: The unique identifier of set
  - `[SetId1 <String>]`: The unique identifier of set
  - `[SiteId <String>]`: The unique identifier of site
  - `[SiteId1 <String>]`: The unique identifier of site
  - `[SitePageId <String>]`: The unique identifier of sitePage
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TermId <String>]`: The unique identifier of term
  - `[TermId1 <String>]`: The unique identifier of term
  - `[ThreatAssessmentRequestId <String>]`: The unique identifier of threatAssessmentRequest
  - `[ThreatAssessmentResultId <String>]`: The unique identifier of threatAssessmentResult
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: The unique identifier of user
  - `[WebPartId <String>]`: The unique identifier of webPart

`LABELS <IMicrosoftGraphTermStoreLocalizedLabel[]>`: Label metadata for a term.
  - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
  - `[LanguageTag <String>]`: The language tag for the label.
  - `[Name <String>]`: The name of the label.

`PROPERTIES <IMicrosoftGraphKeyValue[]>`: Collection of properties on the term.
  - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
  - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.

`RELATIONS <IMicrosoftGraphTermStoreRelation[]>`: To indicate which terms are related to the current term as either pinned or reused.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children of current term.
    - `[CreatedDateTime <DateTime?>]`: Date and time of term creation. Read-only.
    - `[Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>]`: Description about term that is dependent on the languageTag.
      - `[Description <String>]`: The description in the localized language.
      - `[LanguageTag <String>]`: The language tag for the label.
    - `[Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>]`: Label metadata for a term.
      - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
      - `[LanguageTag <String>]`: The language tag for the label.
      - `[Name <String>]`: The name of the label.
    - `[LastModifiedDateTime <DateTime?>]`: Last date and time of term modification. Read-only.
    - `[Properties <IMicrosoftGraphKeyValue[]>]`: Collection of properties on the term.
      - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
      - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
    - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: To indicate which terms are related to the current term as either pinned or reused.
    - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
      - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
      - `[Description <String>]`: Description giving details on the term usage.
      - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
        - `[LanguageTag <String>]`: The language tag for the label.
        - `[Name <String>]`: The name in the localized language.
      - `[ParentGroup <IMicrosoftGraphTermStoreGroup>]`: group
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
        - `[Description <String>]`: Description that gives details on the term usage.
        - `[DisplayName <String>]`: Name of the group.
        - `[ParentSiteId <String>]`: ID of the parent site of this group.
        - `[Scope <String>]`: termGroupScope
        - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
      - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
      - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: Indicates which terms have been pinned or reused directly under the set.
      - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
  - `[Relationship <String>]`: relationType
  - `[Set <IMicrosoftGraphTermStoreSet>]`: set
  - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term

`SET <IMicrosoftGraphTermStoreSet>`: set
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children of current term.
    - `[CreatedDateTime <DateTime?>]`: Date and time of term creation. Read-only.
    - `[Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>]`: Description about term that is dependent on the languageTag.
      - `[Description <String>]`: The description in the localized language.
      - `[LanguageTag <String>]`: The language tag for the label.
    - `[Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>]`: Label metadata for a term.
      - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
      - `[LanguageTag <String>]`: The language tag for the label.
      - `[Name <String>]`: The name of the label.
    - `[LastModifiedDateTime <DateTime?>]`: Last date and time of term modification. Read-only.
    - `[Properties <IMicrosoftGraphKeyValue[]>]`: Collection of properties on the term.
      - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
      - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
    - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: To indicate which terms are related to the current term as either pinned or reused.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
      - `[Relationship <String>]`: relationType
      - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
    - `[Set <IMicrosoftGraphTermStoreSet>]`: set
  - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
  - `[Description <String>]`: Description giving details on the term usage.
  - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
    - `[LanguageTag <String>]`: The language tag for the label.
    - `[Name <String>]`: The name in the localized language.
  - `[ParentGroup <IMicrosoftGraphTermStoreGroup>]`: group
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
    - `[Description <String>]`: Description that gives details on the term usage.
    - `[DisplayName <String>]`: Name of the group.
    - `[ParentSiteId <String>]`: ID of the parent site of this group.
    - `[Scope <String>]`: termGroupScope
    - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
  - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
  - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: Indicates which terms have been pinned or reused directly under the set.
  - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.

## RELATED LINKS


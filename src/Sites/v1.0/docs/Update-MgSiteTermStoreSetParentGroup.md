---
external help file:
Module Name: Microsoft.Graph.Sites
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.sites/update-mgsitetermstoresetparentgroup
schema: 2.0.0
---

# Update-MgSiteTermStoreSetParentGroup

## SYNOPSIS
Update the navigation property parentGroup in sites

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSiteTermStoreSetParentGroup -SetId <String> -SiteId <String> [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-ParentSiteId <String>] [-Scope <String>] [-Sets <IMicrosoftGraphTermStoreSet[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgSiteTermStoreSetParentGroup -SetId <String> -SiteId <String>
 -BodyParameter <IMicrosoftGraphTermStoreGroup> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgSiteTermStoreSetParentGroup -SetId <String> -SiteId <String> -StoreId <String>
 -BodyParameter <IMicrosoftGraphTermStoreGroup> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Update-MgSiteTermStoreSetParentGroup -SetId <String> -SiteId <String> -StoreId <String>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-ParentSiteId <String>] [-Scope <String>]
 [-Sets <IMicrosoftGraphTermStoreSet[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSiteTermStoreSetParentGroup -InputObject <ISitesIdentity>
 -BodyParameter <IMicrosoftGraphTermStoreGroup> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgSiteTermStoreSetParentGroup -InputObject <ISitesIdentity>
 -BodyParameter <IMicrosoftGraphTermStoreGroup> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSiteTermStoreSetParentGroup -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-ParentSiteId <String>] [-Scope <String>] [-Sets <IMicrosoftGraphTermStoreSet[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgSiteTermStoreSetParentGroup -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-ParentSiteId <String>] [-Scope <String>] [-Sets <IMicrosoftGraphTermStoreSet[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property parentGroup in sites

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
group
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreGroup
Parameter Sets: Update, Update1, UpdateViaIdentity, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Date and time of the group creation.
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

### -Description
Description that gives details on the term usage.

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

### -DisplayName
Name of the group.

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
Type: Microsoft.Graph.PowerShell.Models.ISitesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentity1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ParentSiteId
ID of the parent site of this group.

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

### -Scope
termGroupScope

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

### -Sets
All sets under the group in a term [store].
To construct, see NOTES section for SETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreSet[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
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

### -StoreId
The unique identifier of store

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreGroup

### Microsoft.Graph.PowerShell.Models.ISitesIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphTermStoreGroup>`: group
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
  - `[Description <String>]`: Description that gives details on the term usage.
  - `[DisplayName <String>]`: Name of the group.
  - `[ParentSiteId <String>]`: ID of the parent site of this group.
  - `[Scope <String>]`: termGroupScope
  - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
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
        - `[Key <String>]`: Key for the key-value pair.
        - `[Value <String>]`: Value for the key-value pair.
      - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: To indicate which terms are related to the current term as either pinned or reused.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[Relationship <String>]`: relationType
        - `[Set <IMicrosoftGraphTermStoreSet>]`: set
        - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
      - `[Set <IMicrosoftGraphTermStoreSet>]`: set
    - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
    - `[Description <String>]`: Description that gives details on the term usage.
    - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
      - `[LanguageTag <String>]`: The language tag for the label.
      - `[Name <String>]`: The name in the localized language.
    - `[ParentGroup <IMicrosoftGraphTermStoreGroup>]`: group
    - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
    - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: Indicates which terms have been pinned or reused directly under the set.
    - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.

`INPUTOBJECT <ISitesIdentity>`: Identity Parameter
  - `[BaseItemId <String>]`: The unique identifier of baseItem
  - `[ColumnDefinitionId <String>]`: The unique identifier of columnDefinition
  - `[ColumnLinkId <String>]`: The unique identifier of columnLink
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ContentTypeId1 <String>]`: The unique identifier of contentType
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: The unique identifier of group
  - `[GroupId1 <String>]`: The unique identifier of group
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ItemActivityId <String>]`: The unique identifier of itemActivity
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
  - `[SetId <String>]`: The unique identifier of set
  - `[SetId1 <String>]`: The unique identifier of set
  - `[SiteId <String>]`: The unique identifier of site
  - `[SiteId1 <String>]`: The unique identifier of site
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[StoreId <String>]`: The unique identifier of store
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TermId <String>]`: The unique identifier of term
  - `[TermId1 <String>]`: The unique identifier of term
  - `[UserId <String>]`: The unique identifier of user

`SETS <IMicrosoftGraphTermStoreSet[]>`: All sets under the group in a term [store].
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
      - `[Key <String>]`: Key for the key-value pair.
      - `[Value <String>]`: Value for the key-value pair.
    - `[Relations <IMicrosoftGraphTermStoreRelation[]>]`: To indicate which terms are related to the current term as either pinned or reused.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
      - `[Relationship <String>]`: relationType
      - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
    - `[Set <IMicrosoftGraphTermStoreSet>]`: set
  - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
  - `[Description <String>]`: Description that gives details on the term usage.
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


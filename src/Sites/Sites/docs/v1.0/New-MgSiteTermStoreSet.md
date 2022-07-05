---
external help file:
Module Name: Microsoft.Graph.Sites
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites/new-mgsitetermstoreset
schema: 2.0.0
---

# New-MgSiteTermStoreSet

## SYNOPSIS
Create new navigation property to sets for sites

## SYNTAX

### CreateExpanded2 (Default)
```
New-MgSiteTermStoreSet -SiteId <String> [-AdditionalProperties <Hashtable>]
 [-Children <IMicrosoftGraphTermStoreTerm[]>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-Id <String>] [-LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]
 [-ParentGroup <IMicrosoftGraphTermStoreGroup1>] [-Properties <IMicrosoftGraphKeyValue[]>]
 [-Relations <IMicrosoftGraphTermStoreRelation1[]>] [-Terms <IMicrosoftGraphTermStoreTerm[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgSiteTermStoreSet -SiteId <String> -StoreId <String> -BodyParameter <IMicrosoftGraphTermStoreSet>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create2
```
New-MgSiteTermStoreSet -SiteId <String> -BodyParameter <IMicrosoftGraphTermStoreSet> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateExpanded
```
New-MgSiteTermStoreSet -SiteId <String> -StoreId <String> [-AdditionalProperties <Hashtable>]
 [-Children <IMicrosoftGraphTermStoreTerm[]>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-Id <String>] [-LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]
 [-ParentGroup <IMicrosoftGraphTermStoreGroup1>] [-Properties <IMicrosoftGraphKeyValue[]>]
 [-Relations <IMicrosoftGraphTermStoreRelation1[]>] [-Terms <IMicrosoftGraphTermStoreTerm[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgSiteTermStoreSet -InputObject <ISitesIdentity> -BodyParameter <IMicrosoftGraphTermStoreSet> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity2
```
New-MgSiteTermStoreSet -InputObject <ISitesIdentity> -BodyParameter <IMicrosoftGraphTermStoreSet> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgSiteTermStoreSet -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-Children <IMicrosoftGraphTermStoreTerm[]>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-Id <String>] [-LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]
 [-ParentGroup <IMicrosoftGraphTermStoreGroup1>] [-Properties <IMicrosoftGraphKeyValue[]>]
 [-Relations <IMicrosoftGraphTermStoreRelation1[]>] [-Terms <IMicrosoftGraphTermStoreTerm[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded2
```
New-MgSiteTermStoreSet -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-Children <IMicrosoftGraphTermStoreTerm[]>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-Id <String>] [-LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]
 [-ParentGroup <IMicrosoftGraphTermStoreGroup1>] [-Properties <IMicrosoftGraphKeyValue[]>]
 [-Relations <IMicrosoftGraphTermStoreRelation1[]>] [-Terms <IMicrosoftGraphTermStoreTerm[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to sets for sites

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateExpanded2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
set
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreSet
Parameter Sets: Create, Create2, CreateViaIdentity, CreateViaIdentity2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Children
Children terms of set in term [store].
To construct, please use Get-Help -Online and see NOTES section for CHILDREN properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreTerm[]
Parameter Sets: CreateExpanded, CreateExpanded2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Date and time of set creation.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateExpanded2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description giving details on the term usage.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
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
Parameter Sets: CreateExpanded, CreateExpanded2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ISitesIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentity2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LocalizedNames
Name of the set for each languageTag.
To construct, please use Get-Help -Online and see NOTES section for LOCALIZEDNAMES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreLocalizedName[]
Parameter Sets: CreateExpanded, CreateExpanded2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentGroup
group
To construct, please use Get-Help -Online and see NOTES section for PARENTGROUP properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreGroup1
Parameter Sets: CreateExpanded, CreateExpanded2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Properties
Custom properties for the set.
To construct, please use Get-Help -Online and see NOTES section for PROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValue[]
Parameter Sets: CreateExpanded, CreateExpanded2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Relations
Indicates which terms have been pinned or reused directly under the set.
To construct, please use Get-Help -Online and see NOTES section for RELATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreRelation1[]
Parameter Sets: CreateExpanded, CreateExpanded2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteId
key: id of site

```yaml
Type: System.String
Parameter Sets: Create, Create2, CreateExpanded, CreateExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StoreId
key: id of store

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Terms
All the terms under the set.
To construct, please use Get-Help -Online and see NOTES section for TERMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreTerm[]
Parameter Sets: CreateExpanded, CreateExpanded2, CreateViaIdentityExpanded, CreateViaIdentityExpanded2
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreSet

### Microsoft.Graph.PowerShell.Models.ISitesIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreSet

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTermStoreSet>: set
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
    - `[Id <String>]`: 
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
    - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
      - `[Id <String>]`: 
      - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
      - `[Relationship <String>]`: 
      - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
    - `[Set <IMicrosoftGraphTermStoreSet>]`: set
  - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
  - `[Description <String>]`: Description giving details on the term usage.
  - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
    - `[LanguageTag <String>]`: The language tag for the label.
    - `[Name <String>]`: The name in the localized language.
  - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
    - `[Description <String>]`: Description that gives details on the term usage.
    - `[DisplayName <String>]`: Name of the group.
    - `[ParentSiteId <String>]`: ID of the parent site of this group.
    - `[Scope <String>]`: 
    - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
  - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
  - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
  - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.

CHILDREN <IMicrosoftGraphTermStoreTerm[]>: Children terms of set in term [store].
  - `[Id <String>]`: 
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
  - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
    - `[Id <String>]`: 
    - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
    - `[Relationship <String>]`: 
    - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
      - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
      - `[Description <String>]`: Description giving details on the term usage.
      - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
        - `[LanguageTag <String>]`: The language tag for the label.
        - `[Name <String>]`: The name in the localized language.
      - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
        - `[Description <String>]`: Description that gives details on the term usage.
        - `[DisplayName <String>]`: Name of the group.
        - `[ParentSiteId <String>]`: ID of the parent site of this group.
        - `[Scope <String>]`: 
        - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
      - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
      - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
      - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
    - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
  - `[Set <IMicrosoftGraphTermStoreSet>]`: set

INPUTOBJECT <ISitesIdentity>: Identity Parameter
  - `[BaseItemId <String>]`: key: id of baseItem
  - `[ColumnDefinitionId <String>]`: key: id of columnDefinition
  - `[ColumnLinkId <String>]`: key: id of columnLink
  - `[ContentTypeId <String>]`: key: id of contentType
  - `[ContentTypeId1 <String>]`: key: id of contentType
  - `[DocumentSetVersionId <String>]`: key: id of documentSetVersion
  - `[DriveId <String>]`: key: id of drive
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: key: id of group
  - `[GroupId1 <String>]`: key: id of group
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListId <String>]`: key: id of list
  - `[ListId1 <String>]`: Usage: listId='{listId}'
  - `[ListItemId <String>]`: key: id of listItem
  - `[ListItemVersionId <String>]`: key: id of listItemVersion
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[PermissionId <String>]`: key: id of permission
  - `[RelationId <String>]`: key: id of relation
  - `[RichLongRunningOperationId <String>]`: key: id of richLongRunningOperation
  - `[SetId <String>]`: key: id of set
  - `[SetId1 <String>]`: key: id of set
  - `[SiteId <String>]`: key: id of site
  - `[SiteId1 <String>]`: key: id of site
  - `[SitePageId <String>]`: key: id of sitePage
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[StoreId <String>]`: key: id of store
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[TermId <String>]`: key: id of term
  - `[TermId1 <String>]`: key: id of term
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: key: id of user

LOCALIZEDNAMES <IMicrosoftGraphTermStoreLocalizedName[]>: Name of the set for each languageTag.
  - `[LanguageTag <String>]`: The language tag for the label.
  - `[Name <String>]`: The name in the localized language.

PARENTGROUP <IMicrosoftGraphTermStoreGroup1>: group
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
  - `[Description <String>]`: Description that gives details on the term usage.
  - `[DisplayName <String>]`: Name of the group.
  - `[ParentSiteId <String>]`: ID of the parent site of this group.
  - `[Scope <String>]`: 
  - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
    - `[Id <String>]`: 
    - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
      - `[Id <String>]`: 
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
      - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
        - `[Id <String>]`: 
        - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[Relationship <String>]`: 
        - `[Set <IMicrosoftGraphTermStoreSet>]`: set
        - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
      - `[Set <IMicrosoftGraphTermStoreSet>]`: set
    - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
    - `[Description <String>]`: Description giving details on the term usage.
    - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
      - `[LanguageTag <String>]`: The language tag for the label.
      - `[Name <String>]`: The name in the localized language.
    - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
    - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
    - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
    - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.

PROPERTIES <IMicrosoftGraphKeyValue[]>: Custom properties for the set.
  - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
  - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.

RELATIONS <IMicrosoftGraphTermStoreRelation1[]>: Indicates which terms have been pinned or reused directly under the set.
  - `[Id <String>]`: 
  - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
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
    - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
    - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
      - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
      - `[Description <String>]`: Description giving details on the term usage.
      - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
        - `[LanguageTag <String>]`: The language tag for the label.
        - `[Name <String>]`: The name in the localized language.
      - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
        - `[Description <String>]`: Description that gives details on the term usage.
        - `[DisplayName <String>]`: Name of the group.
        - `[ParentSiteId <String>]`: ID of the parent site of this group.
        - `[Scope <String>]`: 
        - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
      - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
      - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
      - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
  - `[Relationship <String>]`: 
  - `[Set <IMicrosoftGraphTermStoreSet>]`: set
  - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term

TERMS <IMicrosoftGraphTermStoreTerm[]>: All the terms under the set.
  - `[Id <String>]`: 
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
  - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
    - `[Id <String>]`: 
    - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
    - `[Relationship <String>]`: 
    - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
      - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
      - `[Description <String>]`: Description giving details on the term usage.
      - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
        - `[LanguageTag <String>]`: The language tag for the label.
        - `[Name <String>]`: The name in the localized language.
      - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
        - `[Description <String>]`: Description that gives details on the term usage.
        - `[DisplayName <String>]`: Name of the group.
        - `[ParentSiteId <String>]`: ID of the parent site of this group.
        - `[Scope <String>]`: 
        - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
      - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
      - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
      - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
    - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
  - `[Set <IMicrosoftGraphTermStoreSet>]`: set

## RELATED LINKS


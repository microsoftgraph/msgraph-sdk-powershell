---
external help file:
Module Name: Microsoft.Graph.Sites
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites/update-mgsitetermstoregroupsetparentgroup
schema: 2.0.0
---

# Update-MgSiteTermStoreGroupSetParentGroup

## SYNOPSIS
Update the navigation property parentGroup in sites

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSiteTermStoreGroupSetParentGroup -GroupId <String> -SetId <String> -SiteId <String> -StoreId <String>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-ParentSiteId <String>] [-Scope <String>]
 [-Sets <IMicrosoftGraphTermStoreSet[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgSiteTermStoreGroupSetParentGroup -GroupId <String> -SetId <String> -SiteId <String> -StoreId <String>
 -BodyParameter <IMicrosoftGraphTermStoreGroup1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSiteTermStoreGroupSetParentGroup -InputObject <ISitesIdentity>
 -BodyParameter <IMicrosoftGraphTermStoreGroup1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSiteTermStoreGroupSetParentGroup -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-ParentSiteId <String>] [-Scope <String>] [-Sets <IMicrosoftGraphTermStoreSet[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property parentGroup in sites

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
group
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreGroup1
Parameter Sets: Update, UpdateViaIdentity
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
key: id of group

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scope
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SetId
key: id of set

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sets
All sets under the group in a term [store].
To construct, please use Get-Help -Online and see NOTES section for SETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreSet[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
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
Parameter Sets: Update, UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermStoreGroup1

### Microsoft.Graph.PowerShell.Models.ISitesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTermStoreGroup1>: group
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

SETS <IMicrosoftGraphTermStoreSet[]>: All sets under the group in a term [store].
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

## RELATED LINKS


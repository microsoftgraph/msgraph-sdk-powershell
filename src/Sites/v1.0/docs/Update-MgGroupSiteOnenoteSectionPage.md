---
external help file:
Module Name: Microsoft.Graph.Sites
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.sites/update-mggroupsiteonenotesectionpage
schema: 2.0.0
---

# Update-MgGroupSiteOnenoteSectionPage

## SYNOPSIS
Update the navigation property pages in groups

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgGroupSiteOnenoteSectionPage -GroupId <String> -OnenotePageId <String> -OnenoteSectionId <String>
 -SiteId <String> [-AdditionalProperties <Hashtable>] [-ContentInputFile <String>] [-ContentUrl <String>]
 [-CreatedByAppId <String>] [-CreatedDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Level <Int32>] [-Links <IMicrosoftGraphPageLinks>] [-Order <Int32>]
 [-ParentNotebook <IMicrosoftGraphNotebook>] [-ParentSection <IMicrosoftGraphOnenoteSection>] [-Self <String>]
 [-Title <String>] [-UserTags <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgGroupSiteOnenoteSectionPage -GroupId <String> -OnenotePageId <String> -OnenoteSectionId <String>
 -SiteId <String> -BodyParameter <IMicrosoftGraphOnenotePage> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgGroupSiteOnenoteSectionPage -InputObject <ISitesIdentity> -BodyParameter <IMicrosoftGraphOnenotePage>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgGroupSiteOnenoteSectionPage -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-ContentInputFile <String>] [-ContentUrl <String>] [-CreatedByAppId <String>] [-CreatedDateTime <DateTime>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>] [-Level <Int32>] [-Links <IMicrosoftGraphPageLinks>]
 [-Order <Int32>] [-ParentNotebook <IMicrosoftGraphNotebook>] [-ParentSection <IMicrosoftGraphOnenoteSection>]
 [-Self <String>] [-Title <String>] [-UserTags <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property pages in groups

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



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
onenotePage
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenotePage
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentInputFile
Input File for Content (The page's HTML content.)

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

### -ContentUrl
The URL for the page's HTML content.
Read-only.

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

### -CreatedByAppId
The unique identifier of the application that created the page.
Read-only.

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

### -CreatedDateTime
The date and time when the page was created.
The timestamp represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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

### -GroupId
The unique identifier of group

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
The unique idenfier for an entity.
Read-only.

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -LastModifiedDateTime
The date and time when the page was last modified.
The timestamp represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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

### -Level
The indentation level of the page.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Links
pageLinks
To construct, see NOTES section for LINKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPageLinks
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnenotePageId
The unique identifier of onenotePage

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

### -OnenoteSectionId
The unique identifier of onenoteSection

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

### -Order
The order of the page within its parent section.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentNotebook
notebook
To construct, see NOTES section for PARENTNOTEBOOK properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNotebook
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentSection
onenoteSection
To construct, see NOTES section for PARENTSECTION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteSection
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Self
The endpoint where you can get details about the page.
Read-only.

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

### -SiteId
The unique identifier of site

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

### -Title
The title of the page.

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

### -UserTags
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenotePage

### Microsoft.Graph.PowerShell.Models.ISitesIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenotePage

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphOnenotePage>`: onenotePage
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Content <Byte[]>]`: The page's HTML content.
  - `[ContentUrl <String>]`: The URL for the page's HTML content.  Read-only.
  - `[CreatedByAppId <String>]`: The unique identifier of the application that created the page. Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Level <Int32?>]`: The indentation level of the page. Read-only.
  - `[Links <IMicrosoftGraphPageLinks>]`: pageLinks
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Href <String>]`: The URL of the link.
    - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
  - `[Order <Int32?>]`: The order of the page within its parent section. Read-only.
  - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
    - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
    - `[Links <IMicrosoftGraphNotebookLinks>]`: notebookLinks
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
    - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
      - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the section. Read-only. Nullable.
      - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
      - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the section group. Read-only. Nullable.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[DisplayName <String>]`: The name of the notebook.
        - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
        - `[Links <IMicrosoftGraphSectionLinks>]`: sectionLinks
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
          - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
        - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
        - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
        - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
      - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
    - `[UserRole <String>]`: onenoteUserRole
  - `[ParentSection <IMicrosoftGraphOnenoteSection>]`: onenoteSection
  - `[Title <String>]`: The title of the page.
  - `[UserTags <String[]>]`: 

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

`LINKS <IMicrosoftGraphPageLinks>`: pageLinks
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Href <String>]`: The URL of the link.
  - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink

`PARENTNOTEBOOK <IMicrosoftGraphNotebook>`: notebook
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
  - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
  - `[Links <IMicrosoftGraphNotebookLinks>]`: notebookLinks
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Href <String>]`: The URL of the link.
    - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
  - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
    - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
    - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the section. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the section group. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
      - `[Links <IMicrosoftGraphSectionLinks>]`: sectionLinks
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[Content <Byte[]>]`: The page's HTML content.
        - `[ContentUrl <String>]`: The URL for the page's HTML content.  Read-only.
        - `[CreatedByAppId <String>]`: The unique identifier of the application that created the page. Read-only.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Level <Int32?>]`: The indentation level of the page. Read-only.
        - `[Links <IMicrosoftGraphPageLinks>]`: pageLinks
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
          - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[Order <Int32?>]`: The order of the page within its parent section. Read-only.
        - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
        - `[ParentSection <IMicrosoftGraphOnenoteSection>]`: onenoteSection
        - `[Title <String>]`: The title of the page.
        - `[UserTags <String[]>]`: 
      - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
      - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
  - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
  - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
  - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
  - `[UserRole <String>]`: onenoteUserRole

`PARENTSECTION <IMicrosoftGraphOnenoteSection>`: onenoteSection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
  - `[Links <IMicrosoftGraphSectionLinks>]`: sectionLinks
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Href <String>]`: The URL of the link.
    - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
  - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Content <Byte[]>]`: The page's HTML content.
    - `[ContentUrl <String>]`: The URL for the page's HTML content.  Read-only.
    - `[CreatedByAppId <String>]`: The unique identifier of the application that created the page. Read-only.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Level <Int32?>]`: The indentation level of the page. Read-only.
    - `[Links <IMicrosoftGraphPageLinks>]`: pageLinks
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
    - `[Order <Int32?>]`: The order of the page within its parent section. Read-only.
    - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
      - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
      - `[Links <IMicrosoftGraphNotebookLinks>]`: notebookLinks
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[DisplayName <String>]`: The name of the notebook.
        - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
        - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
        - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the section. Read-only. Nullable.
        - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
        - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the section group. Read-only. Nullable.
        - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
      - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
      - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
      - `[UserRole <String>]`: onenoteUserRole
    - `[ParentSection <IMicrosoftGraphOnenoteSection>]`: onenoteSection
    - `[Title <String>]`: The title of the page.
    - `[UserTags <String[]>]`: 
  - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
  - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
  - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup

## RELATED LINKS


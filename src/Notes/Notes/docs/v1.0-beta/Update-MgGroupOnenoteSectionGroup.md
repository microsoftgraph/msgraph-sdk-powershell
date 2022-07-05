---
external help file:
Module Name: Microsoft.Graph.Notes
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.notes/update-mggrouponenotesectiongroup
schema: 2.0.0
---

# Update-MgGroupOnenoteSectionGroup

## SYNOPSIS
Update the navigation property sectionGroups in groups

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgGroupOnenoteSectionGroup -GroupId <String> -SectionGroupId <String>
 [-AdditionalProperties <Hashtable>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-ParentNotebook <IMicrosoftGraphNotebook1>]
 [-ParentSectionGroup <IMicrosoftGraphSectionGroup1>] [-SectionGroups <IMicrosoftGraphSectionGroup1[]>]
 [-SectionGroupsUrl <String>] [-Sections <IMicrosoftGraphOnenoteSection1[]>] [-SectionsUrl <String>]
 [-Self <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgGroupOnenoteSectionGroup -GroupId <String> -SectionGroupId <String>
 -BodyParameter <IMicrosoftGraphSectionGroup1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgGroupOnenoteSectionGroup -InputObject <INotesIdentity> -BodyParameter <IMicrosoftGraphSectionGroup1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgGroupOnenoteSectionGroup -InputObject <INotesIdentity> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>] [-DisplayName <String>]
 [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-ParentNotebook <IMicrosoftGraphNotebook1>] [-ParentSectionGroup <IMicrosoftGraphSectionGroup1>]
 [-SectionGroups <IMicrosoftGraphSectionGroup1[]>] [-SectionGroupsUrl <String>]
 [-Sections <IMicrosoftGraphOnenoteSection1[]>] [-SectionsUrl <String>] [-Self <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property sectionGroups in groups

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
sectionGroup
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name of the notebook.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: Update1, UpdateExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.INotesIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The date and time when the notebook was last modified.
The timestamp represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentNotebook
notebook
To construct, please use Get-Help -Online and see NOTES section for PARENTNOTEBOOK properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNotebook1
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentSectionGroup
sectionGroup
To construct, please use Get-Help -Online and see NOTES section for PARENTSECTIONGROUP properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup1
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -SectionGroupId
key: id of sectionGroup

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

### -SectionGroups
The section groups in the section.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for SECTIONGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SectionGroupsUrl
The URL for the sectionGroups navigation property, which returns all the section groups in the section group.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sections
The sections in the section group.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for SECTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteSection1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SectionsUrl
The URL for the sections navigation property, which returns all the sections in the section group.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup1

### Microsoft.Graph.PowerShell.Models.INotesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSectionGroup1>: sectionGroup
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: 
  - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: 
    - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
    - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
    - `[Links <IMicrosoftGraphNotebookLinks>]`: notebookLinks
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Href <String>]`: The url of the link.
      - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
    - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: 
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
      - `[Links <IMicrosoftGraphSectionLinks>]`: sectionLinks
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: 
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
        - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
        - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
        - `[Title <String>]`: The title of the page.
        - `[UserTags <String[]>]`: 
      - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
      - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
    - `[UserRole <String>]`: onenoteUserRole
  - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
  - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the section. Read-only. Nullable.
  - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
  - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the section group. Read-only. Nullable.
  - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

INPUTOBJECT <INotesIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: id of group
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenoteOperationId <String>]`: key: id of onenoteOperation
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteResourceId <String>]`: key: id of onenoteResource
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[SectionGroupId <String>]`: key: id of sectionGroup
  - `[SiteId <String>]`: key: id of site
  - `[UserId <String>]`: key: id of user

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

PARENTNOTEBOOK <IMicrosoftGraphNotebook1>: notebook
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: 
  - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
  - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
  - `[Links <IMicrosoftGraphNotebookLinks>]`: notebookLinks
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Href <String>]`: The url of the link.
    - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
  - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: 
    - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
    - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
    - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the section. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the section group. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: 
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
      - `[Links <IMicrosoftGraphSectionLinks>]`: sectionLinks
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: 
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
        - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
        - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
        - `[Title <String>]`: The title of the page.
        - `[UserTags <String[]>]`: 
      - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
      - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
  - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
  - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
  - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
  - `[UserRole <String>]`: onenoteUserRole

PARENTSECTIONGROUP <IMicrosoftGraphSectionGroup1>: sectionGroup
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: 
  - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: 
    - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
    - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
    - `[Links <IMicrosoftGraphNotebookLinks>]`: notebookLinks
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Href <String>]`: The url of the link.
      - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
    - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: 
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
      - `[Links <IMicrosoftGraphSectionLinks>]`: sectionLinks
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: 
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
        - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
        - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
        - `[Title <String>]`: The title of the page.
        - `[UserTags <String[]>]`: 
      - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
      - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
    - `[UserRole <String>]`: onenoteUserRole
  - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
  - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the section. Read-only. Nullable.
  - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
  - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the section group. Read-only. Nullable.
  - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.

SECTIONGROUPS <IMicrosoftGraphSectionGroup1[]>: The section groups in the section. Read-only. Nullable.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: 
  - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: 
    - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
    - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
    - `[Links <IMicrosoftGraphNotebookLinks>]`: notebookLinks
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Href <String>]`: The url of the link.
      - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
    - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: 
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
      - `[Links <IMicrosoftGraphSectionLinks>]`: sectionLinks
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: 
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
        - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
        - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
        - `[Title <String>]`: The title of the page.
        - `[UserTags <String[]>]`: 
      - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
      - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
    - `[UserRole <String>]`: onenoteUserRole
  - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
  - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the section. Read-only. Nullable.
  - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
  - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the section group. Read-only. Nullable.
  - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.

SECTIONS <IMicrosoftGraphOnenoteSection1[]>: The sections in the section group. Read-only. Nullable.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: 
  - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
  - `[Links <IMicrosoftGraphSectionLinks>]`: sectionLinks
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Href <String>]`: The url of the link.
    - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
  - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: 
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
    - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: 
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
      - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
      - `[Links <IMicrosoftGraphNotebookLinks>]`: notebookLinks
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[OneNoteClientUrl <IMicrosoftGraphExternalLink>]`: externalLink
        - `[OneNoteWebUrl <IMicrosoftGraphExternalLink>]`: externalLink
      - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[DisplayName <String>]`: The name of the notebook.
        - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: 
        - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
        - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
        - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the section. Read-only. Nullable.
        - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
        - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the section group. Read-only. Nullable.
        - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
      - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
      - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
      - `[UserRole <String>]`: onenoteUserRole
    - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
    - `[Title <String>]`: The title of the page.
    - `[UserTags <String[]>]`: 
  - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
  - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
  - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup

## RELATED LINKS


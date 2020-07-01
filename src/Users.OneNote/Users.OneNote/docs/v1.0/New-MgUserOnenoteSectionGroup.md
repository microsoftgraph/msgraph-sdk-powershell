---
external help file:
Module Name: Microsoft.Graph.Users.OneNote
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.onenote/new-mguseronenotesectiongroup
schema: 2.0.0
---

# New-MgUserOnenoteSectionGroup

## SYNOPSIS
Create new navigation property to sectionGroups for users

## SYNTAX

### CreateExpanded2 (Default)
```
New-MgUserOnenoteSectionGroup -UserId <String> [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-ParentNotebook <IMicrosoftGraphNotebook1>] [-ParentSectionGroup <IMicrosoftGraphSectionGroup1>]
 [-SectionGroups <IMicrosoftGraphSectionGroup1[]>] [-SectionGroupsUrl <String>]
 [-Sections <IMicrosoftGraphOnenoteSection1[]>] [-SectionsUrl <String>] [-Self <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create2
```
New-MgUserOnenoteSectionGroup -UserId <String> -BodyParameter <IMicrosoftGraphSectionGroup1> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create3
```
New-MgUserOnenoteSectionGroup -SectionGroupId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphSectionGroup1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded3
```
New-MgUserOnenoteSectionGroup -SectionGroupId <String> -UserId <String>
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>] [-DisplayName <String>]
 [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-ParentNotebook <IMicrosoftGraphNotebook1>] [-ParentSectionGroup <IMicrosoftGraphSectionGroup1>]
 [-SectionGroups <IMicrosoftGraphSectionGroup1[]>] [-SectionGroupsUrl <String>]
 [-Sections <IMicrosoftGraphOnenoteSection1[]>] [-SectionsUrl <String>] [-Self <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity2
```
New-MgUserOnenoteSectionGroup -InputObject <IUsersOneNoteIdentity>
 -BodyParameter <IMicrosoftGraphSectionGroup1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity3
```
New-MgUserOnenoteSectionGroup -InputObject <IUsersOneNoteIdentity>
 -BodyParameter <IMicrosoftGraphSectionGroup1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded2
```
New-MgUserOnenoteSectionGroup -InputObject <IUsersOneNoteIdentity> [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-ParentNotebook <IMicrosoftGraphNotebook1>] [-ParentSectionGroup <IMicrosoftGraphSectionGroup1>]
 [-SectionGroups <IMicrosoftGraphSectionGroup1[]>] [-SectionGroupsUrl <String>]
 [-Sections <IMicrosoftGraphOnenoteSection1[]>] [-SectionsUrl <String>] [-Self <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded3
```
New-MgUserOnenoteSectionGroup -InputObject <IUsersOneNoteIdentity> [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-ParentNotebook <IMicrosoftGraphNotebook1>] [-ParentSectionGroup <IMicrosoftGraphSectionGroup1>]
 [-SectionGroups <IMicrosoftGraphSectionGroup1[]>] [-SectionGroupsUrl <String>]
 [-Sections <IMicrosoftGraphOnenoteSection1[]>] [-SectionsUrl <String>] [-Self <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to sectionGroups for users

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
sectionGroup
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup1
Parameter Sets: Create2, Create3, CreateViaIdentity2, CreateViaIdentity3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
Type: System.String
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
Type: Microsoft.Graph.PowerShell.Models.IUsersOneNoteIdentity
Parameter Sets: CreateViaIdentity2, CreateViaIdentity3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNotebook1
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentSectionGroup
sectionGroup
To construct, see NOTES section for PARENTSECTIONGROUP properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup1
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SectionGroupId
key: sectionGroup-id of sectionGroup

```yaml
Type: System.String
Parameter Sets: Create3, CreateExpanded3
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
To construct, see NOTES section for SECTIONGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup1[]
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
To construct, see NOTES section for SECTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteSection1[]
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Create2, Create3, CreateExpanded2, CreateExpanded3
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup1

### Microsoft.Graph.PowerShell.Models.IUsersOneNoteIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSectionGroup1>: sectionGroup
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: Read-only.
  - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: Read-only.
    - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
    - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
    - `[OneNoteClientUrlHref <String>]`: The url of the link.
    - `[OneNoteWebUrlHref <String>]`: The url of the link.
    - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: Read-only.
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
      - `[LinksOneNoteClientUrlHref <String>]`: The url of the link.
      - `[LinksOneNoteWebUrlHref <String>]`: The url of the link.
      - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: Read-only.
        - `[Content <Byte[]>]`: The page's HTML content.
        - `[ContentUrl <String>]`: The URL for the page's HTML content.  Read-only.
        - `[CreatedByAppId <String>]`: The unique identifier of the application that created the page. Read-only.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[Level <Int32?>]`: The indentation level of the page. Read-only.
        - `[LinksOneNoteClientUrlHref <String>]`: The url of the link.
        - `[LinksOneNoteWebUrlHref <String>]`: The url of the link.
        - `[Order <Int32?>]`: The order of the page within its parent section. Read-only.
        - `[ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
        - `[ParentNotebookId <String>]`: Read-only.
        - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
        - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
        - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
        - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
        - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
        - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
        - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[ParentNotebookUserRole <String>]`: onenoteUserRole
        - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
        - `[Title <String>]`: The title of the page.
        - `[UserTags <String[]>]`: 
      - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
      - `[ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
      - `[ParentNotebookId <String>]`: Read-only.
      - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
      - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
      - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
      - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
      - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
      - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
      - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[ParentNotebookUserRole <String>]`: onenoteUserRole
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
    - `[UserRole <String>]`: onenoteUserRole
  - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
  - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the section. Read-only. Nullable.
  - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
  - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the section group. Read-only. Nullable.
  - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

INPUTOBJECT <IUsersOneNoteIdentity>: Identity Parameter
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenoteOperationId <String>]`: key: onenoteOperation-id of onenoteOperation
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenotePageId1 <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteResourceId <String>]`: key: onenoteResource-id of onenoteResource
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[OnenoteSectionId1 <String>]`: key: onenoteSection-id of onenoteSection
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[SectionGroupId1 <String>]`: key: sectionGroup-id of sectionGroup
  - `[UserId <String>]`: key: user-id of user

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

PARENTNOTEBOOK <IMicrosoftGraphNotebook1>: notebook
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: Read-only.
  - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
  - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
  - `[OneNoteClientUrlHref <String>]`: The url of the link.
  - `[OneNoteWebUrlHref <String>]`: The url of the link.
  - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: Read-only.
    - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
    - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
    - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the section. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the section group. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: Read-only.
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
      - `[LinksOneNoteClientUrlHref <String>]`: The url of the link.
      - `[LinksOneNoteWebUrlHref <String>]`: The url of the link.
      - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: Read-only.
        - `[Content <Byte[]>]`: The page's HTML content.
        - `[ContentUrl <String>]`: The URL for the page's HTML content.  Read-only.
        - `[CreatedByAppId <String>]`: The unique identifier of the application that created the page. Read-only.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[Level <Int32?>]`: The indentation level of the page. Read-only.
        - `[LinksOneNoteClientUrlHref <String>]`: The url of the link.
        - `[LinksOneNoteWebUrlHref <String>]`: The url of the link.
        - `[Order <Int32?>]`: The order of the page within its parent section. Read-only.
        - `[ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
        - `[ParentNotebookId <String>]`: Read-only.
        - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
        - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
        - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
        - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
        - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
        - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
        - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[ParentNotebookUserRole <String>]`: onenoteUserRole
        - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
        - `[Title <String>]`: The title of the page.
        - `[UserTags <String[]>]`: 
      - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
      - `[ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
      - `[ParentNotebookId <String>]`: Read-only.
      - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
      - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
      - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
      - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
      - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
      - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
      - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[ParentNotebookUserRole <String>]`: onenoteUserRole
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
  - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
  - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
  - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
  - `[UserRole <String>]`: onenoteUserRole

PARENTSECTIONGROUP <IMicrosoftGraphSectionGroup1>: sectionGroup
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: Read-only.
  - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: Read-only.
    - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
    - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
    - `[OneNoteClientUrlHref <String>]`: The url of the link.
    - `[OneNoteWebUrlHref <String>]`: The url of the link.
    - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: Read-only.
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
      - `[LinksOneNoteClientUrlHref <String>]`: The url of the link.
      - `[LinksOneNoteWebUrlHref <String>]`: The url of the link.
      - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: Read-only.
        - `[Content <Byte[]>]`: The page's HTML content.
        - `[ContentUrl <String>]`: The URL for the page's HTML content.  Read-only.
        - `[CreatedByAppId <String>]`: The unique identifier of the application that created the page. Read-only.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[Level <Int32?>]`: The indentation level of the page. Read-only.
        - `[LinksOneNoteClientUrlHref <String>]`: The url of the link.
        - `[LinksOneNoteWebUrlHref <String>]`: The url of the link.
        - `[Order <Int32?>]`: The order of the page within its parent section. Read-only.
        - `[ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
        - `[ParentNotebookId <String>]`: Read-only.
        - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
        - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
        - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
        - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
        - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
        - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
        - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[ParentNotebookUserRole <String>]`: onenoteUserRole
        - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
        - `[Title <String>]`: The title of the page.
        - `[UserTags <String[]>]`: 
      - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
      - `[ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
      - `[ParentNotebookId <String>]`: Read-only.
      - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
      - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
      - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
      - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
      - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
      - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
      - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[ParentNotebookUserRole <String>]`: onenoteUserRole
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
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: Read-only.
  - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: Read-only.
    - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
    - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
    - `[OneNoteClientUrlHref <String>]`: The url of the link.
    - `[OneNoteWebUrlHref <String>]`: The url of the link.
    - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: Read-only.
      - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
      - `[LinksOneNoteClientUrlHref <String>]`: The url of the link.
      - `[LinksOneNoteWebUrlHref <String>]`: The url of the link.
      - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: Read-only.
        - `[Content <Byte[]>]`: The page's HTML content.
        - `[ContentUrl <String>]`: The URL for the page's HTML content.  Read-only.
        - `[CreatedByAppId <String>]`: The unique identifier of the application that created the page. Read-only.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[Level <Int32?>]`: The indentation level of the page. Read-only.
        - `[LinksOneNoteClientUrlHref <String>]`: The url of the link.
        - `[LinksOneNoteWebUrlHref <String>]`: The url of the link.
        - `[Order <Int32?>]`: The order of the page within its parent section. Read-only.
        - `[ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
        - `[ParentNotebookId <String>]`: Read-only.
        - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
        - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
        - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
        - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
        - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
        - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
        - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[ParentNotebookUserRole <String>]`: onenoteUserRole
        - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
        - `[Title <String>]`: The title of the page.
        - `[UserTags <String[]>]`: 
      - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
      - `[ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
      - `[ParentNotebookId <String>]`: Read-only.
      - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
      - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
      - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
      - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
      - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
      - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
      - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[ParentNotebookUserRole <String>]`: onenoteUserRole
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
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: The name of the notebook.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: Read-only.
  - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default section. Read-only.
  - `[LinksOneNoteClientUrlHref <String>]`: The url of the link.
  - `[LinksOneNoteWebUrlHref <String>]`: The url of the link.
  - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The collection of pages in the section.  Read-only. Nullable.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: Read-only.
    - `[Content <Byte[]>]`: The page's HTML content.
    - `[ContentUrl <String>]`: The URL for the page's HTML content.  Read-only.
    - `[CreatedByAppId <String>]`: The unique identifier of the application that created the page. Read-only.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the page was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[Level <Int32?>]`: The indentation level of the page. Read-only.
    - `[LinksOneNoteClientUrlHref <String>]`: The url of the link.
    - `[LinksOneNoteWebUrlHref <String>]`: The url of the link.
    - `[Order <Int32?>]`: The order of the page within its parent section. Read-only.
    - `[ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
    - `[ParentNotebookId <String>]`: Read-only.
    - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
    - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
    - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
    - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
    - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: Read-only.
      - `[ParentNotebook <IMicrosoftGraphNotebook1>]`: notebook
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[DisplayName <String>]`: The name of the notebook.
        - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[Id <String>]`: Read-only.
        - `[IsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
        - `[IsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
        - `[OneNoteClientUrlHref <String>]`: The url of the link.
        - `[OneNoteWebUrlHref <String>]`: The url of the link.
        - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
        - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
        - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
        - `[UserRole <String>]`: onenoteUserRole
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup
      - `[SectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the section. Read-only. Nullable.
      - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
      - `[Sections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the section group. Read-only. Nullable.
      - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
    - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
    - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
    - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[ParentNotebookUserRole <String>]`: onenoteUserRole
    - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
    - `[Title <String>]`: The title of the page.
    - `[UserTags <String[]>]`: 
  - `[PagesUrl <String>]`: The pages endpoint where you can get details for all the pages in the section. Read-only.
  - `[ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
  - `[ParentNotebookId <String>]`: Read-only.
  - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
  - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
  - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
  - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
  - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>]`: The section groups in the notebook. Read-only. Nullable.
  - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
  - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
  - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
  - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[ParentNotebookUserRole <String>]`: onenoteUserRole
  - `[ParentSectionGroup <IMicrosoftGraphSectionGroup1>]`: sectionGroup

## RELATED LINKS


---
external help file:
Module Name: Microsoft.Graph.Users.OneNote
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.onenote/update-mguseronenote
schema: 2.0.0
---

# Update-MgUserOnenote

## SYNOPSIS
Update the navigation property onenote in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserOnenote -UserId <String> [-Id <String>] [-Notebooks <IMicrosoftGraphNotebook[]>]
 [-Operations <IMicrosoftGraphOnenoteOperation[]>] [-Pages <IMicrosoftGraphOnenotePage[]>]
 [-Resources <IMicrosoftGraphOnenoteResource[]>] [-SectionGroups <IMicrosoftGraphSectionGroup[]>]
 [-Sections <IMicrosoftGraphOnenoteSection[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserOnenote -UserId <String> -BodyParameter <IMicrosoftGraphOnenote> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserOnenote -InputObject <IUsersOneNoteIdentity> -BodyParameter <IMicrosoftGraphOnenote> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserOnenote -InputObject <IUsersOneNoteIdentity> [-Id <String>]
 [-Notebooks <IMicrosoftGraphNotebook[]>] [-Operations <IMicrosoftGraphOnenoteOperation[]>]
 [-Pages <IMicrosoftGraphOnenotePage[]>] [-Resources <IMicrosoftGraphOnenoteResource[]>]
 [-SectionGroups <IMicrosoftGraphSectionGroup[]>] [-Sections <IMicrosoftGraphOnenoteSection[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property onenote in users

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
onenote
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenote
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Id
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
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersOneNoteIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Notebooks
The collection of OneNote notebooks that are owned by the user or group.
Read-only.
Nullable.
To construct, see NOTES section for NOTEBOOKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNotebook[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Operations
The status of OneNote operations.
Getting an operations collection is not supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response.
Read-only.
Nullable.
To construct, see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteOperation[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Pages
The pages in all OneNote notebooks that are owned by the user or group.
Read-only.
Nullable.
To construct, see NOTES section for PAGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenotePage[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Resources
The image and other file resources in OneNote pages.
Getting a resources collection is not supported, but you can get the binary content of a specific resource.
Read-only.
Nullable.
To construct, see NOTES section for RESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteResource[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SectionGroups
The section groups in all OneNote notebooks that are owned by the user or group.
Read-only.
Nullable.
To construct, see NOTES section for SECTIONGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Sections
The sections in all OneNote notebooks that are owned by the user or group.
Read-only.
Nullable.
To construct, see NOTES section for SECTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteSection[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenote

### Microsoft.Graph.PowerShell.Models.IUsersOneNoteIdentity

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphOnenote>: onenote
  - `[Id <String>]`: Read-only.
  - `[Notebooks <IMicrosoftGraphNotebook[]>]`: The collection of OneNote notebooks that are owned by the user or group. Read-only. Nullable.
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
    - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: Read-only.
      - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
      - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the section. Read-only. Nullable.
      - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
      - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the section group. Read-only. Nullable.
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
          - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
          - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
          - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
          - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
          - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
          - `[ParentNotebookUserRole <String>]`: onenoteUserRole
          - `[ParentSection <IMicrosoftGraphOnenoteSection>]`: onenoteSection
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
        - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
        - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
        - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[ParentNotebookUserRole <String>]`: onenoteUserRole
        - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
      - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
    - `[UserRole <String>]`: onenoteUserRole
  - `[Operations <IMicrosoftGraphOnenoteOperation[]>]`: The status of OneNote operations. Getting an operations collection is not supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response. Read-only. Nullable.
    - `[CreatedDateTime <DateTime?>]`: The start time of the operation.
    - `[LastActionDateTime <DateTime?>]`: The time of the last action of the operation.
    - `[Status <String>]`: operationStatus
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: The error code.
    - `[Message <String>]`: The error message.
    - `[PercentComplete <String>]`: The operation percent complete if the operation is still in running status
    - `[ResourceId <String>]`: The resource id.
    - `[ResourceLocation <String>]`: The resource URI for the object. For example, the resource URI for a copied page or section.
  - `[Pages <IMicrosoftGraphOnenotePage[]>]`: The pages in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.
  - `[Resources <IMicrosoftGraphOnenoteResource[]>]`: The image and other file resources in OneNote pages. Getting a resources collection is not supported, but you can get the binary content of a specific resource. Read-only. Nullable.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: Read-only.
    - `[Content <Byte[]>]`: The content stream
    - `[ContentUrl <String>]`: The URL for downloading the content
  - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.
  - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.

#### INPUTOBJECT <IUsersOneNoteIdentity>: Identity Parameter
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

#### NOTEBOOKS <IMicrosoftGraphNotebook[]>: The collection of OneNote notebooks that are owned by the user or group. Read-only. Nullable.
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
  - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: Read-only.
    - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
    - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
    - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the section. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the section group. Read-only. Nullable.
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
        - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
        - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
        - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[ParentNotebookUserRole <String>]`: onenoteUserRole
        - `[ParentSection <IMicrosoftGraphOnenoteSection>]`: onenoteSection
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
      - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
      - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
      - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[ParentNotebookUserRole <String>]`: onenoteUserRole
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
  - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
  - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
  - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
  - `[UserRole <String>]`: onenoteUserRole

#### OPERATIONS <IMicrosoftGraphOnenoteOperation[]>: The status of OneNote operations. Getting an operations collection is not supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response. Read-only. Nullable.
  - `[CreatedDateTime <DateTime?>]`: The start time of the operation.
  - `[LastActionDateTime <DateTime?>]`: The time of the last action of the operation.
  - `[Status <String>]`: operationStatus
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: The error code.
  - `[Message <String>]`: The error message.
  - `[PercentComplete <String>]`: The operation percent complete if the operation is still in running status
  - `[ResourceId <String>]`: The resource id.
  - `[ResourceLocation <String>]`: The resource URI for the object. For example, the resource URI for a copied page or section.

#### PAGES <IMicrosoftGraphOnenotePage[]>: The pages in all OneNote notebooks that are owned by the user or group. Read-only. Nullable.
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
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ParentNotebookCreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[ParentNotebookDisplayName <String>]`: The name of the notebook.
  - `[ParentNotebookId <String>]`: Read-only.
  - `[ParentNotebookIsDefault <Boolean?>]`: Indicates whether this is the user's default notebook. Read-only.
  - `[ParentNotebookIsShared <Boolean?>]`: Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.
  - `[ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ParentNotebookLastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[ParentNotebookLinksOneNoteClientUrlHref <String>]`: The url of the link.
  - `[ParentNotebookLinksOneNoteWebUrlHref <String>]`: The url of the link.
  - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[DisplayName <String>]`: The name of the notebook.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
    - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[Id <String>]`: Read-only.
    - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
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
      - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
      - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
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
        - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
        - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
        - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[ParentNotebookUserRole <String>]`: onenoteUserRole
        - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
      - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
      - `[UserRole <String>]`: onenoteUserRole
    - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
    - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the section. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the section group. Read-only. Nullable.
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
  - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
  - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
  - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
  - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[ParentNotebookUserRole <String>]`: onenoteUserRole
  - `[ParentSection <IMicrosoftGraphOnenoteSection>]`: onenoteSection
  - `[Title <String>]`: The title of the page.
  - `[UserTags <String[]>]`: 

#### RESOURCES <IMicrosoftGraphOnenoteResource[]>: The image and other file resources in OneNote pages. Getting a resources collection is not supported, but you can get the binary content of a specific resource. Read-only. Nullable.
  - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[Id <String>]`: Read-only.
  - `[Content <Byte[]>]`: The content stream
  - `[ContentUrl <String>]`: The URL for downloading the content

#### SECTIONGROUPS <IMicrosoftGraphSectionGroup[]>: The section groups in all OneNote notebooks that are owned by the user or group. Read-only. Nullable.
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
  - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
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
    - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
    - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
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
        - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
        - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
        - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
        - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
        - `[ParentNotebookUserRole <String>]`: onenoteUserRole
        - `[ParentSection <IMicrosoftGraphOnenoteSection>]`: onenoteSection
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
      - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
      - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
      - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
      - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[ParentNotebookUserRole <String>]`: onenoteUserRole
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
    - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
    - `[UserRole <String>]`: onenoteUserRole
  - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
  - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the section. Read-only. Nullable.
  - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
  - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the section group. Read-only. Nullable.
  - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.

#### SECTIONS <IMicrosoftGraphOnenoteSection[]>: The sections in all OneNote notebooks that are owned by the user or group. Read-only. Nullable.
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
    - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: The name of the notebook.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
      - `[Self <String>]`: The endpoint where you can get details about the page. Read-only.
      - `[Id <String>]`: Read-only.
      - `[ParentNotebook <IMicrosoftGraphNotebook>]`: notebook
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
        - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
        - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
        - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
        - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
        - `[UserRole <String>]`: onenoteUserRole
      - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup
      - `[SectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the section. Read-only. Nullable.
      - `[SectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.
      - `[Sections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the section group. Read-only. Nullable.
      - `[SectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the section group. Read-only.
    - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
    - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
    - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
    - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
    - `[ParentNotebookUserRole <String>]`: onenoteUserRole
    - `[ParentSection <IMicrosoftGraphOnenoteSection>]`: onenoteSection
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
  - `[ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup[]>]`: The section groups in the notebook. Read-only. Nullable.
  - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
  - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection[]>]`: The sections in the notebook. Read-only. Nullable.
  - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
  - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[ParentNotebookUserRole <String>]`: onenoteUserRole
  - `[ParentSectionGroup <IMicrosoftGraphSectionGroup>]`: sectionGroup

## RELATED LINKS


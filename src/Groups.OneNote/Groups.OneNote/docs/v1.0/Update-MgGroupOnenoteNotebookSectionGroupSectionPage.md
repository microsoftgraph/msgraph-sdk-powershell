---
external help file:
Module Name: Microsoft.Graph.Groups.OneNote
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.onenote/update-mggrouponenotenotebooksectiongroupsectionpage
schema: 2.0.0
---

# Update-MgGroupOnenoteNotebookSectionGroupSectionPage

## SYNOPSIS
Update the navigation property pages in groups

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgGroupOnenoteNotebookSectionGroupSectionPage -GroupId <String> -NotebookId <String>
 -OnenotePageId <String> -OnenoteSectionId <String> -SectionGroupId <String> [-ContentInputFile <String>]
 [-ContentUrl <String>] [-CreatedByAppId <String>] [-CreatedDateTime <DateTime>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-Level <Int32>] [-LinksOneNoteClientUrlHref <String>]
 [-LinksOneNoteWebUrlHref <String>] [-Order <Int32>] [-ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]
 [-ParentNotebookCreatedDateTime <DateTime>] [-ParentNotebookDisplayName <String>]
 [-ParentNotebookId <String>] [-ParentNotebookIsDefault] [-ParentNotebookIsShared]
 [-ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>] [-ParentNotebookLastModifiedDateTime <DateTime>]
 [-ParentNotebookLinksOneNoteClientUrlHref <String>] [-ParentNotebookLinksOneNoteWebUrlHref <String>]
 [-ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>] [-ParentNotebookSectionGroupsUrl <String>]
 [-ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>] [-ParentNotebookSectionsUrl <String>]
 [-ParentNotebookSelf <String>] [-ParentNotebookUserRole <String>]
 [-ParentSection <IMicrosoftGraphOnenoteSection1>] [-Self <String>] [-Title <String>] [-UserTags <String[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgGroupOnenoteNotebookSectionGroupSectionPage -GroupId <String> -NotebookId <String>
 -OnenotePageId <String> -OnenoteSectionId <String> -SectionGroupId <String>
 -BodyParameter <IMicrosoftGraphOnenotePage> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgGroupOnenoteNotebookSectionGroupSectionPage -InputObject <IGroupsOneNoteIdentity>
 -BodyParameter <IMicrosoftGraphOnenotePage> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgGroupOnenoteNotebookSectionGroupSectionPage -InputObject <IGroupsOneNoteIdentity>
 [-ContentInputFile <String>] [-ContentUrl <String>] [-CreatedByAppId <String>] [-CreatedDateTime <DateTime>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>] [-Level <Int32>] [-LinksOneNoteClientUrlHref <String>]
 [-LinksOneNoteWebUrlHref <String>] [-Order <Int32>] [-ParentNotebookCreatedBy <IMicrosoftGraphIdentitySet>]
 [-ParentNotebookCreatedDateTime <DateTime>] [-ParentNotebookDisplayName <String>]
 [-ParentNotebookId <String>] [-ParentNotebookIsDefault] [-ParentNotebookIsShared]
 [-ParentNotebookLastModifiedBy <IMicrosoftGraphIdentitySet>] [-ParentNotebookLastModifiedDateTime <DateTime>]
 [-ParentNotebookLinksOneNoteClientUrlHref <String>] [-ParentNotebookLinksOneNoteWebUrlHref <String>]
 [-ParentNotebookSectionGroups <IMicrosoftGraphSectionGroup1[]>] [-ParentNotebookSectionGroupsUrl <String>]
 [-ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>] [-ParentNotebookSectionsUrl <String>]
 [-ParentNotebookSelf <String>] [-ParentNotebookUserRole <String>]
 [-ParentSection <IMicrosoftGraphOnenoteSection1>] [-Self <String>] [-Title <String>] [-UserTags <String[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property pages in groups

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
onenotePage
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenotePage
Parameter Sets: Update1, UpdateViaIdentity1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
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

### -GroupId
key: group-id of group

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IGroupsOneNoteIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
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
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
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

### -Level
The indentation level of the page.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LinksOneNoteClientUrlHref
The url of the link.

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

### -LinksOneNoteWebUrlHref
The url of the link.

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

### -NotebookId
key: notebook-id of notebook

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

### -OnenotePageId
key: onenotePage-id of onenotePage

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

### -OnenoteSectionId
key: onenoteSection-id of onenoteSection

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

### -Order
The order of the page within its parent section.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentNotebookCreatedBy
identitySet
To construct, see NOTES section for PARENTNOTEBOOKCREATEDBY properties and create a hash table.

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

### -ParentNotebookCreatedDateTime
The date and time when the page was created.
The timestamp represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
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

### -ParentNotebookDisplayName
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

### -ParentNotebookId
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

### -ParentNotebookIsDefault
Indicates whether this is the user's default notebook.
Read-only.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentNotebookIsShared
Indicates whether the notebook is shared.
If true, the contents of the notebook can be seen by people other than the owner.
Read-only.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentNotebookLastModifiedBy
identitySet
To construct, see NOTES section for PARENTNOTEBOOKLASTMODIFIEDBY properties and create a hash table.

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

### -ParentNotebookLastModifiedDateTime
The date and time when the notebook was last modified.
The timestamp represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
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

### -ParentNotebookLinksOneNoteClientUrlHref
The url of the link.

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

### -ParentNotebookLinksOneNoteWebUrlHref
The url of the link.

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

### -ParentNotebookSectionGroups
The section groups in the notebook.
Read-only.
Nullable.
To construct, see NOTES section for PARENTNOTEBOOKSECTIONGROUPS properties and create a hash table.

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

### -ParentNotebookSectionGroupsUrl
The URL for the sectionGroups navigation property, which returns all the section groups in the notebook.
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

### -ParentNotebookSections
The sections in the notebook.
Read-only.
Nullable.
To construct, see NOTES section for PARENTNOTEBOOKSECTIONS properties and create a hash table.

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

### -ParentNotebookSectionsUrl
The URL for the sections navigation property, which returns all the sections in the notebook.
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

### -ParentNotebookSelf
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

### -ParentNotebookUserRole
onenoteUserRole

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

### -ParentSection
onenoteSection
To construct, see NOTES section for PARENTSECTION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteSection1
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
key: sectionGroup-id of sectionGroup

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

### -Title
The title of the page.

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

### -UserTags
.

```yaml
Type: System.String[]
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

### Microsoft.Graph.PowerShell.Models.IGroupsOneNoteIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenotePage

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOnenotePage>: onenotePage
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
  - `[ParentNotebookSectionGroupsUrl <String>]`: The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.
  - `[ParentNotebookSections <IMicrosoftGraphOnenoteSection1[]>]`: The sections in the notebook. Read-only. Nullable.
  - `[ParentNotebookSectionsUrl <String>]`: The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.
  - `[ParentNotebookSelf <String>]`: The endpoint where you can get details about the page. Read-only.
  - `[ParentNotebookUserRole <String>]`: onenoteUserRole
  - `[ParentSection <IMicrosoftGraphOnenoteSection1>]`: onenoteSection
  - `[Title <String>]`: The title of the page.
  - `[UserTags <String[]>]`: 

INPUTOBJECT <IGroupsOneNoteIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: group-id of group
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenoteOperationId <String>]`: key: onenoteOperation-id of onenoteOperation
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenotePageId1 <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteResourceId <String>]`: key: onenoteResource-id of onenoteResource
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[OnenoteSectionId1 <String>]`: key: onenoteSection-id of onenoteSection
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[SectionGroupId1 <String>]`: key: sectionGroup-id of sectionGroup

PARENTNOTEBOOKCREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

PARENTNOTEBOOKLASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

PARENTNOTEBOOKSECTIONGROUPS <IMicrosoftGraphSectionGroup1[]>: The section groups in the notebook. Read-only. Nullable.
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

PARENTNOTEBOOKSECTIONS <IMicrosoftGraphOnenoteSection1[]>: The sections in the notebook. Read-only. Nullable.
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

PARENTSECTION <IMicrosoftGraphOnenoteSection1>: onenoteSection
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


---
external help file: Microsoft.Graph.Groups-help.xml
Module Name: Microsoft.Graph.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/get-mggroup
schema: 2.0.0
---

# Get-MgGroup

## SYNOPSIS
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.

## SYNTAX

### List1 (Default)
```
Get-MgGroup [-ExpandProperty <String[]>] [-Property <String[]>] [-Filter <String>] [-Search <String>]
 [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-ConsistencyLevel <String>] [-PageSize <Int32>] [-All]
 [-CountVariable <String>] [<CommonParameters>]
```

### Get
```
Get-MgGroup -GroupId <String> [-ExpandProperty <String[]>] [-Property <String[]>] [-ConsistencyLevel <String>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgGroup -InputObject <IGroupsIdentity> [-ExpandProperty <String[]>] [-Property <String[]>]
 [-ConsistencyLevel <String>] [<CommonParameters>]
```

## DESCRIPTION
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.

## EXAMPLES

### Example 1: Get a list of groups
```powershell
Get-MgGroup | 
  Format-List Id, DisplayName, Description, GroupTypes

Id          : 0a1c8435-40a3-4a72-8586-e916c12b613a
DisplayName : Marketing
Description : A group to synthesize, analyze, and synchronize our marketing efforts.
GroupTypes  : {Unified}

Id          : a8fbb1b5-b994-4835-9183-c7421d149132
DisplayName : Business Development
Description : Welcome to the BizDev team.
GroupTypes  : {Unified}
```

This examples retrieves a list of groups.

### Example 2: Get a group by the display name
```powershell
Get-MgGroup -Filter "DisplayName eq 'Business Development'" | 
  Format-List Id, DisplayName, Description, GroupTypes

Id          : a8fbb1b5-b994-4835-9183-c7421d149132
DisplayName : Business Development
Description : Welcome to the BizDev team.
GroupTypes  : {Unified}
```

This example gets a group by the specified display name.

## PARAMETERS

### -All
List all pages.

```yaml
Type: SwitchParameter
Parameter Sets: List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConsistencyLevel
Indicates the requested consistency level.
Documentation URL: https://developer.microsoft.com/en-us/office/blogs/microsoft-graph-advanced-queries-for-directory-objects-are-now-generally-available/

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: String
Parameter Sets: List1
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: String
Parameter Sets: List1
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
Type: String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IGroupsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: Int32
Parameter Sets: List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: String
Parameter Sets: List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: String[]
Parameter Sets: List1
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: Int32
Parameter Sets: List1
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: Int32
Parameter Sets: List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IGroupsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroup
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IGroupsIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: id of attachment
  - `[ConversationId <String>]`: key: id of conversation
  - `[ConversationThreadId <String>]`: key: id of conversationThread
  - `[DirectorySettingId <String>]`: key: id of directorySetting
  - `[EndpointId <String>]`: key: id of endpoint
  - `[EventId <String>]`: key: id of event
  - `[ExtensionId <String>]`: key: id of extension
  - `[GroupId <String>]`: key: id of group
  - `[GroupLifecyclePolicyId <String>]`: key: id of groupLifecyclePolicy
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[MentionId <String>]`: key: id of mention
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[PostId <String>]`: key: id of post
  - `[ProfilePhotoId <String>]`: key: id of profilePhoto
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[User <String>]`: Usage: User={User}
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

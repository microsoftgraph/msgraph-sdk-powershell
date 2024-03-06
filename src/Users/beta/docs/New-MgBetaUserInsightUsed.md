---
external help file:
Module Name: Microsoft.Graph.Beta.Users
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.users/new-mgbetauserinsightused
schema: 2.0.0
---

# New-MgBetaUserInsightUsed

## SYNOPSIS
Create new navigation property to used for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaUserInsightUsed -UserId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-LastUsed <IMicrosoftGraphUsageDetails>] [-Resource <IMicrosoftGraphEntity>]
 [-ResourceReference <IMicrosoftGraphResourceReference>]
 [-ResourceVisualization <IMicrosoftGraphResourceVisualization>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaUserInsightUsed -UserId <String> -BodyParameter <IMicrosoftGraphUsedInsight>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaUserInsightUsed -InputObject <IUsersIdentity> -BodyParameter <IMicrosoftGraphUsedInsight>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaUserInsightUsed -InputObject <IUsersIdentity> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-LastUsed <IMicrosoftGraphUsageDetails>] [-Resource <IMicrosoftGraphEntity>]
 [-ResourceReference <IMicrosoftGraphResourceReference>]
 [-ResourceVisualization <IMicrosoftGraphResourceVisualization>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to used for users

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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
usedInsight
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUsedInsight
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IUsersIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastUsed
usageDetails
To construct, see NOTES section for LASTUSED properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUsageDetails
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Resource
entity
To construct, see NOTES section for RESOURCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEntity
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceReference
resourceReference
To construct, see NOTES section for RESOURCEREFERENCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphResourceReference
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceVisualization
resourceVisualization
To construct, see NOTES section for RESOURCEVISUALIZATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphResourceVisualization
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUsedInsight

### Microsoft.Graph.Beta.PowerShell.Models.IUsersIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUsedInsight

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphUsedInsight>`: usedInsight
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[LastUsed <IMicrosoftGraphUsageDetails>]`: usageDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LastAccessedDateTime <DateTime?>]`: The date and time the resource was last accessed by the user. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the resource was last modified by the user. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Resource <IMicrosoftGraphEntity>]`: entity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ResourceReference <IMicrosoftGraphResourceReference>]`: resourceReference
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The item's unique identifier.
    - `[Type <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
    - `[WebUrl <String>]`: A URL leading to the referenced item.
  - `[ResourceVisualization <IMicrosoftGraphResourceVisualization>]`: resourceVisualization
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContainerDisplayName <String>]`: A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.
    - `[ContainerType <String>]`: Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
    - `[ContainerWebUrl <String>]`: A path leading to the folder in which the item is stored.
    - `[MediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Not all Media Mime Types are supported.
    - `[PreviewImageUrl <String>]`: A URL leading to the preview image for the item.
    - `[PreviewText <String>]`: A preview text for the item.
    - `[Title <String>]`: The item's title text.
    - `[Type <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See the Type property values section, for supported types.

`INPUTOBJECT <IUsersIdentity>`: Identity Parameter
  - `[AppId <String>]`: Alternate key of servicePrincipal
  - `[AttachmentBaseId <String>]`: The unique identifier of attachmentBase
  - `[AttachmentId <String>]`: The unique identifier of attachment
  - `[AttachmentSessionId <String>]`: The unique identifier of attachmentSession
  - `[ChecklistItemId <String>]`: The unique identifier of checklistItem
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[LicenseDetailsId <String>]`: The unique identifier of licenseDetails
  - `[LinkedResourceId <String>]`: The unique identifier of linkedResource
  - `[NotificationId <String>]`: The unique identifier of notification
  - `[OAuth2PermissionGrantId <String>]`: The unique identifier of oAuth2PermissionGrant
  - `[OutlookCategoryId <String>]`: The unique identifier of outlookCategory
  - `[OutlookTaskFolderId <String>]`: The unique identifier of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: The unique identifier of outlookTaskGroup
  - `[OutlookTaskId <String>]`: The unique identifier of outlookTask
  - `[ProfilePhotoId <String>]`: The unique identifier of profilePhoto
  - `[ServicePrincipalId <String>]`: The unique identifier of servicePrincipal
  - `[SharedInsightId <String>]`: The unique identifier of sharedInsight
  - `[TodoTaskId <String>]`: The unique identifier of todoTask
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[TrendingId <String>]`: The unique identifier of trending
  - `[UsedInsightId <String>]`: The unique identifier of usedInsight
  - `[UserId <String>]`: The unique identifier of user

`LASTUSED <IMicrosoftGraphUsageDetails>`: usageDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastAccessedDateTime <DateTime?>]`: The date and time the resource was last accessed by the user. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the resource was last modified by the user. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.

`RESOURCE <IMicrosoftGraphEntity>`: entity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`RESOURCEREFERENCE <IMicrosoftGraphResourceReference>`: resourceReference
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The item's unique identifier.
  - `[Type <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
  - `[WebUrl <String>]`: A URL leading to the referenced item.

`RESOURCEVISUALIZATION <IMicrosoftGraphResourceVisualization>`: resourceVisualization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContainerDisplayName <String>]`: A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.
  - `[ContainerType <String>]`: Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
  - `[ContainerWebUrl <String>]`: A path leading to the folder in which the item is stored.
  - `[MediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Not all Media Mime Types are supported.
  - `[PreviewImageUrl <String>]`: A URL leading to the preview image for the item.
  - `[PreviewText <String>]`: A preview text for the item.
  - `[Title <String>]`: The item's title text.
  - `[Type <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See the Type property values section, for supported types.

## RELATED LINKS


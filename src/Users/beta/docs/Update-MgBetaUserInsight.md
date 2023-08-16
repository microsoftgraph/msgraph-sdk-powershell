---
external help file:
Module Name: Microsoft.Graph.Beta.Users
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.users/update-mgbetauserinsight
schema: 2.0.0
---

# Update-MgBetaUserInsight

## SYNOPSIS
Update the navigation property insights in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaUserInsight -UserId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Shared <IMicrosoftGraphSharedInsight[]>] [-Trending <IMicrosoftGraphTrending[]>]
 [-Used <IMicrosoftGraphUsedInsight[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaUserInsight -UserId <String> -BodyParameter <Hashtable> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaUserInsight -InputObject <IUsersIdentity> -BodyParameter <Hashtable> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaUserInsight -InputObject <IUsersIdentity> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Shared <IMicrosoftGraphSharedInsight[]>] [-Trending <IMicrosoftGraphTrending[]>]
 [-Used <IMicrosoftGraphUsedInsight[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property insights in users

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
itemInsights

```yaml
Type: System.Collections.Hashtable
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IUsersIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Shared
Access this property from the derived type itemInsights.
To construct, see NOTES section for SHARED properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSharedInsight[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Trending
Access this property from the derived type itemInsights.
To construct, see NOTES section for TRENDING properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTrending[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Used
Access this property from the derived type itemInsights.
To construct, see NOTES section for USED properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUsedInsight[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

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

### Microsoft.Graph.Beta.PowerShell.Models.IUsersIdentity

### System.Collections.Hashtable

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphItemInsights

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IUsersIdentity>`: Identity Parameter
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

`SHARED <IMicrosoftGraphSharedInsight[]>`: Access this property from the derived type itemInsights.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[LastShared <IMicrosoftGraphSharingDetail>]`: sharingDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SharedBy <IMicrosoftGraphInsightIdentity>]`: insightIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of the user who shared the item.
      - `[DisplayName <String>]`: The display name of the user who shared the item.
      - `[Id <String>]`: The id of the user who shared the item.
    - `[SharedDateTime <DateTime?>]`: The date and time the file was last shared. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[SharingReference <IMicrosoftGraphResourceReference>]`: resourceReference
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The item's unique identifier.
      - `[Type <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
      - `[WebUrl <String>]`: A URL leading to the referenced item.
    - `[SharingSubject <String>]`: The subject with which the document was shared.
    - `[SharingType <String>]`: Determines the way the document was shared, can be by a 'Link', 'Attachment', 'Group', 'Site'.
  - `[LastSharedMethod <IMicrosoftGraphEntity>]`: entity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Resource <IMicrosoftGraphEntity>]`: entity
  - `[ResourceReference <IMicrosoftGraphResourceReference>]`: resourceReference
  - `[ResourceVisualization <IMicrosoftGraphResourceVisualization>]`: resourceVisualization
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContainerDisplayName <String>]`: A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.
    - `[ContainerType <String>]`: Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
    - `[ContainerWebUrl <String>]`: A path leading to the folder in which the item is stored.
    - `[MediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.
    - `[PreviewImageUrl <String>]`: A URL leading to the preview image for the item.
    - `[PreviewText <String>]`: A preview text for the item.
    - `[Title <String>]`: The item's title text.
    - `[Type <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.
  - `[SharingHistory <IMicrosoftGraphSharingDetail[]>]`: 

`TRENDING <IMicrosoftGraphTrending[]>`: Access this property from the derived type itemInsights.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: 
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
    - `[MediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.
    - `[PreviewImageUrl <String>]`: A URL leading to the preview image for the item.
    - `[PreviewText <String>]`: A preview text for the item.
    - `[Title <String>]`: The item's title text.
    - `[Type <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.
  - `[Weight <Double?>]`: Value indicating how much the document is currently trending. The larger the number, the more the document is currently trending around the user (the more relevant it is). Returned documents are sorted by this value.

`USED <IMicrosoftGraphUsedInsight[]>`: Access this property from the derived type itemInsights.
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
    - `[MediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.
    - `[PreviewImageUrl <String>]`: A URL leading to the preview image for the item.
    - `[PreviewText <String>]`: A preview text for the item.
    - `[Title <String>]`: The item's title text.
    - `[Type <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.

## RELATED LINKS


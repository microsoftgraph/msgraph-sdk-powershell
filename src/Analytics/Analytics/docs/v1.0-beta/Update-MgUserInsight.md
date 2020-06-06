---
external help file:
Module Name: Microsoft.Graph.Analytics
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.analytics/update-mguserinsight
schema: 2.0.0
---

# Update-MgUserInsight

## SYNOPSIS
Update the navigation property insights in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserInsight -UserId <String> [-Id <String>] [-Shared <IMicrosoftGraphSharedInsight[]>]
 [-Trending <IMicrosoftGraphTrending[]>] [-Used <IMicrosoftGraphUsedInsight[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserInsight -UserId <String> -BodyParameter <IMicrosoftGraphOfficeGraphInsights> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserInsight -InputObject <IAnalyticsIdentity> -BodyParameter <IMicrosoftGraphOfficeGraphInsights>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserInsight -InputObject <IAnalyticsIdentity> [-Id <String>]
 [-Shared <IMicrosoftGraphSharedInsight[]>] [-Trending <IMicrosoftGraphTrending[]>]
 [-Used <IMicrosoftGraphUsedInsight[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property insights in users

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
officeGraphInsights
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeGraphInsights
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
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
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IAnalyticsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Shared
Calculated relationship identifying documents shared with a user.
Documents can be shared as email attachments or as OneDrive for Business links sent in emails.
To construct, see NOTES section for SHARED properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharedInsight[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Trending
Calculated relationship identifying trending documents.
Trending documents can be stored in OneDrive or in SharePoint sites.
To construct, see NOTES section for TRENDING properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTrending[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Used
Calculated relationship identifying documents viewed and modified by a user.
Includes documents the user used in OneDrive for Business, SharePoint, opened as email attachments, and as link attachments from sources like Box, DropBox and Google Drive.
To construct, see NOTES section for USED properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUsedInsight[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IAnalyticsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeGraphInsights

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOfficeGraphInsights>: officeGraphInsights
  - `[Id <String>]`: Read-only.
  - `[Shared <IMicrosoftGraphSharedInsight[]>]`: Calculated relationship identifying documents shared with a user. Documents can be shared as email attachments or as OneDrive for Business links sent in emails.
    - `[Id <String>]`: Read-only.
    - `[LastSharedDateTime <DateTime?>]`: The date and time the file was last shared. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z. Read-only.
    - `[LastSharedMethodId <String>]`: Read-only.
    - `[LastSharedSharingSubject <String>]`: The subject with which the document was shared.
    - `[LastSharedSharingType <String>]`: Determines the way the document was shared, can be by a 'Link', 'Attachment', 'Group', 'Site'.
    - `[ResourceId <String>]`: Read-only.
    - `[ResourceReferenceId <String>]`: The item's unique identifier.
    - `[ResourceReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
    - `[ResourceReferenceWebUrl <String>]`: A URL leading to the referenced item.
    - `[ResourceVisualizationContainerDisplayName <String>]`: A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.
    - `[ResourceVisualizationContainerType <String>]`: Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
    - `[ResourceVisualizationContainerWebUrl <String>]`: A path leading to the folder in which the item is stored.
    - `[ResourceVisualizationMediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.
    - `[ResourceVisualizationPreviewImageUrl <String>]`: A URL leading to the preview image for the item.
    - `[ResourceVisualizationPreviewText <String>]`: A preview text for the item.
    - `[ResourceVisualizationTitle <String>]`: The item's title text.
    - `[ResourceVisualizationType <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.
    - `[SharedByAddress <String>]`: The email address of the user who shared the item.
    - `[SharedByDisplayName <String>]`: The display name of the user who shared the item.
    - `[SharedById <String>]`: The id of the user who shared the item.
    - `[SharingHistory <IMicrosoftGraphSharingDetail[]>]`: 
      - `[SharedByAddress <String>]`: The email address of the user who shared the item.
      - `[SharedByDisplayName <String>]`: The display name of the user who shared the item.
      - `[SharedById <String>]`: The id of the user who shared the item.
      - `[SharedDateTime <DateTime?>]`: The date and time the file was last shared. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z. Read-only.
      - `[SharingReferenceId <String>]`: The item's unique identifier.
      - `[SharingReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
      - `[SharingReferenceWebUrl <String>]`: A URL leading to the referenced item.
      - `[SharingSubject <String>]`: The subject with which the document was shared.
      - `[SharingType <String>]`: Determines the way the document was shared, can be by a 'Link', 'Attachment', 'Group', 'Site'.
    - `[SharingReferenceId <String>]`: The item's unique identifier.
    - `[SharingReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
    - `[SharingReferenceWebUrl <String>]`: A URL leading to the referenced item.
  - `[Trending <IMicrosoftGraphTrending[]>]`: Calculated relationship identifying trending documents. Trending documents can be stored in OneDrive or in SharePoint sites.
    - `[Id <String>]`: Read-only.
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ResourceId <String>]`: Read-only.
    - `[ResourceReferenceId <String>]`: The item's unique identifier.
    - `[ResourceReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
    - `[ResourceReferenceWebUrl <String>]`: A URL leading to the referenced item.
    - `[ResourceVisualizationContainerDisplayName <String>]`: A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.
    - `[ResourceVisualizationContainerType <String>]`: Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
    - `[ResourceVisualizationContainerWebUrl <String>]`: A path leading to the folder in which the item is stored.
    - `[ResourceVisualizationMediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.
    - `[ResourceVisualizationPreviewImageUrl <String>]`: A URL leading to the preview image for the item.
    - `[ResourceVisualizationPreviewText <String>]`: A preview text for the item.
    - `[ResourceVisualizationTitle <String>]`: The item's title text.
    - `[ResourceVisualizationType <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.
    - `[Weight <Double?>]`: Value indicating how much the document is currently trending. The larger the number, the more the document is currently trending around the user (the more relevant it is). Returned documents are sorted by this value.
  - `[Used <IMicrosoftGraphUsedInsight[]>]`: Calculated relationship identifying documents viewed and modified by a user. Includes documents the user used in OneDrive for Business, SharePoint, opened as email attachments, and as link attachments from sources like Box, DropBox and Google Drive.
    - `[Id <String>]`: Read-only.
    - `[LastUsedLastAccessedDateTime <DateTime?>]`: The date and time the resource was last accessed by the user. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z. Read-only.
    - `[LastUsedLastModifiedDateTime <DateTime?>]`: The date and time the resource was last modified by the user. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z. Read-only.
    - `[ResourceId <String>]`: Read-only.
    - `[ResourceReferenceId <String>]`: The item's unique identifier.
    - `[ResourceReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
    - `[ResourceReferenceWebUrl <String>]`: A URL leading to the referenced item.
    - `[ResourceVisualizationContainerDisplayName <String>]`: A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.
    - `[ResourceVisualizationContainerType <String>]`: Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
    - `[ResourceVisualizationContainerWebUrl <String>]`: A path leading to the folder in which the item is stored.
    - `[ResourceVisualizationMediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.
    - `[ResourceVisualizationPreviewImageUrl <String>]`: A URL leading to the preview image for the item.
    - `[ResourceVisualizationPreviewText <String>]`: A preview text for the item.
    - `[ResourceVisualizationTitle <String>]`: The item's title text.
    - `[ResourceVisualizationType <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.

INPUTOBJECT <IAnalyticsIdentity>: Identity Parameter
  - `[ActivityStatisticsId <String>]`: key: activityStatistics-id of activityStatistics
  - `[SharedInsightId <String>]`: key: sharedInsight-id of sharedInsight
  - `[TrendingId <String>]`: key: trending-id of trending
  - `[UsedInsightId <String>]`: key: usedInsight-id of usedInsight
  - `[UserId <String>]`: key: user-id of user

SHARED <IMicrosoftGraphSharedInsight[]>: Calculated relationship identifying documents shared with a user. Documents can be shared as email attachments or as OneDrive for Business links sent in emails.
  - `[Id <String>]`: Read-only.
  - `[LastSharedDateTime <DateTime?>]`: The date and time the file was last shared. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z. Read-only.
  - `[LastSharedMethodId <String>]`: Read-only.
  - `[LastSharedSharingSubject <String>]`: The subject with which the document was shared.
  - `[LastSharedSharingType <String>]`: Determines the way the document was shared, can be by a 'Link', 'Attachment', 'Group', 'Site'.
  - `[ResourceId <String>]`: Read-only.
  - `[ResourceReferenceId <String>]`: The item's unique identifier.
  - `[ResourceReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
  - `[ResourceReferenceWebUrl <String>]`: A URL leading to the referenced item.
  - `[ResourceVisualizationContainerDisplayName <String>]`: A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.
  - `[ResourceVisualizationContainerType <String>]`: Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
  - `[ResourceVisualizationContainerWebUrl <String>]`: A path leading to the folder in which the item is stored.
  - `[ResourceVisualizationMediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.
  - `[ResourceVisualizationPreviewImageUrl <String>]`: A URL leading to the preview image for the item.
  - `[ResourceVisualizationPreviewText <String>]`: A preview text for the item.
  - `[ResourceVisualizationTitle <String>]`: The item's title text.
  - `[ResourceVisualizationType <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.
  - `[SharedByAddress <String>]`: The email address of the user who shared the item.
  - `[SharedByDisplayName <String>]`: The display name of the user who shared the item.
  - `[SharedById <String>]`: The id of the user who shared the item.
  - `[SharingHistory <IMicrosoftGraphSharingDetail[]>]`: 
    - `[SharedByAddress <String>]`: The email address of the user who shared the item.
    - `[SharedByDisplayName <String>]`: The display name of the user who shared the item.
    - `[SharedById <String>]`: The id of the user who shared the item.
    - `[SharedDateTime <DateTime?>]`: The date and time the file was last shared. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z. Read-only.
    - `[SharingReferenceId <String>]`: The item's unique identifier.
    - `[SharingReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
    - `[SharingReferenceWebUrl <String>]`: A URL leading to the referenced item.
    - `[SharingSubject <String>]`: The subject with which the document was shared.
    - `[SharingType <String>]`: Determines the way the document was shared, can be by a 'Link', 'Attachment', 'Group', 'Site'.
  - `[SharingReferenceId <String>]`: The item's unique identifier.
  - `[SharingReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
  - `[SharingReferenceWebUrl <String>]`: A URL leading to the referenced item.

TRENDING <IMicrosoftGraphTrending[]>: Calculated relationship identifying trending documents. Trending documents can be stored in OneDrive or in SharePoint sites.
  - `[Id <String>]`: Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[ResourceId <String>]`: Read-only.
  - `[ResourceReferenceId <String>]`: The item's unique identifier.
  - `[ResourceReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
  - `[ResourceReferenceWebUrl <String>]`: A URL leading to the referenced item.
  - `[ResourceVisualizationContainerDisplayName <String>]`: A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.
  - `[ResourceVisualizationContainerType <String>]`: Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
  - `[ResourceVisualizationContainerWebUrl <String>]`: A path leading to the folder in which the item is stored.
  - `[ResourceVisualizationMediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.
  - `[ResourceVisualizationPreviewImageUrl <String>]`: A URL leading to the preview image for the item.
  - `[ResourceVisualizationPreviewText <String>]`: A preview text for the item.
  - `[ResourceVisualizationTitle <String>]`: The item's title text.
  - `[ResourceVisualizationType <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.
  - `[Weight <Double?>]`: Value indicating how much the document is currently trending. The larger the number, the more the document is currently trending around the user (the more relevant it is). Returned documents are sorted by this value.

USED <IMicrosoftGraphUsedInsight[]>: Calculated relationship identifying documents viewed and modified by a user. Includes documents the user used in OneDrive for Business, SharePoint, opened as email attachments, and as link attachments from sources like Box, DropBox and Google Drive.
  - `[Id <String>]`: Read-only.
  - `[LastUsedLastAccessedDateTime <DateTime?>]`: The date and time the resource was last accessed by the user. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z. Read-only.
  - `[LastUsedLastModifiedDateTime <DateTime?>]`: The date and time the resource was last modified by the user. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z. Read-only.
  - `[ResourceId <String>]`: Read-only.
  - `[ResourceReferenceId <String>]`: The item's unique identifier.
  - `[ResourceReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
  - `[ResourceReferenceWebUrl <String>]`: A URL leading to the referenced item.
  - `[ResourceVisualizationContainerDisplayName <String>]`: A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.
  - `[ResourceVisualizationContainerType <String>]`: Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
  - `[ResourceVisualizationContainerWebUrl <String>]`: A path leading to the folder in which the item is stored.
  - `[ResourceVisualizationMediaType <String>]`: The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.
  - `[ResourceVisualizationPreviewImageUrl <String>]`: A URL leading to the preview image for the item.
  - `[ResourceVisualizationPreviewText <String>]`: A preview text for the item.
  - `[ResourceVisualizationTitle <String>]`: The item's title text.
  - `[ResourceVisualizationType <String>]`: The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.

## RELATED LINKS


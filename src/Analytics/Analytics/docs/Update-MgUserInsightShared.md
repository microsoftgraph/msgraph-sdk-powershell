---
external help file:
Module Name: Microsoft.Graph.Analytics
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.analytics/update-mguserinsightshared
schema: 2.0.0
---

# Update-MgUserInsightShared

## SYNOPSIS
Update the navigation property shared in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserInsightShared -SharedInsightId <String> -UserId <String> [-Id <String>]
 [-LastSharedDateTime <DateTime>] [-LastSharedMethodId <String>] [-LastSharedSharingSubject <String>]
 [-LastSharedSharingType <String>] [-ResourceId <String>] [-ResourceReferenceId <String>]
 [-ResourceReferenceType <String>] [-ResourceReferenceWebUrl <String>]
 [-ResourceVisualizationContainerDisplayName <String>] [-ResourceVisualizationContainerType <String>]
 [-ResourceVisualizationContainerWebUrl <String>] [-ResourceVisualizationMediaType <String>]
 [-ResourceVisualizationPreviewImageUrl <String>] [-ResourceVisualizationPreviewText <String>]
 [-ResourceVisualizationTitle <String>] [-ResourceVisualizationType <String>] [-SharedByAddress <String>]
 [-SharedByDisplayName <String>] [-SharedById <String>] [-SharingHistory <IMicrosoftGraphSharingDetail[]>]
 [-SharingReferenceId <String>] [-SharingReferenceType <String>] [-SharingReferenceWebUrl <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserInsightShared -SharedInsightId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphSharedInsight> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserInsightShared -InputObject <IAnalyticsIdentity> -BodyParameter <IMicrosoftGraphSharedInsight>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserInsightShared -InputObject <IAnalyticsIdentity> [-Id <String>] [-LastSharedDateTime <DateTime>]
 [-LastSharedMethodId <String>] [-LastSharedSharingSubject <String>] [-LastSharedSharingType <String>]
 [-ResourceId <String>] [-ResourceReferenceId <String>] [-ResourceReferenceType <String>]
 [-ResourceReferenceWebUrl <String>] [-ResourceVisualizationContainerDisplayName <String>]
 [-ResourceVisualizationContainerType <String>] [-ResourceVisualizationContainerWebUrl <String>]
 [-ResourceVisualizationMediaType <String>] [-ResourceVisualizationPreviewImageUrl <String>]
 [-ResourceVisualizationPreviewText <String>] [-ResourceVisualizationTitle <String>]
 [-ResourceVisualizationType <String>] [-SharedByAddress <String>] [-SharedByDisplayName <String>]
 [-SharedById <String>] [-SharingHistory <IMicrosoftGraphSharingDetail[]>] [-SharingReferenceId <String>]
 [-SharingReferenceType <String>] [-SharingReferenceWebUrl <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property shared in users

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
sharedInsight
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharedInsight
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
Type: Microsoft.Graph.PowerShell.Models.IAnalyticsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -LastSharedDateTime
The date and time the file was last shared.
The timestamp represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z.
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
Dynamic: False
```

### -LastSharedMethodId
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

### -LastSharedSharingSubject
The subject with which the document was shared.

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

### -LastSharedSharingType
Determines the way the document was shared, can be by a 'Link', 'Attachment', 'Group', 'Site'.

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

### -ResourceId
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

### -ResourceReferenceId
The item's unique identifier.

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

### -ResourceReferenceType
A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'

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

### -ResourceReferenceWebUrl
A URL leading to the referenced item.

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

### -ResourceVisualizationContainerDisplayName
A string describing where the item is stored.
For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.

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

### -ResourceVisualizationContainerType
Can be used for filtering by the type of container in which the file is stored.
Such as Site or OneDriveBusiness.

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

### -ResourceVisualizationContainerWebUrl
A path leading to the folder in which the item is stored.

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

### -ResourceVisualizationMediaType
The item's media type.
Can be used for filtering for a specific type of file based on supported IANA Media Mime Types.
Note that not all Media Mime Types are supported.

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

### -ResourceVisualizationPreviewImageUrl
A URL leading to the preview image for the item.

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

### -ResourceVisualizationPreviewText
A preview text for the item.

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

### -ResourceVisualizationTitle
The item's title text.

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

### -ResourceVisualizationType
The item's media type.
Can be used for filtering for a specific file based on a specific type.
See below for supported types.

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

### -SharedByAddress
The email address of the user who shared the item.

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

### -SharedByDisplayName
The display name of the user who shared the item.

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

### -SharedById
The id of the user who shared the item.

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

### -SharedInsightId
key: sharedInsight-id of sharedInsight

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

### -SharingHistory
.
To construct, see NOTES section for SHARINGHISTORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharingDetail[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SharingReferenceId
The item's unique identifier.

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

### -SharingReferenceType
A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'

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

### -SharingReferenceWebUrl
A URL leading to the referenced item.

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

### Microsoft.Graph.PowerShell.Models.IAnalyticsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharedInsight

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphSharedInsight>: sharedInsight
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

#### INPUTOBJECT <IAnalyticsIdentity>: Identity Parameter
  - `[ActivityStatisticsId <String>]`: key: activityStatistics-id of activityStatistics
  - `[SharedInsightId <String>]`: key: sharedInsight-id of sharedInsight
  - `[TrendingId <String>]`: key: trending-id of trending
  - `[UsedInsightId <String>]`: key: usedInsight-id of usedInsight
  - `[UserId <String>]`: key: user-id of user

#### SHARINGHISTORY <IMicrosoftGraphSharingDetail[]>: .
  - `[SharedByAddress <String>]`: The email address of the user who shared the item.
  - `[SharedByDisplayName <String>]`: The display name of the user who shared the item.
  - `[SharedById <String>]`: The id of the user who shared the item.
  - `[SharedDateTime <DateTime?>]`: The date and time the file was last shared. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z. Read-only.
  - `[SharingReferenceId <String>]`: The item's unique identifier.
  - `[SharingReferenceType <String>]`: A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'
  - `[SharingReferenceWebUrl <String>]`: A URL leading to the referenced item.
  - `[SharingSubject <String>]`: The subject with which the document was shared.
  - `[SharingType <String>]`: Determines the way the document was shared, can be by a 'Link', 'Attachment', 'Group', 'Site'.

## RELATED LINKS


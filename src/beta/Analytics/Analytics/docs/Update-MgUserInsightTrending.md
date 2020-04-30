---
external help file:
Module Name: Microsoft.Graph.Analytics
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.analytics/update-mguserinsighttrending
schema: 2.0.0
---

# Update-MgUserInsightTrending

## SYNOPSIS
Update the navigation property trending in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserInsightTrending -TrendingId <String> -UserId <String> [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-ResourceId <String>] [-ResourceReferenceId <String>]
 [-ResourceReferenceType <String>] [-ResourceReferenceWebUrl <String>]
 [-ResourceVisualizationContainerDisplayName <String>] [-ResourceVisualizationContainerType <String>]
 [-ResourceVisualizationContainerWebUrl <String>] [-ResourceVisualizationMediaType <String>]
 [-ResourceVisualizationPreviewImageUrl <String>] [-ResourceVisualizationPreviewText <String>]
 [-ResourceVisualizationTitle <String>] [-ResourceVisualizationType <String>] [-Weight <Double>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserInsightTrending -TrendingId <String> -UserId <String> -BodyParameter <IMicrosoftGraphTrending>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserInsightTrending -InputObject <IAnalyticsIdentity> -BodyParameter <IMicrosoftGraphTrending>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserInsightTrending -InputObject <IAnalyticsIdentity> [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-ResourceId <String>] [-ResourceReferenceId <String>]
 [-ResourceReferenceType <String>] [-ResourceReferenceWebUrl <String>]
 [-ResourceVisualizationContainerDisplayName <String>] [-ResourceVisualizationContainerType <String>]
 [-ResourceVisualizationContainerWebUrl <String>] [-ResourceVisualizationMediaType <String>]
 [-ResourceVisualizationPreviewImageUrl <String>] [-ResourceVisualizationPreviewText <String>]
 [-ResourceVisualizationTitle <String>] [-ResourceVisualizationType <String>] [-Weight <Double>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property trending in users

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
trending
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTrending
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

### -LastModifiedDateTime
.

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

### -TrendingId
key: trending-id of trending

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

### -Weight
Value indicating how much the document is currently trending.
The larger the number, the more the document is currently trending around the user (the more relevant it is).
Returned documents are sorted by this value.

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTrending

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphTrending>: trending
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

#### INPUTOBJECT <IAnalyticsIdentity>: Identity Parameter
  - `[ActivityStatisticsId <String>]`: key: activityStatistics-id of activityStatistics
  - `[SharedInsightId <String>]`: key: sharedInsight-id of sharedInsight
  - `[TrendingId <String>]`: key: trending-id of trending
  - `[UsedInsightId <String>]`: key: usedInsight-id of usedInsight
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS


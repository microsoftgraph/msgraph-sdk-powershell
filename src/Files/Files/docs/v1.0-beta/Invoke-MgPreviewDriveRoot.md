---
external help file:
Module Name: Microsoft.Graph.Files
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/invoke-mgpreviewdriveroot
schema: 2.0.0
---

# Invoke-MgPreviewDriveRoot

## SYNOPSIS
Invoke action preview

## SYNTAX

### PreviewExpanded1 (Default)
```
Invoke-MgPreviewDriveRoot -DriveId <String> [-AdditionalProperties <Hashtable>] [-AllowEdit] [-Chromeless]
 [-Page <String>] [-Viewer <String>] [-Zoom <Double>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Preview1
```
Invoke-MgPreviewDriveRoot -DriveId <String>
 -BodyParameter <IPaths1X99IewDrivesDriveIdRootMicrosoftGraphPreviewPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PreviewViaIdentity1
```
Invoke-MgPreviewDriveRoot -InputObject <IFilesIdentity>
 -BodyParameter <IPaths1X99IewDrivesDriveIdRootMicrosoftGraphPreviewPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PreviewViaIdentityExpanded1
```
Invoke-MgPreviewDriveRoot -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>] [-AllowEdit]
 [-Chromeless] [-Page <String>] [-Viewer <String>] [-Zoom <Double>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action preview

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: PreviewExpanded1, PreviewViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowEdit
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PreviewExpanded1, PreviewViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1X99IewDrivesDriveIdRootMicrosoftGraphPreviewPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Preview1, PreviewViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Chromeless
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PreviewExpanded1, PreviewViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DriveId
The unique identifier of drive

```yaml
Type: System.String
Parameter Sets: Preview1, PreviewExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IFilesIdentity
Parameter Sets: PreviewViaIdentity1, PreviewViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Page
.

```yaml
Type: System.String
Parameter Sets: PreviewExpanded1, PreviewViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Viewer
.

```yaml
Type: System.String
Parameter Sets: PreviewExpanded1, PreviewViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Zoom
.

```yaml
Type: System.Double
Parameter Sets: PreviewExpanded1, PreviewViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IFilesIdentity

### Microsoft.Graph.PowerShell.Models.IPaths1X99IewDrivesDriveIdRootMicrosoftGraphPreviewPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemPreviewInfo

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1X99IewDrivesDriveIdRootMicrosoftGraphPreviewPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowEdit <Boolean?>]`: 
  - `[Chromeless <Boolean?>]`: 
  - `[Page <String>]`: 
  - `[Viewer <String>]`: 
  - `[Zoom <Double?>]`: 

INPUTOBJECT <IFilesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: The unique identifier of columnDefinition
  - `[ColumnLinkId <String>]`: The unique identifier of columnLink
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ContentTypeId1 <String>]`: The unique identifier of contentType
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[DriveItemId <String>]`: The unique identifier of driveItem
  - `[DriveItemId1 <String>]`: The unique identifier of driveItem
  - `[DriveItemVersionId <String>]`: The unique identifier of driveItemVersion
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: The unique identifier of group
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ItemActivityStatId <String>]`: The unique identifier of itemActivityStat
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[Q <String>]`: Usage: q='{q}'
  - `[RichLongRunningOperationId <String>]`: The unique identifier of richLongRunningOperation
  - `[SharedDriveItemId <String>]`: The unique identifier of sharedDriveItem
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[ThumbnailSetId <String>]`: The unique identifier of thumbnailSet
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS


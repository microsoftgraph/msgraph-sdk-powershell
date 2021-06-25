---
external help file: Microsoft.Graph.Files-help.xml
Module Name: Microsoft.Graph.Files
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/get-mgsharelistitemactivity
schema: 2.0.0
---

# Get-MgShareListItemActivity

## SYNOPSIS
Invoke function getActivitiesByInterval

## SYNTAX

### Get4 (Default)
```
Get-MgShareListItemActivity -SharedDriveItemId <String> [<CommonParameters>]
```

### Get3
```
Get-MgShareListItemActivity -ListItemId <String> -SharedDriveItemId <String> -EndDateTime <String>
 -Interval <String> -StartDateTime <String> [<CommonParameters>]
```

### Get2
```
Get-MgShareListItemActivity -ListItemId <String> -SharedDriveItemId <String> [<CommonParameters>]
```

### Get5
```
Get-MgShareListItemActivity -SharedDriveItemId <String> -EndDateTime <String> -Interval <String>
 -StartDateTime <String> [<CommonParameters>]
```

### GetViaIdentity5
```
Get-MgShareListItemActivity -InputObject <IFilesIdentity> [<CommonParameters>]
```

### GetViaIdentity4
```
Get-MgShareListItemActivity -InputObject <IFilesIdentity> [<CommonParameters>]
```

### GetViaIdentity3
```
Get-MgShareListItemActivity -InputObject <IFilesIdentity> [<CommonParameters>]
```

### GetViaIdentity2
```
Get-MgShareListItemActivity -InputObject <IFilesIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getActivitiesByInterval

## EXAMPLES

## PARAMETERS

### -EndDateTime
Usage: endDateTime={endDateTime}

```yaml
Type: String
Parameter Sets: Get3, Get5
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
Type: IFilesIdentity
Parameter Sets: GetViaIdentity5, GetViaIdentity4, GetViaIdentity3, GetViaIdentity2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Interval
Usage: interval={interval}

```yaml
Type: String
Parameter Sets: Get3, Get5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItemId
key: id of listItem

```yaml
Type: String
Parameter Sets: Get3, Get2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedDriveItemId
key: id of sharedDriveItem

```yaml
Type: String
Parameter Sets: Get4, Get3, Get2, Get5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
Usage: startDateTime={startDateTime}

```yaml
Type: String
Parameter Sets: Get3, Get5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IFilesIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemActivityStat1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IFilesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: id of columnDefinition
  - `[ColumnLinkId <String>]`: key: id of columnLink
  - `[ContentTypeId <String>]`: key: id of contentType
  - `[DriveId <String>]`: key: id of drive
  - `[DriveItemId <String>]`: key: id of driveItem
  - `[EndDateTime <String>]`: Usage: endDateTime={endDateTime}
  - `[GroupId <String>]`: key: id of group
  - `[Interval <String>]`: Usage: interval={interval}
  - `[ListItemId <String>]`: key: id of listItem
  - `[ListItemVersionId <String>]`: key: id of listItemVersion
  - `[Q <String>]`: Usage: q={q}
  - `[SharedDriveItemId <String>]`: key: id of sharedDriveItem
  - `[StartDateTime <String>]`: Usage: startDateTime={startDateTime}
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

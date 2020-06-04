---
external help file:
Module Name: Microsoft.Graph.Files.Drives
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files.drives/get-mgdrivelistitemactivity
schema: 2.0.0
---

# Get-MgDriveListItemActivity

## SYNOPSIS
Invoke function getActivitiesByInterval

## SYNTAX

### Get2 (Default)
```
Get-MgDriveListItemActivity -ListItemId <String> [<CommonParameters>]
```

### Get3
```
Get-MgDriveListItemActivity -EndDateTime <String> -Interval <String> -ListItemId <String>
 -StartDateTime <String> [<CommonParameters>]
```

### Get4
```
Get-MgDriveListItemActivity -DriveId <String> -ListItemId <String> [<CommonParameters>]
```

### Get5
```
Get-MgDriveListItemActivity -DriveId <String> -EndDateTime <String> -Interval <String> -ListItemId <String>
 -StartDateTime <String> [<CommonParameters>]
```

### GetViaIdentity2
```
Get-MgDriveListItemActivity -InputObject <IFilesDrivesIdentity> [<CommonParameters>]
```

### GetViaIdentity3
```
Get-MgDriveListItemActivity -InputObject <IFilesDrivesIdentity> [<CommonParameters>]
```

### GetViaIdentity4
```
Get-MgDriveListItemActivity -InputObject <IFilesDrivesIdentity> [<CommonParameters>]
```

### GetViaIdentity5
```
Get-MgDriveListItemActivity -InputObject <IFilesDrivesIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getActivitiesByInterval

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

### -DriveId
key: drive-id of drive

```yaml
Type: System.String
Parameter Sets: Get4, Get5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
.

```yaml
Type: System.String
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
Type: Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity
Parameter Sets: GetViaIdentity2, GetViaIdentity3, GetViaIdentity4, GetViaIdentity5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Interval
.

```yaml
Type: System.String
Parameter Sets: Get3, Get5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItemId
key: listItem-id of listItem

```yaml
Type: System.String
Parameter Sets: Get2, Get3, Get4, Get5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
.

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemActivityStat

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IFilesDrivesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: columnDefinition-id of columnDefinition
  - `[ColumnLinkId <String>]`: key: columnLink-id of columnLink
  - `[ContentTypeId <String>]`: key: contentType-id of contentType
  - `[DriveId <String>]`: key: drive-id of drive
  - `[DriveItemId <String>]`: key: driveItem-id of driveItem
  - `[EndDateTime <String>]`: 
  - `[Interval <String>]`: 
  - `[ItemActivityOldId <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ItemActivityOldId1 <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ListItemId <String>]`: key: listItem-id of listItem
  - `[ListItemVersionId <String>]`: key: listItemVersion-id of listItemVersion
  - `[Q <String>]`: 
  - `[StartDateTime <String>]`: 
  - `[SubscriptionId <String>]`: key: subscription-id of subscription

## RELATED LINKS


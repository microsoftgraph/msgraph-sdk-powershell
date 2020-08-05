---
external help file:
Module Name: Microsoft.Graph.Files.Drives
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files.drives/restore-mgdrivelistitemversion
schema: 2.0.0
---

# Restore-MgDriveListItemVersion

## SYNOPSIS
Invoke action restoreVersion

## SYNTAX

### Restore (Default)
```
Restore-MgDriveListItemVersion -ListItemId <String> -ListItemVersionId <String> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Restore1
```
Restore-MgDriveListItemVersion -DriveId <String> -ListItemId <String> -ListItemVersionId <String> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RestoreViaIdentity
```
Restore-MgDriveListItemVersion -InputObject <IFilesDrivesIdentity> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### RestoreViaIdentity1
```
Restore-MgDriveListItemVersion -InputObject <IFilesDrivesIdentity> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action restoreVersion

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
Parameter Sets: Restore1
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
Parameter Sets: RestoreViaIdentity, RestoreViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ListItemId
key: listItem-id of listItem

```yaml
Type: System.String
Parameter Sets: Restore, Restore1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItemVersionId
key: listItemVersion-id of listItemVersion

```yaml
Type: System.String
Parameter Sets: Restore, Restore1
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity

## OUTPUTS

### System.Boolean

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


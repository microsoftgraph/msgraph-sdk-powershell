---
external help file: Microsoft.Graph.Files-help.xml
Module Name: Microsoft.Graph.Files
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/update-mgsharelistitemversionfield
schema: 2.0.0
---

# Update-MgShareListItemVersionField

## SYNOPSIS
A collection of the fields and values for this version of the list item.

## SYNTAX

### UpdateExpanded3 (Default)
```
Update-MgShareListItemVersionField -ListItemVersionId <String> -SharedDriveItemId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateExpanded2
```
Update-MgShareListItemVersionField -ListItemId <String> -ListItemVersionId <String> -SharedDriveItemId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update2
```
Update-MgShareListItemVersionField -ListItemId <String> -ListItemVersionId <String> -SharedDriveItemId <String>
 -BodyParameter <Hashtable> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update3
```
Update-MgShareListItemVersionField -ListItemVersionId <String> -SharedDriveItemId <String>
 -BodyParameter <Hashtable> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded3
```
Update-MgShareListItemVersionField -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded2
```
Update-MgShareListItemVersionField -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity3
```
Update-MgShareListItemVersionField -InputObject <IFilesIdentity> -BodyParameter <Hashtable> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity2
```
Update-MgShareListItemVersionField -InputObject <IFilesIdentity> -BodyParameter <Hashtable> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
A collection of the fields and values for this version of the list item.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded3, UpdateExpanded2, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
fieldValueSet

```yaml
Type: Hashtable
Parameter Sets: Update2, Update3, UpdateViaIdentity3, UpdateViaIdentity2
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
Type: String
Parameter Sets: UpdateExpanded3, UpdateExpanded2, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2
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
Type: IFilesIdentity
Parameter Sets: UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentity3, UpdateViaIdentity2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ListItemId
key: id of listItem

```yaml
Type: String
Parameter Sets: UpdateExpanded2, Update2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItemVersionId
key: id of listItemVersion

```yaml
Type: String
Parameter Sets: UpdateExpanded3, UpdateExpanded2, Update2, Update3
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedDriveItemId
key: id of sharedDriveItem

```yaml
Type: String
Parameter Sets: UpdateExpanded3, UpdateExpanded2, Update2, Update3
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
Type: SwitchParameter
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
Type: SwitchParameter
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
### System.Collections.Hashtable
## OUTPUTS

### System.Boolean
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

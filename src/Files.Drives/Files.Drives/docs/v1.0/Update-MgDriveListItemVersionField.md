---
external help file:
Module Name: Microsoft.Graph.Files.Drives
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files.drives/update-mgdrivelistitemversionfield
schema: 2.0.0
---

# Update-MgDriveListItemVersionField

## SYNOPSIS
Update the navigation property fields in drive

## SYNTAX

### UpdateExpanded2 (Default)
```
Update-MgDriveListItemVersionField -ListItemId <String> -ListItemVersionId <String> [-Id <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update2
```
Update-MgDriveListItemVersionField -ListItemId <String> -ListItemVersionId <String>
 -BodyParameter <IMicrosoftGraphFieldValueSet> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update3
```
Update-MgDriveListItemVersionField -DriveId <String> -ListItemId <String> -ListItemVersionId <String>
 -BodyParameter <IMicrosoftGraphFieldValueSet> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded3
```
Update-MgDriveListItemVersionField -DriveId <String> -ListItemId <String> -ListItemVersionId <String>
 [-Id <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity2
```
Update-MgDriveListItemVersionField -InputObject <IFilesDrivesIdentity>
 -BodyParameter <IMicrosoftGraphFieldValueSet> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity3
```
Update-MgDriveListItemVersionField -InputObject <IFilesDrivesIdentity>
 -BodyParameter <IMicrosoftGraphFieldValueSet> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded2
```
Update-MgDriveListItemVersionField -InputObject <IFilesDrivesIdentity> [-Id <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded3
```
Update-MgDriveListItemVersionField -InputObject <IFilesDrivesIdentity> [-Id <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property fields in drive

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
fieldValueSet
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFieldValueSet
Parameter Sets: Update2, Update3, UpdateViaIdentity2, UpdateViaIdentity3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DriveId
key: drive-id of drive

```yaml
Type: System.String
Parameter Sets: Update3, UpdateExpanded3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded3
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
Type: Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity
Parameter Sets: UpdateViaIdentity2, UpdateViaIdentity3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded3
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
Parameter Sets: Update2, Update3, UpdateExpanded2, UpdateExpanded3
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
Parameter Sets: Update2, Update3, UpdateExpanded2, UpdateExpanded3
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFieldValueSet

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphFieldValueSet>: fieldValueSet
  - `[Id <String>]`: Read-only.

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


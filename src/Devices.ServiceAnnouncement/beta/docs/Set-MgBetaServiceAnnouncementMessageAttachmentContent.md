---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.ServiceAnnouncement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devices.serviceannouncement/set-mgbetaserviceannouncementmessageattachmentcontent
schema: 2.0.0
---

# Set-MgBetaServiceAnnouncementMessageAttachmentContent

## SYNOPSIS
The attachment content.

## SYNTAX

### Set (Default)
```
Set-MgBetaServiceAnnouncementMessageAttachmentContent -ServiceAnnouncementAttachmentId <String>
 -ServiceUpdateMessageId <String> -InFile <String> [-Data <Stream>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-MgBetaServiceAnnouncementMessageAttachmentContent -InputObject <IDevicesServiceAnnouncementIdentity>
 -InFile <String> [-Data <Stream>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The attachment content.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement
```

Get-MgBetaServiceAnnouncementMessageAttachment -ServiceUpdateMessageId $serviceUpdateMessageId

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement
```

Get-MgBetaServiceAnnouncementMessageAttachmentArchive -ServiceUpdateMessageId $serviceUpdateMessageId

## PARAMETERS

### -Data
.

```yaml
Type: System.IO.Stream
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InFile
The path to the file to upload.
This should include a path and file name.
If you omit the path, the current location will be used.

```yaml
Type: System.String
Parameter Sets: (All)
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IDevicesServiceAnnouncementIdentity
Parameter Sets: SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ServiceAnnouncementAttachmentId
The unique identifier of serviceAnnouncementAttachment

```yaml
Type: System.String
Parameter Sets: Set
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceUpdateMessageId
The unique identifier of serviceUpdateMessage

```yaml
Type: System.String
Parameter Sets: Set
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

### Microsoft.Graph.Beta.PowerShell.Models.IDevicesServiceAnnouncementIdentity

### System.IO.Stream

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphServiceAnnouncementAttachment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IDevicesServiceAnnouncementIdentity>`: Identity Parameter
  - `[ServiceAnnouncementAttachmentId <String>]`: The unique identifier of serviceAnnouncementAttachment
  - `[ServiceHealthId <String>]`: The unique identifier of serviceHealth
  - `[ServiceHealthIssueId <String>]`: The unique identifier of serviceHealthIssue
  - `[ServiceUpdateMessageId <String>]`: The unique identifier of serviceUpdateMessage

## RELATED LINKS


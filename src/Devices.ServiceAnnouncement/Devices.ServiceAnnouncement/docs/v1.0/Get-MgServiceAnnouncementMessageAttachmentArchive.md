---
external help file:
Module Name: Microsoft.Graph.Devices.ServiceAnnouncement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.serviceannouncement/get-mgserviceannouncementmessageattachmentarchive
schema: 2.0.0
---

# Get-MgServiceAnnouncementMessageAttachmentArchive

## SYNOPSIS
The zip file that contains all attachments for a message.

## SYNTAX

### Get1 (Default)
```
Get-MgServiceAnnouncementMessageAttachmentArchive -ServiceUpdateMessageId <String> -OutFile <String>
 [-PassThru] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgServiceAnnouncementMessageAttachmentArchive -InputObject <IDevicesServiceAnnouncementIdentity>
 -OutFile <String> [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The zip file that contains all attachments for a message.

## EXAMPLES

### Example 1: Using the Get-MgServiceAnnouncementMessageAttachmentArchive Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementMessageAttachmentArchive -ServiceUpdateMessageId $serviceUpdateMessageId
```

This example shows how to use the Get-MgServiceAnnouncementMessageAttachmentArchive Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Get-MgServiceAnnouncementMessageAttachmentArchive Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementMessageAttachmentArchive -ServiceUpdateMessageId $serviceUpdateMessageId -OutFile $outFileId
```

This example shows how to use the Get-MgServiceAnnouncementMessageAttachmentArchive Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesServiceAnnouncementIdentity
Parameter Sets: GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OutFile
Path to write output file to

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

### -ServiceUpdateMessageId
The unique identifier of serviceUpdateMessage

```yaml
Type: System.String
Parameter Sets: Get1
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

### Microsoft.Graph.PowerShell.Models.IDevicesServiceAnnouncementIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDevicesServiceAnnouncementIdentity>: Identity Parameter
  - `[ServiceAnnouncementAttachmentId <String>]`: The unique identifier of serviceAnnouncementAttachment
  - `[ServiceHealthId <String>]`: The unique identifier of serviceHealth
  - `[ServiceHealthIssueId <String>]`: The unique identifier of serviceHealthIssue
  - `[ServiceUpdateMessageId <String>]`: The unique identifier of serviceUpdateMessage

## RELATED LINKS


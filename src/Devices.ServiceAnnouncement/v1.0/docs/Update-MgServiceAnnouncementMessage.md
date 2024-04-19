---
external help file:
Module Name: Microsoft.Graph.Devices.ServiceAnnouncement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devices.serviceannouncement/update-mgserviceannouncementmessage
schema: 2.0.0
---

# Update-MgServiceAnnouncementMessage

## SYNOPSIS
Update the navigation property messages in admin

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgServiceAnnouncementMessage -ServiceUpdateMessageId <String> [-ActionRequiredByDateTime <DateTime>]
 [-AdditionalProperties <Hashtable>] [-Attachments <IMicrosoftGraphServiceAnnouncementAttachment[]>]
 [-AttachmentsArchiveInputFile <String>] [-Body <IMicrosoftGraphItemBody>] [-Category <String>]
 [-Details <IMicrosoftGraphKeyValuePair[]>] [-EndDateTime <DateTime>] [-HasAttachments] [-Id <String>]
 [-IsMajorChange] [-LastModifiedDateTime <DateTime>] [-ResponseHeadersVariable <String>]
 [-Services <String[]>] [-Severity <String>] [-StartDateTime <DateTime>] [-Tags <String[]>] [-Title <String>]
 [-ViewPoint <IMicrosoftGraphServiceUpdateMessageViewpoint>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgServiceAnnouncementMessage -ServiceUpdateMessageId <String>
 -BodyParameter <IMicrosoftGraphServiceUpdateMessage> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgServiceAnnouncementMessage -InputObject <IDevicesServiceAnnouncementIdentity>
 -BodyParameter <IMicrosoftGraphServiceUpdateMessage> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgServiceAnnouncementMessage -InputObject <IDevicesServiceAnnouncementIdentity>
 [-ActionRequiredByDateTime <DateTime>] [-AdditionalProperties <Hashtable>]
 [-Attachments <IMicrosoftGraphServiceAnnouncementAttachment[]>] [-AttachmentsArchiveInputFile <String>]
 [-Body <IMicrosoftGraphItemBody>] [-Category <String>] [-Details <IMicrosoftGraphKeyValuePair[]>]
 [-EndDateTime <DateTime>] [-HasAttachments] [-Id <String>] [-IsMajorChange]
 [-LastModifiedDateTime <DateTime>] [-ResponseHeadersVariable <String>] [-Services <String[]>]
 [-Severity <String>] [-StartDateTime <DateTime>] [-Tags <String[]>] [-Title <String>]
 [-ViewPoint <IMicrosoftGraphServiceUpdateMessageViewpoint>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property messages in admin

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -ActionRequiredByDateTime
The expected deadline of the action for the message.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Attachments
A collection of serviceAnnouncementAttachments.
To construct, see NOTES section for ATTACHMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServiceAnnouncementAttachment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttachmentsArchiveInputFile
Input File for AttachmentsArchive (The zip file that contains all attachments for a message.)

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
itemBody
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemBody
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
serviceUpdateMessage
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServiceUpdateMessage
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
serviceUpdateCategory

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Details
More details about service event.
This property doesn't support filters.
To construct, see NOTES section for DETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
The end time of the service event.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HasAttachments
Indicates whether the message has any attachment.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
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
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesServiceAnnouncementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsMajorChange
Indicates whether the message describes a major update for the service.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The last modified time of the service event.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Services
The affected services by the service message.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Severity
serviceUpdateSeverity

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
The start time of the service event.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tags
A collection of tags for the service message.
Tags are provided by the service team/support team who post the message to tell whether this message contains privacy data, or whether this message is for a service new feature update, and so on.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title
The title of the service event.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewPoint
serviceUpdateMessageViewpoint
To construct, see NOTES section for VIEWPOINT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServiceUpdateMessageViewpoint
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IDevicesServiceAnnouncementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServiceUpdateMessage

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServiceUpdateMessage

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ATTACHMENTS <IMicrosoftGraphServiceAnnouncementAttachment[]>`: A collection of serviceAnnouncementAttachments.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Content <Byte[]>]`: The attachment content.
  - `[ContentType <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Name <String>]`: 
  - `[Size <Int32?>]`: 

`BODY <IMicrosoftGraphItemBody>`: itemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: The content of the item.
  - `[ContentType <String>]`: bodyType

`BODYPARAMETER <IMicrosoftGraphServiceUpdateMessage>`: serviceUpdateMessage
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Details <IMicrosoftGraphKeyValuePair[]>]`: More details about service event. This property doesn't support filters.
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[EndDateTime <DateTime?>]`: The end time of the service event.
  - `[LastModifiedDateTime <DateTime?>]`: The last modified time of the service event.
  - `[StartDateTime <DateTime?>]`: The start time of the service event.
  - `[Title <String>]`: The title of the service event.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActionRequiredByDateTime <DateTime?>]`: The expected deadline of the action for the message.
  - `[Attachments <IMicrosoftGraphServiceAnnouncementAttachment[]>]`: A collection of serviceAnnouncementAttachments.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Content <Byte[]>]`: The attachment content.
    - `[ContentType <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Name <String>]`: 
    - `[Size <Int32?>]`: 
  - `[AttachmentsArchive <Byte[]>]`: The zip file that contains all attachments for a message.
  - `[Body <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[Category <String>]`: serviceUpdateCategory
  - `[HasAttachments <Boolean?>]`: Indicates whether the message has any attachment.
  - `[IsMajorChange <Boolean?>]`: Indicates whether the message describes a major update for the service.
  - `[Services <String[]>]`: The affected services by the service message.
  - `[Severity <String>]`: serviceUpdateSeverity
  - `[Tags <String[]>]`: A collection of tags for the service message. Tags are provided by the service team/support team who post the message to tell whether this message contains privacy data, or whether this message is for a service new feature update, and so on.
  - `[ViewPoint <IMicrosoftGraphServiceUpdateMessageViewpoint>]`: serviceUpdateMessageViewpoint
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsArchived <Boolean?>]`: Indicates whether the user archived the message.
    - `[IsFavorited <Boolean?>]`: Indicates whether the user marked the message as favorite.
    - `[IsRead <Boolean?>]`: Indicates whether the user read the message.

`DETAILS <IMicrosoftGraphKeyValuePair[]>`: More details about service event. This property doesn't support filters.
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

`INPUTOBJECT <IDevicesServiceAnnouncementIdentity>`: Identity Parameter
  - `[ServiceAnnouncementAttachmentId <String>]`: The unique identifier of serviceAnnouncementAttachment
  - `[ServiceHealthId <String>]`: The unique identifier of serviceHealth
  - `[ServiceHealthIssueId <String>]`: The unique identifier of serviceHealthIssue
  - `[ServiceUpdateMessageId <String>]`: The unique identifier of serviceUpdateMessage

`VIEWPOINT <IMicrosoftGraphServiceUpdateMessageViewpoint>`: serviceUpdateMessageViewpoint
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsArchived <Boolean?>]`: Indicates whether the user archived the message.
  - `[IsFavorited <Boolean?>]`: Indicates whether the user marked the message as favorite.
  - `[IsRead <Boolean?>]`: Indicates whether the user read the message.

## RELATED LINKS


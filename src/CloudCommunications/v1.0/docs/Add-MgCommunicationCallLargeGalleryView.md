---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.cloudcommunications/add-mgcommunicationcalllargegalleryview
schema: 2.0.0
---

# Add-MgCommunicationCallLargeGalleryView

## SYNOPSIS
Add the large gallery view to a call.
For details about how to identify a large gallery view participant in a roster so that you can retrieve the relevant data to subscribe to the video feed, see Identify large gallery view participants in a roster.

## SYNTAX

### AddExpanded (Default)
```
Add-MgCommunicationCallLargeGalleryView -CallId <String> [-AdditionalProperties <Hashtable>]
 [-ClientContext <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Add
```
Add-MgCommunicationCallLargeGalleryView -CallId <String>
 -BodyParameter <IPaths12Hh6NfCommunicationsCallsCallIdMicrosoftGraphAddlargegalleryviewPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentity
```
Add-MgCommunicationCallLargeGalleryView -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths12Hh6NfCommunicationsCallsCallIdMicrosoftGraphAddlargegalleryviewPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentityExpanded
```
Add-MgCommunicationCallLargeGalleryView -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-ClientContext <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add the large gallery view to a call.
For details about how to identify a large gallery view participant in a roster so that you can retrieve the relevant data to subscribe to the video feed, see Identify large gallery view participants in a roster.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
```

$params = @{
	clientContext = "785f4929-92ca-497b-863f-c778c77c9758"
}

Add-MgCommunicationCallLargeGalleryView -CallId $callId -BodyParameter $params

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths12Hh6NfCommunicationsCallsCallIdMicrosoftGraphAddlargegalleryviewPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Add, AddViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CallId
The unique identifier of call

```yaml
Type: System.String
Parameter Sets: Add, AddExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientContext
.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: AddViaIdentity, AddViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths12Hh6NfCommunicationsCallsCallIdMicrosoftGraphAddlargegalleryviewPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAddLargeGalleryViewOperation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths12Hh6NfCommunicationsCallsCallIdMicrosoftGraphAddlargegalleryviewPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ClientContext <String>]`: 

`INPUTOBJECT <ICloudCommunicationsIdentity>`: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[AudioRoutingGroupId <String>]`: The unique identifier of audioRoutingGroup
  - `[CallId <String>]`: The unique identifier of call
  - `[CallRecordId <String>]`: The unique identifier of callRecord
  - `[CallRecordingId <String>]`: The unique identifier of callRecording
  - `[CallTranscriptId <String>]`: The unique identifier of callTranscript
  - `[CommsOperationId <String>]`: The unique identifier of commsOperation
  - `[ContentSharingSessionId <String>]`: The unique identifier of contentSharingSession
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[OnlineMeetingId <String>]`: The unique identifier of onlineMeeting
  - `[ParticipantId <String>]`: The unique identifier of participant
  - `[PresenceId <String>]`: The unique identifier of presence
  - `[SessionId <String>]`: The unique identifier of session
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS


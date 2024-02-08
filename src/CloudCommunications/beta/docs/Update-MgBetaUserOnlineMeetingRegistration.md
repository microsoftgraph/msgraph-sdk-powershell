---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.cloudcommunications/update-mgbetauseronlinemeetingregistration
schema: 2.0.0
---

# Update-MgBetaUserOnlineMeetingRegistration

## SYNOPSIS
Update the details of a meetingRegistration object assciated with an onlineMeeting on behalf of the organizer.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaUserOnlineMeetingRegistration -OnlineMeetingId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-AllowedRegistrant <String>]
 [-CustomQuestions <IMicrosoftGraphMeetingRegistrationQuestion[]>] [-Description <String>]
 [-EndDateTime <DateTime>] [-Id <String>] [-Registrants <IMicrosoftGraphMeetingRegistrantBase[]>]
 [-RegistrationPageViewCount <Int32>] [-RegistrationPageWebUrl <String>]
 [-Speakers <IMicrosoftGraphMeetingSpeaker[]>] [-StartDateTime <DateTime>] [-Subject <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaUserOnlineMeetingRegistration -OnlineMeetingId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphMeetingRegistration> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaUserOnlineMeetingRegistration -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IMicrosoftGraphMeetingRegistration> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaUserOnlineMeetingRegistration -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-AllowedRegistrant <String>]
 [-CustomQuestions <IMicrosoftGraphMeetingRegistrationQuestion[]>] [-Description <String>]
 [-EndDateTime <DateTime>] [-Id <String>] [-Registrants <IMicrosoftGraphMeetingRegistrantBase[]>]
 [-RegistrationPageViewCount <Int32>] [-RegistrationPageWebUrl <String>]
 [-Speakers <IMicrosoftGraphMeetingSpeaker[]>] [-StartDateTime <DateTime>] [-Subject <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the details of a meetingRegistration object assciated with an onlineMeeting on behalf of the organizer.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Subject = "Microsoft Ignite: Day 1"
	StartDateTime = [System.DateTime]::Parse("2021-11-02T08:00:00-08:00")
	EndDateTime = [System.DateTime]::Parse("2021-11-02T15:45:00-08:00")
	Speakers = @(
		@{
			DisplayName = "Henry Ross"
			Bio = "Chairman and Chief Executive Officer"
		}
		@{
			DisplayName = "Fred Ryan"
			Bio = "CVP"
		}
	)
}
# A UPN can also be used as -UserId.
Update-MgBetaUserOnlineMeetingRegistration -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params
```



## PARAMETERS

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

### -AllowedRegistrant
meetingAudience

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

### -BodyParameter
meetingRegistration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingRegistration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CustomQuestions
Custom registration questions.
To construct, see NOTES section for CUSTOMQUESTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingRegistrationQuestion[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the meeting.

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

### -EndDateTime
The meeting end time in UTC.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OnlineMeetingId
The unique identifier of onlineMeeting

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

### -Registrants
Registrants of the online meeting.
To construct, see NOTES section for REGISTRANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingRegistrantBase[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegistrationPageViewCount
The number of times the registration page has been visited.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegistrationPageWebUrl
The URL of the registration page.
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

### -Speakers
The meeting speaker's information.
To construct, see NOTES section for SPEAKERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingSpeaker[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
The meeting start time in UTC.

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

### -Subject
The subject of the meeting.

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

### -UserId
The unique identifier of user

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

### Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingRegistration

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingRegistration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphMeetingRegistration>`: meetingRegistration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowedRegistrant <String>]`: meetingAudience
  - `[Registrants <IMicrosoftGraphMeetingRegistrantBase[]>]`: Registrants of the online meeting.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[JoinWebUrl <String>]`: A unique web URL for the registrant to join the meeting. Read-only.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CustomQuestions <IMicrosoftGraphMeetingRegistrationQuestion[]>]`: Custom registration questions.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AnswerInputType <String>]`: answerInputType
    - `[AnswerOptions <String[]>]`: Answer options when answerInputType is radioButton.
    - `[DisplayName <String>]`: Display name of the custom registration question.
    - `[IsRequired <Boolean?>]`: Indicates whether the question is required. Default value is false.
  - `[Description <String>]`: The description of the meeting.
  - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
  - `[RegistrationPageViewCount <Int32?>]`: The number of times the registration page has been visited. Read-only.
  - `[RegistrationPageWebUrl <String>]`: The URL of the registration page. Read-only.
  - `[Speakers <IMicrosoftGraphMeetingSpeaker[]>]`: The meeting speaker's information.
    - `[Bio <String>]`: Bio of the speaker.
    - `[DisplayName <String>]`: Display name of the speaker.
  - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
  - `[Subject <String>]`: The subject of the meeting.

`CUSTOMQUESTIONS <IMicrosoftGraphMeetingRegistrationQuestion[]>`: Custom registration questions.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AnswerInputType <String>]`: answerInputType
  - `[AnswerOptions <String[]>]`: Answer options when answerInputType is radioButton.
  - `[DisplayName <String>]`: Display name of the custom registration question.
  - `[IsRequired <Boolean?>]`: Indicates whether the question is required. Default value is false.

`INPUTOBJECT <ICloudCommunicationsIdentity>`: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[AudioRoutingGroupId <String>]`: The unique identifier of audioRoutingGroup
  - `[CallId <String>]`: The unique identifier of call
  - `[CallRecordId <String>]`: The unique identifier of callRecord
  - `[CallRecordingId <String>]`: The unique identifier of callRecording
  - `[CallTranscriptId <String>]`: The unique identifier of callTranscript
  - `[CommsOperationId <String>]`: The unique identifier of commsOperation
  - `[ContentSharingSessionId <String>]`: The unique identifier of contentSharingSession
  - `[FromDateTime <DateTime?>]`: Usage: fromDateTime={fromDateTime}
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[MeetingRegistrantBaseId <String>]`: The unique identifier of meetingRegistrantBase
  - `[MeetingRegistrationQuestionId <String>]`: The unique identifier of meetingRegistrationQuestion
  - `[OnlineMeetingId <String>]`: The unique identifier of onlineMeeting
  - `[ParticipantId <String>]`: The unique identifier of participant
  - `[PresenceId <String>]`: The unique identifier of presence
  - `[SessionId <String>]`: The unique identifier of session
  - `[ToDateTime <DateTime?>]`: Usage: toDateTime={toDateTime}
  - `[UserId <String>]`: The unique identifier of user

`REGISTRANTS <IMicrosoftGraphMeetingRegistrantBase[]>`: Registrants of the online meeting.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[JoinWebUrl <String>]`: A unique web URL for the registrant to join the meeting. Read-only.

`SPEAKERS <IMicrosoftGraphMeetingSpeaker[]>`: The meeting speaker's information.
  - `[Bio <String>]`: Bio of the speaker.
  - `[DisplayName <String>]`: Display name of the speaker.

## RELATED LINKS


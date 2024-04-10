---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.cloudcommunications/invoke-mgbetaredirectcommunicationcall
schema: 2.0.0
---

# Invoke-MgBetaRedirectCommunicationCall

## SYNOPSIS
Redirect an incoming call that wasn't answered or rejected yet.
The terms 'redirecting' and 'forwarding' a call are used interchangeably.
The bot is expected to redirect the call before the call times out.
The current timeout value is 15 seconds.

## SYNTAX

### RedirectExpanded (Default)
```
Invoke-MgBetaRedirectCommunicationCall -CallId <String> [-AdditionalProperties <Hashtable>]
 [-CallbackUri <String>] [-MaskCallee] [-MaskCaller] [-ResponseHeadersVariable <String>]
 [-TargetDisposition <String>] [-Targets <IMicrosoftGraphInvitationParticipantInfo[]>] [-Timeout <Int32>]
 [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Redirect
```
Invoke-MgBetaRedirectCommunicationCall -CallId <String>
 -BodyParameter <IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### RedirectViaIdentity
```
Invoke-MgBetaRedirectCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### RedirectViaIdentityExpanded
```
Invoke-MgBetaRedirectCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-CallbackUri <String>] [-MaskCallee] [-MaskCaller]
 [-ResponseHeadersVariable <String>] [-TargetDisposition <String>]
 [-Targets <IMicrosoftGraphInvitationParticipantInfo[]>] [-Timeout <Int32>] [-Headers <IDictionary>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Redirect an incoming call that wasn't answered or rejected yet.
The terms 'redirecting' and 'forwarding' a call are used interchangeably.
The bot is expected to redirect the call before the call times out.
The current timeout value is 15 seconds.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				phone = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "+12345678901"
				}
			}
		}
	)
	callbackUri = "https://bot.contoso.com/api/calls/24701998-1a73-4d42-8085-bf46ed0ae039"
}

Invoke-MgBetaRedirectCommunicationCall -CallId $callId -BodyParameter $params

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Redirect, RedirectViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CallbackUri
.

```yaml
Type: System.String
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallId
The unique identifier of call

```yaml
Type: System.String
Parameter Sets: Redirect, RedirectExpanded
Aliases:

Required: True
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: RedirectViaIdentity, RedirectViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MaskCallee
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaskCaller
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
Aliases:

Required: False
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

### -TargetDisposition
callDisposition

```yaml
Type: System.String
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Targets
.
To construct, see NOTES section for TARGETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo[]
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Timeout
.

```yaml
Type: System.Int32
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CallbackUri <String>]`: 
  - `[MaskCallee <Boolean?>]`: 
  - `[MaskCaller <Boolean?>]`: 
  - `[TargetDisposition <String>]`: callDisposition
  - `[Targets <IMicrosoftGraphInvitationParticipantInfo[]>]`: 
    - `[EndpointType <String>]`: endpointType
    - `[Hidden <Boolean?>]`: Optional. Whether to hide the participant from the roster.
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[ParticipantId <String>]`: Optional. The ID of the target participant.
    - `[RemoveFromDefaultAudioRoutingGroup <Boolean?>]`: Optional. Whether to remove them from the main mixer.
    - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.
  - `[Timeout <Int32?>]`: 

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
  - `[JoinWebUrl <String>]`: Alternate key of onlineMeeting
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[MeetingRegistrantBaseId <String>]`: The unique identifier of meetingRegistrantBase
  - `[MeetingRegistrationQuestionId <String>]`: The unique identifier of meetingRegistrationQuestion
  - `[OnlineMeetingId <String>]`: The unique identifier of onlineMeeting
  - `[ParticipantId <String>]`: The unique identifier of participant
  - `[PresenceId <String>]`: The unique identifier of presence
  - `[SessionId <String>]`: The unique identifier of session
  - `[ToDateTime <DateTime?>]`: Usage: toDateTime={toDateTime}
  - `[UserId <String>]`: The unique identifier of user

`TARGETS <IMicrosoftGraphInvitationParticipantInfo[]>`: .
  - `[EndpointType <String>]`: endpointType
  - `[Hidden <Boolean?>]`: Optional. Whether to hide the participant from the roster.
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ParticipantId <String>]`: Optional. The ID of the target participant.
  - `[RemoveFromDefaultAudioRoutingGroup <Boolean?>]`: Optional. Whether to remove them from the main mixer.
  - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.

## RELATED LINKS


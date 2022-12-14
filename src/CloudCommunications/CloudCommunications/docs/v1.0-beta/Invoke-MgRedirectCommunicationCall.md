---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.cloudcommunications/invoke-mgredirectcommunicationcall
schema: 2.0.0
---

# Invoke-MgBetaRedirectCommunicationCall

## SYNOPSIS
Redirect an incoming call that hasn't been answered or rejected yet.
The terms 'redirecting' and 'forwarding' a call are used interchangeably.
The bot is expected to redirect the call before the call times out.
The current timeout value is 15 seconds.

## SYNTAX

### RedirectExpanded1 (Default)
```
Invoke-MgBetaRedirectCommunicationCall -CallId <String> [-AdditionalProperties <Hashtable>]
 [-CallbackUri <String>] [-MaskCallee] [-MaskCaller] [-TargetDisposition <String>]
 [-Targets <IMicrosoftGraphInvitationParticipantInfo1[]>] [-Timeout <Int32>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Redirect1
```
Invoke-MgBetaRedirectCommunicationCall -CallId <String>
 -BodyParameter <IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RedirectViaIdentity1
```
Invoke-MgBetaRedirectCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RedirectViaIdentityExpanded1
```
Invoke-MgBetaRedirectCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-CallbackUri <String>] [-MaskCallee] [-MaskCaller]
 [-TargetDisposition <String>] [-Targets <IMicrosoftGraphInvitationParticipantInfo1[]>] [-Timeout <Int32>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Redirect an incoming call that hasn't been answered or rejected yet.
The terms 'redirecting' and 'forwarding' a call are used interchangeably.
The bot is expected to redirect the call before the call times out.
The current timeout value is 15 seconds.

## EXAMPLES

### Example 1: Using the Invoke-MgBetaRedirectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Targets = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				Application = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					DisplayName = "test bot 2"
					Id = "22bfd41f-550e-477d-8789-f6f7bd2a5e8b"
				}
			}
		}
	)
	CallbackUri = "https://bot.contoso.com/api/calls/24701998-1a73-4d42-8085-bf46ed0ae039"
}
Invoke-MgBetaRedirectCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaRedirectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Invoke-MgBetaRedirectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Targets = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				Phone = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					Id = "+12345678901"
				}
			}
		}
	)
	CallbackUri = "https://bot.contoso.com/api/calls/24701998-1a73-4d42-8085-bf46ed0ae039"
}
Invoke-MgBetaRedirectCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaRedirectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: RedirectExpanded1, RedirectViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Redirect1, RedirectViaIdentity1
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
Parameter Sets: RedirectExpanded1, RedirectViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallId
key: id of call

```yaml
Type: System.String
Parameter Sets: Redirect1, RedirectExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: RedirectViaIdentity1, RedirectViaIdentityExpanded1
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
Parameter Sets: RedirectExpanded1, RedirectViaIdentityExpanded1
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
Parameter Sets: RedirectExpanded1, RedirectViaIdentityExpanded1
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

### -TargetDisposition
callDisposition

```yaml
Type: System.String
Parameter Sets: RedirectExpanded1, RedirectViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Targets
.
To construct, please use Get-Help -Online and see NOTES section for TARGETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo1[]
Parameter Sets: RedirectExpanded1, RedirectViaIdentityExpanded1
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
Parameter Sets: RedirectExpanded1, RedirectViaIdentityExpanded1
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

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CallbackUri <String>]`: 
  - `[MaskCallee <Boolean?>]`: 
  - `[MaskCaller <Boolean?>]`: 
  - `[TargetDisposition <String>]`: callDisposition
  - `[Targets <IMicrosoftGraphInvitationParticipantInfo1[]>]`: 
    - `[EndpointType <String>]`: endpointType
    - `[Hidden <Boolean?>]`: Optional. Whether to hide the participant from the roster.
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[ParticipantId <String>]`: Optional. The ID of the target participant.
    - `[RemoveFromDefaultAudioRoutingGroup <Boolean?>]`: Optional. Whether to remove them from the main mixer.
    - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.
  - `[Timeout <Int32?>]`: 

INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AttendanceRecordId <String>]`: key: id of attendanceRecord
  - `[AudioRoutingGroupId <String>]`: key: id of audioRoutingGroup
  - `[CallId <String>]`: key: id of call
  - `[CallRecordId <String>]`: key: id of callRecord
  - `[CallTranscriptId <String>]`: key: id of callTranscript
  - `[CommsOperationId <String>]`: key: id of commsOperation
  - `[ContentSharingSessionId <String>]`: key: id of contentSharingSession
  - `[MeetingAttendanceReportId <String>]`: key: id of meetingAttendanceReport
  - `[MeetingRegistrationQuestionId <String>]`: key: id of meetingRegistrationQuestion
  - `[OnlineMeetingId <String>]`: key: id of onlineMeeting
  - `[ParticipantId <String>]`: key: id of participant
  - `[PresenceId <String>]`: key: id of presence
  - `[SessionId <String>]`: key: id of session
  - `[UserId <String>]`: key: id of user

TARGETS <IMicrosoftGraphInvitationParticipantInfo1[]>: .
  - `[EndpointType <String>]`: endpointType
  - `[Hidden <Boolean?>]`: Optional. Whether to hide the participant from the roster.
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ParticipantId <String>]`: Optional. The ID of the target participant.
  - `[RemoveFromDefaultAudioRoutingGroup <Boolean?>]`: Optional. Whether to remove them from the main mixer.
  - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.

## RELATED LINKS


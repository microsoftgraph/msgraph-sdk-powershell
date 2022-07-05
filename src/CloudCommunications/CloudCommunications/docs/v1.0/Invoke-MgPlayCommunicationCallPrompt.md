---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/invoke-mgplaycommunicationcallprompt
schema: 2.0.0
---

# Invoke-MgPlayCommunicationCallPrompt

## SYNOPSIS
Invoke action playPrompt

## SYNTAX

### PlayExpanded (Default)
```
Invoke-MgPlayCommunicationCallPrompt -CallId <String> [-AdditionalProperties <Hashtable>]
 [-ClientContext <String>] [-Prompts <IMicrosoftGraphPrompt[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Play
```
Invoke-MgPlayCommunicationCallPrompt -CallId <String>
 -BodyParameter <IPaths1Gzqcv2CommunicationsCallsCallIdMicrosoftGraphPlaypromptPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PlayViaIdentity
```
Invoke-MgPlayCommunicationCallPrompt -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths1Gzqcv2CommunicationsCallsCallIdMicrosoftGraphPlaypromptPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PlayViaIdentityExpanded
```
Invoke-MgPlayCommunicationCallPrompt -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-ClientContext <String>] [-Prompts <IMicrosoftGraphPrompt[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action playPrompt

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: PlayExpanded, PlayViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Gzqcv2CommunicationsCallsCallIdMicrosoftGraphPlaypromptPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Play, PlayViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CallId
key: id of call

```yaml
Type: System.String
Parameter Sets: Play, PlayExpanded
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
Parameter Sets: PlayExpanded, PlayViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: PlayViaIdentity, PlayViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Prompts
.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrompt[]
Parameter Sets: PlayExpanded, PlayViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths1Gzqcv2CommunicationsCallsCallIdMicrosoftGraphPlaypromptPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlayPromptOperation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Gzqcv2CommunicationsCallsCallIdMicrosoftGraphPlaypromptPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ClientContext <String>]`: 
  - `[Prompts <IMicrosoftGraphPrompt[]>]`: 

INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AttendanceRecordId <String>]`: key: id of attendanceRecord
  - `[AudioRoutingGroupId <String>]`: key: id of audioRoutingGroup
  - `[CallId <String>]`: key: id of call
  - `[CallRecordId <String>]`: key: id of callRecord
  - `[CommsOperationId <String>]`: key: id of commsOperation
  - `[ContentSharingSessionId <String>]`: key: id of contentSharingSession
  - `[MeetingAttendanceReportId <String>]`: key: id of meetingAttendanceReport
  - `[MeetingRegistrationQuestionId <String>]`: key: id of meetingRegistrationQuestion
  - `[OnlineMeetingId <String>]`: key: id of onlineMeeting
  - `[ParticipantId <String>]`: key: id of participant
  - `[PresenceId <String>]`: key: id of presence
  - `[SessionId <String>]`: key: id of session
  - `[UserId <String>]`: key: id of user

## RELATED LINKS


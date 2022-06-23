---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/invoke-mgunmutecommunicationcall
schema: 2.0.0
---

# Invoke-MgUnmuteCommunicationCall

## SYNOPSIS
Invoke action unmute

## SYNTAX

### UnmuteExpanded (Default)
```
Invoke-MgUnmuteCommunicationCall -CallId <String> [-AdditionalProperties <Hashtable>]
 [-ClientContext <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Unmute
```
Invoke-MgUnmuteCommunicationCall -CallId <String>
 -BodyParameter <IPaths1X7BvttCommunicationsCallsCallIdMicrosoftGraphUnmutePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UnmuteViaIdentity
```
Invoke-MgUnmuteCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths1X7BvttCommunicationsCallsCallIdMicrosoftGraphUnmutePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UnmuteViaIdentityExpanded
```
Invoke-MgUnmuteCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-ClientContext <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action unmute

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UnmuteExpanded, UnmuteViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1X7BvttCommunicationsCallsCallIdMicrosoftGraphUnmutePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Unmute, UnmuteViaIdentity
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
Parameter Sets: Unmute, UnmuteExpanded
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
Parameter Sets: UnmuteExpanded, UnmuteViaIdentityExpanded
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
Parameter Sets: UnmuteViaIdentity, UnmuteViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1X7BvttCommunicationsCallsCallIdMicrosoftGraphUnmutePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnmuteParticipantOperation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1X7BvttCommunicationsCallsCallIdMicrosoftGraphUnmutePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ClientContext <String>]`: 

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


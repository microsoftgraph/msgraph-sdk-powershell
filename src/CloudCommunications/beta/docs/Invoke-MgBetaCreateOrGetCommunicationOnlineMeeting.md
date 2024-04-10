---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.cloudcommunications/invoke-mgbetacreateorgetcommunicationonlinemeeting
schema: 2.0.0
---

# Invoke-MgBetaCreateOrGetCommunicationOnlineMeeting

## SYNOPSIS
Create an onlineMeeting object with a custom specified external ID.
If the external ID already exists, this API will return the onlineMeeting object with that external ID.

## SYNTAX

### CreateExpanded1 (Default)
```
Invoke-MgBetaCreateOrGetCommunicationOnlineMeeting [-AdditionalProperties <Hashtable>]
 [-ChatInfo <IMicrosoftGraphChatInfo>] [-EndDateTime <DateTime>] [-ExternalId <String>]
 [-Participants <IMicrosoftGraphMeetingParticipants>] [-ResponseHeadersVariable <String>]
 [-StartDateTime <DateTime>] [-Subject <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create1
```
Invoke-MgBetaCreateOrGetCommunicationOnlineMeeting
 -BodyParameter <IPaths1Pc6SxrCommunicationsOnlinemeetingsMicrosoftGraphCreateorgetPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create an onlineMeeting object with a custom specified external ID.
If the external ID already exists, this API will return the onlineMeeting object with that external ID.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1Pc6SxrCommunicationsOnlinemeetingsMicrosoftGraphCreateorgetPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChatInfo
chatInfo
To construct, see NOTES section for CHATINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphChatInfo
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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

### -Participants
meetingParticipants
To construct, see NOTES section for PARTICIPANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingParticipants
Parameter Sets: CreateExpanded1
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

### -StartDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1Pc6SxrCommunicationsOnlinemeetingsMicrosoftGraphCreateorgetPostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnlineMeeting

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths1Pc6SxrCommunicationsOnlinemeetingsMicrosoftGraphCreateorgetPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ChatInfo <IMicrosoftGraphChatInfo>]`: chatInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MessageId <String>]`: The unique identifier for a message in a Microsoft Teams channel.
    - `[ReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[EndDateTime <DateTime?>]`: 
  - `[ExternalId <String>]`: 
  - `[Participants <IMicrosoftGraphMeetingParticipants>]`: meetingParticipants
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Attendees <IMicrosoftGraphMeetingParticipantInfo[]>]`: Information of the meeting attendees.
      - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
          - `[Id <String>]`: The identifier of the identity. This property is read-only.
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[Role <String>]`: onlineMeetingRole
      - `[Upn <String>]`: User principal name of the participant.
    - `[Contributors <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
    - `[Organizer <IMicrosoftGraphMeetingParticipantInfo>]`: meetingParticipantInfo
    - `[Producers <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[Subject <String>]`: 

`CHATINFO <IMicrosoftGraphChatInfo>`: chatInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MessageId <String>]`: The unique identifier for a message in a Microsoft Teams channel.
  - `[ReplyChainMessageId <String>]`: The ID of the reply message.
  - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.

`PARTICIPANTS <IMicrosoftGraphMeetingParticipants>`: meetingParticipants
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Attendees <IMicrosoftGraphMeetingParticipantInfo[]>]`: Information of the meeting attendees.
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Role <String>]`: onlineMeetingRole
    - `[Upn <String>]`: User principal name of the participant.
  - `[Contributors <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
  - `[Organizer <IMicrosoftGraphMeetingParticipantInfo>]`: meetingParticipantInfo
  - `[Producers <IMicrosoftGraphMeetingParticipantInfo[]>]`: 

## RELATED LINKS


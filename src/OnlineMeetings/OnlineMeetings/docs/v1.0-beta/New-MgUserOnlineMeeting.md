---
external help file:
Module Name: Microsoft.Graph.OnlineMeetings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.onlinemeetings/new-mguseronlinemeeting
schema: 2.0.0
---

# New-MgUserOnlineMeeting

## SYNOPSIS
Create new navigation property to onlineMeetings for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserOnlineMeeting -UserId <String> [-AccessLevel <String>] [-AudioConferencingConferenceId <String>]
 [-AudioConferencingDialinUrl <String>] [-AudioConferencingTollFreeNumber <String>]
 [-AudioConferencingTollNumber <String>] [-CanceledDateTime <DateTime>] [-Capabilities <String[]>]
 [-ChatInfoMessageId <String>] [-ChatInfoReplyChainMessageId <String>] [-ChatInfoThreadId <String>]
 [-CreationDateTime <DateTime>] [-EndDateTime <DateTime>] [-EntryExitAnnouncement]
 [-ExpirationDateTime <DateTime>] [-ExternalId <String>] [-Id <String>] [-IsBroadcast] [-IsCancelled]
 [-JoinInformationContent <String>] [-JoinInformationContentType <String>] [-JoinUrl <String>]
 [-OrganizerIdentity <IMicrosoftGraphIdentitySet>] [-OrganizerUpn <String>]
 [-ParticipantAttendees <IMicrosoftGraphMeetingParticipantInfo[]>]
 [-ParticipantContributors <IMicrosoftGraphMeetingParticipantInfo[]>]
 [-ParticipantProducers <IMicrosoftGraphMeetingParticipantInfo[]>] [-StartDateTime <DateTime>]
 [-Subject <String>] [-VideoTeleconferenceId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserOnlineMeeting -UserId <String> -BodyParameter <IMicrosoftGraphOnlineMeeting> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserOnlineMeeting -InputObject <IOnlineMeetingsIdentity> -BodyParameter <IMicrosoftGraphOnlineMeeting>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserOnlineMeeting -InputObject <IOnlineMeetingsIdentity> [-AccessLevel <String>]
 [-AudioConferencingConferenceId <String>] [-AudioConferencingDialinUrl <String>]
 [-AudioConferencingTollFreeNumber <String>] [-AudioConferencingTollNumber <String>]
 [-CanceledDateTime <DateTime>] [-Capabilities <String[]>] [-ChatInfoMessageId <String>]
 [-ChatInfoReplyChainMessageId <String>] [-ChatInfoThreadId <String>] [-CreationDateTime <DateTime>]
 [-EndDateTime <DateTime>] [-EntryExitAnnouncement] [-ExpirationDateTime <DateTime>] [-ExternalId <String>]
 [-Id <String>] [-IsBroadcast] [-IsCancelled] [-JoinInformationContent <String>]
 [-JoinInformationContentType <String>] [-JoinUrl <String>] [-OrganizerIdentity <IMicrosoftGraphIdentitySet>]
 [-OrganizerUpn <String>] [-ParticipantAttendees <IMicrosoftGraphMeetingParticipantInfo[]>]
 [-ParticipantContributors <IMicrosoftGraphMeetingParticipantInfo[]>]
 [-ParticipantProducers <IMicrosoftGraphMeetingParticipantInfo[]>] [-StartDateTime <DateTime>]
 [-Subject <String>] [-VideoTeleconferenceId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to onlineMeetings for users

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AccessLevel
accessLevel

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AudioConferencingConferenceId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AudioConferencingDialinUrl
A URL to the externally-accessible web page that contains dial-in information.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AudioConferencingTollFreeNumber
The toll-free number that connects to the Audio Conference Provider.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AudioConferencingTollNumber
The toll number that connects to the Audio Conference Provider.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
onlineMeeting
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnlineMeeting
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CanceledDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Capabilities
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChatInfoMessageId
The unique identifier of a message in a Microsoft Teams channel.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChatInfoReplyChainMessageId
The ID of the reply message.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChatInfoThreadId
The unique identifier for a thread in Microsoft Teams.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreationDateTime
The meeting creation time in UTC.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EntryExitAnnouncement
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IOnlineMeetingsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsBroadcast
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsCancelled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JoinInformationContent
The content of the item.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JoinInformationContentType
bodyType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JoinUrl
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrganizerIdentity
identitySet
To construct, see NOTES section for ORGANIZERIDENTITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrganizerUpn
User principal name of the participant.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParticipantAttendees
.
To construct, see NOTES section for PARTICIPANTATTENDEES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMeetingParticipantInfo[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParticipantContributors
.
To construct, see NOTES section for PARTICIPANTCONTRIBUTORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMeetingParticipantInfo[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParticipantProducers
.
To construct, see NOTES section for PARTICIPANTPRODUCERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMeetingParticipantInfo[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
The subject of the online meeting.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VideoTeleconferenceId
The video teleconferencing ID.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnlineMeeting

### Microsoft.Graph.PowerShell.Models.IOnlineMeetingsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnlineMeeting

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOnlineMeeting>: onlineMeeting
  - `[Id <String>]`: Read-only.
  - `[AccessLevel <String>]`: accessLevel
  - `[AudioConferencingConferenceId <String>]`: 
  - `[AudioConferencingDialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
  - `[AudioConferencingTollFreeNumber <String>]`: The toll-free number that connects to the Audio Conference Provider.
  - `[AudioConferencingTollNumber <String>]`: The toll number that connects to the Audio Conference Provider.
  - `[CanceledDateTime <DateTime?>]`: 
  - `[Capabilities <String[]>]`: 
  - `[ChatInfoMessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
  - `[ChatInfoReplyChainMessageId <String>]`: The ID of the reply message.
  - `[ChatInfoThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[CreationDateTime <DateTime?>]`: The meeting creation time in UTC. Read-only.
  - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
  - `[EntryExitAnnouncement <Boolean?>]`: 
  - `[ExpirationDateTime <DateTime?>]`: 
  - `[ExternalId <String>]`: 
  - `[IsBroadcast <Boolean?>]`: 
  - `[IsCancelled <Boolean?>]`: 
  - `[JoinInformationContent <String>]`: The content of the item.
  - `[JoinInformationContentType <String>]`: bodyType
  - `[JoinUrl <String>]`: 
  - `[OrganizerIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[OrganizerUpn <String>]`: User principal name of the participant.
  - `[ParticipantAttendees <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Upn <String>]`: User principal name of the participant.
  - `[ParticipantContributors <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
  - `[ParticipantProducers <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
  - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
  - `[Subject <String>]`: The subject of the online meeting.
  - `[VideoTeleconferenceId <String>]`: The video teleconferencing ID. Read-only.

INPUTOBJECT <IOnlineMeetingsIdentity>: Identity Parameter
  - `[OnlineMeetingId <String>]`: key: onlineMeeting-id of onlineMeeting
  - `[UserId <String>]`: key: user-id of user

ORGANIZERIDENTITY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

PARTICIPANTATTENDEES <IMicrosoftGraphMeetingParticipantInfo[]>: .
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Upn <String>]`: User principal name of the participant.

PARTICIPANTCONTRIBUTORS <IMicrosoftGraphMeetingParticipantInfo[]>: .
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Upn <String>]`: User principal name of the participant.

PARTICIPANTPRODUCERS <IMicrosoftGraphMeetingParticipantInfo[]>: .
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Upn <String>]`: User principal name of the participant.

## RELATED LINKS


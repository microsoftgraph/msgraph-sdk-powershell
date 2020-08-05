---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/invoke-mgredirectcommunicationcall
schema: 2.0.0
---

# Invoke-MgRedirectCommunicationCall

## SYNOPSIS
Invoke action redirect

## SYNTAX

### RedirectExpanded1 (Default)
```
Invoke-MgRedirectCommunicationCall -CallId <String> [-CallbackUri <String>]
 [-Targets <IMicrosoftGraphInvitationParticipantInfo1[]>] [-Timeout <Int32>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Redirect1
```
Invoke-MgRedirectCommunicationCall -CallId <String>
 -BodyParameter <IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RedirectViaIdentity1
```
Invoke-MgRedirectCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RedirectViaIdentityExpanded1
```
Invoke-MgRedirectCommunicationCall -InputObject <ICloudCommunicationsIdentity> [-CallbackUri <String>]
 [-Targets <IMicrosoftGraphInvitationParticipantInfo1[]>] [-Timeout <Int32>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action redirect

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

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema1
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
key: call-id of call

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: RedirectViaIdentity1, RedirectViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Targets
.
To construct, see NOTES section for TARGETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo1[]
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

### Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths183Gi8UCommunicationsCallsCallIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema1>: .
  - `[CallbackUri <String>]`: 
  - `[Targets <IMicrosoftGraphInvitationParticipantInfo1[]>]`: 
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. This call will be dropped once the participant is added.
  - `[Timeout <Int32?>]`: 

INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AudioRoutingGroupId <String>]`: key: audioRoutingGroup-id of audioRoutingGroup
  - `[CallId <String>]`: key: call-id of call
  - `[CallRecordId <String>]`: key: callRecord-id of callRecord
  - `[CommsOperationId <String>]`: key: commsOperation-id of commsOperation
  - `[OnlineMeetingId <String>]`: key: onlineMeeting-id of onlineMeeting
  - `[ParticipantId <String>]`: key: participant-id of participant
  - `[SegmentId <String>]`: key: segment-id of segment
  - `[SessionId <String>]`: key: session-id of session

TARGETS <IMicrosoftGraphInvitationParticipantInfo1[]>: .
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. This call will be dropped once the participant is added.

## RELATED LINKS


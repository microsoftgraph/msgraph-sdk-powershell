---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/invoke-mgmutecommunicationcall
schema: 2.0.0
---

# Invoke-MgMuteCommunicationCall

## SYNOPSIS
Invoke action mute

## SYNTAX

### MuteExpanded1 (Default)
```
Invoke-MgMuteCommunicationCall -CallId <String> [-ClientContext <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Mute1
```
Invoke-MgMuteCommunicationCall -CallId <String>
 -BodyParameter <IPaths13Zt223CommunicationsCallsCallIdMicrosoftGraphMutePostRequestbodyContentApplicationJsonSchema1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### MuteViaIdentity1
```
Invoke-MgMuteCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths13Zt223CommunicationsCallsCallIdMicrosoftGraphMutePostRequestbodyContentApplicationJsonSchema1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### MuteViaIdentityExpanded1
```
Invoke-MgMuteCommunicationCall -InputObject <ICloudCommunicationsIdentity> [-ClientContext <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action mute

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
Type: Microsoft.Graph.PowerShell.Models.IPaths13Zt223CommunicationsCallsCallIdMicrosoftGraphMutePostRequestbodyContentApplicationJsonSchema1
Parameter Sets: Mute1, MuteViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CallId
key: call-id of call

```yaml
Type: System.String
Parameter Sets: Mute1, MuteExpanded1
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
Parameter Sets: MuteExpanded1, MuteViaIdentityExpanded1
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
Parameter Sets: MuteViaIdentity1, MuteViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPaths13Zt223CommunicationsCallsCallIdMicrosoftGraphMutePostRequestbodyContentApplicationJsonSchema1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMuteParticipantOperation1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths13Zt223CommunicationsCallsCallIdMicrosoftGraphMutePostRequestbodyContentApplicationJsonSchema1>: .
  - `[ClientContext <String>]`: 

INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AudioRoutingGroupId <String>]`: key: audioRoutingGroup-id of audioRoutingGroup
  - `[CallId <String>]`: key: call-id of call
  - `[CallRecordId <String>]`: key: callRecord-id of callRecord
  - `[CommsOperationId <String>]`: key: commsOperation-id of commsOperation
  - `[OnlineMeetingId <String>]`: key: onlineMeeting-id of onlineMeeting
  - `[ParticipantId <String>]`: key: participant-id of participant
  - `[SegmentId <String>]`: key: segment-id of segment
  - `[SessionId <String>]`: key: session-id of session

## RELATED LINKS


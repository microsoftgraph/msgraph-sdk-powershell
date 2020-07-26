---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/invoke-mglogcommunicationcallteleconferencedevicequality
schema: 2.0.0
---

# Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality

## SYNOPSIS
Invoke action logTeleconferenceDeviceQuality

## SYNTAX

### LogExpanded (Default)
```
Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality [-QualityCallChainId <String>]
 [-QualityCloudServiceDeploymentEnvironment <String>] [-QualityCloudServiceDeploymentId <String>]
 [-QualityCloudServiceInstanceName <String>] [-QualityCloudServiceName <String>]
 [-QualityDeviceDescription <String>] [-QualityDeviceName <String>] [-QualityMediaLegId <String>]
 [-QualityMediaQualityList <IMicrosoftGraphTeleconferenceDeviceMediaQuality[]>]
 [-QualityParticipantId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Log
```
Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality
 -BodyParameter <IPaths1JbdsmaCommunicationsCallsMicrosoftGraphLogteleconferencedevicequalityPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action logTeleconferenceDeviceQuality

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
Type: Microsoft.Graph.PowerShell.Models.IPaths1JbdsmaCommunicationsCallsMicrosoftGraphLogteleconferencedevicequalityPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Log
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

### -QualityCallChainId
A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in P2P call.
This needs to be copied over from Microsoft.Graph.Call.CallChainId.

```yaml
Type: System.String
Parameter Sets: LogExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QualityCloudServiceDeploymentEnvironment
A geo-region where the service is deployed, such as ProdNoam.

```yaml
Type: System.String
Parameter Sets: LogExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QualityCloudServiceDeploymentId
A unique deployment identifier assigned by Azure.

```yaml
Type: System.String
Parameter Sets: LogExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QualityCloudServiceInstanceName
The Azure deployed cloud service instance name, such as FrontEnd_IN_3.

```yaml
Type: System.String
Parameter Sets: LogExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QualityCloudServiceName
The Azure deployed cloud service name, such as contoso.cloudapp.net.

```yaml
Type: System.String
Parameter Sets: LogExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QualityDeviceDescription
Any additional description, such as VTC Bldg 30/21.

```yaml
Type: System.String
Parameter Sets: LogExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QualityDeviceName
The user media agent name, such as Cisco SX80.

```yaml
Type: System.String
Parameter Sets: LogExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QualityMediaLegId
A unique identifier for a specific media leg of a participant in a conference.
One participant can have multiple media leg identifiers if retargeting happens.
CVI partner assigns this value.

```yaml
Type: System.String
Parameter Sets: LogExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QualityMediaQualityList
The list of media qualities in a media session (call), such as audio quality, video quality, and/or screen sharing quality.
To construct, see NOTES section for QUALITYMEDIAQUALITYLIST properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeleconferenceDeviceMediaQuality[]
Parameter Sets: LogExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QualityParticipantId
A unique identifier for a specific participant in a conference.
The CVI partner needs to copy over Call.MyParticipantId to this property.

```yaml
Type: System.String
Parameter Sets: LogExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1JbdsmaCommunicationsCallsMicrosoftGraphLogteleconferencedevicequalityPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1JbdsmaCommunicationsCallsMicrosoftGraphLogteleconferencedevicequalityPostRequestbodyContentApplicationJsonSchema>: .
  - `[QualityCallChainId <String>]`: A unique identifier for all  the participant calls in a conference or a unique identifier for two participant calls in P2P call. This needs to be copied over from Microsoft.Graph.Call.CallChainId.
  - `[QualityCloudServiceDeploymentEnvironment <String>]`: A geo-region where the service is deployed, such as ProdNoam.
  - `[QualityCloudServiceDeploymentId <String>]`: A unique deployment identifier assigned by Azure.
  - `[QualityCloudServiceInstanceName <String>]`: The Azure deployed cloud service instance name, such as FrontEnd_IN_3.
  - `[QualityCloudServiceName <String>]`: The Azure deployed cloud service name, such as contoso.cloudapp.net.
  - `[QualityDeviceDescription <String>]`: Any additional description, such as VTC Bldg 30/21.
  - `[QualityDeviceName <String>]`: The user media agent name, such as Cisco SX80.
  - `[QualityMediaLegId <String>]`: A unique identifier for a specific media leg of a participant in a conference.  One participant can have multiple media leg identifiers if retargeting happens. CVI partner assigns this value.
  - `[QualityMediaQualityList <IMicrosoftGraphTeleconferenceDeviceMediaQuality[]>]`: The list of media qualities in a media session (call), such as audio quality, video quality, and/or screen sharing quality.
    - `[AverageInboundJitter <TimeSpan?>]`: The average inbound stream network jitter.
    - `[AverageInboundPacketLossRateInPercentage <Double?>]`: The average inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
    - `[AverageInboundRoundTripDelay <TimeSpan?>]`: The average inbound stream network round trip delay.
    - `[AverageOutboundJitter <TimeSpan?>]`: The average outbound stream network jitter.
    - `[AverageOutboundPacketLossRateInPercentage <Double?>]`: The average outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
    - `[AverageOutboundRoundTripDelay <TimeSpan?>]`: The average outbound stream network round trip delay.
    - `[ChannelIndex <Int32?>]`: The channel index of media. Indexing begins with 1.  If a media session contains 3 video modalities, channel indexes will be 1, 2, and 3.
    - `[InboundPackets <Int64?>]`: The total number of the inbound packets.
    - `[LocalIPAddress <String>]`: the local IP address for the media session.
    - `[LocalPort <Int32?>]`: The local media port.
    - `[MaximumInboundJitter <TimeSpan?>]`: The maximum inbound stream network jitter.
    - `[MaximumInboundPacketLossRateInPercentage <Double?>]`: The maximum inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
    - `[MaximumInboundRoundTripDelay <TimeSpan?>]`: The maximum inbound stream network round trip delay.
    - `[MaximumOutboundJitter <TimeSpan?>]`: The maximum outbound stream network jitter.
    - `[MaximumOutboundPacketLossRateInPercentage <Double?>]`: The maximum outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
    - `[MaximumOutboundRoundTripDelay <TimeSpan?>]`: The maximum outbound stream network round trip delay.
    - `[MediaDuration <TimeSpan?>]`: The total modality duration. If the media enabled and disabled multiple times, MediaDuration will the summation of all of the durations.
    - `[NetworkLinkSpeedInBytes <Int64?>]`: The network link speed in bytes
    - `[OutboundPackets <Int64?>]`: The total number of the outbound packets.
    - `[RemoteIPAddress <String>]`: The remote IP address for the media session.
    - `[RemotePort <Int32?>]`: The remote media port.
  - `[QualityParticipantId <String>]`: A unique identifier for a specific participant in a conference. The CVI partner needs to copy over Call.MyParticipantId to this property.

QUALITYMEDIAQUALITYLIST <IMicrosoftGraphTeleconferenceDeviceMediaQuality[]>: The list of media qualities in a media session (call), such as audio quality, video quality, and/or screen sharing quality.
  - `[AverageInboundJitter <TimeSpan?>]`: The average inbound stream network jitter.
  - `[AverageInboundPacketLossRateInPercentage <Double?>]`: The average inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
  - `[AverageInboundRoundTripDelay <TimeSpan?>]`: The average inbound stream network round trip delay.
  - `[AverageOutboundJitter <TimeSpan?>]`: The average outbound stream network jitter.
  - `[AverageOutboundPacketLossRateInPercentage <Double?>]`: The average outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
  - `[AverageOutboundRoundTripDelay <TimeSpan?>]`: The average outbound stream network round trip delay.
  - `[ChannelIndex <Int32?>]`: The channel index of media. Indexing begins with 1.  If a media session contains 3 video modalities, channel indexes will be 1, 2, and 3.
  - `[InboundPackets <Int64?>]`: The total number of the inbound packets.
  - `[LocalIPAddress <String>]`: the local IP address for the media session.
  - `[LocalPort <Int32?>]`: The local media port.
  - `[MaximumInboundJitter <TimeSpan?>]`: The maximum inbound stream network jitter.
  - `[MaximumInboundPacketLossRateInPercentage <Double?>]`: The maximum inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
  - `[MaximumInboundRoundTripDelay <TimeSpan?>]`: The maximum inbound stream network round trip delay.
  - `[MaximumOutboundJitter <TimeSpan?>]`: The maximum outbound stream network jitter.
  - `[MaximumOutboundPacketLossRateInPercentage <Double?>]`: The maximum outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
  - `[MaximumOutboundRoundTripDelay <TimeSpan?>]`: The maximum outbound stream network round trip delay.
  - `[MediaDuration <TimeSpan?>]`: The total modality duration. If the media enabled and disabled multiple times, MediaDuration will the summation of all of the durations.
  - `[NetworkLinkSpeedInBytes <Int64?>]`: The network link speed in bytes
  - `[OutboundPackets <Int64?>]`: The total number of the outbound packets.
  - `[RemoteIPAddress <String>]`: The remote IP address for the media session.
  - `[RemotePort <Int32?>]`: The remote media port.

## RELATED LINKS


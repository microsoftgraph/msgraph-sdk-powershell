---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.cloudcommunications/invoke-mglogcommunicationcallteleconferencedevicequality
schema: 2.0.0
---

# Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality

## SYNOPSIS
Log video teleconferencing device quality data.
The Cloud Video Interop (CVI) bot represents video teleconferencing (VTC) devices and acts as a back-to-back agent for a VTC device in a conference call.
Because a CVI bot is in the middle of the VTC and Microsoft Teams infrastructure as a VTC proxy, it has two media legs.
One media leg is between the CVI bot and Teams infrastructure, such as Teams conference server or a Teams client.
The other media leg is between the CVI bot and the VTC device.
The third-party partners own the VTC media leg and the Teams infrastructure cannot access the quality data of the third-party call leg.
This method is only for the CVI partners to provide their media quality data.

## SYNTAX

### LogExpanded (Default)
```
Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality [-AdditionalProperties <Hashtable>]
 [-Quality <IMicrosoftGraphTeleconferenceDeviceQuality>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Log
```
Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality
 -Body <IPaths1JbdsmaCommunicationsCallsMicrosoftGraphLogteleconferencedevicequalityPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Log video teleconferencing device quality data.
The Cloud Video Interop (CVI) bot represents video teleconferencing (VTC) devices and acts as a back-to-back agent for a VTC device in a conference call.
Because a CVI bot is in the middle of the VTC and Microsoft Teams infrastructure as a VTC proxy, it has two media legs.
One media leg is between the CVI bot and Teams infrastructure, such as Teams conference server or a Teams client.
The other media leg is between the CVI bot and the VTC device.
The third-party partners own the VTC media leg and the Teams infrastructure cannot access the quality data of the third-party call leg.
This method is only for the CVI partners to provide their media quality data.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Quality = @{
		"@odata.type" = "#microsoft.graph.teleconferenceDeviceQuality"
		CallChainId = "0622673d-9f69-49b3-9d4f-5ec64f42ecce"
		ParticipantId = "ea078406-b5d4-4d3c-b85e-90103dcec7f6"
		MediaLegId = "bd9ee398-4b9d-42c7-8b8d-4e8efad9435f"
		DeviceName = "TestAgent"
		DeviceDescription = "TestDescription"
		MediaQualityList = @(
			@{
				"@odata.type" = "#microsoft.graph.teleconferenceDeviceAudioQuality"
				ChannelIndex = 1
				MediaDuration = "PT20M"
				NetworkLinkSpeedInBytes = 13000
				LocalIPAddress = "127.0.0.1"
				LocalPort = 6300
				RemoteIPAddress = "102.1.1.101"
				RemotePort = 6301
				InboundPackets = 5500
				OutboundPackets = 5400
				AverageInboundPacketLossRateInPercentage = 0.01
				AverageOutboundPacketLossRateInPercentage = 0.02
				MaximumInboundPacketLossRateInPercentage = 0.05
				MaximumOutboundPacketLossRateInPercentage = 0.06
				AverageInboundRoundTripDelay = "PT0.03S"
				AverageOutboundRoundTripDelay = "PT0.04S"
				MaximumInboundRoundTripDelay = "PT0.13S"
				MaximumOutboundRoundTripDelay = "PT0.14S"
				AverageInboundJitter = "PT0.01S"
				AverageOutboundJitter = "PT0.015S"
				MaximumInboundJitter = "PT0.023S"
				MaximumOutboundJitter = "PT0.024S"
			}
			@{
				"@odata.type" = "#microsoft.graph.teleconferenceDeviceVideoQuality"
				ChannelIndex = 1
				MediaDuration = "PT20M"
				NetworkLinkSpeedInBytes = 13000
				LocalIPAddress = "127.0.0.1"
				LocalPort = 6300
				RemoteIPAddress = "102.1.1.101"
				RemotePort = 6301
				InboundPackets = 5500
				OutboundPackets = 5400
				AverageInboundPacketLossRateInPercentage = 0.01
				AverageOutboundPacketLossRateInPercentage = 0.02
				MaximumInboundPacketLossRateInPercentage = 0.05
				MaximumOutboundPacketLossRateInPercentage = 0.06
				AverageInboundRoundTripDelay = "PT0.03S"
				AverageOutboundRoundTripDelay = "PT0.04S"
				MaximumInboundRoundTripDelay = "PT0.13S"
				MaximumOutboundRoundTripDelay = "PT0.14S"
				AverageInboundJitter = "PT0.01S"
				AverageOutboundJitter = "PT0.015S"
				MaximumInboundJitter = "PT0.023S"
				MaximumOutboundJitter = "PT0.024S"
			}
			@{
				"@odata.type" = "#microsoft.graph.teleconferenceDeviceScreenSharingQuality"
				ChannelIndex = 1
				MediaDuration = "PT20M"
				NetworkLinkSpeedInBytes = 13000
				LocalIPAddress = "127.0.0.1"
				LocalPort = 6300
				RemoteIPAddress = "102.1.1.101"
				RemotePort = 6301
				InboundPackets = 5500
				OutboundPackets = 5400
				AverageInboundPacketLossRateInPercentage = 0.01
				AverageOutboundPacketLossRateInPercentage = 0.02
				MaximumInboundPacketLossRateInPercentage = 0.05
				MaximumOutboundPacketLossRateInPercentage = 0.06
				AverageInboundRoundTripDelay = "PT0.03S"
				AverageOutboundRoundTripDelay = "PT0.04S"
				MaximumInboundRoundTripDelay = "PT0.13S"
				MaximumOutboundRoundTripDelay = "PT0.14S"
				AverageInboundJitter = "PT0.01S"
				AverageOutboundJitter = "PT0.015S"
				MaximumInboundJitter = "PT0.023S"
				MaximumOutboundJitter = "PT0.024S"
			}
		)
	}
}
Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality -BodyParameter $params
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: LogExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

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

### -Quality
teleconferenceDeviceQuality
To construct, see NOTES section for QUALITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeleconferenceDeviceQuality
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


`BODY <IPaths1JbdsmaCommunicationsCallsMicrosoftGraphLogteleconferencedevicequalityPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Quality <IMicrosoftGraphTeleconferenceDeviceQuality>]`: teleconferenceDeviceQuality
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CallChainId <String>]`: A unique identifier for all  the participant calls in a conference or a unique identifier for two participant calls in P2P call. This needs to be copied over from Microsoft.Graph.Call.CallChainId.
    - `[CloudServiceDeploymentEnvironment <String>]`: A geo-region where the service is deployed, such as ProdNoam.
    - `[CloudServiceDeploymentId <String>]`: A unique deployment identifier assigned by Azure.
    - `[CloudServiceInstanceName <String>]`: The Azure deployed cloud service instance name, such as FrontEndIN3.
    - `[CloudServiceName <String>]`: The Azure deployed cloud service name, such as contoso.cloudapp.net.
    - `[DeviceDescription <String>]`: Any additional description, such as VTC Bldg 30/21.
    - `[DeviceName <String>]`: The user media agent name, such as Cisco SX80.
    - `[MediaLegId <String>]`: A unique identifier for a specific media leg of a participant in a conference.  One participant can have multiple media leg identifiers if retargeting happens. CVI partner assigns this value.
    - `[MediaQualityList <IMicrosoftGraphTeleconferenceDeviceMediaQuality[]>]`: The list of media qualities in a media session (call), such as audio quality, video quality, and/or screen sharing quality.
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
    - `[ParticipantId <String>]`: A unique identifier for a specific participant in a conference. The CVI partner needs to copy over Call.MyParticipantId to this property.

`QUALITY <IMicrosoftGraphTeleconferenceDeviceQuality>`: teleconferenceDeviceQuality
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CallChainId <String>]`: A unique identifier for all  the participant calls in a conference or a unique identifier for two participant calls in P2P call. This needs to be copied over from Microsoft.Graph.Call.CallChainId.
  - `[CloudServiceDeploymentEnvironment <String>]`: A geo-region where the service is deployed, such as ProdNoam.
  - `[CloudServiceDeploymentId <String>]`: A unique deployment identifier assigned by Azure.
  - `[CloudServiceInstanceName <String>]`: The Azure deployed cloud service instance name, such as FrontEndIN3.
  - `[CloudServiceName <String>]`: The Azure deployed cloud service name, such as contoso.cloudapp.net.
  - `[DeviceDescription <String>]`: Any additional description, such as VTC Bldg 30/21.
  - `[DeviceName <String>]`: The user media agent name, such as Cisco SX80.
  - `[MediaLegId <String>]`: A unique identifier for a specific media leg of a participant in a conference.  One participant can have multiple media leg identifiers if retargeting happens. CVI partner assigns this value.
  - `[MediaQualityList <IMicrosoftGraphTeleconferenceDeviceMediaQuality[]>]`: The list of media qualities in a media session (call), such as audio quality, video quality, and/or screen sharing quality.
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
  - `[ParticipantId <String>]`: A unique identifier for a specific participant in a conference. The CVI partner needs to copy over Call.MyParticipantId to this property.

## RELATED LINKS


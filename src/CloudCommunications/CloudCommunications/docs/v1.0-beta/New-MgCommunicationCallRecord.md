---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/new-mgcommunicationcallrecord
schema: 2.0.0
---

# New-MgCommunicationCallRecord

## SYNOPSIS
Create new navigation property to callRecords for communications

## SYNTAX

### CreateExpanded (Default)
```
New-MgCommunicationCallRecord [-EndDateTime <DateTime>] [-Id <String>] [-JoinWebUrl <String>]
 [-LastModifiedDateTime <DateTime>] [-Modalities <String[]>] [-Organizer <IMicrosoftGraphIdentitySet>]
 [-Participants <IMicrosoftGraphIdentitySet[]>] [-Sessions <IMicrosoftGraphCallRecordsSession[]>]
 [-StartDateTime <DateTime>] [-Type <String>] [-Version <Int64>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgCommunicationCallRecord -BodyParameter <IMicrosoftGraphCallRecordsCallRecord> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to callRecords for communications

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
callRecord
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsCallRecord
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EndDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JoinWebUrl
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Modalities
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Organizer
identitySet
To construct, see NOTES section for ORGANIZER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Participants
.
To construct, see NOTES section for PARTICIPANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sessions
.
To construct, see NOTES section for SESSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsSession[]
Parameter Sets: CreateExpanded
Aliases:

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
callType

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsCallRecord

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsCallRecord

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCallRecordsCallRecord>: callRecord
  - `[Id <String>]`: Read-only.
  - `[EndDateTime <DateTime?>]`: 
  - `[JoinWebUrl <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Modalities <String[]>]`: 
  - `[Organizer <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Participants <IMicrosoftGraphIdentitySet[]>]`: 
  - `[Sessions <IMicrosoftGraphCallRecordsSession[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CalleeUserAgentApplicationVersion <String>]`: 
    - `[CalleeUserAgentHeaderValue <String>]`: 
    - `[CallerUserAgentApplicationVersion <String>]`: 
    - `[CallerUserAgentHeaderValue <String>]`: 
    - `[EndDateTime <DateTime?>]`: 
    - `[FailureInfoReason <String>]`: 
    - `[FailureInfoStage <String>]`: failureStage
    - `[Modalities <String[]>]`: 
    - `[Segments <IMicrosoftGraphCallRecordsSegment[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[CalleeUserAgentApplicationVersion <String>]`: 
      - `[CalleeUserAgentHeaderValue <String>]`: 
      - `[CallerUserAgentApplicationVersion <String>]`: 
      - `[CallerUserAgentHeaderValue <String>]`: 
      - `[EndDateTime <DateTime?>]`: 
      - `[FailureInfoReason <String>]`: 
      - `[FailureInfoStage <String>]`: failureStage
      - `[Media <IMicrosoftGraphCallRecordsMedia[]>]`: 
        - `[CalleeDeviceCaptureDeviceDriver <String>]`: 
        - `[CalleeDeviceCaptureDeviceName <String>]`: 
        - `[CalleeDeviceCaptureNotFunctioningEventRatio <Single?>]`: 
        - `[CalleeDeviceClippingEventRatio <Single?>]`: 
        - `[CalleeDeviceCpuInsufficentEventRatio <Single?>]`: 
        - `[CalleeDeviceGlitchEventRatio <Single?>]`: 
        - `[CalleeDeviceHowlingEventCount <Int32?>]`: 
        - `[CalleeDeviceInitialSignalLevelRootMeanSquare <Single?>]`: 
        - `[CalleeDeviceLowSpeechLevelEventRatio <Single?>]`: 
        - `[CalleeDeviceLowSpeechToNoiseEventRatio <Single?>]`: 
        - `[CalleeDeviceMicGlitchRate <Single?>]`: 
        - `[CalleeDeviceReceivedNoiseLevel <Int32?>]`: 
        - `[CalleeDeviceReceivedSignalLevel <Int32?>]`: 
        - `[CalleeDeviceRenderDeviceDriver <String>]`: 
        - `[CalleeDeviceRenderDeviceName <String>]`: 
        - `[CalleeDeviceRenderMuteEventRatio <Single?>]`: 
        - `[CalleeDeviceRenderNotFunctioningEventRatio <Single?>]`: 
        - `[CalleeDeviceRenderZeroVolumeEventRatio <Single?>]`: 
        - `[CalleeDeviceSentNoiseLevel <Int32?>]`: 
        - `[CalleeDeviceSentSignalLevel <Int32?>]`: 
        - `[CalleeDeviceSpeakerGlitchRate <Single?>]`: 
        - `[CalleeNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
          - `[BandwidthLowEventRatio <Single?>]`: 
          - `[BasicServiceSetIdentifier <String>]`: 
          - `[ConnectionType <String>]`: networkConnectionType
          - `[DelayEventRatio <Single?>]`: 
          - `[DnsSuffix <String>]`: 
          - `[IPAddress <String>]`: 
          - `[LinkSpeed <Int64?>]`: 
          - `[MacAddress <String>]`: 
          - `[Port <Int32?>]`: 
          - `[ReceivedQualityEventRatio <Single?>]`: 
          - `[ReflexiveIPAddress <String>]`: 
          - `[RelayIPAddress <String>]`: 
          - `[RelayPort <Int32?>]`: 
          - `[SentQualityEventRatio <Single?>]`: 
          - `[Subnet <String>]`: 
          - `[WifiBand <String>]`: wifiBand
          - `[WifiBatteryCharge <Int32?>]`: 
          - `[WifiChannel <Int32?>]`: 
          - `[WifiMicrosoftDriver <String>]`: 
          - `[WifiMicrosoftDriverVersion <String>]`: 
          - `[WifiRadioType <String>]`: wifiRadioType
          - `[WifiSignalStrength <Int32?>]`: 
          - `[WifiVendorDriver <String>]`: 
          - `[WifiVendorDriverVersion <String>]`: 
        - `[CallerDeviceCaptureDeviceDriver <String>]`: 
        - `[CallerDeviceCaptureDeviceName <String>]`: 
        - `[CallerDeviceCaptureNotFunctioningEventRatio <Single?>]`: 
        - `[CallerDeviceClippingEventRatio <Single?>]`: 
        - `[CallerDeviceCpuInsufficentEventRatio <Single?>]`: 
        - `[CallerDeviceGlitchEventRatio <Single?>]`: 
        - `[CallerDeviceHowlingEventCount <Int32?>]`: 
        - `[CallerDeviceInitialSignalLevelRootMeanSquare <Single?>]`: 
        - `[CallerDeviceLowSpeechLevelEventRatio <Single?>]`: 
        - `[CallerDeviceLowSpeechToNoiseEventRatio <Single?>]`: 
        - `[CallerDeviceMicGlitchRate <Single?>]`: 
        - `[CallerDeviceReceivedNoiseLevel <Int32?>]`: 
        - `[CallerDeviceReceivedSignalLevel <Int32?>]`: 
        - `[CallerDeviceRenderDeviceDriver <String>]`: 
        - `[CallerDeviceRenderDeviceName <String>]`: 
        - `[CallerDeviceRenderMuteEventRatio <Single?>]`: 
        - `[CallerDeviceRenderNotFunctioningEventRatio <Single?>]`: 
        - `[CallerDeviceRenderZeroVolumeEventRatio <Single?>]`: 
        - `[CallerDeviceSentNoiseLevel <Int32?>]`: 
        - `[CallerDeviceSentSignalLevel <Int32?>]`: 
        - `[CallerDeviceSpeakerGlitchRate <Single?>]`: 
        - `[CallerNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
        - `[Label <String>]`: 
        - `[Streams <IMicrosoftGraphCallRecordsMediaStream[]>]`: 
          - `[AverageAudioDegradation <Single?>]`: 
          - `[AverageAudioNetworkJitter <TimeSpan?>]`: 
          - `[AverageBandwidthEstimate <Int64?>]`: 
          - `[AverageJitter <TimeSpan?>]`: 
          - `[AveragePacketLossRate <Single?>]`: 
          - `[AverageRatioOfConcealedSamples <Single?>]`: 
          - `[AverageReceivedFrameRate <Single?>]`: 
          - `[AverageRoundTripTime <TimeSpan?>]`: 
          - `[AverageVideoFrameLossPercentage <Single?>]`: 
          - `[AverageVideoFrameRate <Single?>]`: 
          - `[AverageVideoPacketLossRate <Single?>]`: 
          - `[EndDateTime <DateTime?>]`: 
          - `[LowFrameRateRatio <Single?>]`: 
          - `[LowVideoProcessingCapabilityRatio <Single?>]`: 
          - `[MaxAudioNetworkJitter <TimeSpan?>]`: 
          - `[MaxJitter <TimeSpan?>]`: 
          - `[MaxPacketLossRate <Single?>]`: 
          - `[MaxRatioOfConcealedSamples <Single?>]`: 
          - `[MaxRoundTripTime <TimeSpan?>]`: 
          - `[PacketUtilization <Int64?>]`: 
          - `[PostForwardErrorCorrectionPacketLossRate <Single?>]`: 
          - `[StartDateTime <DateTime?>]`: 
          - `[StreamDirection <String>]`: mediaStreamDirection
          - `[StreamId <String>]`: 
          - `[WasMediaBypassed <Boolean?>]`: 
      - `[StartDateTime <DateTime?>]`: 
    - `[StartDateTime <DateTime?>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[Type <String>]`: callType
  - `[Version <Int64?>]`: 

ORGANIZER <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

PARTICIPANTS <IMicrosoftGraphIdentitySet[]>: .
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

SESSIONS <IMicrosoftGraphCallRecordsSession[]>: .
  - `[Id <String>]`: Read-only.
  - `[CalleeUserAgentApplicationVersion <String>]`: 
  - `[CalleeUserAgentHeaderValue <String>]`: 
  - `[CallerUserAgentApplicationVersion <String>]`: 
  - `[CallerUserAgentHeaderValue <String>]`: 
  - `[EndDateTime <DateTime?>]`: 
  - `[FailureInfoReason <String>]`: 
  - `[FailureInfoStage <String>]`: failureStage
  - `[Modalities <String[]>]`: 
  - `[Segments <IMicrosoftGraphCallRecordsSegment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CalleeUserAgentApplicationVersion <String>]`: 
    - `[CalleeUserAgentHeaderValue <String>]`: 
    - `[CallerUserAgentApplicationVersion <String>]`: 
    - `[CallerUserAgentHeaderValue <String>]`: 
    - `[EndDateTime <DateTime?>]`: 
    - `[FailureInfoReason <String>]`: 
    - `[FailureInfoStage <String>]`: failureStage
    - `[Media <IMicrosoftGraphCallRecordsMedia[]>]`: 
      - `[CalleeDeviceCaptureDeviceDriver <String>]`: 
      - `[CalleeDeviceCaptureDeviceName <String>]`: 
      - `[CalleeDeviceCaptureNotFunctioningEventRatio <Single?>]`: 
      - `[CalleeDeviceClippingEventRatio <Single?>]`: 
      - `[CalleeDeviceCpuInsufficentEventRatio <Single?>]`: 
      - `[CalleeDeviceGlitchEventRatio <Single?>]`: 
      - `[CalleeDeviceHowlingEventCount <Int32?>]`: 
      - `[CalleeDeviceInitialSignalLevelRootMeanSquare <Single?>]`: 
      - `[CalleeDeviceLowSpeechLevelEventRatio <Single?>]`: 
      - `[CalleeDeviceLowSpeechToNoiseEventRatio <Single?>]`: 
      - `[CalleeDeviceMicGlitchRate <Single?>]`: 
      - `[CalleeDeviceReceivedNoiseLevel <Int32?>]`: 
      - `[CalleeDeviceReceivedSignalLevel <Int32?>]`: 
      - `[CalleeDeviceRenderDeviceDriver <String>]`: 
      - `[CalleeDeviceRenderDeviceName <String>]`: 
      - `[CalleeDeviceRenderMuteEventRatio <Single?>]`: 
      - `[CalleeDeviceRenderNotFunctioningEventRatio <Single?>]`: 
      - `[CalleeDeviceRenderZeroVolumeEventRatio <Single?>]`: 
      - `[CalleeDeviceSentNoiseLevel <Int32?>]`: 
      - `[CalleeDeviceSentSignalLevel <Int32?>]`: 
      - `[CalleeDeviceSpeakerGlitchRate <Single?>]`: 
      - `[CalleeNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
        - `[BandwidthLowEventRatio <Single?>]`: 
        - `[BasicServiceSetIdentifier <String>]`: 
        - `[ConnectionType <String>]`: networkConnectionType
        - `[DelayEventRatio <Single?>]`: 
        - `[DnsSuffix <String>]`: 
        - `[IPAddress <String>]`: 
        - `[LinkSpeed <Int64?>]`: 
        - `[MacAddress <String>]`: 
        - `[Port <Int32?>]`: 
        - `[ReceivedQualityEventRatio <Single?>]`: 
        - `[ReflexiveIPAddress <String>]`: 
        - `[RelayIPAddress <String>]`: 
        - `[RelayPort <Int32?>]`: 
        - `[SentQualityEventRatio <Single?>]`: 
        - `[Subnet <String>]`: 
        - `[WifiBand <String>]`: wifiBand
        - `[WifiBatteryCharge <Int32?>]`: 
        - `[WifiChannel <Int32?>]`: 
        - `[WifiMicrosoftDriver <String>]`: 
        - `[WifiMicrosoftDriverVersion <String>]`: 
        - `[WifiRadioType <String>]`: wifiRadioType
        - `[WifiSignalStrength <Int32?>]`: 
        - `[WifiVendorDriver <String>]`: 
        - `[WifiVendorDriverVersion <String>]`: 
      - `[CallerDeviceCaptureDeviceDriver <String>]`: 
      - `[CallerDeviceCaptureDeviceName <String>]`: 
      - `[CallerDeviceCaptureNotFunctioningEventRatio <Single?>]`: 
      - `[CallerDeviceClippingEventRatio <Single?>]`: 
      - `[CallerDeviceCpuInsufficentEventRatio <Single?>]`: 
      - `[CallerDeviceGlitchEventRatio <Single?>]`: 
      - `[CallerDeviceHowlingEventCount <Int32?>]`: 
      - `[CallerDeviceInitialSignalLevelRootMeanSquare <Single?>]`: 
      - `[CallerDeviceLowSpeechLevelEventRatio <Single?>]`: 
      - `[CallerDeviceLowSpeechToNoiseEventRatio <Single?>]`: 
      - `[CallerDeviceMicGlitchRate <Single?>]`: 
      - `[CallerDeviceReceivedNoiseLevel <Int32?>]`: 
      - `[CallerDeviceReceivedSignalLevel <Int32?>]`: 
      - `[CallerDeviceRenderDeviceDriver <String>]`: 
      - `[CallerDeviceRenderDeviceName <String>]`: 
      - `[CallerDeviceRenderMuteEventRatio <Single?>]`: 
      - `[CallerDeviceRenderNotFunctioningEventRatio <Single?>]`: 
      - `[CallerDeviceRenderZeroVolumeEventRatio <Single?>]`: 
      - `[CallerDeviceSentNoiseLevel <Int32?>]`: 
      - `[CallerDeviceSentSignalLevel <Int32?>]`: 
      - `[CallerDeviceSpeakerGlitchRate <Single?>]`: 
      - `[CallerNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
      - `[Label <String>]`: 
      - `[Streams <IMicrosoftGraphCallRecordsMediaStream[]>]`: 
        - `[AverageAudioDegradation <Single?>]`: 
        - `[AverageAudioNetworkJitter <TimeSpan?>]`: 
        - `[AverageBandwidthEstimate <Int64?>]`: 
        - `[AverageJitter <TimeSpan?>]`: 
        - `[AveragePacketLossRate <Single?>]`: 
        - `[AverageRatioOfConcealedSamples <Single?>]`: 
        - `[AverageReceivedFrameRate <Single?>]`: 
        - `[AverageRoundTripTime <TimeSpan?>]`: 
        - `[AverageVideoFrameLossPercentage <Single?>]`: 
        - `[AverageVideoFrameRate <Single?>]`: 
        - `[AverageVideoPacketLossRate <Single?>]`: 
        - `[EndDateTime <DateTime?>]`: 
        - `[LowFrameRateRatio <Single?>]`: 
        - `[LowVideoProcessingCapabilityRatio <Single?>]`: 
        - `[MaxAudioNetworkJitter <TimeSpan?>]`: 
        - `[MaxJitter <TimeSpan?>]`: 
        - `[MaxPacketLossRate <Single?>]`: 
        - `[MaxRatioOfConcealedSamples <Single?>]`: 
        - `[MaxRoundTripTime <TimeSpan?>]`: 
        - `[PacketUtilization <Int64?>]`: 
        - `[PostForwardErrorCorrectionPacketLossRate <Single?>]`: 
        - `[StartDateTime <DateTime?>]`: 
        - `[StreamDirection <String>]`: mediaStreamDirection
        - `[StreamId <String>]`: 
        - `[WasMediaBypassed <Boolean?>]`: 
    - `[StartDateTime <DateTime?>]`: 
  - `[StartDateTime <DateTime?>]`: 

## RELATED LINKS


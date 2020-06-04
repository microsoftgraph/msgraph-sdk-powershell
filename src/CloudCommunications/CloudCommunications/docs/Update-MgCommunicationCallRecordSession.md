---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/update-mgcommunicationcallrecordsession
schema: 2.0.0
---

# Update-MgCommunicationCallRecordSession

## SYNOPSIS
Update the navigation property sessions in communications

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgCommunicationCallRecordSession -CallRecordId <String> -SessionId <String>
 [-CalleeUserAgentApplicationVersion <String>] [-CalleeUserAgentHeaderValue <String>]
 [-CallerUserAgentApplicationVersion <String>] [-CallerUserAgentHeaderValue <String>]
 [-EndDateTime <DateTime>] [-FailureInfoReason <String>] [-FailureInfoStage <String>] [-Id <String>]
 [-Modalities <String[]>] [-Segments <IMicrosoftGraphCallRecordsSegment[]>] [-StartDateTime <DateTime>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgCommunicationCallRecordSession -CallRecordId <String> -SessionId <String>
 -BodyParameter <IMicrosoftGraphCallRecordsSession> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgCommunicationCallRecordSession -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IMicrosoftGraphCallRecordsSession> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgCommunicationCallRecordSession -InputObject <ICloudCommunicationsIdentity>
 [-CalleeUserAgentApplicationVersion <String>] [-CalleeUserAgentHeaderValue <String>]
 [-CallerUserAgentApplicationVersion <String>] [-CallerUserAgentHeaderValue <String>]
 [-EndDateTime <DateTime>] [-FailureInfoReason <String>] [-FailureInfoStage <String>] [-Id <String>]
 [-Modalities <String[]>] [-Segments <IMicrosoftGraphCallRecordsSegment[]>] [-StartDateTime <DateTime>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property sessions in communications

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
session
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsSession
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CalleeUserAgentApplicationVersion
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CalleeUserAgentHeaderValue
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CallerUserAgentApplicationVersion
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CallerUserAgentHeaderValue
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CallRecordId
key: callRecord-id of callRecord

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EndDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -FailureInfoReason
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -FailureInfoStage
failureStage

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Modalities
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Segments
.
To construct, see NOTES section for SEGMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsSegment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SessionId
key: session-id of session

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -StartDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsSession

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphCallRecordsSession>: session
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

#### INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AudioRoutingGroupId <String>]`: key: audioRoutingGroup-id of audioRoutingGroup
  - `[CallId <String>]`: key: call-id of call
  - `[CallRecordId <String>]`: key: callRecord-id of callRecord
  - `[CommsOperationId <String>]`: key: commsOperation-id of commsOperation
  - `[OnlineMeetingId <String>]`: key: onlineMeeting-id of onlineMeeting
  - `[ParticipantId <String>]`: key: participant-id of participant
  - `[SegmentId <String>]`: key: segment-id of segment
  - `[SessionId <String>]`: key: session-id of session

#### SEGMENTS <IMicrosoftGraphCallRecordsSegment[]>: .
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

## RELATED LINKS


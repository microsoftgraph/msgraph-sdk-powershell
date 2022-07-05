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
 [-AdditionalProperties <Hashtable>] [-Callee <IMicrosoftGraphCallRecordsEndpoint>]
 [-Caller <IMicrosoftGraphCallRecordsEndpoint>] [-EndDateTime <DateTime>]
 [-FailureInfo <IMicrosoftGraphCallRecordsFailureInfo>] [-Id <String>] [-Modalities <String[]>]
 [-Segments <IMicrosoftGraphCallRecordsSegment[]>] [-StartDateTime <DateTime>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
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
 [-AdditionalProperties <Hashtable>] [-Callee <IMicrosoftGraphCallRecordsEndpoint>]
 [-Caller <IMicrosoftGraphCallRecordsEndpoint>] [-EndDateTime <DateTime>]
 [-FailureInfo <IMicrosoftGraphCallRecordsFailureInfo>] [-Id <String>] [-Modalities <String[]>]
 [-Segments <IMicrosoftGraphCallRecordsSegment[]>] [-StartDateTime <DateTime>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property sessions in communications

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
session
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsSession
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Callee
endpoint
To construct, please use Get-Help -Online and see NOTES section for CALLEE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsEndpoint
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Caller
endpoint
To construct, please use Get-Help -Online and see NOTES section for CALLER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsEndpoint
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallRecordId
key: id of callRecord

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
UTC time when the last user left the session.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FailureInfo
failureInfo
To construct, please use Get-Help -Online and see NOTES section for FAILUREINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsFailureInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
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
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Modalities
List of modalities present in the session.
Possible values are: unknown, audio, video, videoBasedScreenSharing, data, screenSharing, unknownFutureValue.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -Segments
The list of segments involved in the session.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for SEGMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsSegment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SessionId
key: id of session

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
UTC fime when the first user joined the session.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsSession

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCallRecordsSession>: session
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Callee <IMicrosoftGraphCallRecordsEndpoint>]`: endpoint
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UserAgent <IMicrosoftGraphCallRecordsUserAgent>]`: userAgent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApplicationVersion <String>]`: Identifies the version of application software used by this endpoint.
      - `[HeaderValue <String>]`: User-agent header value reported by this endpoint.
  - `[Caller <IMicrosoftGraphCallRecordsEndpoint>]`: endpoint
  - `[EndDateTime <DateTime?>]`: UTC time when the last user left the session. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[FailureInfo <IMicrosoftGraphCallRecordsFailureInfo>]`: failureInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Reason <String>]`: Classification of why a call or portion of a call failed.
    - `[Stage <String>]`: failureStage
  - `[Modalities <String[]>]`: List of modalities present in the session. Possible values are: unknown, audio, video, videoBasedScreenSharing, data, screenSharing, unknownFutureValue.
  - `[Segments <IMicrosoftGraphCallRecordsSegment[]>]`: The list of segments involved in the session. Read-only. Nullable.
    - `[Id <String>]`: 
    - `[Callee <IMicrosoftGraphCallRecordsEndpoint>]`: endpoint
    - `[Caller <IMicrosoftGraphCallRecordsEndpoint>]`: endpoint
    - `[EndDateTime <DateTime?>]`: UTC time when the segment ended. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[FailureInfo <IMicrosoftGraphCallRecordsFailureInfo>]`: failureInfo
    - `[Media <IMicrosoftGraphCallRecordsMedia[]>]`: Media associated with this segment.
      - `[CalleeDevice <IMicrosoftGraphCallRecordsDeviceInfo>]`: deviceInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CaptureDeviceDriver <String>]`: Name of the capture device driver used by the media endpoint.
        - `[CaptureDeviceName <String>]`: Name of the capture device used by the media endpoint.
        - `[CaptureNotFunctioningEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the capture device was not working properly.
        - `[CpuInsufficentEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the CPU resources available were insufficient and caused poor quality of the audio sent and received.
        - `[DeviceClippingEventRatio <Single?>]`: Fraction of the call that the media endpoint detected clipping in the captured audio that caused poor quality of the audio being sent.
        - `[DeviceGlitchEventRatio <Single?>]`: Fraction of the call that the media endpoint detected glitches or gaps in the audio played or captured that caused poor quality of the audio being sent or received.
        - `[HowlingEventCount <Int32?>]`: Number of times during the call that the media endpoint detected howling or screeching audio.
        - `[InitialSignalLevelRootMeanSquare <Single?>]`: The root mean square (RMS) of the incoming signal of up to the first 30 seconds of the call.
        - `[LowSpeechLevelEventRatio <Single?>]`: Fraction of the call that the media endpoint detected low speech level that caused poor quality of the audio being sent.
        - `[LowSpeechToNoiseEventRatio <Single?>]`: Fraction of the call that the media endpoint detected low speech to noise level that caused poor quality of the audio being sent.
        - `[MicGlitchRate <Single?>]`: Glitches per 5 minute interval for the media endpoint's microphone.
        - `[ReceivedNoiseLevel <Int32?>]`: Average energy level of received audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.
        - `[ReceivedSignalLevel <Int32?>]`: Average energy level of received audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.
        - `[RenderDeviceDriver <String>]`: Name of the render device driver used by the media endpoint.
        - `[RenderDeviceName <String>]`: Name of the render device used by the media endpoint.
        - `[RenderMuteEventRatio <Single?>]`: Fraction of the call that media endpoint detected device render is muted.
        - `[RenderNotFunctioningEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the render device was not working properly.
        - `[RenderZeroVolumeEventRatio <Single?>]`: Fraction of the call that media endpoint detected device render volume is set to 0.
        - `[SentNoiseLevel <Int32?>]`: Average energy level of sent audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.
        - `[SentSignalLevel <Int32?>]`: Average energy level of sent audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.
        - `[SpeakerGlitchRate <Single?>]`: Glitches per 5 minute internal for the media endpoint's loudspeaker.
      - `[CalleeNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[BandwidthLowEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the available bandwidth or bandwidth policy was low enough to cause poor quality of the audio sent.
        - `[BasicServiceSetIdentifier <String>]`: The wireless LAN basic service set identifier of the media endpoint used to connect to the network.
        - `[ConnectionType <String>]`: networkConnectionType
        - `[DelayEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the network delay was significant enough to impact the ability to have real-time two-way communication.
        - `[DnsSuffix <String>]`: DNS suffix associated with the network adapter of the media endpoint.
        - `[IPAddress <String>]`: IP address of the media endpoint.
        - `[LinkSpeed <Int64?>]`: Link speed in bits per second reported by the network adapter used by the media endpoint.
        - `[MacAddress <String>]`: The media access control (MAC) address of the media endpoint's network device.
        - `[NetworkTransportProtocol <String>]`: networkTransportProtocol
        - `[Port <Int32?>]`: Network port number used by media endpoint.
        - `[ReceivedQualityEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the network was causing poor quality of the audio received.
        - `[ReflexiveIPAddress <String>]`: IP address of the media endpoint as seen by the media relay server. This is typically the public internet IP address associated to the endpoint.
        - `[RelayIPAddress <String>]`: IP address of the media relay server allocated by the media endpoint.
        - `[RelayPort <Int32?>]`: Network port number allocated on the media relay server by the media endpoint.
        - `[SentQualityEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the network was causing poor quality of the audio sent.
        - `[Subnet <String>]`: Subnet used for media stream by the media endpoint.
        - `[TraceRouteHops <IMicrosoftGraphCallRecordsTraceRouteHop[]>]`: List of network trace route hops collected for this media stream.*
          - `[HopCount <Int32?>]`: The network path count of this hop that was used to compute the round-trip time.
          - `[IPAddress <String>]`: IP address used for this hop in the network trace.
          - `[RoundTripTime <TimeSpan?>]`: The time from when the trace route packet was sent from the client to this hop and back to the client, denoted in [ISO 8601][] format. For example, 1 second is denoted as PT1S, where P is the duration designator, T is the time designator, and S is the second designator.
        - `[WifiBand <String>]`: wifiBand
        - `[WifiBatteryCharge <Int32?>]`: Estimated remaining battery charge in percentage reported by the media endpoint.
        - `[WifiChannel <Int32?>]`: WiFi channel used by the media endpoint.
        - `[WifiMicrosoftDriver <String>]`: Name of the Microsoft WiFi driver used by the media endpoint. Value may be localized based on the language used by endpoint.
        - `[WifiMicrosoftDriverVersion <String>]`: Version of the Microsoft WiFi driver used by the media endpoint.
        - `[WifiRadioType <String>]`: wifiRadioType
        - `[WifiSignalStrength <Int32?>]`: WiFi signal strength in percentage reported by the media endpoint.
        - `[WifiVendorDriver <String>]`: Name of the WiFi driver used by the media endpoint. Value may be localized based on the language used by endpoint.
        - `[WifiVendorDriverVersion <String>]`: Version of the WiFi driver used by the media endpoint.
      - `[CallerDevice <IMicrosoftGraphCallRecordsDeviceInfo>]`: deviceInfo
      - `[CallerNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
      - `[Label <String>]`: How the media was identified during media negotiation stage.
      - `[Streams <IMicrosoftGraphCallRecordsMediaStream[]>]`: Network streams associated with this media.
        - `[AudioCodec <String>]`: audioCodec
        - `[AverageAudioDegradation <Single?>]`: Average Network Mean Opinion Score degradation for stream. Represents how much the network loss and jitter has impacted the quality of received audio.
        - `[AverageAudioNetworkJitter <TimeSpan?>]`: Average jitter for the stream computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        - `[AverageBandwidthEstimate <Int64?>]`: Average estimated bandwidth available between two endpoints in bits per second.
        - `[AverageJitter <TimeSpan?>]`: Average jitter for the stream computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        - `[AveragePacketLossRate <Single?>]`: Average packet loss rate for stream.
        - `[AverageRatioOfConcealedSamples <Single?>]`: Ratio of the number of audio frames with samples generated by packet loss concealment to the total number of audio frames.
        - `[AverageReceivedFrameRate <Single?>]`: Average frames per second received for all video streams computed over the duration of the session.
        - `[AverageRoundTripTime <TimeSpan?>]`: Average network propagation round-trip time computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        - `[AverageVideoFrameLossPercentage <Single?>]`: Average percentage of video frames lost as displayed to the user.
        - `[AverageVideoFrameRate <Single?>]`: Average frames per second received for a video stream, computed over the duration of the session.
        - `[AverageVideoPacketLossRate <Single?>]`: Average fraction of packets lost, as specified in [RFC 3550][], computed over the duration of the session.
        - `[EndDateTime <DateTime?>]`: UTC time when the stream ended. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[LowFrameRateRatio <Single?>]`: Fraction of the call where frame rate is less than 7.5 frames per second.
        - `[LowVideoProcessingCapabilityRatio <Single?>]`: Fraction of the call that the client is running less than 70% expected video processing capability.
        - `[MaxAudioNetworkJitter <TimeSpan?>]`: Maximum of audio network jitter computed over each of the 20 second windows during the session, denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        - `[MaxJitter <TimeSpan?>]`: Maximum jitter for the stream computed as specified in RFC 3550, denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        - `[MaxPacketLossRate <Single?>]`: Maximum packet loss rate for the stream.
        - `[MaxRatioOfConcealedSamples <Single?>]`: Maximum ratio of packets concealed by the healer.
        - `[MaxRoundTripTime <TimeSpan?>]`: Maximum network propagation round-trip time computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        - `[PacketUtilization <Int64?>]`: Packet count for the stream.
        - `[PostForwardErrorCorrectionPacketLossRate <Single?>]`: Packet loss rate after FEC has been applied aggregated across all video streams and codecs.
        - `[StartDateTime <DateTime?>]`: UTC time when the stream started. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[StreamDirection <String>]`: mediaStreamDirection
        - `[StreamId <String>]`: Unique identifier for the stream.
        - `[VideoCodec <String>]`: videoCodec
        - `[WasMediaBypassed <Boolean?>]`: True if the media stream bypassed the Mediation Server and went straight between client and PSTN Gateway/PBX, false otherwise.
    - `[StartDateTime <DateTime?>]`: UTC time when the segment started. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[StartDateTime <DateTime?>]`: UTC fime when the first user joined the session. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

CALLEE <IMicrosoftGraphCallRecordsEndpoint>: endpoint
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[UserAgent <IMicrosoftGraphCallRecordsUserAgent>]`: userAgent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplicationVersion <String>]`: Identifies the version of application software used by this endpoint.
    - `[HeaderValue <String>]`: User-agent header value reported by this endpoint.

CALLER <IMicrosoftGraphCallRecordsEndpoint>: endpoint
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[UserAgent <IMicrosoftGraphCallRecordsUserAgent>]`: userAgent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplicationVersion <String>]`: Identifies the version of application software used by this endpoint.
    - `[HeaderValue <String>]`: User-agent header value reported by this endpoint.

FAILUREINFO <IMicrosoftGraphCallRecordsFailureInfo>: failureInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Reason <String>]`: Classification of why a call or portion of a call failed.
  - `[Stage <String>]`: failureStage

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

SEGMENTS <IMicrosoftGraphCallRecordsSegment[]>: The list of segments involved in the session. Read-only. Nullable.
  - `[Id <String>]`: 
  - `[Callee <IMicrosoftGraphCallRecordsEndpoint>]`: endpoint
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UserAgent <IMicrosoftGraphCallRecordsUserAgent>]`: userAgent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApplicationVersion <String>]`: Identifies the version of application software used by this endpoint.
      - `[HeaderValue <String>]`: User-agent header value reported by this endpoint.
  - `[Caller <IMicrosoftGraphCallRecordsEndpoint>]`: endpoint
  - `[EndDateTime <DateTime?>]`: UTC time when the segment ended. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[FailureInfo <IMicrosoftGraphCallRecordsFailureInfo>]`: failureInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Reason <String>]`: Classification of why a call or portion of a call failed.
    - `[Stage <String>]`: failureStage
  - `[Media <IMicrosoftGraphCallRecordsMedia[]>]`: Media associated with this segment.
    - `[CalleeDevice <IMicrosoftGraphCallRecordsDeviceInfo>]`: deviceInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CaptureDeviceDriver <String>]`: Name of the capture device driver used by the media endpoint.
      - `[CaptureDeviceName <String>]`: Name of the capture device used by the media endpoint.
      - `[CaptureNotFunctioningEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the capture device was not working properly.
      - `[CpuInsufficentEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the CPU resources available were insufficient and caused poor quality of the audio sent and received.
      - `[DeviceClippingEventRatio <Single?>]`: Fraction of the call that the media endpoint detected clipping in the captured audio that caused poor quality of the audio being sent.
      - `[DeviceGlitchEventRatio <Single?>]`: Fraction of the call that the media endpoint detected glitches or gaps in the audio played or captured that caused poor quality of the audio being sent or received.
      - `[HowlingEventCount <Int32?>]`: Number of times during the call that the media endpoint detected howling or screeching audio.
      - `[InitialSignalLevelRootMeanSquare <Single?>]`: The root mean square (RMS) of the incoming signal of up to the first 30 seconds of the call.
      - `[LowSpeechLevelEventRatio <Single?>]`: Fraction of the call that the media endpoint detected low speech level that caused poor quality of the audio being sent.
      - `[LowSpeechToNoiseEventRatio <Single?>]`: Fraction of the call that the media endpoint detected low speech to noise level that caused poor quality of the audio being sent.
      - `[MicGlitchRate <Single?>]`: Glitches per 5 minute interval for the media endpoint's microphone.
      - `[ReceivedNoiseLevel <Int32?>]`: Average energy level of received audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.
      - `[ReceivedSignalLevel <Int32?>]`: Average energy level of received audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.
      - `[RenderDeviceDriver <String>]`: Name of the render device driver used by the media endpoint.
      - `[RenderDeviceName <String>]`: Name of the render device used by the media endpoint.
      - `[RenderMuteEventRatio <Single?>]`: Fraction of the call that media endpoint detected device render is muted.
      - `[RenderNotFunctioningEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the render device was not working properly.
      - `[RenderZeroVolumeEventRatio <Single?>]`: Fraction of the call that media endpoint detected device render volume is set to 0.
      - `[SentNoiseLevel <Int32?>]`: Average energy level of sent audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.
      - `[SentSignalLevel <Int32?>]`: Average energy level of sent audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.
      - `[SpeakerGlitchRate <Single?>]`: Glitches per 5 minute internal for the media endpoint's loudspeaker.
    - `[CalleeNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BandwidthLowEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the available bandwidth or bandwidth policy was low enough to cause poor quality of the audio sent.
      - `[BasicServiceSetIdentifier <String>]`: The wireless LAN basic service set identifier of the media endpoint used to connect to the network.
      - `[ConnectionType <String>]`: networkConnectionType
      - `[DelayEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the network delay was significant enough to impact the ability to have real-time two-way communication.
      - `[DnsSuffix <String>]`: DNS suffix associated with the network adapter of the media endpoint.
      - `[IPAddress <String>]`: IP address of the media endpoint.
      - `[LinkSpeed <Int64?>]`: Link speed in bits per second reported by the network adapter used by the media endpoint.
      - `[MacAddress <String>]`: The media access control (MAC) address of the media endpoint's network device.
      - `[NetworkTransportProtocol <String>]`: networkTransportProtocol
      - `[Port <Int32?>]`: Network port number used by media endpoint.
      - `[ReceivedQualityEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the network was causing poor quality of the audio received.
      - `[ReflexiveIPAddress <String>]`: IP address of the media endpoint as seen by the media relay server. This is typically the public internet IP address associated to the endpoint.
      - `[RelayIPAddress <String>]`: IP address of the media relay server allocated by the media endpoint.
      - `[RelayPort <Int32?>]`: Network port number allocated on the media relay server by the media endpoint.
      - `[SentQualityEventRatio <Single?>]`: Fraction of the call that the media endpoint detected the network was causing poor quality of the audio sent.
      - `[Subnet <String>]`: Subnet used for media stream by the media endpoint.
      - `[TraceRouteHops <IMicrosoftGraphCallRecordsTraceRouteHop[]>]`: List of network trace route hops collected for this media stream.*
        - `[HopCount <Int32?>]`: The network path count of this hop that was used to compute the round-trip time.
        - `[IPAddress <String>]`: IP address used for this hop in the network trace.
        - `[RoundTripTime <TimeSpan?>]`: The time from when the trace route packet was sent from the client to this hop and back to the client, denoted in [ISO 8601][] format. For example, 1 second is denoted as PT1S, where P is the duration designator, T is the time designator, and S is the second designator.
      - `[WifiBand <String>]`: wifiBand
      - `[WifiBatteryCharge <Int32?>]`: Estimated remaining battery charge in percentage reported by the media endpoint.
      - `[WifiChannel <Int32?>]`: WiFi channel used by the media endpoint.
      - `[WifiMicrosoftDriver <String>]`: Name of the Microsoft WiFi driver used by the media endpoint. Value may be localized based on the language used by endpoint.
      - `[WifiMicrosoftDriverVersion <String>]`: Version of the Microsoft WiFi driver used by the media endpoint.
      - `[WifiRadioType <String>]`: wifiRadioType
      - `[WifiSignalStrength <Int32?>]`: WiFi signal strength in percentage reported by the media endpoint.
      - `[WifiVendorDriver <String>]`: Name of the WiFi driver used by the media endpoint. Value may be localized based on the language used by endpoint.
      - `[WifiVendorDriverVersion <String>]`: Version of the WiFi driver used by the media endpoint.
    - `[CallerDevice <IMicrosoftGraphCallRecordsDeviceInfo>]`: deviceInfo
    - `[CallerNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
    - `[Label <String>]`: How the media was identified during media negotiation stage.
    - `[Streams <IMicrosoftGraphCallRecordsMediaStream[]>]`: Network streams associated with this media.
      - `[AudioCodec <String>]`: audioCodec
      - `[AverageAudioDegradation <Single?>]`: Average Network Mean Opinion Score degradation for stream. Represents how much the network loss and jitter has impacted the quality of received audio.
      - `[AverageAudioNetworkJitter <TimeSpan?>]`: Average jitter for the stream computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
      - `[AverageBandwidthEstimate <Int64?>]`: Average estimated bandwidth available between two endpoints in bits per second.
      - `[AverageJitter <TimeSpan?>]`: Average jitter for the stream computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
      - `[AveragePacketLossRate <Single?>]`: Average packet loss rate for stream.
      - `[AverageRatioOfConcealedSamples <Single?>]`: Ratio of the number of audio frames with samples generated by packet loss concealment to the total number of audio frames.
      - `[AverageReceivedFrameRate <Single?>]`: Average frames per second received for all video streams computed over the duration of the session.
      - `[AverageRoundTripTime <TimeSpan?>]`: Average network propagation round-trip time computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
      - `[AverageVideoFrameLossPercentage <Single?>]`: Average percentage of video frames lost as displayed to the user.
      - `[AverageVideoFrameRate <Single?>]`: Average frames per second received for a video stream, computed over the duration of the session.
      - `[AverageVideoPacketLossRate <Single?>]`: Average fraction of packets lost, as specified in [RFC 3550][], computed over the duration of the session.
      - `[EndDateTime <DateTime?>]`: UTC time when the stream ended. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[LowFrameRateRatio <Single?>]`: Fraction of the call where frame rate is less than 7.5 frames per second.
      - `[LowVideoProcessingCapabilityRatio <Single?>]`: Fraction of the call that the client is running less than 70% expected video processing capability.
      - `[MaxAudioNetworkJitter <TimeSpan?>]`: Maximum of audio network jitter computed over each of the 20 second windows during the session, denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
      - `[MaxJitter <TimeSpan?>]`: Maximum jitter for the stream computed as specified in RFC 3550, denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
      - `[MaxPacketLossRate <Single?>]`: Maximum packet loss rate for the stream.
      - `[MaxRatioOfConcealedSamples <Single?>]`: Maximum ratio of packets concealed by the healer.
      - `[MaxRoundTripTime <TimeSpan?>]`: Maximum network propagation round-trip time computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
      - `[PacketUtilization <Int64?>]`: Packet count for the stream.
      - `[PostForwardErrorCorrectionPacketLossRate <Single?>]`: Packet loss rate after FEC has been applied aggregated across all video streams and codecs.
      - `[StartDateTime <DateTime?>]`: UTC time when the stream started. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[StreamDirection <String>]`: mediaStreamDirection
      - `[StreamId <String>]`: Unique identifier for the stream.
      - `[VideoCodec <String>]`: videoCodec
      - `[WasMediaBypassed <Boolean?>]`: True if the media stream bypassed the Mediation Server and went straight between client and PSTN Gateway/PBX, false otherwise.
  - `[StartDateTime <DateTime?>]`: UTC time when the segment started. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

## RELATED LINKS


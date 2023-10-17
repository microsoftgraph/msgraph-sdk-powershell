---
Module Name: Microsoft.Graph.CloudCommunications
Module Guid: eea630c4-225d-43f8-8227-f5fb04a0e475
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.cloudcommunications
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.CloudCommunications Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.CloudCommunications Cmdlets
### [Add-MgCommunicationCallLargeGalleryView](Add-MgCommunicationCallLargeGalleryView.md)
Add the large gallery view to a call.
For details about how to identify a large gallery view participant in a roster so that you can retrieve the relevant data to subscribe to the video feed, see Identify large gallery view participants in a roster.
This API is available in the following national cloud deployments.

### [Clear-MgCommunicationPresence](Clear-MgCommunicationPresence.md)
Clear the application's presence session for a user.
If it is the user's only presence session, the user's presence will change to Offline/Offline.
For details about presences sessions, see presence: setPresence.
This API is available in the following national cloud deployments.

### [Clear-MgCommunicationPresenceUserPreferredPresence](Clear-MgCommunicationPresenceUserPreferredPresence.md)
Clear the preferred availability and activity status for a user.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationCall](Get-MgCommunicationCall.md)
Retrieve the properties and relationships of a call object.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationCallAudioRoutingGroup](Get-MgCommunicationCallAudioRoutingGroup.md)
Retrieve the properties and relationships of an audioRoutingGroup object.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationCallAudioRoutingGroupCount](Get-MgCommunicationCallAudioRoutingGroupCount.md)
Get the number of the resource

### [Get-MgCommunicationCallContentSharingSession](Get-MgCommunicationCallContentSharingSession.md)
Retrieve the properties of a contentSharingSession object in a call.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationCallContentSharingSessionCount](Get-MgCommunicationCallContentSharingSessionCount.md)
Get the number of the resource

### [Get-MgCommunicationCallCount](Get-MgCommunicationCallCount.md)
Get the number of the resource

### [Get-MgCommunicationCallOperation](Get-MgCommunicationCallOperation.md)
Get the status of an operation that adds the large gallery view to a call.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationCallOperationCount](Get-MgCommunicationCallOperationCount.md)
Get the number of the resource

### [Get-MgCommunicationCallParticipant](Get-MgCommunicationCallParticipant.md)
Retrieve the properties and relationships of a participant object.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationCallParticipantCount](Get-MgCommunicationCallParticipantCount.md)
Get the number of the resource

### [Get-MgCommunicationCallRecord](Get-MgCommunicationCallRecord.md)
Retrieve the properties and relationships of a callRecord object.
There are two ways to get the id of a callRecord: You can use the $expand query parameter to optionally include session and segment details, as shown in the Get full details example.
When you expand session details, the maximum page size is 60 sessions.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationCallRecordCount](Get-MgCommunicationCallRecordCount.md)
Get the number of the resource

### [Get-MgCommunicationCallRecordSession](Get-MgCommunicationCallRecordSession.md)
List of sessions involved in the call.
Peer-to-peer calls typically only have one session, whereas group calls typically have at least one session per participant.
Read-only.
Nullable.

### [Get-MgCommunicationCallRecordSessionCount](Get-MgCommunicationCallRecordSessionCount.md)
Get the number of the resource

### [Get-MgCommunicationCallRecordSessionSegmentCount](Get-MgCommunicationCallRecordSessionSegmentCount.md)
Get the number of the resource

### [Get-MgCommunicationOnlineMeeting](Get-MgCommunicationOnlineMeeting.md)
Get onlineMeetings from communications

### [Get-MgCommunicationOnlineMeetingAttendanceReport](Get-MgCommunicationOnlineMeetingAttendanceReport.md)
Get the meetingAttendanceReport for an onlineMeeting.
Each time an online meeting ends, an attendance report will be generated for that session.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord](Get-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
List of attendance records of an attendance report.
Read-only.

### [Get-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecordCount](Get-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecordCount.md)
Get the number of the resource

### [Get-MgCommunicationOnlineMeetingAttendanceReportCount](Get-MgCommunicationOnlineMeetingAttendanceReportCount.md)
Get the number of the resource

### [Get-MgCommunicationOnlineMeetingAttendeeReport](Get-MgCommunicationOnlineMeetingAttendeeReport.md)
Get attendeeReport for the navigation property onlineMeetings from communications

### [Get-MgCommunicationOnlineMeetingCount](Get-MgCommunicationOnlineMeetingCount.md)
Get the number of the resource

### [Get-MgCommunicationOnlineMeetingTranscript](Get-MgCommunicationOnlineMeetingTranscript.md)
Retrieve a callTranscript object associated with a scheduled onlineMeeting.
This API doesn't support getting call transcripts from channel meetings.
Retrieving the transcript returns the metadata of the single transcript associated with the online meeting.
Retrieving the content of the transcript returns the stream of text associated with the transcript.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationOnlineMeetingTranscriptContent](Get-MgCommunicationOnlineMeetingTranscriptContent.md)
The content of the transcript.
Read-only.

### [Get-MgCommunicationOnlineMeetingTranscriptCount](Get-MgCommunicationOnlineMeetingTranscriptCount.md)
Get the number of the resource

### [Get-MgCommunicationOnlineMeetingTranscriptMetadataContent](Get-MgCommunicationOnlineMeetingTranscriptMetadataContent.md)
The time-aligned metadata of the utterances in the transcript.
Read-only.

### [Get-MgCommunicationOnlineMeetingVirtualAppointmentJoinWebUrl](Get-MgCommunicationOnlineMeetingVirtualAppointmentJoinWebUrl.md)
Invoke function getVirtualAppointmentJoinWebUrl

### [Get-MgCommunicationPresence](Get-MgCommunicationPresence.md)
Get a user's presence information.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationPresenceByUserId](Get-MgCommunicationPresenceByUserId.md)
Get the presence information for multiple users.
This API is available in the following national cloud deployments.

### [Get-MgCommunicationPresenceCount](Get-MgCommunicationPresenceCount.md)
Get the number of the resource

### [Get-MgUserOnlineMeeting](Get-MgUserOnlineMeeting.md)
Retrieve the properties and relationships of an onlineMeeting object.
For example, you can: Teams live event attendee report (deprecated) is an online meeting artifact.
For details, see Online meeting artifacts and permissions.
This API is available in the following national cloud deployments.

### [Get-MgUserOnlineMeetingAttendanceReport](Get-MgUserOnlineMeetingAttendanceReport.md)
Get the meetingAttendanceReport for an onlineMeeting.
Each time an online meeting ends, an attendance report will be generated for that session.
This API is available in the following national cloud deployments.

### [Get-MgUserOnlineMeetingAttendanceReportAttendanceRecord](Get-MgUserOnlineMeetingAttendanceReportAttendanceRecord.md)
List of attendance records of an attendance report.
Read-only.

### [Get-MgUserOnlineMeetingAttendanceReportAttendanceRecordCount](Get-MgUserOnlineMeetingAttendanceReportAttendanceRecordCount.md)
Get the number of the resource

### [Get-MgUserOnlineMeetingAttendanceReportCount](Get-MgUserOnlineMeetingAttendanceReportCount.md)
Get the number of the resource

### [Get-MgUserOnlineMeetingAttendeeReport](Get-MgUserOnlineMeetingAttendeeReport.md)
Get attendeeReport for the navigation property onlineMeetings from users

### [Get-MgUserOnlineMeetingCount](Get-MgUserOnlineMeetingCount.md)
Get the number of the resource

### [Get-MgUserOnlineMeetingTranscript](Get-MgUserOnlineMeetingTranscript.md)
Retrieve a callTranscript object associated with a scheduled onlineMeeting.
This API doesn't support getting call transcripts from channel meetings.
Retrieving the transcript returns the metadata of the single transcript associated with the online meeting.
Retrieving the content of the transcript returns the stream of text associated with the transcript.
This API is available in the following national cloud deployments.

### [Get-MgUserOnlineMeetingTranscriptContent](Get-MgUserOnlineMeetingTranscriptContent.md)
The content of the transcript.
Read-only.

### [Get-MgUserOnlineMeetingTranscriptCount](Get-MgUserOnlineMeetingTranscriptCount.md)
Get the number of the resource

### [Get-MgUserOnlineMeetingTranscriptMetadataContent](Get-MgUserOnlineMeetingTranscriptMetadataContent.md)
The time-aligned metadata of the utterances in the transcript.
Read-only.

### [Get-MgUserPresence](Get-MgUserPresence.md)
Set a presence status message for a user.
An optional expiration date and time can be supplied.
This API is available in the following national cloud deployments.

### [Invoke-MgAnswerCommunicationCall](Invoke-MgAnswerCommunicationCall.md)
Enable a bot to answer an incoming call.
The incoming call request can be an invite from a participant in a group call or a peer-to-peer call.
If an invite to a group call is received, the notification will contain the chatInfo and meetingInfo parameters.
The bot is expected to answer, reject, or redirect the call before the call times out.
The current timeout value is 15 seconds for regular scenarios, and 5 seconds for policy-based recording scenarios.
This API is available in the following national cloud deployments.

### [Invoke-MgCreateOrGetCommunicationOnlineMeeting](Invoke-MgCreateOrGetCommunicationOnlineMeeting.md)
Create an onlineMeeting object with a custom specified external ID.
If the external ID already exists, this API will return the onlineMeeting object with that external ID.
This API is available in the following national cloud deployments.

### [Invoke-MgInviteCommunicationCallParticipant](Invoke-MgInviteCommunicationCallParticipant.md)
Delete a specific participant in a call.
In some situations, it is appropriate for an application to remove a participant from an active call.
This action can be done before or after the participant answers the call.
When an active caller is removed, they are immediately dropped from the call with no pre- or post-removal notification.
When an invited participant is removed, any outstanding add participant request is canceled.
This API is available in the following national cloud deployments.

### [Invoke-MgKeepCommunicationCallAlive](Invoke-MgKeepCommunicationCallAlive.md)
Make a request to this API every 15 to 45 minutes to ensure that an ongoing call remains active.
A call that does not receive this request within 45 minutes is considered inactive and will subsequently end.
At least one successful request must be made within 45 minutes of the previous request, or the start of the call.
We recommend that you send a request in shorter time intervals (every 15 minutes).
Make sure that these requests are successful to prevent the call from timing out and ending.
Attempting to send a request to a call that has already ended will result in a 404 Not-Found error.
The resources related to the call should be cleaned up on the application side.
This API is available in the following national cloud deployments.

### [Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality](Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality.md)
Log video teleconferencing device quality data.
The Cloud Video Interop (CVI) bot represents video teleconferencing (VTC) devices and acts as a back-to-back agent for a VTC device in a conference call.
Because a CVI bot is in the middle of the VTC and Microsoft Teams infrastructure as a VTC proxy, it has two media legs.
One media leg is between the CVI bot and Teams infrastructure, such as Teams conference server or a Teams client.
The other media leg is between the CVI bot and the VTC device.
The third-party partners own the VTC media leg and the Teams infrastructure cannot access the quality data of the third-party call leg.
This method is only for the CVI partners to provide their media quality data.
This API is available in the following national cloud deployments.

### [Invoke-MgMuteCommunicationCall](Invoke-MgMuteCommunicationCall.md)
Allows the application to mute itself.
This is a server mute, meaning that the server will drop all audio packets for this participant, even if the participant continues to stream audio.
For more details about how to handle mute operations, see muteParticipantOperation This API is available in the following national cloud deployments.

### [Invoke-MgMuteCommunicationCallParticipant](Invoke-MgMuteCommunicationCallParticipant.md)
Mute a specific participant in the call.
This is a server mute, meaning that the server will drop all audio packets for this participant, even if the participant continues to stream audio.
For more information about how to handle mute operations, see muteParticipantOperation.
This API is available in the following national cloud deployments.

### [Invoke-MgPlayCommunicationCallPrompt](Invoke-MgPlayCommunicationCallPrompt.md)
Play a prompt in the call.
For more information about how to handle operations, see commsOperation This API is available in the following national cloud deployments.

### [Invoke-MgRecordCommunicationCallResponse](Invoke-MgRecordCommunicationCallResponse.md)
Records a short audio response from the caller.\nA bot can utilize this to capture a voice response from a caller after they are prompted for a response.
For further information on how to handle operations, please review commsOperation This action is not intended to record the entire call.
The maximum length of recording is 2 minutes.
The recording is not saved permanently by the Cloud Communications Platform and is discarded shortly after the call ends.
The bot must download the recording promptly after the recording operation finishes by using the recordingLocation value that's given in the completed notification.
This API is available in the following national cloud deployments.

### [Invoke-MgRedirectCommunicationCall](Invoke-MgRedirectCommunicationCall.md)
Redirect an incoming call that hasn't been answered or rejected yet.
The terms 'redirecting' and 'forwarding' a call are used interchangeably.
The bot is expected to redirect the call before the call times out.
The current timeout value is 15 seconds.
This API is available in the following national cloud deployments.

### [Invoke-MgRejectCommunicationCall](Invoke-MgRejectCommunicationCall.md)
Enable a bot to reject an incoming call.
The incoming call request can be an invite from a participant in a group call or a peer-to-peer call.
If an invite to a group call is received, the notification will contain the chatInfo and meetingInfo parameters.
The bot is expected to answer or reject the call before the call times out.
The current timeout value is 15 seconds.
This API does not end existing calls that have already been answered.
Use delete call to end a call.
This API is available in the following national cloud deployments.

### [Invoke-MgSubscribeCommunicationCallToTone](Invoke-MgSubscribeCommunicationCallToTone.md)
Subscribe to DTMF (dual-tone multi-frequency signaling) which allows you to be notified when the user presses keys on a 'dialpad'.
This API is available in the following national cloud deployments.

### [Invoke-MgUnmuteCommunicationCall](Invoke-MgUnmuteCommunicationCall.md)
Allow the application to unmute itself.
This is a server unmute, meaning that the server will start sending audio packets for this participant to other participants again.
For more information about how to handle unmute operations, see unmuteParticipantOperation.
This API is available in the following national cloud deployments.

### [Move-MgCommunicationCall](Move-MgCommunicationCall.md)
Transfer an active peer-to-peer call or group call.
A consultative transfer means that the transferor can inform the person they want to transfer the call to (the transferee), before the transfer is made.
This is opposed to transfering the call directly.
This API is available in the following national cloud deployments.

### [New-MgCommunicationCall](New-MgCommunicationCall.md)
Create call enables your bot to create a new outgoing peer-to-peer or group call, or join an existing meeting.
You will need to register the calling bot and go through the list of permissions needed as mentioned below.
This API is available in the following national cloud deployments.

### [New-MgCommunicationCallAudioRoutingGroup](New-MgCommunicationCallAudioRoutingGroup.md)
Create a new audioRoutingGroup.
This API is available in the following national cloud deployments.

### [New-MgCommunicationCallContentSharingSession](New-MgCommunicationCallContentSharingSession.md)
Create new navigation property to contentSharingSessions for communications

### [New-MgCommunicationCallOperation](New-MgCommunicationCallOperation.md)
Create new navigation property to operations for communications

### [New-MgCommunicationCallParticipant](New-MgCommunicationCallParticipant.md)
Create new navigation property to participants for communications

### [New-MgCommunicationCallRecordSession](New-MgCommunicationCallRecordSession.md)
Create new navigation property to sessions for communications

### [New-MgCommunicationOnlineMeeting](New-MgCommunicationOnlineMeeting.md)
Create new navigation property to onlineMeetings for communications

### [New-MgCommunicationOnlineMeetingAttendanceReport](New-MgCommunicationOnlineMeetingAttendanceReport.md)
Create new navigation property to attendanceReports for communications

### [New-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord](New-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
Create new navigation property to attendanceRecords for communications

### [New-MgCommunicationOnlineMeetingTranscript](New-MgCommunicationOnlineMeetingTranscript.md)
Create new navigation property to transcripts for communications

### [New-MgCommunicationPresence](New-MgCommunicationPresence.md)
Create new navigation property to presences for communications

### [New-MgUserOnlineMeeting](New-MgUserOnlineMeeting.md)
Create an online meeting on behalf of a user.
This API is available in the following national cloud deployments.

### [New-MgUserOnlineMeetingAttendanceReport](New-MgUserOnlineMeetingAttendanceReport.md)
Create new navigation property to attendanceReports for users

### [New-MgUserOnlineMeetingAttendanceReportAttendanceRecord](New-MgUserOnlineMeetingAttendanceReportAttendanceRecord.md)
Create new navigation property to attendanceRecords for users

### [New-MgUserOnlineMeetingTranscript](New-MgUserOnlineMeetingTranscript.md)
Create new navigation property to transcripts for users

### [Remove-MgCommunicationCall](Remove-MgCommunicationCall.md)
Delete or hang up an active call.
For group calls, this will only delete your call leg and the underlying group call will still continue.
This API is available in the following national cloud deployments.

### [Remove-MgCommunicationCallAudioRoutingGroup](Remove-MgCommunicationCallAudioRoutingGroup.md)
Delete the specified audioRoutingGroup.
This API is available in the following national cloud deployments.

### [Remove-MgCommunicationCallContentSharingSession](Remove-MgCommunicationCallContentSharingSession.md)
Delete navigation property contentSharingSessions for communications

### [Remove-MgCommunicationCallOperation](Remove-MgCommunicationCallOperation.md)
Delete navigation property operations for communications

### [Remove-MgCommunicationCallParticipant](Remove-MgCommunicationCallParticipant.md)
Delete a specific participant in a call.
In some situations, it is appropriate for an application to remove a participant from an active call.
This action can be done before or after the participant answers the call.
When an active caller is removed, they are immediately dropped from the call with no pre- or post-removal notification.
When an invited participant is removed, any outstanding add participant request is canceled.
This API is available in the following national cloud deployments.

### [Remove-MgCommunicationCallRecordSession](Remove-MgCommunicationCallRecordSession.md)
Delete navigation property sessions for communications

### [Remove-MgCommunicationOnlineMeeting](Remove-MgCommunicationOnlineMeeting.md)
Delete navigation property onlineMeetings for communications

### [Remove-MgCommunicationOnlineMeetingAttendanceReport](Remove-MgCommunicationOnlineMeetingAttendanceReport.md)
Delete navigation property attendanceReports for communications

### [Remove-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord](Remove-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
Delete navigation property attendanceRecords for communications

### [Remove-MgCommunicationOnlineMeetingTranscript](Remove-MgCommunicationOnlineMeetingTranscript.md)
Delete navigation property transcripts for communications

### [Remove-MgCommunicationPresence](Remove-MgCommunicationPresence.md)
Delete navigation property presences for communications

### [Remove-MgUserOnlineMeeting](Remove-MgUserOnlineMeeting.md)
Delete an onlineMeeting object.
This API is available in the following national cloud deployments.

### [Remove-MgUserOnlineMeetingAttendanceReport](Remove-MgUserOnlineMeetingAttendanceReport.md)
Delete navigation property attendanceReports for users

### [Remove-MgUserOnlineMeetingAttendanceReportAttendanceRecord](Remove-MgUserOnlineMeetingAttendanceReportAttendanceRecord.md)
Delete navigation property attendanceRecords for users

### [Remove-MgUserOnlineMeetingTranscript](Remove-MgUserOnlineMeetingTranscript.md)
Delete navigation property transcripts for users

### [Remove-MgUserPresence](Remove-MgUserPresence.md)
Delete navigation property presence for users

### [Rename-MgCommunicationCallScreenSharingRole](Rename-MgCommunicationCallScreenSharingRole.md)
Allow applications to share screen content with the participants of a group call.
This API is available in the following national cloud deployments.

### [Set-MgCommunicationOnlineMeetingAttendeeReport](Set-MgCommunicationOnlineMeetingAttendeeReport.md)
Update attendeeReport for the navigation property onlineMeetings in communications

### [Set-MgCommunicationOnlineMeetingTranscriptContent](Set-MgCommunicationOnlineMeetingTranscriptContent.md)
The content of the transcript.
Read-only.

### [Set-MgCommunicationOnlineMeetingTranscriptMetadataContent](Set-MgCommunicationOnlineMeetingTranscriptMetadataContent.md)
The time-aligned metadata of the utterances in the transcript.
Read-only.

### [Set-MgCommunicationPresence](Set-MgCommunicationPresence.md)
Set the state of a user's presence session as an application.
This API is available in the following national cloud deployments.

### [Set-MgCommunicationPresenceStatusMessage](Set-MgCommunicationPresenceStatusMessage.md)
Set a presence status message for a user.
An optional expiration date and time can be supplied.
This API is available in the following national cloud deployments.

### [Set-MgCommunicationPresenceUserPreferredPresence](Set-MgCommunicationPresenceUserPreferredPresence.md)
Set the preferred availability and activity status for a user.
If the preferred presence of a user is set, the user's presence shows as the preferred status.
Preferred presence takes effect only when at least one presence session exists for the user.
Otherwise, the user's presence shows as Offline.
A presence session is created as a result of a successful setPresence operation, or if the user is signed in on a Microsoft Teams client.
For more details, see presence sessions and time-out and expiration.
This API is available in the following national cloud deployments.

### [Set-MgUserOnlineMeetingAttendeeReport](Set-MgUserOnlineMeetingAttendeeReport.md)
Update attendeeReport for the navigation property onlineMeetings in users

### [Set-MgUserOnlineMeetingTranscriptContent](Set-MgUserOnlineMeetingTranscriptContent.md)
The content of the transcript.
Read-only.

### [Set-MgUserOnlineMeetingTranscriptMetadataContent](Set-MgUserOnlineMeetingTranscriptMetadataContent.md)
The time-aligned metadata of the utterances in the transcript.
Read-only.

### [Start-MgCommunicationCallParticipantHoldMusic](Start-MgCommunicationCallParticipantHoldMusic.md)
Put a participant on hold and play music in the background.
This API is available in the following national cloud deployments.

### [Stop-MgCommunicationCallMediaProcessing](Stop-MgCommunicationCallMediaProcessing.md)
Cancels processing for any in-progress media operations.
Media operations refer to the IVR operations playPrompt and recordResponse, which are by default queued to process in order.
The cancelMediaProcessing method cancels any operation that is in-process as well as operations that are queued.
For example, this method can be used to clean up the IVR operation queue for a new media operation.
However, it will not cancel a subscribeToTone operation because it operates independent of any operation queue.
This API is available in the following national cloud deployments.

### [Stop-MgCommunicationCallParticipantHoldMusic](Stop-MgCommunicationCallParticipantHoldMusic.md)
Reincorporate a participant previously put on hold to the call.
This API is available in the following national cloud deployments.

### [Update-MgCommunicationCallAudioRoutingGroup](Update-MgCommunicationCallAudioRoutingGroup.md)
Modify sources and receivers of an audioRoutingGroup.
This API is available in the following national cloud deployments.

### [Update-MgCommunicationCallContentSharingSession](Update-MgCommunicationCallContentSharingSession.md)
Update the navigation property contentSharingSessions in communications

### [Update-MgCommunicationCallOperation](Update-MgCommunicationCallOperation.md)
Update the navigation property operations in communications

### [Update-MgCommunicationCallParticipant](Update-MgCommunicationCallParticipant.md)
Update the navigation property participants in communications

### [Update-MgCommunicationCallRecordingStatus](Update-MgCommunicationCallRecordingStatus.md)
Update the application's recording status associated with a call.
This requires the use of the Teams policy-based recording solution.
This API is available in the following national cloud deployments.

### [Update-MgCommunicationCallRecordSession](Update-MgCommunicationCallRecordSession.md)
Update the navigation property sessions in communications

### [Update-MgCommunicationOnlineMeeting](Update-MgCommunicationOnlineMeeting.md)
Update the navigation property onlineMeetings in communications

### [Update-MgCommunicationOnlineMeetingAttendanceReport](Update-MgCommunicationOnlineMeetingAttendanceReport.md)
Update the navigation property attendanceReports in communications

### [Update-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord](Update-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
Update the navigation property attendanceRecords in communications

### [Update-MgCommunicationOnlineMeetingTranscript](Update-MgCommunicationOnlineMeetingTranscript.md)
Update the navigation property transcripts in communications

### [Update-MgCommunicationPresence](Update-MgCommunicationPresence.md)
Update the navigation property presences in communications

### [Update-MgUserOnlineMeeting](Update-MgUserOnlineMeeting.md)
Update the properties of the specified onlineMeeting object.
Please see Request body section for the list of properties that support updating.
This API is available in the following national cloud deployments.

### [Update-MgUserOnlineMeetingAttendanceReport](Update-MgUserOnlineMeetingAttendanceReport.md)
Update the navigation property attendanceReports in users

### [Update-MgUserOnlineMeetingAttendanceReportAttendanceRecord](Update-MgUserOnlineMeetingAttendanceReportAttendanceRecord.md)
Update the navigation property attendanceRecords in users

### [Update-MgUserOnlineMeetingTranscript](Update-MgUserOnlineMeetingTranscript.md)
Update the navigation property transcripts in users

### [Update-MgUserPresence](Update-MgUserPresence.md)
Update the navigation property presence in users


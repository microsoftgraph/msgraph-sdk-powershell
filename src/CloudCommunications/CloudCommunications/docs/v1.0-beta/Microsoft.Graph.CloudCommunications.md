---
Module Name: Microsoft.Graph.CloudCommunications
Module Guid: 6b912831-9942-4fc4-af7e-2906a9bf4f41
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications
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

### [Clear-MgCommunicationPresence](Clear-MgCommunicationPresence.md)
Clear a presence session of an application for a user.
If it is the user's only presence session, a successful **clearPresence** changes the user's presence to `Offline/Offline`.
Read more about presence sessions and their time-out and expiration.

### [Clear-MgCommunicationPresenceUserPreferredPresence](Clear-MgCommunicationPresenceUserPreferredPresence.md)
Clear the preferred availability and activity status for a user.

### [Get-MgCommunicationCall](Get-MgCommunicationCall.md)
Get calls from communications

### [Get-MgCommunicationCallAudioRoutingGroup](Get-MgCommunicationCallAudioRoutingGroup.md)
Get audioRoutingGroups from communications

### [Get-MgCommunicationCallContentSharingSession](Get-MgCommunicationCallContentSharingSession.md)
Get contentSharingSessions from communications

### [Get-MgCommunicationCallOperation](Get-MgCommunicationCallOperation.md)
Get operations from communications

### [Get-MgCommunicationCallParticipant](Get-MgCommunicationCallParticipant.md)
Get participants from communications

### [Get-MgCommunicationCallRecord](Get-MgCommunicationCallRecord.md)
Get callRecords from communications

### [Get-MgCommunicationCallRecordSession](Get-MgCommunicationCallRecordSession.md)
List of sessions involved in the call.
Peer-to-peer calls typically only have one session, whereas group calls typically have at least one session per participant.
Read-only.
Nullable.

### [Get-MgCommunicationOnlineMeeting](Get-MgCommunicationOnlineMeeting.md)
Get onlineMeetings from communications

### [Get-MgCommunicationOnlineMeetingAlternativeRecording](Get-MgCommunicationOnlineMeetingAlternativeRecording.md)
The content stream of the alternative recording of a Microsoft Teams live event.
Read-only.

### [Get-MgCommunicationOnlineMeetingAttendanceReport](Get-MgCommunicationOnlineMeetingAttendanceReport.md)
The attendance reports of an online meeting.
Read-only.

### [Get-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord](Get-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
List of attendance records of an attendance report.
Read-only.

### [Get-MgCommunicationOnlineMeetingAttendeeReport](Get-MgCommunicationOnlineMeetingAttendeeReport.md)
The content stream of the attendee report of a Teams live event.
Read-only.

### [Get-MgCommunicationOnlineMeetingRecording](Get-MgCommunicationOnlineMeetingRecording.md)
The content stream of the recording of a Teams live event.
Read-only.

### [Get-MgCommunicationOnlineMeetingRegistration](Get-MgCommunicationOnlineMeetingRegistration.md)
Get the externalMeetingRegistration details associated with an onlineMeeting.

### [Get-MgCommunicationOnlineMeetingRegistrationCustomQuestion](Get-MgCommunicationOnlineMeetingRegistrationCustomQuestion.md)
Custom registration questions.

### [Get-MgCommunicationOnlineMeetingTranscript](Get-MgCommunicationOnlineMeetingTranscript.md)
The transcripts of an online meeting.
Read-only.

### [Get-MgCommunicationOnlineMeetingTranscriptContent](Get-MgCommunicationOnlineMeetingTranscriptContent.md)
A field representing the content of the transcript.
Read-only.

### [Get-MgCommunicationOnlineMeetingVirtualAppointment](Get-MgCommunicationOnlineMeetingVirtualAppointment.md)
Get virtualAppointment from communications

### [Get-MgCommunicationPresence](Get-MgCommunicationPresence.md)
Get presences from communications

### [Get-MgCommunicationPresenceByUserId](Get-MgCommunicationPresenceByUserId.md)
Get the presence information for multiple users.

### [Get-MgUserOnlineMeeting](Get-MgUserOnlineMeeting.md)
Get onlineMeetings from users

### [Get-MgUserOnlineMeetingAlternativeRecording](Get-MgUserOnlineMeetingAlternativeRecording.md)
The content stream of the alternative recording of a Microsoft Teams live event.
Read-only.

### [Get-MgUserOnlineMeetingAttendanceReport](Get-MgUserOnlineMeetingAttendanceReport.md)
The attendance reports of an online meeting.
Read-only.

### [Get-MgUserOnlineMeetingAttendanceReportAttendanceRecord](Get-MgUserOnlineMeetingAttendanceReportAttendanceRecord.md)
List of attendance records of an attendance report.
Read-only.

### [Get-MgUserOnlineMeetingAttendeeReport](Get-MgUserOnlineMeetingAttendeeReport.md)
The content stream of the attendee report of a Teams live event.
Read-only.

### [Get-MgUserOnlineMeetingRecording](Get-MgUserOnlineMeetingRecording.md)
The content stream of the recording of a Teams live event.
Read-only.

### [Get-MgUserOnlineMeetingRegistration](Get-MgUserOnlineMeetingRegistration.md)
Get the externalMeetingRegistration details associated with an onlineMeeting.

### [Get-MgUserOnlineMeetingRegistrationCustomQuestion](Get-MgUserOnlineMeetingRegistrationCustomQuestion.md)
Custom registration questions.

### [Get-MgUserOnlineMeetingTranscript](Get-MgUserOnlineMeetingTranscript.md)
The transcripts of an online meeting.
Read-only.

### [Get-MgUserOnlineMeetingTranscriptContent](Get-MgUserOnlineMeetingTranscriptContent.md)
A field representing the content of the transcript.
Read-only.

### [Get-MgUserOnlineMeetingVirtualAppointment](Get-MgUserOnlineMeetingVirtualAppointment.md)
Get virtualAppointment from users

### [Get-MgUserPresence](Get-MgUserPresence.md)
Get a user's presence information.

### [Invoke-MgAnswerCommunicationCall](Invoke-MgAnswerCommunicationCall.md)
Enable a bot to answer an incoming call.
The incoming call request can be an invite from a participant in a group call or a peer-to-peer call.
If an invite to a group call is received, the notification will contain the chatInfo and meetingInfo parameters.
The bot is expected to answer, reject or redirect the call before the call times out.
The current timeout value is 15 seconds.
The current timeout value is 15 seconds for regular scenarios, and 5 seconds for policy-based recording scenarios.

### [Invoke-MgCreateOrGetCommunicationOnlineMeeting](Invoke-MgCreateOrGetCommunicationOnlineMeeting.md)
Create an onlineMeeting object with a custom specified external ID.
If the external ID already exists, this API will return the onlineMeeting object with that external ID.

### [Invoke-MgInviteCommunicationCallParticipant](Invoke-MgInviteCommunicationCallParticipant.md)
Delete a specific participant in a call.
In some situations, it is appropriate for an application to remove a participant from an active call.
This action can be done before or after the participant answers the call.
When an active caller is removed, they are immediately dropped from the call with no pre- or post-removal notification.
When an invited participant is removed, any outstanding add participant request is canceled.

### [Invoke-MgKeepCommunicationCallAlive](Invoke-MgKeepCommunicationCallAlive.md)
Make a request to this API every 15 to 45 minutes to ensure that an ongoing call remains active.
A call that does not receive this request within 45 minutes is considered inactive and will subsequently end.
At least one successful request must be made within 45 minutes of the previous request, or the start of the call.
We recommend that you send a request in shorter time intervals (every 15 minutes).
Make sure that these requests are successful to prevent the call from timing out and ending.
Attempting to send a request to a call that has already ended will result in a `404 Not-Found` error.
The resources related to the call should be cleaned up on the application side.

### [Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality](Invoke-MgLogCommunicationCallTeleconferenceDeviceQuality.md)
Log video teleconferencing device quality data.
The Cloud Video Interop (CVI) bot represents video teleconferencing (VTC) devices and acts as a back-to-back agent for a VTC device in a conference call.
Because a CVI bot is in the middle of the VTC and Microsoft Teams infrastructure as a VTC proxy, it has two media legs.
One media leg is between the CVI bot and Teams infrastructure, such as Teams conference server or a Teams client.
The other media leg is between the CVI bot and the VTC device.
The third-party partners own the VTC media leg and the Teams infrastructure cannot access the quality data of the third-party call leg.
This method is only for the CVI partners to provide their media quality data.

### [Invoke-MgMuteAllCommunicationCallParticipant](Invoke-MgMuteAllCommunicationCallParticipant.md)
Mute all participants in the call.

### [Invoke-MgMuteCommunicationCall](Invoke-MgMuteCommunicationCall.md)
Allows the application to mute itself.
This is a server mute, meaning that the server will drop all audio packets for this participant, even if the participant continues to stream audio.
For more details about how to handle mute operations, see muteParticipantOperation

### [Invoke-MgMuteCommunicationCallParticipant](Invoke-MgMuteCommunicationCallParticipant.md)
Mute a specific participant in the call.
This is a server mute, meaning that the server will drop all audio packets for this participant, even if the participant continues to stream audio.
For more information about how to handle mute operations, see muteParticipantOperation.

### [Invoke-MgPlayCommunicationCallPrompt](Invoke-MgPlayCommunicationCallPrompt.md)
Play a prompt in the call.
For more information about how to handle operations, see commsOperation

### [Invoke-MgRecordCommunicationCall](Invoke-MgRecordCommunicationCall.md)
Invoke action record

### [Invoke-MgRecordCommunicationCallResponse](Invoke-MgRecordCommunicationCallResponse.md)
Record a short audio response from the caller.
A bot can use this to capture a voice response from a caller after they are prompted for a response.
For more information about how to handle operations, see commsOperation This action is not intended to record the entire call.
The maximum length of recording is 2 minutes.
The recording is not saved permanently by the by the Cloud Communications Platform and is discarded shortly after the call ends.
The bot must download the recording promptly after the recording operation finishes by using the recordingLocation value that's given in the completed notification.

### [Invoke-MgRedirectCommunicationCall](Invoke-MgRedirectCommunicationCall.md)
Redirect an incoming call that hasn't been answered or rejected yet.
The terms 'redirecting' and 'forwarding' a call are used interchangeably.
The bot is expected to redirect the call before the call times out.
The current timeout value is 15 seconds.

### [Invoke-MgRejectCommunicationCall](Invoke-MgRejectCommunicationCall.md)
Enable a bot to reject an incoming call.
The incoming call request can be an invite from a participant in a group call or a peer-to-peer call.
If an invite to a group call is received, the notification will contain the **chatInfo** and **meetingInfo** parameters.
The bot is expected to answer or reject the call before the call times out.
The current timeout value is 15 seconds.
This API does not end existing calls that have already been answered.
Use delete call to end a call.

### [Invoke-MgSubscribeCommunicationCallToTone](Invoke-MgSubscribeCommunicationCallToTone.md)
Subscribe to DTMF (dual-tone multi-frequency signaling).
This allows you to be notified when the user presses keys on a 'Dialpad'.

### [Invoke-MgUnmuteCommunicationCall](Invoke-MgUnmuteCommunicationCall.md)
Allow the application to unmute itself.
This is a server unmute, meaning that the server will start sending audio packets for this participant to other participants again.
For more information about how to handle unmute operations, see unmuteParticipantOperation.

### [Move-MgCommunicationCall](Move-MgCommunicationCall.md)
Transfer an active peer-to-peer call or group call.
A consultative transfer means that the transferor can inform the person they want to transfer the call to (the transferee), before the transfer is made.
This is opposed to transfering the call directly.

### [New-MgCommunicationCall](New-MgCommunicationCall.md)
Create call enables your bot to create a new outgoing peer-to-peer or group call, or join an existing meeting.
You will need to register the calling bot and go through the list of permissions needed.

### [New-MgCommunicationCallAudioRoutingGroup](New-MgCommunicationCallAudioRoutingGroup.md)
Create a new **audioRoutingGroup**.

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

### [New-MgCommunicationOnlineMeetingRegistrationCustomQuestion](New-MgCommunicationOnlineMeetingRegistrationCustomQuestion.md)
Create a custom registration question associated with a meetingRegistration object on behalf of the organizer.

### [New-MgCommunicationOnlineMeetingTranscript](New-MgCommunicationOnlineMeetingTranscript.md)
Create new navigation property to transcripts for communications

### [New-MgCommunicationPresence](New-MgCommunicationPresence.md)
Create new navigation property to presences for communications

### [New-MgUserOnlineMeeting](New-MgUserOnlineMeeting.md)
Create an online meeting on behalf of a user.

### [New-MgUserOnlineMeetingAttendanceReport](New-MgUserOnlineMeetingAttendanceReport.md)
Create new navigation property to attendanceReports for users

### [New-MgUserOnlineMeetingAttendanceReportAttendanceRecord](New-MgUserOnlineMeetingAttendanceReportAttendanceRecord.md)
Create new navigation property to attendanceRecords for users

### [New-MgUserOnlineMeetingRegistrationCustomQuestion](New-MgUserOnlineMeetingRegistrationCustomQuestion.md)
Create a custom registration question associated with a meetingRegistration object on behalf of the organizer.

### [New-MgUserOnlineMeetingTranscript](New-MgUserOnlineMeetingTranscript.md)
Create new navigation property to transcripts for users

### [Remove-MgCommunicationCall](Remove-MgCommunicationCall.md)
Delete navigation property calls for communications

### [Remove-MgCommunicationCallAudioRoutingGroup](Remove-MgCommunicationCallAudioRoutingGroup.md)
Delete navigation property audioRoutingGroups for communications

### [Remove-MgCommunicationCallContentSharingSession](Remove-MgCommunicationCallContentSharingSession.md)
Delete navigation property contentSharingSessions for communications

### [Remove-MgCommunicationCallOperation](Remove-MgCommunicationCallOperation.md)
Delete navigation property operations for communications

### [Remove-MgCommunicationCallParticipant](Remove-MgCommunicationCallParticipant.md)
Delete navigation property participants for communications

### [Remove-MgCommunicationCallRecordSession](Remove-MgCommunicationCallRecordSession.md)
Delete navigation property sessions for communications

### [Remove-MgCommunicationOnlineMeeting](Remove-MgCommunicationOnlineMeeting.md)
Delete navigation property onlineMeetings for communications

### [Remove-MgCommunicationOnlineMeetingAttendanceReport](Remove-MgCommunicationOnlineMeetingAttendanceReport.md)
Delete navigation property attendanceReports for communications

### [Remove-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord](Remove-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
Delete navigation property attendanceRecords for communications

### [Remove-MgCommunicationOnlineMeetingRegistration](Remove-MgCommunicationOnlineMeetingRegistration.md)
Disable and delete the meetingRegistration of an onlineMeeting on behalf of the organizer.

### [Remove-MgCommunicationOnlineMeetingRegistrationCustomQuestion](Remove-MgCommunicationOnlineMeetingRegistrationCustomQuestion.md)
Delete navigation property customQuestions for communications

### [Remove-MgCommunicationOnlineMeetingTranscript](Remove-MgCommunicationOnlineMeetingTranscript.md)
Delete navigation property transcripts for communications

### [Remove-MgCommunicationOnlineMeetingVirtualAppointment](Remove-MgCommunicationOnlineMeetingVirtualAppointment.md)
Delete navigation property virtualAppointment for communications

### [Remove-MgCommunicationPresence](Remove-MgCommunicationPresence.md)
Delete navigation property presences for communications

### [Remove-MgUserOnlineMeeting](Remove-MgUserOnlineMeeting.md)
Delete navigation property onlineMeetings for users

### [Remove-MgUserOnlineMeetingAttendanceReport](Remove-MgUserOnlineMeetingAttendanceReport.md)
Delete navigation property attendanceReports for users

### [Remove-MgUserOnlineMeetingAttendanceReportAttendanceRecord](Remove-MgUserOnlineMeetingAttendanceReportAttendanceRecord.md)
Delete navigation property attendanceRecords for users

### [Remove-MgUserOnlineMeetingRegistration](Remove-MgUserOnlineMeetingRegistration.md)
Disable and delete the meetingRegistration of an onlineMeeting on behalf of the organizer.

### [Remove-MgUserOnlineMeetingRegistrationCustomQuestion](Remove-MgUserOnlineMeetingRegistrationCustomQuestion.md)
Delete navigation property customQuestions for users

### [Remove-MgUserOnlineMeetingTranscript](Remove-MgUserOnlineMeetingTranscript.md)
Delete navigation property transcripts for users

### [Remove-MgUserOnlineMeetingVirtualAppointment](Remove-MgUserOnlineMeetingVirtualAppointment.md)
Delete navigation property virtualAppointment for users

### [Remove-MgUserPresence](Remove-MgUserPresence.md)
Delete navigation property presence for users

### [Rename-MgCommunicationCallScreenSharingRole](Rename-MgCommunicationCallScreenSharingRole.md)
Allow applications to share screen content with the participants of a group call.

### [Set-MgCommunicationOnlineMeetingAlternativeRecording](Set-MgCommunicationOnlineMeetingAlternativeRecording.md)
The content stream of the alternative recording of a Microsoft Teams live event.
Read-only.

### [Set-MgCommunicationOnlineMeetingAttendeeReport](Set-MgCommunicationOnlineMeetingAttendeeReport.md)
The content stream of the attendee report of a Teams live event.
Read-only.

### [Set-MgCommunicationOnlineMeetingRecording](Set-MgCommunicationOnlineMeetingRecording.md)
The content stream of the recording of a Teams live event.
Read-only.

### [Set-MgCommunicationOnlineMeetingTranscriptContent](Set-MgCommunicationOnlineMeetingTranscriptContent.md)
A field representing the content of the transcript.
Read-only.

### [Set-MgCommunicationPresence](Set-MgCommunicationPresence.md)
Set the availability and activity status in a presence session of an application for a user.

### [Set-MgCommunicationPresenceUserPreferredPresence](Set-MgCommunicationPresenceUserPreferredPresence.md)
Set the preferred availability and activity status for a user.
If the preferred presence of a user is set, the user's presence is the preferred presence.
Preferred presence takes effect only when there is at least one presence session of the user.
Otherwise, the user's presence stays as Offline.
A presence session can be created as a result of a successful setPresence operation, or if the user is signed in on a Teams client.
Read more about presence sessions and their time-out and expiration.

### [Set-MgUserOnlineMeetingAlternativeRecording](Set-MgUserOnlineMeetingAlternativeRecording.md)
The content stream of the alternative recording of a Microsoft Teams live event.
Read-only.

### [Set-MgUserOnlineMeetingAttendeeReport](Set-MgUserOnlineMeetingAttendeeReport.md)
The content stream of the attendee report of a Teams live event.
Read-only.

### [Set-MgUserOnlineMeetingRecording](Set-MgUserOnlineMeetingRecording.md)
The content stream of the recording of a Teams live event.
Read-only.

### [Set-MgUserOnlineMeetingTranscriptContent](Set-MgUserOnlineMeetingTranscriptContent.md)
A field representing the content of the transcript.
Read-only.

### [Start-MgCommunicationCallParticipantHoldMusic](Start-MgCommunicationCallParticipantHoldMusic.md)
Put a participant on hold and play music in the background.

### [Stop-MgCommunicationCallMediaProcessing](Stop-MgCommunicationCallMediaProcessing.md)
Cancels processing for any in-progress media operations.
Media operations refer to the IVR operations playPrompt and recordResponse, which are by default queued to process in order.
The **cancelMediaProcessing** method cancels any operation that is in-process as well as operations that are queued.
For example, this API can be used to clean up the IVR operation queue for a new media operation.
However, it will not cancel a **ubscribeToTone** operation because it operates independent of any operation queue.

### [Stop-MgCommunicationCallParticipantHoldMusic](Stop-MgCommunicationCallParticipantHoldMusic.md)
Reincorporate a participant previously put on hold to the call.

### [Update-MgCommunicationCallAudioRoutingGroup](Update-MgCommunicationCallAudioRoutingGroup.md)
Update the navigation property audioRoutingGroups in communications

### [Update-MgCommunicationCallContentSharingSession](Update-MgCommunicationCallContentSharingSession.md)
Update the navigation property contentSharingSessions in communications

### [Update-MgCommunicationCallOperation](Update-MgCommunicationCallOperation.md)
Update the navigation property operations in communications

### [Update-MgCommunicationCallParticipant](Update-MgCommunicationCallParticipant.md)
Update the navigation property participants in communications

### [Update-MgCommunicationCallRecordingStatus](Update-MgCommunicationCallRecordingStatus.md)
Update the application's recording status associated with a call.
This requires the use of the Teams policy-based recording solution.

### [Update-MgCommunicationCallRecordSession](Update-MgCommunicationCallRecordSession.md)
Update the navigation property sessions in communications

### [Update-MgCommunicationOnlineMeeting](Update-MgCommunicationOnlineMeeting.md)
Update the navigation property onlineMeetings in communications

### [Update-MgCommunicationOnlineMeetingAttendanceReport](Update-MgCommunicationOnlineMeetingAttendanceReport.md)
Update the navigation property attendanceReports in communications

### [Update-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord](Update-MgCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
Update the navigation property attendanceRecords in communications

### [Update-MgCommunicationOnlineMeetingRegistration](Update-MgCommunicationOnlineMeetingRegistration.md)
Update the details of a meetingRegistration object assciated with an onlineMeeting on behalf of the organizer.

### [Update-MgCommunicationOnlineMeetingRegistrationCustomQuestion](Update-MgCommunicationOnlineMeetingRegistrationCustomQuestion.md)
Update the navigation property customQuestions in communications

### [Update-MgCommunicationOnlineMeetingTranscript](Update-MgCommunicationOnlineMeetingTranscript.md)
Update the navigation property transcripts in communications

### [Update-MgCommunicationOnlineMeetingVirtualAppointment](Update-MgCommunicationOnlineMeetingVirtualAppointment.md)
Update the navigation property virtualAppointment in communications

### [Update-MgCommunicationPresence](Update-MgCommunicationPresence.md)
Update the navigation property presences in communications

### [Update-MgUserOnlineMeeting](Update-MgUserOnlineMeeting.md)
Update the navigation property onlineMeetings in users

### [Update-MgUserOnlineMeetingAttendanceReport](Update-MgUserOnlineMeetingAttendanceReport.md)
Update the navigation property attendanceReports in users

### [Update-MgUserOnlineMeetingAttendanceReportAttendanceRecord](Update-MgUserOnlineMeetingAttendanceReportAttendanceRecord.md)
Update the navigation property attendanceRecords in users

### [Update-MgUserOnlineMeetingRegistration](Update-MgUserOnlineMeetingRegistration.md)
Update the details of a meetingRegistration object assciated with an onlineMeeting on behalf of the organizer.

### [Update-MgUserOnlineMeetingRegistrationCustomQuestion](Update-MgUserOnlineMeetingRegistrationCustomQuestion.md)
Update the navigation property customQuestions in users

### [Update-MgUserOnlineMeetingTranscript](Update-MgUserOnlineMeetingTranscript.md)
Update the navigation property transcripts in users

### [Update-MgUserOnlineMeetingVirtualAppointment](Update-MgUserOnlineMeetingVirtualAppointment.md)
Update the navigation property virtualAppointment in users

### [Update-MgUserPresence](Update-MgUserPresence.md)
Update the navigation property presence in users


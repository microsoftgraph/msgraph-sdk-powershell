---
Module Name: Microsoft.Graph.Beta.CloudCommunications
Module Guid: 5067629f-10f9-4f48-bf48-251ad1f02651
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.cloudcommunications
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.CloudCommunications Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.CloudCommunications Cmdlets
### [Add-MgBetaCommunicationCallLargeGalleryView](Add-MgBetaCommunicationCallLargeGalleryView.md)
Add the large gallery view to a call.
For details about how to identify a large gallery view participant in a roster so that you can retrieve the relevant data to subscribe to the video feed, see Identify large gallery view participants in a roster.

### [Clear-MgBetaCommunicationPresence](Clear-MgBetaCommunicationPresence.md)
Clear a presence session of an application for a user.
If it is the user's only presence session, a successful **clearPresence** changes the user's presence to `Offline/Offline`.
Read more about presence sessions and their time-out and expiration.

### [Clear-MgBetaCommunicationPresenceUserPreferredPresence](Clear-MgBetaCommunicationPresenceUserPreferredPresence.md)
Clear the preferred availability and activity status for a user.

### [Get-MgBetaCommunicationCall](Get-MgBetaCommunicationCall.md)
Retrieve the properties and relationships of a call object.

### [Get-MgBetaCommunicationCallAudioRoutingGroup](Get-MgBetaCommunicationCallAudioRoutingGroup.md)
Retrieve the properties and relationships of an audioRoutingGroup object.

### [Get-MgBetaCommunicationCallAudioRoutingGroupCount](Get-MgBetaCommunicationCallAudioRoutingGroupCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationCallContentSharingSession](Get-MgBetaCommunicationCallContentSharingSession.md)
Retrieve the properties of a contentSharingSession object.

### [Get-MgBetaCommunicationCallContentSharingSessionCount](Get-MgBetaCommunicationCallContentSharingSessionCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationCallCount](Get-MgBetaCommunicationCallCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationCallOperation](Get-MgBetaCommunicationCallOperation.md)
Get the status of an operation that adds the large gallery view to a call.

### [Get-MgBetaCommunicationCallOperationCount](Get-MgBetaCommunicationCallOperationCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationCallParticipant](Get-MgBetaCommunicationCallParticipant.md)
Retrieve the properties and relationships of a **participant** object.

### [Get-MgBetaCommunicationCallParticipantCount](Get-MgBetaCommunicationCallParticipantCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationCallRecord](Get-MgBetaCommunicationCallRecord.md)
Retrieve the properties and relationships of a callRecord object.
There are two ways to get the **id** of a **callRecord**:

### [Get-MgBetaCommunicationCallRecordCount](Get-MgBetaCommunicationCallRecordCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationCallRecordPstnBlockedUserLog](Get-MgBetaCommunicationCallRecordPstnBlockedUserLog.md)
Invoke function getPstnBlockedUsersLog

### [Get-MgBetaCommunicationCallRecordPstnOnlineMeetingDialoutReport](Get-MgBetaCommunicationCallRecordPstnOnlineMeetingDialoutReport.md)
Invoke function getPstnOnlineMeetingDialoutReport

### [Get-MgBetaCommunicationCallRecordSession](Get-MgBetaCommunicationCallRecordSession.md)
List of sessions involved in the call.
Peer-to-peer calls typically only have one session, whereas group calls typically have at least one session per participant.
Read-only.
Nullable.

### [Get-MgBetaCommunicationCallRecordSessionCount](Get-MgBetaCommunicationCallRecordSessionCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationCallRecordSessionSegmentCount](Get-MgBetaCommunicationCallRecordSessionSegmentCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationCallRecordSmLog](Get-MgBetaCommunicationCallRecordSmLog.md)
Invoke function getSmsLog

### [Get-MgBetaCommunicationOnlineMeeting](Get-MgBetaCommunicationOnlineMeeting.md)
Get onlineMeetings from communications

### [Get-MgBetaCommunicationOnlineMeetingAlternativeRecording](Get-MgBetaCommunicationOnlineMeetingAlternativeRecording.md)
The content stream of the alternative recording of a Microsoft Teams live event.
Read-only.

### [Get-MgBetaCommunicationOnlineMeetingAttendanceReport](Get-MgBetaCommunicationOnlineMeetingAttendanceReport.md)
Get the meetingAttendanceReport for an onlineMeeting.
Each time an online meeting ends, an attendance report will be generated for that session.

### [Get-MgBetaCommunicationOnlineMeetingAttendanceReportAttendanceRecord](Get-MgBetaCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
List of attendance records of an attendance report.
Read-only.

### [Get-MgBetaCommunicationOnlineMeetingAttendanceReportAttendanceRecordCount](Get-MgBetaCommunicationOnlineMeetingAttendanceReportAttendanceRecordCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationOnlineMeetingAttendanceReportCount](Get-MgBetaCommunicationOnlineMeetingAttendanceReportCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationOnlineMeetingAttendeeReport](Get-MgBetaCommunicationOnlineMeetingAttendeeReport.md)
The content stream of the attendee report of a Teams live event.
Read-only.

### [Get-MgBetaCommunicationOnlineMeetingCount](Get-MgBetaCommunicationOnlineMeetingCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationOnlineMeetingRecording](Get-MgBetaCommunicationOnlineMeetingRecording.md)
The content stream of the recording of a Teams live event.
Read-only.

### [Get-MgBetaCommunicationOnlineMeetingRegistration](Get-MgBetaCommunicationOnlineMeetingRegistration.md)
Get the externalMeetingRegistration details associated with an onlineMeeting.

### [Get-MgBetaCommunicationOnlineMeetingRegistrationCustomQuestion](Get-MgBetaCommunicationOnlineMeetingRegistrationCustomQuestion.md)
Get a custom registration question associated with a meetingRegistration object on behalf of the organizer.

### [Get-MgBetaCommunicationOnlineMeetingRegistrationCustomQuestionCount](Get-MgBetaCommunicationOnlineMeetingRegistrationCustomQuestionCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationOnlineMeetingRegistrationRegistrant](Get-MgBetaCommunicationOnlineMeetingRegistrationRegistrant.md)
Registrants of the online meeting.

### [Get-MgBetaCommunicationOnlineMeetingRegistrationRegistrantCount](Get-MgBetaCommunicationOnlineMeetingRegistrationRegistrantCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationOnlineMeetingTranscript](Get-MgBetaCommunicationOnlineMeetingTranscript.md)
Retrieve a callTranscript object associated with an onlineMeeting.
Retrieving the transcript returns the metadata of the single transcript associated with the online meeting.
Retrieving the content of the transcript returns the stream of text associated with the transcript.

### [Get-MgBetaCommunicationOnlineMeetingTranscriptContent](Get-MgBetaCommunicationOnlineMeetingTranscriptContent.md)
A field that represents the content of the transcript.
Read-only.

### [Get-MgBetaCommunicationOnlineMeetingTranscriptCount](Get-MgBetaCommunicationOnlineMeetingTranscriptCount.md)
Get the number of the resource

### [Get-MgBetaCommunicationOnlineMeetingTranscriptMetadataContent](Get-MgBetaCommunicationOnlineMeetingTranscriptMetadataContent.md)
A field that represents the time-aligned metadata of the utterances in the transcript.
Read-only.

### [Get-MgBetaCommunicationOnlineMeetingVirtualAppointment](Get-MgBetaCommunicationOnlineMeetingVirtualAppointment.md)
Get virtualAppointment from communications

### [Get-MgBetaCommunicationOnlineMeetingVirtualAppointmentJoinWebUrl](Get-MgBetaCommunicationOnlineMeetingVirtualAppointmentJoinWebUrl.md)
Invoke function getVirtualAppointmentJoinWebUrl

### [Get-MgBetaCommunicationPresence](Get-MgBetaCommunicationPresence.md)
Get a user's presence information.

### [Get-MgBetaCommunicationPresenceByUserId](Get-MgBetaCommunicationPresenceByUserId.md)
Get the presence information for multiple users.

### [Get-MgBetaCommunicationPresenceCount](Get-MgBetaCommunicationPresenceCount.md)
Get the number of the resource

### [Get-MgBetaUserOnlineMeeting](Get-MgBetaUserOnlineMeeting.md)
Get onlineMeetings from users

### [Get-MgBetaUserOnlineMeetingAlternativeRecording](Get-MgBetaUserOnlineMeetingAlternativeRecording.md)
The content stream of the alternative recording of a Microsoft Teams live event.
Read-only.

### [Get-MgBetaUserOnlineMeetingAttendanceReport](Get-MgBetaUserOnlineMeetingAttendanceReport.md)
Get the meetingAttendanceReport for an onlineMeeting.
Each time an online meeting ends, an attendance report will be generated for that session.

### [Get-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord](Get-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord.md)
List of attendance records of an attendance report.
Read-only.

### [Get-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecordCount](Get-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecordCount.md)
Get the number of the resource

### [Get-MgBetaUserOnlineMeetingAttendanceReportCount](Get-MgBetaUserOnlineMeetingAttendanceReportCount.md)
Get the number of the resource

### [Get-MgBetaUserOnlineMeetingAttendeeReport](Get-MgBetaUserOnlineMeetingAttendeeReport.md)
The content stream of the attendee report of a Teams live event.
Read-only.

### [Get-MgBetaUserOnlineMeetingCount](Get-MgBetaUserOnlineMeetingCount.md)
Get the number of the resource

### [Get-MgBetaUserOnlineMeetingRecording](Get-MgBetaUserOnlineMeetingRecording.md)
The content stream of the recording of a Teams live event.
Read-only.

### [Get-MgBetaUserOnlineMeetingRegistration](Get-MgBetaUserOnlineMeetingRegistration.md)
Get the externalMeetingRegistration details associated with an onlineMeeting.

### [Get-MgBetaUserOnlineMeetingRegistrationCustomQuestion](Get-MgBetaUserOnlineMeetingRegistrationCustomQuestion.md)
Get a custom registration question associated with a meetingRegistration object on behalf of the organizer.

### [Get-MgBetaUserOnlineMeetingRegistrationCustomQuestionCount](Get-MgBetaUserOnlineMeetingRegistrationCustomQuestionCount.md)
Get the number of the resource

### [Get-MgBetaUserOnlineMeetingRegistrationRegistrant](Get-MgBetaUserOnlineMeetingRegistrationRegistrant.md)
Registrants of the online meeting.

### [Get-MgBetaUserOnlineMeetingRegistrationRegistrantCount](Get-MgBetaUserOnlineMeetingRegistrationRegistrantCount.md)
Get the number of the resource

### [Get-MgBetaUserOnlineMeetingTranscript](Get-MgBetaUserOnlineMeetingTranscript.md)
Retrieve a callTranscript object associated with an onlineMeeting.
Retrieving the transcript returns the metadata of the single transcript associated with the online meeting.
Retrieving the content of the transcript returns the stream of text associated with the transcript.

### [Get-MgBetaUserOnlineMeetingTranscriptContent](Get-MgBetaUserOnlineMeetingTranscriptContent.md)
A field that represents the content of the transcript.
Read-only.

### [Get-MgBetaUserOnlineMeetingTranscriptCount](Get-MgBetaUserOnlineMeetingTranscriptCount.md)
Get the number of the resource

### [Get-MgBetaUserOnlineMeetingTranscriptMetadataContent](Get-MgBetaUserOnlineMeetingTranscriptMetadataContent.md)
A field that represents the time-aligned metadata of the utterances in the transcript.
Read-only.

### [Get-MgBetaUserOnlineMeetingVirtualAppointment](Get-MgBetaUserOnlineMeetingVirtualAppointment.md)
Get virtualAppointment from users

### [Get-MgBetaUserPresence](Get-MgBetaUserPresence.md)
Set a presence status message for a user.
An optional expiration date and time can be supplied.

### [Invoke-MgBetaAnswerCommunicationCall](Invoke-MgBetaAnswerCommunicationCall.md)
Enable a bot to answer an incoming call.
The incoming call request can be an invite from a participant in a group call or a peer-to-peer call.
If an invite to a group call is received, the notification will contain the chatInfo and meetingInfo parameters.
The bot is expected to answer, reject or redirect the call before the call times out.
The current timeout value is 15 seconds.
The current timeout value is 15 seconds for regular scenarios, and 5 seconds for policy-based recording scenarios.

### [Invoke-MgBetaCreateOrGetCommunicationOnlineMeeting](Invoke-MgBetaCreateOrGetCommunicationOnlineMeeting.md)
Create an onlineMeeting object with a custom specified external ID.
If the external ID already exists, this API will return the onlineMeeting object with that external ID.

### [Invoke-MgBetaInviteCommunicationCallParticipant](Invoke-MgBetaInviteCommunicationCallParticipant.md)
Delete a specific participant in a call.
In some situations, it is appropriate for an application to remove a participant from an active call.
This action can be done before or after the participant answers the call.
When an active caller is removed, they are immediately dropped from the call with no pre- or post-removal notification.
When an invited participant is removed, any outstanding add participant request is canceled.

### [Invoke-MgBetaKeepCommunicationCallAlive](Invoke-MgBetaKeepCommunicationCallAlive.md)
Make a request to this API every 15 to 45 minutes to ensure that an ongoing call remains active.
A call that does not receive this request within 45 minutes is considered inactive and will subsequently end.
At least one successful request must be made within 45 minutes of the previous request, or the start of the call.
We recommend that you send a request in shorter time intervals (every 15 minutes).
Make sure that these requests are successful to prevent the call from timing out and ending.
Attempting to send a request to a call that has already ended will result in a `404 Not-Found` error.
The resources related to the call should be cleaned up on the application side.

### [Invoke-MgBetaLogCommunicationCallTeleconferenceDeviceQuality](Invoke-MgBetaLogCommunicationCallTeleconferenceDeviceQuality.md)
Log video teleconferencing device quality data.
The Cloud Video Interop (CVI) bot represents video teleconferencing (VTC) devices and acts as a back-to-back agent for a VTC device in a conference call.
Because a CVI bot is in the middle of the VTC and Microsoft Teams infrastructure as a VTC proxy, it has two media legs.
One media leg is between the CVI bot and Teams infrastructure, such as Teams conference server or a Teams client.
The other media leg is between the CVI bot and the VTC device.
The third-party partners own the VTC media leg and the Teams infrastructure cannot access the quality data of the third-party call leg.
This method is only for the CVI partners to provide their media quality data.

### [Invoke-MgBetaMuteAllCommunicationCallParticipant](Invoke-MgBetaMuteAllCommunicationCallParticipant.md)
Mute all participants in the call.

### [Invoke-MgBetaMuteCommunicationCall](Invoke-MgBetaMuteCommunicationCall.md)
Allows the application to mute itself.
This is a server mute, meaning that the server will drop all audio packets for this participant, even if the participant continues to stream audio.
For more details about how to handle mute operations, see muteParticipantOperation

### [Invoke-MgBetaMuteCommunicationCallParticipant](Invoke-MgBetaMuteCommunicationCallParticipant.md)
Mute a specific participant in the call.
This is a server mute, meaning that the server will drop all audio packets for this participant, even if the participant continues to stream audio.
For more information about how to handle mute operations, see muteParticipantOperation.

### [Invoke-MgBetaPlayCommunicationCallPrompt](Invoke-MgBetaPlayCommunicationCallPrompt.md)
Play a prompt in the call.
For more information about how to handle operations, see commsOperation

### [Invoke-MgBetaRecordCommunicationCall](Invoke-MgBetaRecordCommunicationCall.md)
Invoke action record

### [Invoke-MgBetaRecordCommunicationCallResponse](Invoke-MgBetaRecordCommunicationCallResponse.md)
Record a short audio response from the caller.
A bot can use this to capture a voice response from a caller after they are prompted for a response.
For more information about how to handle operations, see commsOperation This action is not intended to record the entire call.
The maximum length of recording is 2 minutes.
The recording is not saved permanently by the by the Cloud Communications Platform and is discarded shortly after the call ends.
The bot must download the recording promptly after the recording operation finishes by using the recordingLocation value that's given in the completed notification.

### [Invoke-MgBetaRedirectCommunicationCall](Invoke-MgBetaRedirectCommunicationCall.md)
Redirect an incoming call that hasn't been answered or rejected yet.
The terms 'redirecting' and 'forwarding' a call are used interchangeably.
The bot is expected to redirect the call before the call times out.
The current timeout value is 15 seconds.

### [Invoke-MgBetaRejectCommunicationCall](Invoke-MgBetaRejectCommunicationCall.md)
Enable a bot to reject an incoming call.
The incoming call request can be an invite from a participant in a group call or a peer-to-peer call.
If an invite to a group call is received, the notification will contain the **chatInfo** and **meetingInfo** parameters.
The bot is expected to answer or reject the call before the call times out.
The current timeout value is 15 seconds.
This API does not end existing calls that have already been answered.
Use delete call to end a call.

### [Invoke-MgBetaSubscribeCommunicationCallToTone](Invoke-MgBetaSubscribeCommunicationCallToTone.md)
Subscribe to DTMF (dual-tone multi-frequency signaling).
This allows you to be notified when the user presses keys on a 'Dialpad'.

### [Invoke-MgBetaUnmuteCommunicationCall](Invoke-MgBetaUnmuteCommunicationCall.md)
Allow the application to unmute itself.
This is a server unmute, meaning that the server will start sending audio packets for this participant to other participants again.
For more information about how to handle unmute operations, see unmuteParticipantOperation.

### [Move-MgBetaCommunicationCall](Move-MgBetaCommunicationCall.md)
Transfer an active peer-to-peer call or group call.
A consultative transfer means that the transferor can inform the person they want to transfer the call to (the transferee), before the transfer is made.
This is opposed to transfering the call directly.

### [New-MgBetaCommunicationCall](New-MgBetaCommunicationCall.md)
Create call enables your bot to create a new outgoing peer-to-peer or group call, or join an existing meeting.
You will need to register the calling bot and go through the list of permissions needed.

### [New-MgBetaCommunicationCallAudioRoutingGroup](New-MgBetaCommunicationCallAudioRoutingGroup.md)
Create a new **audioRoutingGroup**.

### [New-MgBetaCommunicationCallContentSharingSession](New-MgBetaCommunicationCallContentSharingSession.md)
Create new navigation property to contentSharingSessions for communications

### [New-MgBetaCommunicationCallOperation](New-MgBetaCommunicationCallOperation.md)
Create new navigation property to operations for communications

### [New-MgBetaCommunicationCallParticipant](New-MgBetaCommunicationCallParticipant.md)
Create new navigation property to participants for communications

### [New-MgBetaCommunicationCallRecordSession](New-MgBetaCommunicationCallRecordSession.md)
Create new navigation property to sessions for communications

### [New-MgBetaCommunicationOnlineMeeting](New-MgBetaCommunicationOnlineMeeting.md)
Create new navigation property to onlineMeetings for communications

### [New-MgBetaCommunicationOnlineMeetingAttendanceReport](New-MgBetaCommunicationOnlineMeetingAttendanceReport.md)
Create new navigation property to attendanceReports for communications

### [New-MgBetaCommunicationOnlineMeetingAttendanceReportAttendanceRecord](New-MgBetaCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
Create new navigation property to attendanceRecords for communications

### [New-MgBetaCommunicationOnlineMeetingRegistrationCustomQuestion](New-MgBetaCommunicationOnlineMeetingRegistrationCustomQuestion.md)
Create a custom registration question associated with a meetingRegistration object on behalf of the organizer.

### [New-MgBetaCommunicationOnlineMeetingRegistrationRegistrant](New-MgBetaCommunicationOnlineMeetingRegistrationRegistrant.md)
Create new navigation property to registrants for communications

### [New-MgBetaCommunicationOnlineMeetingTranscript](New-MgBetaCommunicationOnlineMeetingTranscript.md)
Create new navigation property to transcripts for communications

### [New-MgBetaCommunicationPresence](New-MgBetaCommunicationPresence.md)
Create new navigation property to presences for communications

### [New-MgBetaUserOnlineMeeting](New-MgBetaUserOnlineMeeting.md)
Create an online meeting on behalf of a user.

### [New-MgBetaUserOnlineMeetingAttendanceReport](New-MgBetaUserOnlineMeetingAttendanceReport.md)
Create new navigation property to attendanceReports for users

### [New-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord](New-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord.md)
Create new navigation property to attendanceRecords for users

### [New-MgBetaUserOnlineMeetingRegistrationCustomQuestion](New-MgBetaUserOnlineMeetingRegistrationCustomQuestion.md)
Create a custom registration question associated with a meetingRegistration object on behalf of the organizer.

### [New-MgBetaUserOnlineMeetingRegistrationRegistrant](New-MgBetaUserOnlineMeetingRegistrationRegistrant.md)
Create new navigation property to registrants for users

### [New-MgBetaUserOnlineMeetingTranscript](New-MgBetaUserOnlineMeetingTranscript.md)
Create new navigation property to transcripts for users

### [Remove-MgBetaCommunicationCall](Remove-MgBetaCommunicationCall.md)
Delete or hang up an active call.
For group calls, this will only delete your call leg and the underlying group call will still continue.

### [Remove-MgBetaCommunicationCallAudioRoutingGroup](Remove-MgBetaCommunicationCallAudioRoutingGroup.md)
Delete the specified audioRoutingGroup.

### [Remove-MgBetaCommunicationCallContentSharingSession](Remove-MgBetaCommunicationCallContentSharingSession.md)
Delete navigation property contentSharingSessions for communications

### [Remove-MgBetaCommunicationCallOperation](Remove-MgBetaCommunicationCallOperation.md)
Delete navigation property operations for communications

### [Remove-MgBetaCommunicationCallParticipant](Remove-MgBetaCommunicationCallParticipant.md)
Delete a specific participant in a call.
In some situations, it is appropriate for an application to remove a participant from an active call.
This action can be done before or after the participant answers the call.
When an active caller is removed, they are immediately dropped from the call with no pre- or post-removal notification.
When an invited participant is removed, any outstanding add participant request is canceled.

### [Remove-MgBetaCommunicationCallRecordSession](Remove-MgBetaCommunicationCallRecordSession.md)
Delete navigation property sessions for communications

### [Remove-MgBetaCommunicationOnlineMeeting](Remove-MgBetaCommunicationOnlineMeeting.md)
Delete navigation property onlineMeetings for communications

### [Remove-MgBetaCommunicationOnlineMeetingAttendanceReport](Remove-MgBetaCommunicationOnlineMeetingAttendanceReport.md)
Delete navigation property attendanceReports for communications

### [Remove-MgBetaCommunicationOnlineMeetingAttendanceReportAttendanceRecord](Remove-MgBetaCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
Delete navigation property attendanceRecords for communications

### [Remove-MgBetaCommunicationOnlineMeetingRegistration](Remove-MgBetaCommunicationOnlineMeetingRegistration.md)
Disable and delete the meetingRegistration of an onlineMeeting on behalf of the organizer.

### [Remove-MgBetaCommunicationOnlineMeetingRegistrationCustomQuestion](Remove-MgBetaCommunicationOnlineMeetingRegistrationCustomQuestion.md)
Delete a custom registration question from a meetingRegistration object on behalf of the organizer.

### [Remove-MgBetaCommunicationOnlineMeetingRegistrationRegistrant](Remove-MgBetaCommunicationOnlineMeetingRegistrationRegistrant.md)
Delete navigation property registrants for communications

### [Remove-MgBetaCommunicationOnlineMeetingTranscript](Remove-MgBetaCommunicationOnlineMeetingTranscript.md)
Delete navigation property transcripts for communications

### [Remove-MgBetaCommunicationOnlineMeetingVirtualAppointment](Remove-MgBetaCommunicationOnlineMeetingVirtualAppointment.md)
Delete navigation property virtualAppointment for communications

### [Remove-MgBetaCommunicationPresence](Remove-MgBetaCommunicationPresence.md)
Delete navigation property presences for communications

### [Remove-MgBetaUserOnlineMeeting](Remove-MgBetaUserOnlineMeeting.md)
Delete an onlineMeeting object.

### [Remove-MgBetaUserOnlineMeetingAttendanceReport](Remove-MgBetaUserOnlineMeetingAttendanceReport.md)
Delete navigation property attendanceReports for users

### [Remove-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord](Remove-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord.md)
Delete navigation property attendanceRecords for users

### [Remove-MgBetaUserOnlineMeetingRegistration](Remove-MgBetaUserOnlineMeetingRegistration.md)
Disable and delete the meetingRegistration of an onlineMeeting on behalf of the organizer.

### [Remove-MgBetaUserOnlineMeetingRegistrationCustomQuestion](Remove-MgBetaUserOnlineMeetingRegistrationCustomQuestion.md)
Delete a custom registration question from a meetingRegistration object on behalf of the organizer.

### [Remove-MgBetaUserOnlineMeetingRegistrationRegistrant](Remove-MgBetaUserOnlineMeetingRegistrationRegistrant.md)
Delete navigation property registrants for users

### [Remove-MgBetaUserOnlineMeetingTranscript](Remove-MgBetaUserOnlineMeetingTranscript.md)
Delete navigation property transcripts for users

### [Remove-MgBetaUserOnlineMeetingVirtualAppointment](Remove-MgBetaUserOnlineMeetingVirtualAppointment.md)
Delete navigation property virtualAppointment for users

### [Remove-MgBetaUserPresence](Remove-MgBetaUserPresence.md)
Delete navigation property presence for users

### [Rename-MgBetaCommunicationCallScreenSharingRole](Rename-MgBetaCommunicationCallScreenSharingRole.md)
Allow applications to share screen content with the participants of a group call.

### [Set-MgBetaCommunicationOnlineMeetingAlternativeRecording](Set-MgBetaCommunicationOnlineMeetingAlternativeRecording.md)
The content stream of the alternative recording of a Microsoft Teams live event.
Read-only.

### [Set-MgBetaCommunicationOnlineMeetingAttendeeReport](Set-MgBetaCommunicationOnlineMeetingAttendeeReport.md)
The content stream of the attendee report of a Teams live event.
Read-only.

### [Set-MgBetaCommunicationOnlineMeetingRecording](Set-MgBetaCommunicationOnlineMeetingRecording.md)
The content stream of the recording of a Teams live event.
Read-only.

### [Set-MgBetaCommunicationOnlineMeetingTranscriptContent](Set-MgBetaCommunicationOnlineMeetingTranscriptContent.md)
A field that represents the content of the transcript.
Read-only.

### [Set-MgBetaCommunicationOnlineMeetingTranscriptMetadataContent](Set-MgBetaCommunicationOnlineMeetingTranscriptMetadataContent.md)
A field that represents the time-aligned metadata of the utterances in the transcript.
Read-only.

### [Set-MgBetaCommunicationPresence](Set-MgBetaCommunicationPresence.md)
Set the availability and activity status in a presence session of an application for a user.

### [Set-MgBetaCommunicationPresenceStatusMessage](Set-MgBetaCommunicationPresenceStatusMessage.md)
Set a presence status message for a user.
An optional expiration date and time can be supplied.

### [Set-MgBetaCommunicationPresenceUserPreferredPresence](Set-MgBetaCommunicationPresenceUserPreferredPresence.md)
Set the preferred availability and activity status for a user.
If the preferred presence of a user is set, the user's presence is the preferred presence.
Preferred presence takes effect only when there is at least one presence session of the user.
Otherwise, the user's presence stays as Offline.
A presence session can be created as a result of a successful setPresence operation, or if the user is signed in on a Teams client.
Read more about presence sessions and their time-out and expiration.

### [Set-MgBetaUserOnlineMeetingAlternativeRecording](Set-MgBetaUserOnlineMeetingAlternativeRecording.md)
The content stream of the alternative recording of a Microsoft Teams live event.
Read-only.

### [Set-MgBetaUserOnlineMeetingAttendeeReport](Set-MgBetaUserOnlineMeetingAttendeeReport.md)
The content stream of the attendee report of a Teams live event.
Read-only.

### [Set-MgBetaUserOnlineMeetingRecording](Set-MgBetaUserOnlineMeetingRecording.md)
The content stream of the recording of a Teams live event.
Read-only.

### [Set-MgBetaUserOnlineMeetingTranscriptContent](Set-MgBetaUserOnlineMeetingTranscriptContent.md)
A field that represents the content of the transcript.
Read-only.

### [Set-MgBetaUserOnlineMeetingTranscriptMetadataContent](Set-MgBetaUserOnlineMeetingTranscriptMetadataContent.md)
A field that represents the time-aligned metadata of the utterances in the transcript.
Read-only.

### [Start-MgBetaCommunicationCallParticipantHoldMusic](Start-MgBetaCommunicationCallParticipantHoldMusic.md)
Put a participant on hold and play music in the background.

### [Stop-MgBetaCommunicationCallMediaProcessing](Stop-MgBetaCommunicationCallMediaProcessing.md)
Cancels processing for any in-progress media operations.
Media operations refer to the IVR operations playPrompt and recordResponse, which are by default queued to process in order.
The **cancelMediaProcessing** method cancels any operation that is in-process as well as operations that are queued.
For example, this API can be used to clean up the IVR operation queue for a new media operation.
However, it will not cancel a **ubscribeToTone** operation because it operates independent of any operation queue.

### [Stop-MgBetaCommunicationCallParticipantHoldMusic](Stop-MgBetaCommunicationCallParticipantHoldMusic.md)
Reincorporate a participant previously put on hold to the call.

### [Update-MgBetaCommunicationCallAudioRoutingGroup](Update-MgBetaCommunicationCallAudioRoutingGroup.md)
Modify sources and receivers of an audioRoutingGroup.

### [Update-MgBetaCommunicationCallContentSharingSession](Update-MgBetaCommunicationCallContentSharingSession.md)
Update the navigation property contentSharingSessions in communications

### [Update-MgBetaCommunicationCallOperation](Update-MgBetaCommunicationCallOperation.md)
Update the navigation property operations in communications

### [Update-MgBetaCommunicationCallParticipant](Update-MgBetaCommunicationCallParticipant.md)
Update the navigation property participants in communications

### [Update-MgBetaCommunicationCallRecordingStatus](Update-MgBetaCommunicationCallRecordingStatus.md)
Update the application's recording status associated with a call.
This requires the use of the Teams policy-based recording solution.

### [Update-MgBetaCommunicationCallRecordSession](Update-MgBetaCommunicationCallRecordSession.md)
Update the navigation property sessions in communications

### [Update-MgBetaCommunicationOnlineMeeting](Update-MgBetaCommunicationOnlineMeeting.md)
Update the navigation property onlineMeetings in communications

### [Update-MgBetaCommunicationOnlineMeetingAttendanceReport](Update-MgBetaCommunicationOnlineMeetingAttendanceReport.md)
Update the navigation property attendanceReports in communications

### [Update-MgBetaCommunicationOnlineMeetingAttendanceReportAttendanceRecord](Update-MgBetaCommunicationOnlineMeetingAttendanceReportAttendanceRecord.md)
Update the navigation property attendanceRecords in communications

### [Update-MgBetaCommunicationOnlineMeetingRegistration](Update-MgBetaCommunicationOnlineMeetingRegistration.md)
Update the details of a meetingRegistration object assciated with an onlineMeeting on behalf of the organizer.

### [Update-MgBetaCommunicationOnlineMeetingRegistrationCustomQuestion](Update-MgBetaCommunicationOnlineMeetingRegistrationCustomQuestion.md)
Update a custom registration question associated with a meetingRegistration object on behalf of the organizer.

### [Update-MgBetaCommunicationOnlineMeetingRegistrationRegistrant](Update-MgBetaCommunicationOnlineMeetingRegistrationRegistrant.md)
Update the navigation property registrants in communications

### [Update-MgBetaCommunicationOnlineMeetingTranscript](Update-MgBetaCommunicationOnlineMeetingTranscript.md)
Update the navigation property transcripts in communications

### [Update-MgBetaCommunicationOnlineMeetingVirtualAppointment](Update-MgBetaCommunicationOnlineMeetingVirtualAppointment.md)
Update the navigation property virtualAppointment in communications

### [Update-MgBetaCommunicationPresence](Update-MgBetaCommunicationPresence.md)
Update the navigation property presences in communications

### [Update-MgBetaUserOnlineMeeting](Update-MgBetaUserOnlineMeeting.md)
Update the properties of the specified onlineMeeting object.
Please see Request body section for the list of properties that support updating.

### [Update-MgBetaUserOnlineMeetingAttendanceReport](Update-MgBetaUserOnlineMeetingAttendanceReport.md)
Update the navigation property attendanceReports in users

### [Update-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord](Update-MgBetaUserOnlineMeetingAttendanceReportAttendanceRecord.md)
Update the navigation property attendanceRecords in users

### [Update-MgBetaUserOnlineMeetingRegistration](Update-MgBetaUserOnlineMeetingRegistration.md)
Update the details of a meetingRegistration object assciated with an onlineMeeting on behalf of the organizer.

### [Update-MgBetaUserOnlineMeetingRegistrationCustomQuestion](Update-MgBetaUserOnlineMeetingRegistrationCustomQuestion.md)
Update a custom registration question associated with a meetingRegistration object on behalf of the organizer.

### [Update-MgBetaUserOnlineMeetingRegistrationRegistrant](Update-MgBetaUserOnlineMeetingRegistrationRegistrant.md)
Update the navigation property registrants in users

### [Update-MgBetaUserOnlineMeetingTranscript](Update-MgBetaUserOnlineMeetingTranscript.md)
Update the navigation property transcripts in users

### [Update-MgBetaUserOnlineMeetingVirtualAppointment](Update-MgBetaUserOnlineMeetingVirtualAppointment.md)
Update the navigation property virtualAppointment in users

### [Update-MgBetaUserPresence](Update-MgBetaUserPresence.md)
Update the navigation property presence in users


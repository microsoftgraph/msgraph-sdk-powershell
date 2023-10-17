---
Module Name: Microsoft.Graph.Calendar
Module Guid: 4cb73b44-8cc6-49af-9348-b9ce70bdf042
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.calendar
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Calendar Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Calendar Cmdlets
### [Get-MgGroupCalendar](Get-MgGroupCalendar.md)
The group's calendar.
Read-only.

### [Get-MgGroupCalendarEvent](Get-MgGroupCalendarEvent.md)
The events in the calendar.
Navigation property.
Read-only.

### [Get-MgGroupCalendarPermission](Get-MgGroupCalendarPermission.md)
Get the specified permissions object of a user or group calendar that has been shared.
This API is available in the following national cloud deployments.

### [Get-MgGroupCalendarPermissionCount](Get-MgGroupCalendarPermissionCount.md)
Get the number of the resource

### [Get-MgGroupCalendarView](Get-MgGroupCalendarView.md)
The calendar view for the calendar.
Navigation property.
Read-only.

### [Get-MgGroupEvent](Get-MgGroupEvent.md)
Get an event object.
This API is available in the following national cloud deployments.

### [Get-MgGroupEventAttachment](Get-MgGroupEventAttachment.md)
The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event.
Navigation property.
Read-only.
Nullable.

### [Get-MgGroupEventAttachmentCount](Get-MgGroupEventAttachmentCount.md)
Get the number of the resource

### [Get-MgGroupEventCalendar](Get-MgGroupEventCalendar.md)
The calendar that contains the event.
Navigation property.
Read-only.

### [Get-MgGroupEventCount](Get-MgGroupEventCount.md)
Get the number of the resource

### [Get-MgGroupEventExtension](Get-MgGroupEventExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.
This API is available in the following national cloud deployments.

### [Get-MgGroupEventExtensionCount](Get-MgGroupEventExtensionCount.md)
Get the number of the resource

### [Get-MgGroupEventInstance](Get-MgGroupEventInstance.md)
The occurrences of a recurring series, if the event is a series master.
This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series.
Navigation property.
Read-only.
Nullable.

### [Get-MgGroupEventInstanceAttachment](Get-MgGroupEventInstanceAttachment.md)
The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event.
Navigation property.
Read-only.
Nullable.

### [Get-MgGroupEventInstanceAttachmentCount](Get-MgGroupEventInstanceAttachmentCount.md)
Get the number of the resource

### [Get-MgGroupEventInstanceCalendar](Get-MgGroupEventInstanceCalendar.md)
The calendar that contains the event.
Navigation property.
Read-only.

### [Get-MgGroupEventInstanceCount](Get-MgGroupEventInstanceCount.md)
Get the number of the resource

### [Get-MgGroupEventInstanceExtension](Get-MgGroupEventInstanceExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.
This API is available in the following national cloud deployments.

### [Get-MgGroupEventInstanceExtensionCount](Get-MgGroupEventInstanceExtensionCount.md)
Get the number of the resource

### [Get-MgPlaceAsRoom](Get-MgPlaceAsRoom.md)
Get the item of type microsoft.graph.place as microsoft.graph.room

### [Get-MgPlaceAsRoomList](Get-MgPlaceAsRoomList.md)
Get the item of type microsoft.graph.place as microsoft.graph.roomList

### [Get-MgPlaceCount](Get-MgPlaceCount.md)
Get the number of the resource

### [Get-MgPlaceCountAsRoom](Get-MgPlaceCountAsRoom.md)
Get the number of the resource

### [Get-MgPlaceCountAsRoomList](Get-MgPlaceCountAsRoomList.md)
Get the number of the resource

### [Get-MgUserCalendar](Get-MgUserCalendar.md)
The user's calendars.
Read-only.
Nullable.

### [Get-MgUserCalendarCount](Get-MgUserCalendarCount.md)
Get the number of the resource

### [Get-MgUserCalendarEvent](Get-MgUserCalendarEvent.md)
Retrieve a list of events in a calendar.
The calendar can be one for a user, or the default calendar of a Microsoft 365 group.
The list of events contains single instance meetings and series masters.
To get expanded event instances, you can get the calendar view, or \nget the instances of an event.
This API is available in the following national cloud deployments.

### [Get-MgUserCalendarGroup](Get-MgUserCalendarGroup.md)
Retrieve the properties and relationships of a calendar group object.
This API is available in the following national cloud deployments.

### [Get-MgUserCalendarGroupCalendar](Get-MgUserCalendarGroupCalendar.md)
Retrieve a list of calendars belonging to a calendar group.
This API is available in the following national cloud deployments.

### [Get-MgUserCalendarGroupCount](Get-MgUserCalendarGroupCount.md)
Get the number of the resource

### [Get-MgUserCalendarPermission](Get-MgUserCalendarPermission.md)
Get the specified permissions object of a user or group calendar that has been shared.
This API is available in the following national cloud deployments.

### [Get-MgUserCalendarPermissionCount](Get-MgUserCalendarPermissionCount.md)
Get the number of the resource

### [Get-MgUserCalendarView](Get-MgUserCalendarView.md)
The calendar view for the calendar.
Navigation property.
Read-only.

### [Get-MgUserDefaultCalendar](Get-MgUserDefaultCalendar.md)
Get the properties and relationships of a calendar object.
The calendar can be one for a user, \nor the default calendar of a Microsoft 365 group.
There are two scenarios where an app can get another user's calendar: This API is available in the following national cloud deployments.

### [Get-MgUserDefaultCalendarEvent](Get-MgUserDefaultCalendarEvent.md)
Retrieve a list of events in a calendar.
The calendar can be one for a user, or the default calendar of a Microsoft 365 group.
The list of events contains single instance meetings and series masters.
To get expanded event instances, you can get the calendar view, or \nget the instances of an event.
This API is available in the following national cloud deployments.

### [Get-MgUserEvent](Get-MgUserEvent.md)
Get the properties and relationships of the specified event object.
Currently, this operation returns event bodies in only HTML format.
There are two scenarios where an app can get an event in another user's calendar: Since the event resource supports extensions, you can also use the GET operation to get custom properties and extension data in an event instance.
This API is available in the following national cloud deployments.

### [Get-MgUserEventAttachment](Get-MgUserEventAttachment.md)
The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event.
Navigation property.
Read-only.
Nullable.

### [Get-MgUserEventAttachmentCount](Get-MgUserEventAttachmentCount.md)
Get the number of the resource

### [Get-MgUserEventCalendar](Get-MgUserEventCalendar.md)
The calendar that contains the event.
Navigation property.
Read-only.

### [Get-MgUserEventCount](Get-MgUserEventCount.md)
Get the number of the resource

### [Get-MgUserEventExtension](Get-MgUserEventExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.
This API is available in the following national cloud deployments.

### [Get-MgUserEventExtensionCount](Get-MgUserEventExtensionCount.md)
Get the number of the resource

### [Get-MgUserEventInstance](Get-MgUserEventInstance.md)
The occurrences of a recurring series, if the event is a series master.
This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series.
Navigation property.
Read-only.
Nullable.

### [Get-MgUserEventInstanceAttachment](Get-MgUserEventInstanceAttachment.md)
The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event.
Navigation property.
Read-only.
Nullable.

### [Get-MgUserEventInstanceAttachmentCount](Get-MgUserEventInstanceAttachmentCount.md)
Get the number of the resource

### [Get-MgUserEventInstanceCalendar](Get-MgUserEventInstanceCalendar.md)
The calendar that contains the event.
Navigation property.
Read-only.

### [Get-MgUserEventInstanceCount](Get-MgUserEventInstanceCount.md)
Get the number of the resource

### [Get-MgUserEventInstanceExtension](Get-MgUserEventInstanceExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.
This API is available in the following national cloud deployments.

### [Get-MgUserEventInstanceExtensionCount](Get-MgUserEventInstanceExtensionCount.md)
Get the number of the resource

### [New-MgGroupCalendarEvent](New-MgGroupCalendarEvent.md)
Use this API to create a new event in a calendar.
The calendar can be one for a user, or the default calendar of a Microsoft 365 group.
This API is available in the following national cloud deployments.

### [New-MgGroupCalendarPermission](New-MgGroupCalendarPermission.md)
Create a calendarPermission resource to specify the identity and role of the user with whom the specified calendar is being shared or delegated.
This API is available in the following national cloud deployments.

### [New-MgGroupEvent](New-MgGroupEvent.md)
Use this API to create a new event.
This API is available in the following national cloud deployments.

### [New-MgGroupEventAttachment](New-MgGroupEventAttachment.md)
Use this API to add an attachment to an existing event.
This operation limits the size of the attachment you can add to under 3 MB.
If an organizer adds an attachment to a meeting event, the organizer can subsequently update the event to send the attachment and update the event for each attendee as well.
This API is available in the following national cloud deployments.

### [New-MgGroupEventExtension](New-MgGroupEventExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.
This API is available in the following national cloud deployments.

### [New-MgGroupEventInstanceAttachment](New-MgGroupEventInstanceAttachment.md)
Use this API to add an attachment to an existing event.
This operation limits the size of the attachment you can add to under 3 MB.
If an organizer adds an attachment to a meeting event, the organizer can subsequently update the event to send the attachment and update the event for each attendee as well.
This API is available in the following national cloud deployments.

### [New-MgGroupEventInstanceExtension](New-MgGroupEventInstanceExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.
This API is available in the following national cloud deployments.

### [New-MgUserCalendar](New-MgUserCalendar.md)
Create a new calendar for a user.
This API is available in the following national cloud deployments.

### [New-MgUserCalendarEvent](New-MgUserCalendarEvent.md)
Use this API to create a new event in a calendar.
The calendar can be one for a user, or the default calendar of a Microsoft 365 group.
This API is available in the following national cloud deployments.

### [New-MgUserCalendarGroup](New-MgUserCalendarGroup.md)
Use this API to create a new CalendarGroup.
This API is available in the following national cloud deployments.

### [New-MgUserCalendarGroupCalendar](New-MgUserCalendarGroupCalendar.md)
Use this API to create a new calendar in a calendar group for a user.
This API is available in the following national cloud deployments.

### [New-MgUserCalendarPermission](New-MgUserCalendarPermission.md)
Create a calendarPermission resource to specify the identity and role of the user with whom the specified calendar is being shared or delegated.
This API is available in the following national cloud deployments.

### [New-MgUserDefaultCalendarEvent](New-MgUserDefaultCalendarEvent.md)
Use this API to create a new event in a calendar.
The calendar can be one for a user, or the default calendar of a Microsoft 365 group.
This API is available in the following national cloud deployments.

### [New-MgUserEvent](New-MgUserEvent.md)
Create an event in the user's default calendar or specified calendar.
By default, the allowNewTimeProposals property is set to true when an event is created, which means invitees can propose a different date/time for the event.
See Propose new meeting times for more information on how to propose a time, and how to receive and accept a new time proposal.
You can specify the time zone for each of the start and end times of the event as part of their values, because the \nstart and end properties are of dateTimeTimeZone type.
First find the supported time zones to make sure you set only time zones that have been configured for the user's mailbox server.
When an event is sent, the server sends invitations to all the attendees.
Setting the location in an event An Exchange administrator can set up a mailbox and an email address for a resource such as a meeting room, or equipment \nlike a projector.
Users can then invite the resource as an attendee to a meeting.
On behalf of the resource, the server accepts or rejects \nthe meeting request based on the free/busy schedule of the resource.
\nIf the server accepts a meeting for the resource, it creates an event for the meeting in the resource's calendar.
If the meeting is rescheduled, \nthe server automatically updates the event in the resource's calendar.
Another advantage of setting up a mailbox for a resource is to control scheduling of the resource, for example, only executives\nor their delegates can book a private meeting room.
If you're organizing an event that involves a meeting location: Additionally, if the meeting location has been set up as a resource, or if the event involves some equipment that has been set up as a resource: This API is available in the following national cloud deployments.

### [New-MgUserEventAttachment](New-MgUserEventAttachment.md)
Use this API to add an attachment to an existing event.
This operation limits the size of the attachment you can add to under 3 MB.
If an organizer adds an attachment to a meeting event, the organizer can subsequently update the event to send the attachment and update the event for each attendee as well.
This API is available in the following national cloud deployments.

### [New-MgUserEventExtension](New-MgUserEventExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.
This API is available in the following national cloud deployments.

### [New-MgUserEventInstanceAttachment](New-MgUserEventInstanceAttachment.md)
Use this API to add an attachment to an existing event.
This operation limits the size of the attachment you can add to under 3 MB.
If an organizer adds an attachment to a meeting event, the organizer can subsequently update the event to send the attachment and update the event for each attendee as well.
This API is available in the following national cloud deployments.

### [New-MgUserEventInstanceExtension](New-MgUserEventInstanceExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.
This API is available in the following national cloud deployments.

### [Remove-MgGroupCalendarEvent](Remove-MgGroupCalendarEvent.md)
Delete navigation property events for groups

### [Remove-MgGroupCalendarPermission](Remove-MgGroupCalendarPermission.md)
Delete calendarPermission.
This API is available in the following national cloud deployments.

### [Remove-MgGroupEvent](Remove-MgGroupEvent.md)
Delete an event object.
This API is available in the following national cloud deployments.

### [Remove-MgGroupEventAttachment](Remove-MgGroupEventAttachment.md)
Delete an attachment from a user calendar event, mail message, or group post.
This API is available in the following national cloud deployments.

### [Remove-MgGroupEventExtension](Remove-MgGroupEventExtension.md)
Delete navigation property extensions for groups

### [Remove-MgGroupEventInstanceAttachment](Remove-MgGroupEventInstanceAttachment.md)
Delete an attachment from a user calendar event, mail message, or group post.
This API is available in the following national cloud deployments.

### [Remove-MgGroupEventInstanceExtension](Remove-MgGroupEventInstanceExtension.md)
Delete navigation property extensions for groups

### [Remove-MgPlace](Remove-MgPlace.md)
Delete entity from places

### [Remove-MgUserCalendarGroup](Remove-MgUserCalendarGroup.md)
Delete a calendar group other than the default calendar group.
This API is available in the following national cloud deployments.

### [Remove-MgUserCalendarPermission](Remove-MgUserCalendarPermission.md)
Delete calendarPermission.
This API is available in the following national cloud deployments.

### [Remove-MgUserEvent](Remove-MgUserEvent.md)
Removes the specified event from the containing calendar.
If the event is a meeting, deleting the event on the organizer's calendar sends a cancellation message to the meeting attendees.
This API is available in the following national cloud deployments.

### [Remove-MgUserEventAttachment](Remove-MgUserEventAttachment.md)
Delete an attachment from a user calendar event, mail message, or group post.
This API is available in the following national cloud deployments.

### [Remove-MgUserEventExtension](Remove-MgUserEventExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserEventInstanceAttachment](Remove-MgUserEventInstanceAttachment.md)
Delete an attachment from a user calendar event, mail message, or group post.
This API is available in the following national cloud deployments.

### [Remove-MgUserEventInstanceExtension](Remove-MgUserEventInstanceExtension.md)
Delete navigation property extensions for users

### [Update-MgGroupCalendarEvent](Update-MgGroupCalendarEvent.md)
Update an event object.
This API is available in the following national cloud deployments.

### [Update-MgGroupCalendarPermission](Update-MgGroupCalendarPermission.md)
Update the permissions assigned to an existing share recipient or delegate, through the corresponding \<b\>calendarPermission\</b\> object for a calendar.
This API is available in the following national cloud deployments.

### [Update-MgGroupEvent](Update-MgGroupEvent.md)
Update the navigation property events in groups

### [Update-MgGroupEventExtension](Update-MgGroupEventExtension.md)
Update the navigation property extensions in groups

### [Update-MgGroupEventInstanceExtension](Update-MgGroupEventInstanceExtension.md)
Update the navigation property extensions in groups

### [Update-MgPlace](Update-MgPlace.md)
Update the properties of place object, which can be a room or roomList.
You can identify the room or roomList by specifying the id or emailAddress property.
This API is available in the following national cloud deployments.

### [Update-MgUserCalendarGroup](Update-MgUserCalendarGroup.md)
Update the properties of calendargroup object.
This API is available in the following national cloud deployments.

### [Update-MgUserCalendarPermission](Update-MgUserCalendarPermission.md)
Update the permissions assigned to an existing share recipient or delegate, through the corresponding \<b\>calendarPermission\</b\> object for a calendar.
This API is available in the following national cloud deployments.

### [Update-MgUserEvent](Update-MgUserEvent.md)
Update the properties of the event object.
This API is available in the following national cloud deployments.

### [Update-MgUserEventExtension](Update-MgUserEventExtension.md)
Update the navigation property extensions in users

### [Update-MgUserEventInstanceExtension](Update-MgUserEventInstanceExtension.md)
Update the navigation property extensions in users


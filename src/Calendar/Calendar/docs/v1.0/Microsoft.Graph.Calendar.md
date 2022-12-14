---
Module Name: Microsoft.Graph.Calendar
Module Guid: 4e27bfc9-a497-44da-9f0b-b2eec31267a3
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.calendar
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

### [Get-MgGroupCalendarMultiValueExtendedProperty](Get-MgGroupCalendarMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the calendar.
Read-only.
Nullable.

### [Get-MgGroupCalendarPermission](Get-MgGroupCalendarPermission.md)
The permissions of the users with whom the calendar is shared.

### [Get-MgGroupCalendarSingleValueExtendedProperty](Get-MgGroupCalendarSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the calendar.
Read-only.
Nullable.

### [Get-MgGroupCalendarView](Get-MgGroupCalendarView.md)
The calendar view for the calendar.
Navigation property.
Read-only.

### [Get-MgGroupEvent](Get-MgGroupEvent.md)
The group's calendar events.

### [Get-MgGroupEventAttachment](Get-MgGroupEventAttachment.md)
The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event.
Navigation property.
Read-only.
Nullable.

### [Get-MgGroupEventCalendar](Get-MgGroupEventCalendar.md)
The calendar that contains the event.
Navigation property.
Read-only.

### [Get-MgGroupEventExtension](Get-MgGroupEventExtension.md)
The collection of open extensions defined for the event.
Nullable.

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

### [Get-MgGroupEventInstanceCalendar](Get-MgGroupEventInstanceCalendar.md)
The calendar that contains the event.
Navigation property.
Read-only.

### [Get-MgGroupEventInstanceExtension](Get-MgGroupEventInstanceExtension.md)
The collection of open extensions defined for the event.
Nullable.

### [Get-MgGroupEventInstanceMultiValueExtendedProperty](Get-MgGroupEventInstanceMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the event.
Read-only.
Nullable.

### [Get-MgGroupEventInstanceSingleValueExtendedProperty](Get-MgGroupEventInstanceSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the event.
Read-only.
Nullable.

### [Get-MgGroupEventMultiValueExtendedProperty](Get-MgGroupEventMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the event.
Read-only.
Nullable.

### [Get-MgGroupEventSingleValueExtendedProperty](Get-MgGroupEventSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the event.
Read-only.
Nullable.

### [Get-MgPlace](Get-MgPlace.md)
Get the properties and relationships of a place object specified by either its ID or email address.
The **place** object can be one of the following types: Both **room** and **roomList** are derived from the place object.

### [Get-MgUserCalendar](Get-MgUserCalendar.md)
The user's calendars.
Read-only.
Nullable.

### [Get-MgUserCalendarEvent](Get-MgUserCalendarEvent.md)
Retrieve a list of events in a calendar.
The calendar can be one for a user, or the default calendar of a Microsoft 365 group.
The list of events contains single instance meetings and series masters.
To get expanded event instances, you can get the calendar view, or \nget the instances of an event.

### [Get-MgUserCalendarGroup](Get-MgUserCalendarGroup.md)
The user's calendar groups.
Read-only.
Nullable.

### [Get-MgUserCalendarGroupCalendar](Get-MgUserCalendarGroupCalendar.md)
Retrieve a list of calendars belonging to a calendar group.

### [Get-MgUserCalendarMultiValueExtendedProperty](Get-MgUserCalendarMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the calendar.
Read-only.
Nullable.

### [Get-MgUserCalendarPermission](Get-MgUserCalendarPermission.md)
The permissions of the users with whom the calendar is shared.

### [Get-MgUserCalendarSingleValueExtendedProperty](Get-MgUserCalendarSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the calendar.
Read-only.
Nullable.

### [Get-MgUserCalendarView](Get-MgUserCalendarView.md)
The calendar view for the calendar.
Navigation property.
Read-only.

### [Get-MgUserDefaultCalendar](Get-MgUserDefaultCalendar.md)
Get the properties and relationships of a calendar object.
The calendar can be one for a user, \nor the default calendar of a Microsoft 365 group.
There are two scenarios where an app can get another user's calendar:

### [Get-MgUserEvent](Get-MgUserEvent.md)
The user's events.
Default is to show Events under the Default Calendar.
Read-only.
Nullable.

### [Get-MgUserEventAttachment](Get-MgUserEventAttachment.md)
The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event.
Navigation property.
Read-only.
Nullable.

### [Get-MgUserEventCalendar](Get-MgUserEventCalendar.md)
The calendar that contains the event.
Navigation property.
Read-only.

### [Get-MgUserEventExtension](Get-MgUserEventExtension.md)
The collection of open extensions defined for the event.
Nullable.

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

### [Get-MgUserEventInstanceCalendar](Get-MgUserEventInstanceCalendar.md)
The calendar that contains the event.
Navigation property.
Read-only.

### [Get-MgUserEventInstanceExtension](Get-MgUserEventInstanceExtension.md)
The collection of open extensions defined for the event.
Nullable.

### [Get-MgUserEventInstanceMultiValueExtendedProperty](Get-MgUserEventInstanceMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the event.
Read-only.
Nullable.

### [Get-MgUserEventInstanceSingleValueExtendedProperty](Get-MgUserEventInstanceSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the event.
Read-only.
Nullable.

### [Get-MgUserEventMultiValueExtendedProperty](Get-MgUserEventMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the event.
Read-only.
Nullable.

### [Get-MgUserEventSingleValueExtendedProperty](Get-MgUserEventSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the event.
Read-only.
Nullable.

### [New-MgGroupCalendarMultiValueExtendedProperty](New-MgGroupCalendarMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgGroupCalendarPermission](New-MgGroupCalendarPermission.md)
Create a calendarPermission resource to specify the identity and role of the user with whom the specified calendar is being shared or delegated.

### [New-MgGroupCalendarSingleValueExtendedProperty](New-MgGroupCalendarSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [New-MgGroupEvent](New-MgGroupEvent.md)
Use this API to create a new event.

### [New-MgGroupEventAttachment](New-MgGroupEventAttachment.md)
Use this API to add an attachment to an existing event.
This operation limits the size of the attachment you can add to under 3 MB.
If an organizer adds an attachment to a meeting event, the organizer can subsequently update the event to send the attachment and update the event for each attendee as well.

### [New-MgGroupEventExtension](New-MgGroupEventExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgGroupEventInstanceAttachment](New-MgGroupEventInstanceAttachment.md)
Use this API to add an attachment to an existing event.
This operation limits the size of the attachment you can add to under 3 MB.
If an organizer adds an attachment to a meeting event, the organizer can subsequently update the event to send the attachment and update the event for each attendee as well.

### [New-MgGroupEventInstanceExtension](New-MgGroupEventInstanceExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgGroupEventInstanceMultiValueExtendedProperty](New-MgGroupEventInstanceMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgGroupEventInstanceSingleValueExtendedProperty](New-MgGroupEventInstanceSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [New-MgGroupEventMultiValueExtendedProperty](New-MgGroupEventMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgGroupEventSingleValueExtendedProperty](New-MgGroupEventSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [New-MgPlace](New-MgPlace.md)
Add new entity to places

### [New-MgUserCalendar](New-MgUserCalendar.md)
Create a new calendar for a user.

### [New-MgUserCalendarEvent](New-MgUserCalendarEvent.md)
Use this API to create a new event in a calendar.
The calendar can be one for a user, or the default calendar of a Microsoft 365 group.

### [New-MgUserCalendarGroup](New-MgUserCalendarGroup.md)
Use this API to create a new CalendarGroup.

### [New-MgUserCalendarGroupCalendar](New-MgUserCalendarGroupCalendar.md)
Use this API to create a new calendar in a calendar group for a user.

### [New-MgUserCalendarMultiValueExtendedProperty](New-MgUserCalendarMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserCalendarPermission](New-MgUserCalendarPermission.md)
Create a calendarPermission resource to specify the identity and role of the user with whom the specified calendar is being shared or delegated.

### [New-MgUserCalendarSingleValueExtendedProperty](New-MgUserCalendarSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserEvent](New-MgUserEvent.md)
Create an event in the user's default calendar or specified calendar.
By default, the **allowNewTimeProposals** property is set to true when an event is created, which means invitees can propose a different date/time for the event.
See Propose new meeting times for more information on how to propose a time, and how to receive and accept a new time proposal.
You can specify the time zone for each of the start and end times of the event as part of their values, because the \n**start** and **end** properties are of dateTimeTimeZone type.
First find the supported time zones to make sure you set only time zones that have been configured for the user's mailbox server.
When an event is sent, the server sends invitations to all the attendees.
**Setting the location in an event** An Exchange administrator can set up a mailbox and an email address for a resource such as a meeting room, or equipment \nlike a projector.
Users can then invite the resource as an attendee to a meeting.
On behalf of the resource, the server accepts or rejects \nthe meeting request based on the free/busy schedule of the resource.
\nIf the server accepts a meeting for the resource, it creates an event for the meeting in the resource's calendar.
If the meeting is rescheduled, \nthe server automatically updates the event in the resource's calendar.
Another advantage of setting up a mailbox for a resource is to control scheduling of the resource, for example, only executives\nor their delegates can book a private meeting room.
If you're organizing an event that involves a meeting location: Additionally, if the meeting location has been set up as a resource, or if the event involves some equipment that has been set up as a resource:

### [New-MgUserEventAttachment](New-MgUserEventAttachment.md)
Use this API to add an attachment to an existing event.
This operation limits the size of the attachment you can add to under 3 MB.
If an organizer adds an attachment to a meeting event, the organizer can subsequently update the event to send the attachment and update the event for each attendee as well.

### [New-MgUserEventExtension](New-MgUserEventExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgUserEventInstanceAttachment](New-MgUserEventInstanceAttachment.md)
Use this API to add an attachment to an existing event.
This operation limits the size of the attachment you can add to under 3 MB.
If an organizer adds an attachment to a meeting event, the organizer can subsequently update the event to send the attachment and update the event for each attendee as well.

### [New-MgUserEventInstanceExtension](New-MgUserEventInstanceExtension.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgUserEventInstanceMultiValueExtendedProperty](New-MgUserEventInstanceMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserEventInstanceSingleValueExtendedProperty](New-MgUserEventInstanceSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserEventMultiValueExtendedProperty](New-MgUserEventMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserEventSingleValueExtendedProperty](New-MgUserEventSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [Remove-MgGroupCalendarMultiValueExtendedProperty](Remove-MgGroupCalendarMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgGroupCalendarPermission](Remove-MgGroupCalendarPermission.md)
Delete navigation property calendarPermissions for groups

### [Remove-MgGroupCalendarSingleValueExtendedProperty](Remove-MgGroupCalendarSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Remove-MgGroupEvent](Remove-MgGroupEvent.md)
Delete navigation property events for groups

### [Remove-MgGroupEventAttachment](Remove-MgGroupEventAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgGroupEventExtension](Remove-MgGroupEventExtension.md)
Delete navigation property extensions for groups

### [Remove-MgGroupEventInstanceAttachment](Remove-MgGroupEventInstanceAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgGroupEventInstanceExtension](Remove-MgGroupEventInstanceExtension.md)
Delete navigation property extensions for groups

### [Remove-MgGroupEventInstanceMultiValueExtendedProperty](Remove-MgGroupEventInstanceMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgGroupEventInstanceSingleValueExtendedProperty](Remove-MgGroupEventInstanceSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Remove-MgGroupEventMultiValueExtendedProperty](Remove-MgGroupEventMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgGroupEventSingleValueExtendedProperty](Remove-MgGroupEventSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Remove-MgPlace](Remove-MgPlace.md)
Delete entity from places

### [Remove-MgUserCalendar](Remove-MgUserCalendar.md)
Delete navigation property calendars for users

### [Remove-MgUserCalendarGroup](Remove-MgUserCalendarGroup.md)
Delete navigation property calendarGroups for users

### [Remove-MgUserCalendarMultiValueExtendedProperty](Remove-MgUserCalendarMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserCalendarPermission](Remove-MgUserCalendarPermission.md)
Delete navigation property calendarPermissions for users

### [Remove-MgUserCalendarSingleValueExtendedProperty](Remove-MgUserCalendarSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserEvent](Remove-MgUserEvent.md)
Delete navigation property events for users

### [Remove-MgUserEventAttachment](Remove-MgUserEventAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserEventExtension](Remove-MgUserEventExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserEventInstanceAttachment](Remove-MgUserEventInstanceAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserEventInstanceExtension](Remove-MgUserEventInstanceExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserEventInstanceMultiValueExtendedProperty](Remove-MgUserEventInstanceMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserEventInstanceSingleValueExtendedProperty](Remove-MgUserEventInstanceSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserEventMultiValueExtendedProperty](Remove-MgUserEventMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserEventSingleValueExtendedProperty](Remove-MgUserEventSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Update-MgGroupCalendarMultiValueExtendedProperty](Update-MgGroupCalendarMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgGroupCalendarPermission](Update-MgGroupCalendarPermission.md)
Update the navigation property calendarPermissions in groups

### [Update-MgGroupCalendarSingleValueExtendedProperty](Update-MgGroupCalendarSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

### [Update-MgGroupEvent](Update-MgGroupEvent.md)
Update the navigation property events in groups

### [Update-MgGroupEventExtension](Update-MgGroupEventExtension.md)
Update the navigation property extensions in groups

### [Update-MgGroupEventInstanceExtension](Update-MgGroupEventInstanceExtension.md)
Update the navigation property extensions in groups

### [Update-MgGroupEventInstanceMultiValueExtendedProperty](Update-MgGroupEventInstanceMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgGroupEventInstanceSingleValueExtendedProperty](Update-MgGroupEventInstanceSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

### [Update-MgGroupEventMultiValueExtendedProperty](Update-MgGroupEventMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgGroupEventSingleValueExtendedProperty](Update-MgGroupEventSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

### [Update-MgPlace](Update-MgPlace.md)
Update the properties of place object, which can be a room or roomList.
You can identify the **room** or **roomList** by specifying the **id** or **emailAddress** property.

### [Update-MgUserCalendar](Update-MgUserCalendar.md)
Update the navigation property calendars in users

### [Update-MgUserCalendarGroup](Update-MgUserCalendarGroup.md)
Update the navigation property calendarGroups in users

### [Update-MgUserCalendarMultiValueExtendedProperty](Update-MgUserCalendarMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserCalendarPermission](Update-MgUserCalendarPermission.md)
Update the navigation property calendarPermissions in users

### [Update-MgUserCalendarSingleValueExtendedProperty](Update-MgUserCalendarSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserEvent](Update-MgUserEvent.md)
Update the navigation property events in users

### [Update-MgUserEventExtension](Update-MgUserEventExtension.md)
Update the navigation property extensions in users

### [Update-MgUserEventInstanceExtension](Update-MgUserEventInstanceExtension.md)
Update the navigation property extensions in users

### [Update-MgUserEventInstanceMultiValueExtendedProperty](Update-MgUserEventInstanceMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserEventInstanceSingleValueExtendedProperty](Update-MgUserEventInstanceSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserEventMultiValueExtendedProperty](Update-MgUserEventMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserEventSingleValueExtendedProperty](Update-MgUserEventSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users


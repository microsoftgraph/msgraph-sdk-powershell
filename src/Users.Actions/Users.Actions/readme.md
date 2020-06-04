<!-- region Generated -->
# Microsoft.Graph.Users.Actions
This directory contains the PowerShell module for the UsersActions service.

---
## Status
[![Microsoft.Graph.Users.Actions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Users.Actions.svg?style=flat-square&label=Microsoft.Graph.Users.Actions "Microsoft.Graph.Users.Actions")](https://www.powershellgallery.com/packages/Microsoft.Graph.Users.Actions/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Users.Actions`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''
input-file: $(spec-doc-repo)/$(title).yml
directive:
# Remove paths that have /parent* or /calendarView*.
  - remove-path-by-operation: users.onenote..*.parent.*|users.*.calendarView.*
# Remove cmdlets.
  - where:
      verb: Clear
      subject: ^UserManagedAppRegistration$
      variant: ^Wipe$|^WipeExpanded$|^WipeViaIdentity$|^WipeViaIdentityExpanded$
    remove: true
# Duplicate - Can be called by Get-MgUserEventCalendarSchedule
  - where:
      verb: Get
      subject: ^UserCalendarEventCalendarSchedule$
    remove: true
  - where:
      verb: Get
      subject: ^(UserOnlineMeeting)$
    remove: true
# Rename
  - where:
      verb: Get
      subject: ^(User)$
    set:
      subject: $1ById
  - where:
      verb: Get
      subject: ^(UserOwnedObject)$
    set:
      subject: $1ByType
  - where:
      verb: New
      subject: ^(UserOnlineMeeting)$
    set:
      verb: Invoke
      subject: CreateOrGet$1
  - where:
      verb: Update
      subject: ^(UserTeamworkInstalledApp)$
    set:
      verb: Invoke
      subject: Upgrade$1
  - where:
      verb: Update
      subject: ^(UserOnenote)(NotebookSectionGroupSectionPage|NotebookSectionPage|Page|SectionGroupSectionPage|SectionPage)$
    set:
      subject: $1$2Content
  - where:
      verb: Get
      subject: ^(User)(CalendarSchedule)$
      variant: ^Get$|^GetExpanded$|^GetViaIdentity$|^GetViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: New
      subject: ^(User)(CalendarEventAttachmentUploadSession)$
      variant: ^Create$|^CreateExpanded$|^CreateViaIdentity$|^CreateViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(AcceptUser)(CalendarEvent|CalendarEventInstance|CalendarEventTentatively|CalendarEventInstanceTentatively)$
      variant: ^Accept$|^AcceptExpanded$|^AcceptViaIdentity$|^AcceptViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(DeclineUser)(CalendarEventInstance)$
      variant: ^Decline1$|^DeclineExpanded1$|^DeclineViaIdentity1$|^DeclineViaIdentityExpanded1$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(DeclineUser)(CalendarEvent)$
      variant: ^Decline$|^DeclineExpanded$|^DeclineViaIdentity$|^DeclineViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(ForwardUser)(CalendarEventInstance)$
      variant: ^Forward1$|^ForwardExpanded1$|^ForwardViaIdentity1$|^ForwardViaIdentityExpanded1$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(ForwardUser)(CalendarEvent)$
      variant: ^Forward$|^ForwardExpanded$|^ForwardViaIdentity$|^ForwardViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(SnoozeUser)(CalendarEventInstanceReminder)$
      variant: ^Snooze1$|^SnoozeExpanded1$|^SnoozeViaIdentity1$|^SnoozeViaIdentityExpanded1$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(SnoozeUser)(CalendarEventReminder)$
      variant: ^Snooze$|^SnoozeExpanded$|^SnoozeViaIdentity$|^SnoozeViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Stop
      subject: ^(User)(CalendarEvent|CalendarEventInstance)$
      variant: ^Cancel$|^CancelExpanded$|^CancelViaIdentity$|^CancelViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(Reply)(UserMessage|UserMailFolderMessage)$
      variant: ^Reply1$|^ReplyExpanded1$|^ReplyViaIdentity1$|^ReplyViaIdentityExpanded1$
    set:
      subject: $1All$2
  - where:
      verb: New
      subject: ^(UserMessageReply|UserMailFolderMessageReply)$
      variant: ^Create1$|^CreateExpanded1$|^CreateViaIdentity1$|^CreateViaIdentityExpanded1$
    set:
      subject: $1All
```
### Versioning

``` yaml
module-version: 0.5.1
release-notes: See https://aka.ms/GraphPowerShell-Release.
```

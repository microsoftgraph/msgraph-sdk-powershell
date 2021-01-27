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

```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove invalid paths.
  - remove-path-by-operation: .*exceptionOccurrences.*|users\.onenote\..*.parent.*|users.*\.calendarView.*|.*\.notebooks\.section.*|.*\.sectionGroups\.section.*|.*\.sections\.pages.*|users\.calendar\.events.*|users\.calendarGroups\.calendars.*|users\.calendars\.events.*|users\.events\.calendar\.events.*
# Remove cmdlets.
  - where:
      verb: Clear
      subject: ^UserManagedAppRegistration$
      variant: ^Wipe1$|^WipeExpanded1$|^WipeViaIdentity1$|^WipeViaIdentityExpanded1$
    remove: true
  - where:
      verb: Get
      subject: ^(UserOnlineMeeting)$
    remove: true
# Rename
  - where:
      verb: Clear
      subject: ^(UserManagedAppRegistration)$
    set:
      subject: $1ByDeviceTag
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
      subject: ^(UserOnenotePage)$
    set:
      subject: $1Content
  - where:
      verb: Rename
      subject: ^(UserPassword)$
    set:
      verb: Reset
      subject: $1
  - where:
      verb: Get
      subject: ^(User)(CalendarSchedule)$
      variant: ^Get$|^GetExpanded$|^GetViaIdentity$|^GetViaIdentityExpanded$|Get2$|^GetExpanded2$|^GetViaIdentity2$|^GetViaIdentityExpanded2$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(DismissUser)(CalendarEventInstanceReminder)$
      variant: ^Dismiss$|^DismissViaIdentity$|Dismiss3$|^DismissViaIdentity3$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(Reply)(UserMessage|UserMailFolderMessage)$
      variant: ^Reply1$|^ReplyExpanded1$|^ReplyViaIdentity1$|^ReplyViaIdentityExpanded1$|^Reply3$|^ReplyExpanded3$|^ReplyViaIdentity3$|^ReplyViaIdentityExpanded3$
    set:
      subject: $1All$2
  - where:
      verb: New
      subject: ^(User)(MessageReply|MailFolderMessageReply)$
      variant: ^Create1$|^CreateExpanded1$|^CreateViaIdentity1$|^CreateViaIdentityExpanded1$|^Create3$|^CreateExpanded3$|^CreateViaIdentity3$|^CreateViaIdentityExpanded3$
    set:
      subject: $1$2All
  # https://docs.microsoft.com/en-us/graph/api/resources/intune-devices-devicelogcollectionresponse?view=graph-rest-beta
  - where:
      verb: New
      subject: ^(UserManagedDeviceLogCollection)Request(DownloadUrl)$
    set:
      subject: $1Response$2
  - where:
      verb: Update
      subject: ^(UserManagedDevice)$
    set:
      verb: New
      subject: $1WindowsDefenderUpdateSignature
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```

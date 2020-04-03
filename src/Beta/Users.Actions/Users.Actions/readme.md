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
  - $(this-folder)/../../../readme.graph.md
title: $(service-name)
subject-prefix: ''
input-file: $(spec-doc-repo)/$(title).yml
# Custom directives.
declare-directive:
  where-operation-byRegex: >-
    (() => {
      return { from: "openapi-document", where: `$..paths.*[?(/${$}/i.exec(@.operationId))]` };
    })()
  remove-operation-byRegex: >-
    [{
      from: 'openapi-document',
      "where-operation-byRegex": $,
      transform: '$ = undefined'
    }]
directive:
# Remove paths that have /parent*. The parent can be passed via an id parameter.
  - remove-operation-byRegex: users.onenote..*.parent.*
  - remove-operation-byRegex: users.calendar.*.calendarView.*
# Remove Add|Remove-MgSite. They are duplicate of Sites.Site.
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
# Rename
  - where:
      verb: Get
      subject: ^(User)(CalendarSchedule)$
      variant: ^Get$|^GetExpanded$|^GetViaIdentity$|^GetViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(AcceptUser)(CalendarEventInstanceTentatively)$
      variant: ^Accept$|^AcceptExpanded$|^AcceptViaIdentity$|^AcceptViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(AcceptUser)(CalendarEventInstance)$
      variant: ^Accept$|^AcceptExpanded$|^AcceptViaIdentity$|^AcceptViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(AcceptUser)(CalendarEventTentatively)$
      variant: ^Accept$|^AcceptExpanded$|^AcceptViaIdentity$|^AcceptViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(AcceptUser)(CalendarEvent)$
      variant: ^Accept$|^AcceptExpanded$|^AcceptViaIdentity$|^AcceptViaIdentityExpanded$
    set:
      subject: $1Default$2
```

### Versioning

``` yaml
module-version: 0.2.1
release-notes: See https://aka.ms/GraphPowerShell-Release.
```

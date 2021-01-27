<!-- region Generated -->
# Microsoft.Graph.Users.Functions
This directory contains the PowerShell module for the UsersFunctions service.

---
## Status
[![Microsoft.Graph.Users.Functions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Users.Functions.svg?style=flat-square&label=Microsoft.Graph.Users.Functions "Microsoft.Graph.Users.Functions")](https://www.powershellgallery.com/packages/Microsoft.Graph.Users.Functions/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Users.Functions`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: .*exceptionOccurrences.*|users\.onenote\..*.parent.*|users.*\.calendarView.*|.*\.notebooks\.section.*|.*\.sectionGroups.section.*|.*\.sections\.pages.*|users\.calendar\.events\..*|users\.calendarGroups\.calendars|users\.calendars\.events\..*|users\.events\.calendar\..*
# Rename cmdlets.
  - where:
      verb: Get
      subject: ^(UserOnenote)Notebook(RecentNotebook)$
    set:
      subject: $1$2
  - where:
      verb: Invoke
      subject: ^(CalendarUserEventCalendar|CalendarUserCalendar)$
    set:
      subject: $1AllowedCalendarSharingRoles
  - where:
      verb: Get
      subject: ^(UserManagedDevice)$
    set:
      subject: $1WithAppFailure
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```

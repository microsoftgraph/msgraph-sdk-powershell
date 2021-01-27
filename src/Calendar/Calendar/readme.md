<!-- region Generated -->
# Microsoft.Graph.Calendar
This directory contains the PowerShell module for the Calendar service.

---
## Status
[![Microsoft.Graph.Calendar](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Calendar.svg?style=flat-square&label=Microsoft.Graph.Calendar "Microsoft.Graph.Calendar")](https://www.powershellgallery.com/packages/Microsoft.Graph.Calendar/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Calendar`, see [how-to.md](how-to.md).
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
# Remove paths that are not valid.
  - remove-path-by-operation: (users|groups)_(Update|Delete)Calendar$|(users|groups)..*_(Get|Create|Update|Delete)CalendarView$|(users|groups).(calendar|calendars).calendarView.*$|(users|groups).calendar_.*Events$|users.calendars_(Get|Update|Delete)Events$|(users|groups).(calendar|calendars).events.*$|(users|groups)_.*CalendarView$|(users|groups).calendarView.*$|users.calendarGroups_(Get|Update|Delete)Calendars$|users.calendarGroups.calendars.*$|(groups|users).events_(Create|Update|Create)Calendar$|(users|groups).events.calendar.*$
# Rename cmdlets.
  - where:
      verb: Get
      subject: ^(User)(Calendar)$
      variant: Get1|Get3|GetViaIdentity1|GetViaIdentity3
    set:
      subject: $1Default$2

```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```

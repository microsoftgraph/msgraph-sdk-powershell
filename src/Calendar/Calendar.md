# Calendar

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Calendar v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove paths that are not valid.
  - remove-path-by-operation: (users|groups)_(Update|Delete)Calendar$|(users|groups)..*_(Get|Create|Update|Delete)CalendarView$|(users|groups).(calendar|calendars).calendarView.*$|(users|groups).calendar_.*Events$|users.calendars_(Get|Update|Delete)Events$|(users|groups).(calendar|calendars).events.*$|(users|groups)_.*CalendarView$|(users|groups).calendarView.*$|users.calendarGroups_(Get|Update|Delete)Calendars$|users.calendarGroups.calendars.*$|(groups|users).events_(Create|Update|Create)Calendar$|(users|groups).events.calendar.*$
# Rename cmdlets.
# TODO: Clean up
  # - where:
  #     verb: Get
  #     subject: ^(User)(Calendar)$
  #     variant: Get1|Get3|GetViaIdentity1|GetViaIdentity3
  #   set:
  #     subject: $1Default$2
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```

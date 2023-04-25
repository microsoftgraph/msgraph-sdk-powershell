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
  - remove-path-by-operation: (user|group)_(Update|Delete)Calendar$|(user|group)..*_(Get|Create|Update|Delete)CalendarView$|(user|group).(calendar).calendarView.*$|(user|group).calendar_.*Event$|user.calendar_(Get|Update|Delete)Event$|(user|group).(calendar).event.*$|(user|group)_.*CalendarView$|(user|group).calendarView.*$|user.calendarGroup_(Get|Update|Delete)Calendar$|user.calendarGroup.calendar.*$|(group|user).event_(Create|Update|Create)Calendar$|(user|group).event.calendar.*$
# Rename cmdlets.
  - where:
      verb: Get
      subject: ^(User)(Calendar)$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: $1Default$2
```

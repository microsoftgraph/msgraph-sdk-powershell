# Users.Functions

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Users.Functions v1.0 and/or beta modules.

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
# Remove invalid paths.
  - remove-path-by-operation: .*exceptionOccurrences.*|users\.joinedGroups.*|users\.joinedTeams.*|users\.onenote\..*.parent.*|users.*\.calendarView.*|.*\.notebooks\.section.*|.*\.sectionGroups.section.*|.*\.sections\.pages.*|users\.calendar\.events\..*|users\.calendarGroups\.calendars|users\.calendars\.events\..*|users\.events\.calendar\..*|users\.pendingAccessReviewInstances\.stages\.decisions.*|users\.pendingAccessReviewInstances(\.decisions|\.stages\.decisions)\.instance.*
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
      subject: ^(UserChatMessage)$
    set:
      subject: All$1
```

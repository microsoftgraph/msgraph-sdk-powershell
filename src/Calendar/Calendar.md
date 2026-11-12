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
# Wrapper migration: evaluate this selector against the actual legacy profile.
# All 136 v1.0 and 137 beta matches survive in the current compatible specs.
# Operation-ID alignment now makes the literal current selector cover that exact
# set; the adjacent ledger uses the existing inventory schema. Module tests retain
# independent complete legacy proof, including qualified final action/function
# paths. Exact entries cover both profiles without relying on v1.0-only derived
# data. No surviving legacy match is classified as absent.
# The ledger separately reconciles six existing derived collision suppressions
# across both profiles; their separate provenance does not broaden this selector.
  - remove-path-by-operation: (user|group)_(Update|Delete)Calendar$|(user|group)..*_(Get|Create|Update|Delete)CalendarView$|(user|group).(calendar).calendarView.*$|user.calendar_(Get|Update|Delete)Event$|(user|group).(calendar).event.*$|(user|group)_.*CalendarView$|(user|group).calendarView.*$|user.calendarGroup_(Get|Update|Delete)Calendar$|user.calendarGroup.calendar.*$|(group|user).event_(Create|Update|Create)Calendar$|(user|group).event.calendar.*$|placeAsRoomList.room_(Get|Update|Delete)GraphBPrePlaceId$|placeAsRoomList.workspace_(Get|Update|Delete)GraphBPrePlaceId$
# Rename cmdlets.
# Wrapper migration: exact noun and Invoke verb fallbacks cover the default-user-
# calendar function in both profiles, using the shared ReplaceVerb prerequisite.
# v1.0 derived data retains precedence. Neither spec contains the event-calendar
# function counterpart; the ledger records that absence without fabricating a route.
  - where:
      verb: Invoke
      subject: ^(CalendarUserEventCalendar|CalendarUserCalendar)$
    set:
      subject: $1AllowedCalendarSharingRoles
# Wrapper migration: the existing exact GET noun override implements this rename.
  - where:
      verb: Get
      subject: ^(User)(Calendar)$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: $1Default$2
# Wrapper migration: the existing exact collection override supplies Default for
# List/Create. Cancel is present but suppressed by directive 1; no rename revives it.
  - where:
      subject: ^(User)(CalendarEvent)$
      variant: ^List$|^Create$|^CreateExpanded$|^CreateViaIdentity$|^CreateViaIdentityExpanded$|^Cancel$|^CancelExpanded$|^CancelViaIdentity$|^CancelViaIdentityExpanded$
    set:
      subject: $1Default$2

# Remove duplicate cmdlet
# Wrapper migration: exact POST getSchedule routes for default and named user
# calendars are suppressed; HTTP method and legacy Get verb are not interchangeable.
  - where:
      verb: Get
      subject: ^(UserCalendarSchedule)$
    remove: true
#Remove cmdlet to avoid conflicts where alias has been set:[#3241](https://github.com/microsoftgraph/msgraph-sdk-powershell/issues/3241)
# Wrapper migration: exact GET delta routes for default and named calendars are
# suppressed in both profiles. CalendarDirectiveMigrationTests pins the evidence,
# precedence and unaffected neighbors. Keep all original AutoRest directives active
# until retirement. Global/profile-local directives are not audited here; parameter
# aliases/transforms and schema/response changes remain deferred.
  - where:
      verb: Get
      subject: ^UserCalendarEventDelta$
    remove: true
```

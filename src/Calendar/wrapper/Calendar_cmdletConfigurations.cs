using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> CalendarCmdletConfigurations =
    [
        // The SDK ships no Update cmdlet for /users/{id}/calendar. Its pipeline removes the
        // operation outright, in src/Calendar/Calendar.md: remove-path-by-operation
        // user_UpdateCalendar. The wrapper must not invent a cmdlet the SDK chose to drop.
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/users/{}/calendar", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md remove-path-by-operation user_UpdateCalendar"),

        // GET /users/{id}/calendar ships as Get-MgUserDefaultCalendar, renamed in
        // src/Calendar/Calendar.md: "^(User)(Calendar)$" -> "$1Default$2".
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/users/{}/calendar", Match: PathMatch.Exact, Value: "UserDefaultCalendar",
            Reason: "Calendar.md directive renames UserCalendar to UserDefaultCalendar"),

        // Calendar: the shipped default-calendar surface. Events under a NAMED calendar and
        // the default-calendar event item tree ship nothing; event items ship from
        // /users/{}/events (Get-MgUserEvent family).
        new(OverrideKind.ReplaceNoun, Method: null, "/users/{}/calendar/events", Match: PathMatch.Exact, Value: "UserDefaultCalendarEvent",
            Reason: "oracle: list/create ship as Get/New-MgUserDefaultCalendarEvent"),
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/calendar/events/{}", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: default-calendar event items ship nothing; items ship from /users/{}/events/{}"),
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/calendars/{}/events/{}", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: named-calendar event items ship nothing; items ship from /users/{}/events/{}"),
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/calendars/{}/calendarpermissions", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: permissions ship only from the default calendar (Get-MgUserCalendarPermission on /users/{}/calendar/calendarPermissions)"),
    ];
}

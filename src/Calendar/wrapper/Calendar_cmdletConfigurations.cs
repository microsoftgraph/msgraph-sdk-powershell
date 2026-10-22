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

        // Exact matches of Calendar.md directive 1 in both compatible specs. The existing
        // default-calendar event-item prefix above already covers the user item operations.
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/calendar/calendarview/delta", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.calendarView.delta"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/calendar/events/delta", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.delta"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/calendarview/delta", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendarView.delta"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/calendar/events/{}/attachments/createuploadsession", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.event.attachments.createUploadSession"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/calendar/events/{}/instances/delta", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.event.instances.delta"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/calendar/events/{}/accept", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.event.accept"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/calendar/events/{}/cancel", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.event.cancel"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/calendar/events/{}/decline", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.event.decline"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/calendar/events/{}/dismissreminder", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.event.dismissReminder"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/calendar/events/{}/forward", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.event.forward"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/calendar/events/{}/permanentdelete", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.event.permanentDelete"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/calendar/events/{}/snoozereminder", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.event.snoozeReminder"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/calendar/events/{}/tentativelyaccept", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: groups.group.calendar.events.event.tentativelyAccept"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/calendar/calendarview/delta", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: users.user.calendar.calendarView.delta"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/calendarview/delta", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 1: users.user.calendarView.delta"),

        // The oracle-derived v1.0 entry takes precedence. These fallbacks preserve the
        // shared directive's subject and Invoke verb when no derived entry is available.
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/users/{}/calendar/allowedcalendarsharingroles(user='{}')", Match: PathMatch.Exact,
            Value: "CalendarUserCalendarAllowedCalendarSharingRoles", Reason: "Calendar.md directive 2 subject rename"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/users/{}/calendar/allowedcalendarsharingroles(user='{}')", Match: PathMatch.Exact,
            Value: "Invoke", Reason: "Calendar.md directive 2 retains Invoke for the renamed function"),

        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/users/{}/calendar/getschedule", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 5 removes Get-UserCalendarSchedule"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/users/{}/calendars/{}/getschedule", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 5 removes Get-UserCalendarSchedule"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/calendar/events/delta", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directives 1 and 6 remove the default-calendar event delta"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/calendars/{}/events/delta", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md directive 6 removes Get-UserCalendarEventDelta"),

        // Reconcile existing v1.0 collision suppressions for beta, not additional regex
        // matches. Both-profile oracle evidence and retained routes are in the ledger.
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/calendarview", Match: PathMatch.Exact, Value: null,
            Reason: "existing collision suppression: group calendarView ships from /calendar/calendarView"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/calendarview", Match: PathMatch.Exact, Value: null,
            Reason: "existing collision suppression: user calendarView ships from /calendar/calendarView"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/calendars/{}/calendarview", Match: PathMatch.Exact, Value: null,
            Reason: "existing collision suppression: user calendarView ships from /calendar/calendarView"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/calendar/events/$count", Match: PathMatch.Exact, Value: null,
            Reason: "existing collision suppression: no published default-calendar event count route"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/calendars/{}/events/$count", Match: PathMatch.Exact, Value: null,
            Reason: "existing collision suppression: no published named-calendar event count route"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/users/{}/calendars/{}/permanentdelete", Match: PathMatch.Exact, Value: null,
            Reason: "existing collision suppression: permanentDelete ships from the default calendar"),
    ];
}

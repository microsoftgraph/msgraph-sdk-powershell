### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Calendar

$params = @{
	name = "Marketing calendar"
}

# A UPN can also be used as -UserId.
New-MgBetaUserCalendarGroupCalendar -UserId $userId -CalendarGroupId $calendarGroupId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaUserCalendarGroupCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


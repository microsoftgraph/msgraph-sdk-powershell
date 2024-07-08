### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	name = "name-value"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserCalendarGroup -UserId $userId -CalendarGroupId $calendarGroupId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserCalendarGroup Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


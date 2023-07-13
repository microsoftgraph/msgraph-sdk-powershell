### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Calendar

$params = @{
	name = "Volunteer"
}

# A UPN can also be used as -UserId.
New-MgBetaUserCalendar -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


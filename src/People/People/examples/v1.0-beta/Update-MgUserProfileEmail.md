### Example 1: Using the Update-MgUserProfileEmail Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	DisplayName = "Business Email"
	Type = "work"
}
Update-MgUserProfileEmail -UserId $userId -ItemEmailId $itemEmailId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileEmail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Update-MgBetaUserProfileEmail Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	DisplayName = "Business Email"
	Type = "work"
}
Update-MgBetaUserProfileEmail -UserId $userId -ItemEmailId $itemEmailId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileEmail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

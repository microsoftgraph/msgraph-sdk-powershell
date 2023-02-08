### Example 1: Using the Update-MgBetaUserProfilePhone Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Type = "other"
}
Update-MgBetaUserProfilePhone -UserId $userId -ItemPhoneId $itemPhoneId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfilePhone Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

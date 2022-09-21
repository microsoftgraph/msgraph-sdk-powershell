### Example 1: Using the Update-MgUserProfilePhone Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Type = "other"
}
Update-MgUserProfilePhone -UserId $userId -ItemPhoneId $itemPhoneId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfilePhone Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

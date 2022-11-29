### Example 1: Using the New-MgUserProfilePhone Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	DisplayName = "Car Phone"
	Number = "+7 499 342 22 13"
}
# A UPN can also be used as -UserId.
New-MgUserProfilePhone -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfilePhone Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

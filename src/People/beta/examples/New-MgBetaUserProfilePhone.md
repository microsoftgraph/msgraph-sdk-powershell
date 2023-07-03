### Example 1: Using the New-MgBetaUserProfilePhone Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	DisplayName = "Car Phone"
	Number = "+7 499 342 22 13"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfilePhone -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfilePhone Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Update-MgBetaUserProfileAddress Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	AllowedAudiences = "me"
	DisplayName = "Secret Hideout"
}
Update-MgBetaUserProfileAddress -UserId $userId -ItemAddressId $itemAddressId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileAddress Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Update-MgUserProfileAddress Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	AllowedAudiences = "me"
	DisplayName = "Secret Hideout"
}
Update-MgUserProfileAddress -UserId $userId -ItemAddressId $itemAddressId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileAddress Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

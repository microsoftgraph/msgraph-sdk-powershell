### Example 1: Using the Update-MgBetaUserProfileWebsite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Description = "Lyn Damer play in the Women's 1st Division (Toppserien) in Norway"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserProfileWebsite -UserId $userId -PersonWebsiteId $personWebsiteId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileWebsite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

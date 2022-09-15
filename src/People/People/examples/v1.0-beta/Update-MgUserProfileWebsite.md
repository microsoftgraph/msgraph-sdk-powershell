### Example 1: Using the Update-MgUserProfileWebsite Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Description = "Lyn Damer play in the Women's 1st Division (Toppserien) in Norway"
}
# A UPN can also be used as -UserId.
Update-MgUserProfileWebsite -UserId $userId -PersonWebsiteId $personWebsiteId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileWebsite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

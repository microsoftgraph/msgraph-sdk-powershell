### Example 1: Using the Update-MgBetaUserProfilePatent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Number = "USPTO-3954432633"
	WebUrl = "https://patents.gov/3954432633"
}
Update-MgBetaUserProfilePatent -UserId $userId -ItemPatentId $itemPatentId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfilePatent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

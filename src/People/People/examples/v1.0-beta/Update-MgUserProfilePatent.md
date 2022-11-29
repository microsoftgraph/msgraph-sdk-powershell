### Example 1: Using the Update-MgUserProfilePatent Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Number = "USPTO-3954432633"
	WebUrl = "https://patents.gov/3954432633"
}
Update-MgUserProfilePatent -UserId $userId -ItemPatentId $itemPatentId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfilePatent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

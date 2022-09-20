### Example 1: Using the Update-MgUserProfileInterest Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Categories = @(
		"Sports"
	)
}
# A UPN can also be used as -UserId.
Update-MgUserProfileInterest -UserId $userId -PersonInterestId $personInterestId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileInterest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

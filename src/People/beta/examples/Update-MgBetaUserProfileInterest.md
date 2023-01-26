### Example 1: Using the Update-MgBetaUserProfileInterest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Categories = @(
		"Sports"
	)
}
# A UPN can also be used as -UserId.
Update-MgBetaUserProfileInterest -UserId $userId -PersonInterestId $personInterestId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileInterest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Invoke-MgBetaDismissRiskyUser Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	UserIds = @(
		"04487ee0-f4f6-4e7f-8999-facc5a30e232"
		"13387ee0-f4f6-4e7f-8999-facc5120e345"
	)
}
Invoke-MgBetaDismissRiskyUser -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaDismissRiskyUser Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

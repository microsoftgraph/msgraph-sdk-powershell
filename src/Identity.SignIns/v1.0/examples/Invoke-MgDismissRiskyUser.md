### Example 1: Using the Invoke-MgDismissRiskyUser Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	UserIds = @(
		"04487ee0-f4f6-4e7f-8999-facc5a30e232"
		"13387ee0-f4f6-4e7f-8999-facc5120e345"
	)
}
Invoke-MgDismissRiskyUser -BodyParameter $params
```
This example shows how to use the Invoke-MgDismissRiskyUser Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

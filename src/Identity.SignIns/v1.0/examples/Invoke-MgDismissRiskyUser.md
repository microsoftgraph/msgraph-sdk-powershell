### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	userIds = @(
	"04487ee0-f4f6-4e7f-8999-facc5a30e232"
"13387ee0-f4f6-4e7f-8999-facc5120e345"
)
}

Invoke-MgDismissRiskyUser -BodyParameter $params

```
This example shows how to use the Invoke-MgDismissRiskyUser Cmdlet.


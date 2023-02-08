### Example 1: Using the Confirm-MgBetaAuditLogSignInSafe Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Reports
$params = @{
	RequestIds = @(
		"5a0c76d2-cb57-4ece-9bc1-c323178f116a"
		"96609214-09ef-4f80-9d4a-ace5fceecaec"
		"05020696-4eb8-45a3-918f-8f8bb7ad6015"
	)
}
Confirm-MgBetaAuditLogSignInSafe -BodyParameter $params
```
This example shows how to use the Confirm-MgBetaAuditLogSignInSafe Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

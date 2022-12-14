### Example 1: Using the New-MgBetaProgram Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	DisplayName = "testprogram3"
	Description = "test description"
}
New-MgBetaProgram -BodyParameter $params
```
This example shows how to use the New-MgBetaProgram Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

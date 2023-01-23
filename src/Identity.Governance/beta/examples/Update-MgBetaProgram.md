### Example 1: Using the Update-MgBetaProgram Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	DisplayName = "testprogram3 new name"
}
Update-MgBetaProgram -ProgramId $programId -BodyParameter $params
```
This example shows how to use the Update-MgBetaProgram Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Update-MgProgram Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "testprogram3 new name"
}
Update-MgProgram -ProgramId $programId -BodyParameter $params
```
This example shows how to use the Update-MgProgram Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

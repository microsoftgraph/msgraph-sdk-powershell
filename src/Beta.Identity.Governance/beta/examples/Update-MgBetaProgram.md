### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "testprogram3 new name"
}

Update-MgBetaProgram -ProgramId $programId -BodyParameter $params

```
This example shows how to use the Update-MgBetaProgram Cmdlet.


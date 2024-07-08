### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "testprogram3"
	description = "test description"
}

New-MgBetaProgram -BodyParameter $params

```
This example shows how to use the New-MgBetaProgram Cmdlet.


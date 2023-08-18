### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	id = "contosohr"
	name = "Contoso HR"
	description = "Connection to index Contoso HR system"
}

New-MgBetaExternalConnection -BodyParameter $params

```
This example shows how to use the New-MgBetaExternalConnection Cmdlet.


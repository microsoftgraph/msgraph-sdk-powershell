### Example 1: Using the New-MgBetaExternalConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Search
$params = @{
	Id = "contosohr"
	Name = "Contoso HR"
	Description = "Connection to index Contoso HR system"
}
New-MgBetaExternalConnection -BodyParameter $params
```
This example shows how to use the New-MgBetaExternalConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

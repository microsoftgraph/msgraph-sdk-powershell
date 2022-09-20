### Example 1: Using the New-MgExternalConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
$params = @{
	Id = "contosohr"
	Name = "Contoso HR"
	Description = "Connection to index Contoso HR system"
}
New-MgExternalConnection -BodyParameter $params
```
This example shows how to use the New-MgExternalConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

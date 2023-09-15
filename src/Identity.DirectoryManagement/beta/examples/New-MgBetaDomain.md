### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	id = "contoso.com"
}

New-MgBetaDomain -BodyParameter $params
```
This example shows how to use the New-MgBetaDomain Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


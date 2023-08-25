### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	id = "contoso.com"
}

New-MgDomain -BodyParameter $params
```
This example shows how to use the New-MgDomain Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


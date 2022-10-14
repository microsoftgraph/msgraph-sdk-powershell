### Example 1: Using the New-MgDomain Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	Id = "contoso.com"
}
New-MgDomain -BodyParameter $params
```
This example shows how to use the New-MgDomain Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

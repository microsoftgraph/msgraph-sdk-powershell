### Example 1: Using the New-MgBetaDomain Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	Id = "contoso.com"
}
New-MgBetaDomain -BodyParameter $params
```
This example shows how to use the New-MgBetaDomain Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

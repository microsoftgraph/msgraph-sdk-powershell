### Example 1: Using the New-MgProgram Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "testprogram3"
	Description = "test description"
}
New-MgProgram -BodyParameter $params
```
This example shows how to use the New-MgProgram Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

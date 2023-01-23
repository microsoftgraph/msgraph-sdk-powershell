### Example 1: Using the New-MgBetaDirectoryAttributeSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	Id = "Engineering"
	Description = "Attributes for engineering team"
	MaxAttributesPerSet = 25
}
New-MgBetaDirectoryAttributeSet -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryAttributeSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

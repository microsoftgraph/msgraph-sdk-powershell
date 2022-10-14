### Example 1: Using the New-MgDirectoryAttributeSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	Id = "Engineering"
	Description = "Attributes for engineering team"
	MaxAttributesPerSet = 25
}
New-MgDirectoryAttributeSet -BodyParameter $params
```
This example shows how to use the New-MgDirectoryAttributeSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

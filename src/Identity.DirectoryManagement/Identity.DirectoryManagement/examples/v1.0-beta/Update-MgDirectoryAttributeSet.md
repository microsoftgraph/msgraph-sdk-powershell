### Example 1: Using the Update-MgDirectoryAttributeSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	Description = "Attributes for engineering team"
	MaxAttributesPerSet = 20
}
Update-MgDirectoryAttributeSet -AttributeSetId $attributeSetId -BodyParameter $params
```
This example shows how to use the Update-MgDirectoryAttributeSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

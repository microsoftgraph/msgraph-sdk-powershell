### Example 1: Using the Update-MgBetaDirectoryAttributeSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	Description = "Attributes for engineering team"
	MaxAttributesPerSet = 20
}
Update-MgBetaDirectoryAttributeSet -AttributeSetId $attributeSetId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDirectoryAttributeSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

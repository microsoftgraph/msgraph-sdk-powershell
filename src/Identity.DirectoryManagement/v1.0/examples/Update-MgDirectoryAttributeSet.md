### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	description = "Attributes for engineering team"
	maxAttributesPerSet = 20
}

Update-MgDirectoryAttributeSet -AttributeSetId $attributeSetId -BodyParameter $params

```
This example shows how to use the Update-MgDirectoryAttributeSet Cmdlet.


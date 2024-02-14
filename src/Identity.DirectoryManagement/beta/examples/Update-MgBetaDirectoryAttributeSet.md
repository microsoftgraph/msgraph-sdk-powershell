### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	description = "Attributes for engineering team"
	maxAttributesPerSet = 20
}

Update-MgBetaDirectoryAttributeSet -AttributeSetId $attributeSetId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryAttributeSet Cmdlet.


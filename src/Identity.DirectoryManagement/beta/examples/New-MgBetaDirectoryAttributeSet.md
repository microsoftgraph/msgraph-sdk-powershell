### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	id = "Engineering"
	description = "Attributes for engineering team"
	maxAttributesPerSet = 25
}

New-MgBetaDirectoryAttributeSet -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryAttributeSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


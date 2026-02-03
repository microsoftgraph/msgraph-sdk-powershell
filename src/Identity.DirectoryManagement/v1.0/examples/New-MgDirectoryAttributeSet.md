### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	id = "Engineering"
	description = "Attributes for engineering team"
	maxAttributesPerSet = 25
}

New-MgDirectoryAttributeSet -BodyParameter $params

```
This example shows how to use the New-MgDirectoryAttributeSet Cmdlet.


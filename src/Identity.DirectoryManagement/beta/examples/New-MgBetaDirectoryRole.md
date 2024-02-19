### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	roleTemplateId = "fe930be7-5e62-47db-91af-98c3a49a38b1"
}

New-MgBetaDirectoryRole -BodyParameter $params

```
This example shows how to use the New-MgBetaDirectoryRole Cmdlet.


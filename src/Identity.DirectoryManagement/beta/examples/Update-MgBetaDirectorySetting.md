### Example 1: Using the Update-MgBetaDirectorySetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	Values = @(
		@{
			Name = "CustomBlockedWordsList"
			Value = "Contoso"
		}
	)
}
Update-MgBetaDirectorySetting -DirectorySettingId $directorySettingId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDirectorySetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

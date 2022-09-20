### Example 1: Using the Update-MgDirectorySetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	Values = @(
		@{
			Name = "CustomBlockedWordsList"
			Value = "Contoso"
		}
	)
}
Update-MgDirectorySetting -DirectorySettingId $directorySettingId -BodyParameter $params
```
This example shows how to use the Update-MgDirectorySetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

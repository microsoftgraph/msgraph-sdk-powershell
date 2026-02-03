### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	values = @(
		@{
			name = "CustomBlockedWordsList"
			value = "Contoso"
		}
	)
}

Update-MgBetaDirectorySetting -DirectorySettingId $directorySettingId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectorySetting Cmdlet.


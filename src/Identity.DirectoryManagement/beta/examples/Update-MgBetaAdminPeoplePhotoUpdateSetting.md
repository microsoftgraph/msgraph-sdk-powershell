### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.photoUpdateSettings"
	source = "String"
	allowedRoles = @(
	"String"
)
}

Update-MgBetaAdminPeoplePhotoUpdateSetting -BodyParameter $params

```
This example shows how to use the Update-MgBetaAdminPeoplePhotoUpdateSetting Cmdlet.


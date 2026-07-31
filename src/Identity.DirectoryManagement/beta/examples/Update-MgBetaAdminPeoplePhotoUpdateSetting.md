### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	source = "cloud"
	allowedRoles = @(
	)
}

Update-MgBetaAdminPeoplePhotoUpdateSetting -BodyParameter $params

```
This example shows how to use the Update-MgBetaAdminPeoplePhotoUpdateSetting Cmdlet.


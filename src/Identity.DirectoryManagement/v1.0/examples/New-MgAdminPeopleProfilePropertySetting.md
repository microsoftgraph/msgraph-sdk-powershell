### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.profilePropertySetting"
	displayName = "Profile priority config"
	name = "Profile priority config"
	prioritizedSourceUrls = @(
	"https://graph.microsoft.com/v1.0/admin/people/profileSources(sourceId='contosohr1')"
)
}

New-MgAdminPeopleProfilePropertySetting -BodyParameter $params

```
This example shows how to use the New-MgAdminPeopleProfilePropertySetting Cmdlet.


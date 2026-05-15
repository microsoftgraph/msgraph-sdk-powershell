### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.profilePropertySetting"
	prioritizedSourceUrls = @(
	"https://graph.microsoft.com/v1.0/admin/people/profileSources(sourceId='contosohr1')"
"https://graph.microsoft.com/v1.0/admin/people/profileSources(sourceId='contosohr2')"
)
}

Update-MgAdminPeopleProfilePropertySetting -ProfilePropertySettingId $profilePropertySettingId -BodyParameter $params

```
This example shows how to use the Update-MgAdminPeopleProfilePropertySetting Cmdlet.


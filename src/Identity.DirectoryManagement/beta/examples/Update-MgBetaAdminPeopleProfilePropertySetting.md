### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.profilePropertySetting"
	prioritizedSourceUrls = @(
	"https://graph.microsoft.com/beta/admin/people/profileSources(sourceId='contosohr1')"
"https://graph.microsoft.com/beta/admin/people/profileSources(sourceId='contosohr2')"
)
}

Update-MgBetaAdminPeopleProfilePropertySetting -ProfilePropertySettingId $profilePropertySettingId -BodyParameter $params

```
This example shows how to use the Update-MgBetaAdminPeopleProfilePropertySetting Cmdlet.


### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.profilePropertySetting"
	prioritizedSourceUrls = @(
	"https://graph.microsoft.com/beta/admin/people/profileSources(sourceId='contosohr1')"
)
}

New-MgBetaAdminPeopleProfilePropertySetting -BodyParameter $params

```
This example shows how to use the New-MgBetaAdminPeopleProfilePropertySetting Cmdlet.


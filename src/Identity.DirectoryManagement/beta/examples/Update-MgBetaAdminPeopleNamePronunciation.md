### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.namePronunciationSettings"
	isEnabledInOrganization = $true
}

Update-MgBetaAdminPeopleNamePronunciation -BodyParameter $params

```
This example shows how to use the Update-MgBetaAdminPeopleNamePronunciation Cmdlet.


### Example 1: Update settings for contact insights

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	isEnabledInOrganization = $true
	disabledForGroup = "edbfe4fb-ec70-4300-928f-dbb2ae86c981"
}

Update-MgBetaOrganizationSettingContactInsight -OrganizationId $organizationId -BodyParameter $params

```
This example will update settings for contact insights


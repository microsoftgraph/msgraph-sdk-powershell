### Example 1: Using the Update-MgOrganizationSettingContactInsight Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	IsEnabledInOrganization = $true
	DisabledForGroup = "edbfe4fb-ec70-4300-928f-dbb2ae86c981"
}
Update-MgOrganizationSettingContactInsight -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the Update-MgOrganizationSettingContactInsight Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

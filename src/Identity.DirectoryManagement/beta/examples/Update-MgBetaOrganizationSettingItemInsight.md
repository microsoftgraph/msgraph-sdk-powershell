### Example 1: Using the Update-MgBetaOrganizationSettingItemInsight Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	DisabledForGroup = "edbfe4fb-ec70-4300-928f-dbb2ae86c981"
}
Update-MgBetaOrganizationSettingItemInsight -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaOrganizationSettingItemInsight Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

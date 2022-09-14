### Example 1: Using the Update-MgEntitlementManagementSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	ExternalUserLifecycleAction = "None"
}
Update-MgEntitlementManagementSetting -BodyParameter $params
```
This example shows how to use the Update-MgEntitlementManagementSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

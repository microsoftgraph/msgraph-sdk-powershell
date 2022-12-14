### Example 1: Using the Update-MgBetaEntitlementManagementSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	ExternalUserLifecycleAction = "None"
}
Update-MgBetaEntitlementManagementSetting -BodyParameter $params
```
This example shows how to use the Update-MgBetaEntitlementManagementSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

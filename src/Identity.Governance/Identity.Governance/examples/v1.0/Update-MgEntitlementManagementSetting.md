### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	ExternalUserLifecycleAction = "None"
}
Update-MgEntitlementManagementSetting -BodyParameter $params
```

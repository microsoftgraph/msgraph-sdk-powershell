###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	ExternalUserLifecycleAction = "None"
}
Update-MgEntitlementManagementSetting -BodyParameter $params
```

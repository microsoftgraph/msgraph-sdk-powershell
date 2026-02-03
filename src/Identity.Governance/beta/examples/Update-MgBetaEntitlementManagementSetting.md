### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	externalUserLifecycleAction = "None"
}

Update-MgBetaEntitlementManagementSetting -BodyParameter $params

```
This example shows how to use the Update-MgBetaEntitlementManagementSetting Cmdlet.


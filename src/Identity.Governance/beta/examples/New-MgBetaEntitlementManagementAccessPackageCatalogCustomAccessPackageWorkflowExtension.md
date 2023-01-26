### Example 1: Using the New-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	DisplayName = "test_action_0124"
	Description = "this is for graph testing only"
	EndpointConfiguration = @{
		"@odata.type" = "#microsoft.graph.logicAppTriggerEndpointConfiguration"
		SubscriptionId = "38ab2ccc-3747-4567-b36b-9478f5602f0d"
		ResourceGroupName = "EMLogicApp"
		LogicAppWorkflowName = "customextension_test"
	}
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.azureAdTokenAuthentication"
		ResourceId = "f604bd15-f785-4309-ad7c-6fad18ddb6cb"
	}
}
New-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension -AccessPackageCatalogId $accessPackageCatalogId -BodyParameter $params
```
This example shows how to use the New-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

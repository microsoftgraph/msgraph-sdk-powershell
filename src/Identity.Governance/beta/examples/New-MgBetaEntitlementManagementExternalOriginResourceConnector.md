### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.externalOriginResourceConnector"
	displayName = "SAP Access Control"
	description = "SAP Access Control connector"
	connectorType = "sapAc"
	connectionInfo = @{
		"@odata.type" = "microsoft.graph.externalTokenBasedSapIagConnectionInfo"
		url = "dev.test"
		accessTokenUrl = "9e90019f-6256-41fa-a225-5ef9cc1d9bf8"
		clientId = "e9ad8b1d-959c-4e86-8ba2-2cbf4d14bc29"
		keyVaultName = "Keyvault"
		secretName = "Test"
		subscriptionId = "5ee98b73-d9df-43a7-8a92-36855054bdee"
		resourceGroup = "SAPIAG Group"
	}
}

New-MgBetaEntitlementManagementExternalOriginResourceConnector -BodyParameter $params

```
This example shows how to use the New-MgBetaEntitlementManagementExternalOriginResourceConnector Cmdlet.


### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	id = "d743fe46-80f8-41b1-a2ee-7796e024edb9"
	connectorType = "sapIag"
	displayName = "SAP IAG 5.0"
	description = "SAP IAG 5.0.0.0.0"
	connectionInfo = @{
		"@odata.type" = "Microsoft.IGAELM.EC.FrontEnd.ExternalModel.externalTokenBasedSapIagConnectionInfo"
		url = "https://IAGINTGORG-iag-intg-space-java-rest-arqapi.cfps.sap.hana.ondemand.com"
		keyVaultName = "sap-key-vault"
		subscriptionId = "caa5v042-9c76-44de-9e84-f3e3071a7b4e"
		resourceGroup = "test-rg"
		accessTokenUrl = "https://entra-intg-l4nds6yn.authentication.sap.hana.ondemand.com/oauth/token"
		clientId = "sb-8d896b-72b5-46ce-9273-471874a09137!b133623|iagapi-iag-intg-space!b11378"
		secretName = "clienecret"
	}
}

Update-MgBetaEntitlementManagementExternalOriginResourceConnector -ExternalOriginResourceConnectorId $externalOriginResourceConnectorId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEntitlementManagementExternalOriginResourceConnector Cmdlet.


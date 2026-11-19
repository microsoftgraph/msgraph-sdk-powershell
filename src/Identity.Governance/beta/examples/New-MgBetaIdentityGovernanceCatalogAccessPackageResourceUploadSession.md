### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.customDataProvidedResourceAccessReviewUploadSession"
	data = @{
		"@odata.type" = "#microsoft.graph.customDataProvidedResourcePayloads.accessReviewContextData"
		reviewDefinitionId = "9e4b1c6f-2a3d-4f8e-9b7a-5c1e2d3f4a6b"
		reviewInstanceId = "15eeb4df-8a4d-4f8e-9b7a-6b3e1c7f5a9d"
	}
}

New-MgBetaIdentityGovernanceCatalogAccessPackageResourceUploadSession -AccessPackageCatalogId $accessPackageCatalogId -AccessPackageResourceId $accessPackageResourceId -BodyParameter $params

```
This example shows how to use the New-MgBetaIdentityGovernanceCatalogAccessPackageResourceUploadSession Cmdlet.


### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	isUploadDone = $true
}

Update-MgBetaIdentityGovernanceCatalogAccessPackageResourceUploadSession -AccessPackageCatalogId $accessPackageCatalogId -AccessPackageResourceId $accessPackageResourceId -CustomDataProvidedResourceUploadSessionId $customDataProvidedResourceUploadSessionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityGovernanceCatalogAccessPackageResourceUploadSession Cmdlet.


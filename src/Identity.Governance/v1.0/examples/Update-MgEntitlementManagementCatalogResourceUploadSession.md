### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	isUploadDone = $true
}

Update-MgEntitlementManagementCatalogResourceUploadSession -AccessPackageCatalogId $accessPackageCatalogId -AccessPackageResourceId $accessPackageResourceId -CustomDataProvidedResourceUploadSessionId $customDataProvidedResourceUploadSessionId -BodyParameter $params

```
This example shows how to use the Update-MgEntitlementManagementCatalogResourceUploadSession Cmdlet.


### Example 1: Retrieving the roles of a resource for a group

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgEntitlementManagementCatalogResourceRole -AccessPackageCatalogId $accessPackageCatalogId -Filter "(originSystem eq 'AadGroup' and resource/id eq 'a35bef72-a8aa-4ca3-af30-f6b2ece7208f')" -ExpandProperty "resource" 

```
This example shows retrieving the roles of a resource for a group

### Example 2: Retrieving the roles of a resource for a SharePoint Online site collection

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgEntitlementManagementCatalogResourceRole -AccessPackageCatalogId $accessPackageCatalogId -Filter "(originSystem eq 'SharePointOnline' and resource/id eq 'dcc3f966-a73c-48e2-8c1d-bcac775488c3')" -ExpandProperty "resource" 

```
This example shows retrieving the roles of a resource for a sharepoint online site collection


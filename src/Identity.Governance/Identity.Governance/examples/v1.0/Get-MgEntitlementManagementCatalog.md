### Example 1: Get a list of all access package catalogs

```powershell
Get-MgEntitlementManagementCatalog | fl

AccessPackages       :
CatalogType          : serviceDefault
CreatedDateTime      : 1/13/2022 6:47:56 AM
Description          : Built-in catalog.
DisplayName          : General
Id                   : 88d3e491-5247-4209-9b56-c4c95d9694e9
IsExternallyVisible  : True
ModifiedDateTime     : 1/13/2022 6:47:56 AM
State                : published
AdditionalProperties : {}
```

This examples gets a list of all the access package catalogs.

### Example 2: Get a access package catalog by the AccessPackageCatalogId

```powershell
Get-MgEntitlementManagementCatalog -AccessPackageCatalogId '88d3e491-5247-4209-9b56-c4c95d9694e9' |fl

AccessPackages       :
CatalogType          : serviceDefault
CreatedDateTime      : 1/13/2022 6:47:56 AM
Description          : Built-in catalog.
DisplayName          : General
Id                   : 88d3e491-5247-4209-9b56-c4c95d9694e9
IsExternallyVisible  : True
ModifiedDateTime     : 1/13/2022 6:47:56 AM
State                : published
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#identityGovernance/entitlementManag
                       ement/catalogs/$entity]}
```

his examples gets access package catalog for the specified access package Id.


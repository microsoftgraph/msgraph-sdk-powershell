### Example 1: Get a list of all access package catalogs

```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgEntitlementManagementAccessPackageCatalog | Format-list

AccessPackageResourceRoles  :
AccessPackageResourceScopes :
AccessPackageResources      :
AccessPackages              :
CatalogStatus               : Published
CatalogType                 : ServiceDefault
CreatedBy                   : Azure AD
CreatedDateTime             : 9/15/2021 7:23:24 AM
Description                 : Built-in catalog.
DisplayName                 : General
Id                          : 54152ecb-c65d-47f2-8a4d-ba2732de0a7b
IsExternallyVisible         : True
ModifiedBy                  : Azure AD
ModifiedDateTime            : 9/15/2021 7:23:24 AM
AdditionalProperties        : {}
```

This command returns a list of all the access package catalogs.

### Example 2: Filter the access package catalogs by the display name

```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgEntitlementManagementAccessPackageCatalog -Filter "DisplayName eq 'General'" | Format-List

AccessPackageResourceRoles  :
AccessPackageResourceScopes :
AccessPackageResources      :
AccessPackages              :
CatalogStatus               : Published
CatalogType                 : ServiceDefault
CreatedBy                   : Azure AD
CreatedDateTime             : 9/15/2021 7:23:24 AM
Description                 : Built-in catalog.
DisplayName                 : General
Id                          : 54152ecb-c65d-47f2-8a4d-ba2732de0a7b
IsExternallyVisible         : True
ModifiedBy                  : Azure AD
ModifiedDateTime            : 9/15/2021 7:23:24 AM
AdditionalProperties        : {}
```

This command returns the access package catalogs that meet the defined filter.

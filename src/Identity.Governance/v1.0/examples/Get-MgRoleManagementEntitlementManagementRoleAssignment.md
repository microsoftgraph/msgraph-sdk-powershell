### Example 1: Request using $filter for role assignments on an access package catalog and expand the principal object

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgRoleManagementEntitlementManagementRoleAssignment -Filter "appScopeId eq '/AccessPackageCatalog/4cee616b-fdf9-4890-9d10-955e0ccb12bc'" -ExpandProperty "principal" 

```
This example will request using $filter for role assignments on an access package catalog and expand the principal object


###Example 1
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementEntitlementManagementRoleAssignment -Filter "appScopeId eq '/AccessPackageCatalog/4cee616b-fdf9-4890-9d10-955e0ccb12bc'" -ExpandProperty "principal" 
```

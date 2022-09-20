### Example 1: Using the Get-MgEntitlementManagementAccessPackageResourceEnvironment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgEntitlementManagementAccessPackageResourceEnvironment -AccessPackageResourceEnvironmentId $accessPackageResourceEnvironmentId
```
This example shows how to use the Get-MgEntitlementManagementAccessPackageResourceEnvironment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgEntitlementManagementAccessPackageResourceEnvironment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgEntitlementManagementAccessPackageResourceEnvironment -Filter "originSystem eq 'SharePointOnline'" 
```
This example shows how to use the Get-MgEntitlementManagementAccessPackageResourceEnvironment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

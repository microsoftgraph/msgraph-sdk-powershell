### Example 1: Create an access package

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
New-MgBetaEntitlementManagementAccessPackage -CatalogId '54152ecb-c65d-47f2-8a4d-ba2732de0a7b'  -DisplayName 'Marketing Campaign' | Format-list

AccessPackageAssignmentPolicies :
AccessPackageCatalog            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog
AccessPackageResourceRoleScopes :
AccessPackagesIncompatibleWith  :
CatalogId                       : 54152ecb-c65d-47f2-8a4d-ba2732de0a7b
CreatedBy                       : admin@M365x814237.onmicrosoft.com
CreatedDateTime                 : 10/13/2021 9:08:02 AM
Description                     :
DisplayName                     : Marketing Campaign
Id                              : 481927e3-c76b-447e-a97d-a944f694ce03
IncompatibleAccessPackages      :
IncompatibleGroups              :
IsHidden                        : False
IsRoleScopesVisible             : False
ModifiedBy                      : admin@M365x814237.onmicrosoft.com
ModifiedDateTime                : 10/13/2021 9:08:02 AM
AdditionalProperties            : {[@odata.context, https://graph.microsoft.com/beta/$metadata#identityGovernance/entitlementManagement/accessPackages/$entity]}
```

This example creates an access package with he defined display name under the specified catalog. The $allowedRequestors variable should contain the **id** of the requestor.

### Example 1: Get a list of all access packages

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgBetaEntitlementManagementAccessPackage | Format-List

AccessPackageAssignmentPolicies :
AccessPackageCatalog            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog
AccessPackageResourceRoleScopes :
AccessPackagesIncompatibleWith  :
CatalogId                       : 54152ecb-c65d-47f2-8a4d-ba2732de0a7b
CreatedBy                       : admin@M365x814237.onmicrosoft.com
CreatedDateTime                 : 11/5/2021 8:03:39 AM
Description                     :
DisplayName                     : Marketing Campaign
Id                              : bc041fda-b3ba-41fc-b911-ca95f7aac656
IncompatibleAccessPackages      :
IncompatibleGroups              :
IsHidden                        : False
IsRoleScopesVisible             : False
ModifiedBy                      : admin@M365x814237.onmicrosoft.com
ModifiedDateTime                : 11/5/2021 9:08:44 AM
AdditionalProperties            : {}

AccessPackageAssignmentPolicies :
AccessPackageCatalog            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog
AccessPackageResourceRoleScopes :
AccessPackagesIncompatibleWith  :
CatalogId                       : 54152ecb-c65d-47f2-8a4d-ba2732de0a7b
CreatedBy                       : admin@M365x814237.onmicrosoft.com
CreatedDateTime                 : 9/15/2021 7:23:44 AM
Description                     : Access for Sales and Marketing users and guests
DisplayName                     : Sales and Marketing
Id                              : b90cbf24-66b9-4cd8-b270-863b6fca641c
IncompatibleAccessPackages      :
IncompatibleGroups              :
IsHidden                        : False
IsRoleScopesVisible             : False
ModifiedBy                      : admin@M365x814237.onmicrosoft.com
ModifiedDateTime                : 9/15/2021 7:23:44 AM
AdditionalProperties            : {}
```

This examples returns all access packages.

### Example 2: Get access package by Id

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgBetaEntitlementManagementAccessPackage -AccessPackageId 'bc041fda-b3ba-41fc-b911-ca95f7aac656'| Format-List


AccessPackageAssignmentPolicies :
AccessPackageCatalog            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog
AccessPackageResourceRoleScopes :
AccessPackagesIncompatibleWith  :
CatalogId                       : 54152ecb-c65d-47f2-8a4d-ba2732de0a7b
CreatedBy                       : admin@M365x814237.onmicrosoft.com
CreatedDateTime                 : 11/5/2021 8:03:39 AM
Description                     :
DisplayName                     : Marketing Campaign
Id                              : bc041fda-b3ba-41fc-b911-ca95f7aac656
IncompatibleAccessPackages      :
IncompatibleGroups              :
IsHidden                        : False
IsRoleScopesVisible             : False
ModifiedBy                      : admin@M365x814237.onmicrosoft.com
ModifiedDateTime                : 11/5/2021 9:08:44 AM
AdditionalProperties            : {[@odata.context, https://graph.microsoft.com/beta/$metadata#identityGovernance/entitlementManagement/accessPackages/$entity]}

```

This example returns the access package of the specified id.

### Example 1: Get a list of all access packages

```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgEntitlementManagementAccessPackage | Format-List

AssignmentPolicies   :
Catalog              : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog1
CreatedDateTime      : 5/4/2022 10:02:17 AM
Description          :
DisplayName          : Marketing Campaign
Id                   : 5c17e2d4-b421-4c32-ac09-8b96cddd3042
IsHidden             : False
ModifiedDateTime     : 5/4/2022 10:07:59 AM
AdditionalProperties : {}

AssignmentPolicies   :
Catalog              : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog1
CreatedDateTime      : 1/13/2022 6:48:14 AM
Description          : Access for Sales and Marketing users and guests
DisplayName          : Sales and Marketing
Id                   : 3f367184-5e17-47d6-b505-4cb43b471875
IsHidden             : False
ModifiedDateTime     : 1/13/2022 6:48:14 AM
AdditionalProperties : {}
```

This examples returns all access packages.

### Example 2: Get access package by Id

```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgEntitlementManagementAccessPackage -AccessPackageId '5c17e2d4-b421-4c32-ac09-8b96cddd3042'| Format-List

AssignmentPolicies   :
Catalog              : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog1
CreatedDateTime      : 5/4/2022 10:02:17 AM
Description          :
DisplayName          : Marketing Campaign
Id                   : 5c17e2d4-b421-4c32-ac09-8b96cddd3042
IsHidden             : False
ModifiedDateTime     : 5/4/2022 10:07:59 AM
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#identityGovernance/entitlementManagement/accessPackages/$entity]}
```

This example returns the access package of the specified Id.

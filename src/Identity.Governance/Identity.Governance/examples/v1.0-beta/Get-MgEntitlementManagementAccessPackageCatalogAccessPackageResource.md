### Example 1: Get catalog resources by catalog id

```powershell
Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResource -AccessPackageCatalogId '54152ecb-c65d-47f2-8a4d-ba2732de0a7b' | Format-List

AccessPackageResourceEnvironment : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageResourceEnvironment
AccessPackageResourceRoles       :
AccessPackageResourceScopes      :
AddedBy                          : admin@M365x814237.onmicrosoft.com
AddedOn                          : 10/19/2021 2:50:24 PM
Attributes                       : {}
Description                      : Marketing resources
DisplayName                      : Marketing resources
Id                               : 36d8d18f-b081-4867-acf5-4a8b893761e8
IsPendingOnboarding              : False
OriginId                         : b5cd9d19-91c0-4622-93e2-537ad8a0b3ad
OriginSystem                     : AadGroup
ResourceType                     : Security Group
Url                              : https://account.activedirectory.windowsazure.com/r?tenantId=c265ddcc-4694-4bb0-b771-4829ca21177d#/manageMembership?objectType=Group&objectId=b5cd9d19-91c0-4622-93e2-537ad8a0b3ad
AdditionalProperties             : {}

AccessPackageResourceEnvironment : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageResourceEnvironment
AccessPackageResourceRoles       :
AccessPackageResourceScopes      :
AddedBy                          : admin@M365x814237.onmicrosoft.com
AddedOn                          : 10/13/2021 8:51:24 AM
Attributes                       : {}
Description                      : Marketing group2
DisplayName                      : Marketing resources2
Id                               : 99cbe4a3-d7d2-4f19-90af-cc7c9dccd7f8
IsPendingOnboarding              : False
OriginId                         : c41e321d-2907-4183-8224-b4cec9c9381b
OriginSystem                     : AadGroup
ResourceType                     : Security Group
Url                              : https://account.activedirectory.windowsazure.com/r?tenantId=c265ddcc-4694-4bb0-b771-4829ca21177d#/manageMembership?objectType=Group&objectId=c41e321d-2907-4183-8224-b4cec9c9381b
AdditionalProperties             : {}
```

This example returns all access package catalog resources for the specified catalog.

### Example 2: Use -Filter to get all catalog resources with the display name 'Marketing resources'

```powershell
Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResource -AccessPackageCatalogId '54152ecb-c65d-47f2-8a4d-ba2732de0a7b' -Filter "DisplayName eq 'Marketing resources'" | Format-List

AccessPackageResourceEnvironment : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageResourceEnvironment
AccessPackageResourceRoles       :
AccessPackageResourceScopes      :
AddedBy                          : admin@M365x814237.onmicrosoft.com
AddedOn                          : 10/19/2021 2:50:24 PM
Attributes                       : {}
Description                      : Marketing resources
DisplayName                      : Marketing resources
Id                               : 36d8d18f-b081-4867-acf5-4a8b893761e8
IsPendingOnboarding              : False
OriginId                         : b5cd9d19-91c0-4622-93e2-537ad8a0b3ad
OriginSystem                     : AadGroup
ResourceType                     : Security Group
Url                              : https://account.activedirectory.windowsazure.com/r?tenantId=c265ddcc-4694-4bb0-b771-4829ca21177d#/manageMembership?objectType=Group&objectId=b5cd9d19-91c0-4622-93e2-537ad8a0b3ad
AdditionalProperties             : {}
```

This example returns the resources in the specified catalog whose display name is `marketing resources`.

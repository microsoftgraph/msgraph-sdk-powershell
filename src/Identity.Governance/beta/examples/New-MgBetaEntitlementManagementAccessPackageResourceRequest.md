### Example 1: Create a new access package resource request

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All', 'Group.ReadWrite.All'
$accessPackageResource = @{
  "originSystem" = "AadGroup "
  OriginId= "b5cd9d19-91c0-4622-93e2-537ad8a0b3ad"
  }
New-MgBetaEntitlementManagementAccessPackageResourceRequest -CatalogId '54152ecb-c65d-47f2-8a4d-ba2732de0a7b' -RequestType "AdminAdd" -AccessPackageResource $accessPackageResource

AccessPackageResource : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageResource
CatalogId             : 54152ecb-c65d-47f2-8a4d-ba2732de0a7b
ExecuteImmediately    : False
ExpirationDateTime    :
Id                    : 88098a60-489a-4c28-bfe7-9fecd4713b81
IsValidationOnly      :
Justification         :
RequestState          : Delivered
RequestStatus         : Fulfilled
RequestType           : AdminAdd
Requestor             : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageSubject
AdditionalProperties  : {[@odata.context, https://graph.microsoft.com/beta/$metadata#identityGovernance/entitlementManagement/accessPackageResourceRequests/$entity]}                                                            
```

This example creates a new resource request for addition of a resource to an access package catalog.

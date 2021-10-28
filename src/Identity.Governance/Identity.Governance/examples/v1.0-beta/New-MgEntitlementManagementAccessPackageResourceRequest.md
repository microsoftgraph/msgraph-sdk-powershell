### Example 1: Create a new access package resource request

```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'
$accessPackageResource = @{
  "originSystem" = "AadGroup "
  OriginId= "b5cd9d19-91c0-4622-93e2-537ad8a0b3ad"
  }
New-MgEntitlementManagementAccessPackageResourceRequest -CatalogId '54152ecb-c65d-47f2-8a4d-ba2732de0a7b' -RequestType "AdminAdd" -AccessPackageResource $accessPackageResource

Id                                   CatalogId                            ExecuteImmediately ExpirationDateTime IsValidationOnly Justification RequestState RequestStatus RequestType
--                                   ---------                            ------------------ ------------------ ---------------- ------------- ------------ ------------- -----------
dce7a865-ba5d-4c86-af92-5daaa44c4b1a 54152ecb-c65d-47f2-8a4d-ba2732de0a7b False                                                                Delivered    Fulfilled     AdminAdd
```

This example create a new resource request for addition of a resource to an access package catalog, or removal of a resource from a catalog.

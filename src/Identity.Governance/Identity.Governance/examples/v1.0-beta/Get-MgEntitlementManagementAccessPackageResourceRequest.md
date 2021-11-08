### Example 1: Get all access package resource requests

```powershell
Get-MgEntitlementManagementAccessPackageResourceRequest

Id                                   CatalogId                            ExecuteImmediately ExpirationDateTime IsValidationOnly Justification RequestState   RequestStatus RequestType
--                                   ---------                            ------------------ ------------------ ---------------- ------------- ------------   ------------- -----------
88098a60-489a-4c28-bfe7-9fecd4713b81 54152ecb-c65d-47f2-8a4d-ba2732de0a7b False                                                                Delivered      Fulfilled     AdminAdd
fcbf2d6a-3b33-412b-bb41-c91b27dff4b6 54152ecb-c65d-47f2-8a4d-ba2732de0a7b False                                                                Delivered      Fulfilled     AdminAdd
6c8fd194-4998-4096-9812-de77d6994ffe 54152ecb-c65d-47f2-8a4d-ba2732de0a7b False                                                                Delivered      Fulfilled     AdminAdd
4f9584b7-c8d6-4b09-8383-8303a27d2236 54152ecb-c65d-47f2-8a4d-ba2732de0a7b False                                                                Delivered      Fulfilled     AdminAdd
52727043-09c1-412b-a3b4-7c4c4f4abfd0 54152ecb-c65d-47f2-8a4d-ba2732de0a7b False                                                                Delivered      Fulfilled     AdminAdd
ec74bc22-8d36-44a2-b294-82c538a48c4c 54152ecb-c65d-47f2-8a4d-ba2732de0a7b False                                                                Delivered      Fulfilled     AdminAdd

```

This example all access package resource requests.

### Example 2: Get all access package resource requests

```powershell
Get-MgEntitlementManagementAccessPackageResourceRequest -AccessPackageResourceRequestId '88098a60-489a-4c28-bfe7-9fecd4713b81'
```

This examples gets the access package resource request for the specified resource request id.

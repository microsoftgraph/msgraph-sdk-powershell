### Example 1: Create an assignment request

```powershell
New-MgEntitlementManagementAccessPackageAssignmentRequest -RequestType 'AdminAdd' -AccessPackageId '481927e3-c76b-447e-a97d-a944f694ce03' -AssignmentPolicyId '66eb5245-7de2-471d-a545-0528353193a4' -TargetId 'e4ef0e03-e149-4cbc-8f56-27bb22171a64'
```

This example creates an access package assignment request. **AccessPackageId** is the identifier of the access package, **AssignmentPolicyId** is the identifier of the access package assignment policy and the **TargetId** is the identifier of the user account to be assigned the access.

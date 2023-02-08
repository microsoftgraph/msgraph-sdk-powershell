### Example 1: Get catalog resource roles

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResourceRole -AccessPackageCatalogId '54152ecb-c65d-47f2-8a4d-ba2732de0a7b' -Filter "originSystem eq 'AadGroup' and accessPackageResource/id eq '36d8d18f-b081-4867-acf5-4a8b893761e8'"

Id                                   Description DisplayName OriginId                                    OriginSystem
--                                   ----------- ----------- --------                                    ------------
00000000-0000-0000-0000-000000000000             Owner       Owner_b5cd9d19-91c0-4622-93e2-537ad8a0b3ad  AadGroup
00000000-0000-0000-0000-000000000000             Member      Member_b5cd9d19-91c0-4622-93e2-537ad8a0b3ad AadGroup
```

This example gets the resource roles for the specified catalog id and filtering the results for the specified access package resource id.

### Example 2: Extend the -Filter to get the resource roles with the display name 'Member'

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResourceRole -AccessPackageCatalogId '54152ecb-c65d-47f2-8a4d-ba2732de0a7b' -Filter "originSystem eq 'AadGroup' and accessPackageResource/id eq '36d8d18f-b081-4867-acf5-4a8b893761e8' and DisplayName eq 'Member'"

Id                                   Description DisplayName OriginId                                    OriginSystem
--                                   ----------- ----------- --------                                    ------------
00000000-0000-0000-0000-000000000000             Member      Member_b5cd9d19-91c0-4622-93e2-537ad8a0b3ad AadGroup
```

This example extends the filter in example 1 to return access roles whose display name is 'Member'.

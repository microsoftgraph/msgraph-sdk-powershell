### Example 1: Remove an access package assignment policy

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageAssignmentPolicyId 'f134999f-8a59-49bb-b3a9-e8365d6fff94
```

This example removes the specified assignment policy.

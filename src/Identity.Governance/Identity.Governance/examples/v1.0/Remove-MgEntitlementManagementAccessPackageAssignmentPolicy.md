### Example 1: Remove an access package assignment policy

```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'

Remove-MgEntitlementManagementAssignmentPolicy -AccessPackageAssignmentPolicyId '62073739-d160-40e4-8367-87e88d85d083'
```

This example removes the specified assignment policy.

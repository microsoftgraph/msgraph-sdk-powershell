### Example 1: Create an assignment request

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
New-MgBetaEntitlementManagementAccessPackageAssignmentRequest -RequestType 'UserAdd' -AccessPackageId 'bc041fda-b3ba-41fc-b911-ca95f7aac656' -AssignmentPolicyId 'f134999f-8a59-49bb-b3a9-e8365d6fff94' -TargetId 'f5ac31b5-ae89-4d34-83ec-198072555d1d'
```

This example creates an access package assignment request. **AccessPackageId** is the identifier of the access package, **AssignmentPolicyId** is the identifier of the access package assignment policy and the **TargetId** is the identifier of the user account to be assigned the access.

### Example 2: Create an assignment removal request

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
New-MgBetaEntitlementManagementAccessPackageAssignmentRequest -RequestType 'AdminRemove' -AccessPackageAssignmentId '1634548f-cf76-4ac9-b496-f667d33d1dc0'
```

This examples removes the specified assignment.

### Example 1: Remove an access package

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Remove-MgBetaEntitlementManagementAccessPackage -AccessPackageId 'bc041fda-b3ba-41fc-b911-ca95f7aac656'
```

This example removes the specified access package.

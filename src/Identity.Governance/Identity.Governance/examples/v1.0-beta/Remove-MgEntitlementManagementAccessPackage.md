### Example 1: Remove an access package

```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Remove-MgEntitlementManagementAccessPackage -AccessPackageId 'bc041fda-b3ba-41fc-b911-ca95f7aac656'
```

This example removes the specified access package.

### Example 1: Remove a permission grant policy

```powershell
Connect-MgBetaGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
Remove-MgBetaPolicyPermissionGrantPolicy -PermissionGrantPolicyId "testtenant-sampleapp-permissions"
```

This command deletes the specified permission grant policy in Azure AD.

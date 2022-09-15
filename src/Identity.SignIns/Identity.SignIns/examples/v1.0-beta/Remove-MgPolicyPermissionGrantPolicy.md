### Example 1: Remove a permission grant policy

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
Remove-MgPolicyPermissionGrantPolicy -PermissionGrantPolicyId "testtenant-sampleapp-permissions"
```

This command deletes the specified permission grant policy in Azure AD.

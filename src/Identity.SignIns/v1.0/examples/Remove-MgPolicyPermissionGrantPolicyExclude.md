### Example 1: Remove a permission grant policy exclude

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
Remove-MgPolicyPermissionGrantPolicyExclude -PermissionGrantConditionSetId "60ba4fac-d39e-47b3-bd99-4394cb88a2f8" -PermissionGrantPolicyId "testtenant-sampleapp-permissions"  
```

This command deletes the specified exclude configuration from the specific permission grant policy in Azure AD.


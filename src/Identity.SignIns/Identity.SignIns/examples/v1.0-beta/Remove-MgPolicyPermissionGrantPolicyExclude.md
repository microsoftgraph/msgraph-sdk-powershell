### Example 1: Remove a permission grant policy exclude

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
Remove-MgPolicyPermissionGrantPolicyExclude -PermissionGrantConditionSetId "66a94faf-9134-4f46-83d2-1aae2eaea98f" -PermissionGrantPolicyId "testtenant-sampleapp-permissions"  
```

This command deletes the specified exclude configuration from the specific permission grant policy in Azure AD.

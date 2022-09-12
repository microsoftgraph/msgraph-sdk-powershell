### Example 1: {Remove a permission grant policy include

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
Remove-MgPolicyPermissionGrantPolicyInclude -PermissionGrantConditionSetId "a42959bb-c338-469c-b224-6998216ec573" -PermissionGrantPolicyId "testtenant-sampleapp-permissions"  
```

This command deletes the specified include configuration from the specific permission grant policy in Azure AD. 

### Example 1: Update a permission grant policy include

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
Update-MgPolicyPermissionGrantPolicyInclude -PermissionGrantConditionSetId "084b9abc-cf56-4d84-bdb0-5ad8f3a51038" -PermissionGrantPolicyId "testtenant-sampleapp-permissions" -PermissionType "application" -ResourceApplication "00000000-0000-0000-0000-000000000000" -Permissions "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000001" | fl
```

This command replaces the existing values with the provided new values for the specified include configuration properties in the specified permission grant policy in Azure AD.

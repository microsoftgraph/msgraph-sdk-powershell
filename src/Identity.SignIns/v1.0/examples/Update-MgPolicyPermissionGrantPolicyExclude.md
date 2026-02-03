### Example 1: Update a permission grant policy exclude

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
Update-MgPolicyPermissionGrantPolicyExclude -PermissionGrantConditionSetId "33895130-8450-4a4b-a353-e2bc28d54f97" -PermissionGrantPolicyId "testtenant-sampleapp-permissions" -PermissionType "application" -ResourceApplication "00000000-0000-0000-0000-000000000000" -Permissions "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000001"  
```

This command replaces the existing values with the provided new values for the specified exclude configuration properties in the specified permission grant policy in Azure AD.

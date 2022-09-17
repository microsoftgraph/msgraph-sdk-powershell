### Example 1: Update a permission grant policy

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
Update-MgPolicyPermissionGrantPolicy -PermissionGrantPolicyId "testtenant-sampleapp-permissions" -Description "Permissions for sample app in test tenant with new updates" -DisplayName "Sample app permissions with new updates"
```

This command replaces the existing values with the provided new values for the specified properties in the specified permission grant policy in Azure AD.

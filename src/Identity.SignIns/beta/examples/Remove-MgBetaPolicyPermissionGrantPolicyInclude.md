### Example 1: Remove a permission grant policy include

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
Remove-MgBetaPolicyPermissionGrantPolicyInclude -PermissionGrantConditionSetId "084b9abc-cf56-4d84-bdb0-5ad8f3a51038" -PermissionGrantPolicyId "testtenant-sampleapp-permissions"  
```



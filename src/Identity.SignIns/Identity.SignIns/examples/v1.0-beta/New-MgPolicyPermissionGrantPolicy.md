### Example 1: Create a permission grant policy

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
New-MgPolicyPermissionGrantPolicy -Id "testtenant-sampleapp-permissions" -Description "Permissions for sample app in test tenant" -DisplayName "Sample app permissions" | fl

DeletedDateTime      :
Description          : Permissions for sample app in test tenant
DisplayName          : Sample app permissions
Excludes             :
Id                   : testtenant-sampleapp-permissions
Includes             :
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#policies/permissionGrantPolicies/$entity]}
```

This command creates a new permission grant policy in Azure AD.  Specific include and exclude configurations can be created using the `New-MgPolicyPermissionGrantPolicyInclude` and `New-MgPolicyPermissionGrantPolicyExclude` cmdlets.


### Example 1: Create a permission grant policy include 

```powershell
Connect-MgBetaGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
New-MgBetaPolicyPermissionGrantPolicyInclude -PermissionGrantPolicyId "testtenant-sampleapp-permissions" -PermissionType "application" -ResourceApplication "00000000-0000-0000-0000-000000000000" -Permissions "00000000-0000-0000-0000-000000000000"  | fl

ClientApplicationIds                        : {all}
ClientApplicationPublisherIds               : {all}
ClientApplicationTenantIds                  : {all}
ClientApplicationsFromVerifiedPublisherOnly : False
Id                                          : 084b9abc-cf56-4d84-bdb0-5ad8f3a51038
PermissionClassification                    : all
PermissionType                              : application
Permissions                                 : {00000000-0000-0000-0000-000000000000}
ResourceApplication                         : 00000000-0000-0000-0000-000000000000
AdditionalProperties                        : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#policies/permissionGrantPolicies('testtenant-sampleapp-permissions')/includes/$entity]}
```

This command creates a new permission grant policy include configuration for the specified permission grant policy in Azure AD.

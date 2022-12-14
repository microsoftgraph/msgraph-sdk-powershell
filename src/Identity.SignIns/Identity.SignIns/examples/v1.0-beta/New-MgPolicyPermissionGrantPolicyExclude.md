### Example 1: Create a permission grant policy exclude

```powershell
Connect-MgBetaGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
New-MgBetaPolicyPermissionGrantPolicyExclude -PermissionGrantPolicyId "testtenant-sampleapp-permissions" -PermissionType "application" -ResourceApplication "00000000-0000-0000-0000-000000000000" -Permissions "00000000-0000-0000-0000-000000000000" | fl 

ClientApplicationIds                        : {all}
ClientApplicationPublisherIds               : {all}
ClientApplicationTenantIds                  : {all}
ClientApplicationsFromVerifiedPublisherOnly : False
Id                                          : 66a94faf-9134-4f46-83d2-1aae2eaea98f
PermissionClassification                    : all
PermissionType                              : application
Permissions                                 : {00000000-0000-0000-0000-000000000000}
ResourceApplication                         : 00000000-0000-0000-0000-000000000000
AdditionalProperties                        : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#policies/permissionGrantPolicies('testtenant-sampleapp-permissions')/excludes/$entity]}
```

This command creates a new permission grant policy exclude configuration for the specified permission grant policy in Azure AD.


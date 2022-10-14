### Example 1: Get a permission grant policy include by ID 

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant" 
Get-MgPolicyPermissionGrantPolicyInclude -PermissionGrantPolicyId "microsoft-all-application-permissions" | fl  

CertifiedClientApplicationsOnly             : False
ClientApplicationIds                        : {all}
ClientApplicationPublisherIds               : {all}
ClientApplicationTenantIds                  : {all}
ClientApplicationsFromVerifiedPublisherOnly : False
Id                                          : bddda1ec-0174-44d5-84e2-47fb0ac01595
PermissionClassification                    : all
PermissionType                              : application
Permissions                                 : {all}
ResourceApplication                         : any
AdditionalProperties                        : {[scopeSensitivityLabels, System.Collections.Generic.Dictionary`2[System.String,System.Object]]}
```

This command retrieves a specified permission grant policy include configuration in Azure AD.

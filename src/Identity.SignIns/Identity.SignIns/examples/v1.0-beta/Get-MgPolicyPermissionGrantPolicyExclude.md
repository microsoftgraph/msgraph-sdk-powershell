### Example 1: Get a permission grant policy exclude by ID

```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant" 
Get-MgPolicyPermissionGrantPolicyExclude -PermissionGrantPolicyId "microsoft-application-admin" | fl  

CertifiedClientApplicationsOnly             : False
ClientApplicationIds                        : {all}
ClientApplicationPublisherIds               : {all}
ClientApplicationTenantIds                  : {all}
ClientApplicationsFromVerifiedPublisherOnly : False
Id                                          : c85b029f-4abf-47d8-ae61-d2a38299033a
PermissionClassification                    : all
PermissionType                              : application
Permissions                                 : {all}
ResourceApplication                         : 00000003-0000-0000-c000-000000000000
AdditionalProperties                        : {[scopeSensitivityLabels, System.Collections.Generic.Dictionary`2[System.String,System.Object]]}

CertifiedClientApplicationsOnly             : False
ClientApplicationIds                        : {all}
ClientApplicationPublisherIds               : {all}
ClientApplicationTenantIds                  : {all}
ClientApplicationsFromVerifiedPublisherOnly : False
Id                                          : 2a1fbb36-9d9a-42d8-8804-de2aa45aca80
PermissionClassification                    : all
PermissionType                              : application
Permissions                                 : {all}
ResourceApplication                         : 00000002-0000-0000-c000-000000000000
AdditionalProperties                        : {[scopeSensitivityLabels, System.Collections.Generic.Dictionary`2[System.String,System.Object]]}
```

This command retrieves a specified permission grant policy exclude configuration in Azure AD.


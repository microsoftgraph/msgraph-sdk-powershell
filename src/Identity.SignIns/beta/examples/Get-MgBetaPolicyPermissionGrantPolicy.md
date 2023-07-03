### Example 1:  List all permission grant policies

```powershell
Connect-MgBetaGraph -Scopes "Policy.Read.PermissionGrant"  
Get-MgBetaPolicyPermissionGrantPolicy | fl  

DeletedDateTime      :
Description          : Includes all application permissions (app roles), for all APIs, for any client application.
DisplayName          : All application permissions, for any client app
Excludes             : {}
Id                   : microsoft-all-application-permissions
Includes             : {bddda1ec-0174-44d5-84e2-47fb0ac01595}
AdditionalProperties : {[includeAllPreApprovedApplications, False], [resourceScopeType, tenant], [includes@odata.context,
                       https://graph.microsoft.com/beta/$metadata#policies/permissionGrantPolicies('microsoft-all-application-permissions')/includes], [excludes@odata.context,
                       https://graph.microsoft.com/beta/$metadata#policies/permissionGrantPolicies('microsoft-all-application-permissions')/excludes]}

DeletedDateTime      :
Description          : Includes all chat resoruce-specific application permissions, for all APIs, for any client application.
DisplayName          : All chat resource-specific application permissions, for any client app
Excludes             : {}
Id                   : microsoft-all-application-permissions-for-chat
Includes             : {013e8de3-5e79-4b0f-a440-8f7794086460}
AdditionalProperties : {[includeAllPreApprovedApplications, False], [resourceScopeType, chat], [includes@odata.context,
                       https://graph.microsoft.com/beta/$metadata#policies/permissionGrantPolicies('microsoft-all-application-permissions-for-chat')/includes], [excludes@odata.context,
                       https://graph.microsoft.com/beta/$metadata#policies/permissionGrantPolicies('microsoft-all-application-permissions-for-chat')/excludes]}
```

This command retrieves a list of all permission grant policies in Azure AD. 

### Example 2: Get a permission grant policy by ID

```powershell
Connect-MgBetaGraph -Scopes "Policy.Read.PermissionGrant"  
Get-MgBetaPolicyPermissionGrantPolicy -PermissionGrantPolicyId "microsoft-all-application-permissions" | fl  

DeletedDateTime      :
Description          : Includes all application permissions (app roles), for all APIs, for any client application.
DisplayName          : All application permissions, for any client app
Excludes             : {}
Id                   : microsoft-all-application-permissions
Includes             : {bddda1ec-0174-44d5-84e2-47fb0ac01595}
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/beta/$metadata#policies/permissionGrantPolicies/$entity], [includeAllPreApprovedApplications, False], [resourceScopeType, tenant],
                       [includes@odata.context, https://graph.microsoft.com/beta/$metadata#policies/permissionGrantPolicies('microsoft-all-application-permissions')/includes]…}
```

This command retrieves a specified permission grant policy in Azure AD.


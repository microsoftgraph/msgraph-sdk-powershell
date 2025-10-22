### Example 1: Update or set Guest user access level for the tenant

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	allowEmailVerifiedUsersToJoinOrganization = $false
}

Update-MgPolicyAuthorizationPolicy -BodyParameter $params

```
This example will update or set guest user access level for the tenant

### Example 2: Block MSOL PowerShell in tenant

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	blockMsolPowerShell = $true
}

Update-MgPolicyAuthorizationPolicy -BodyParameter $params

```
This example will block msol powershell in tenant

### Example 3: Disable default user role's permission to create applications

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	defaultUserRolePermissions = @{
		allowedToCreateApps = $false
	}
}

Update-MgPolicyAuthorizationPolicy -BodyParameter $params

```
This example will disable default user role's permission to create applications

### Example 4: Enable administrators to use Self-Serve Password Reset feature

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	allowedToUseSSPR = $true
}

Update-MgPolicyAuthorizationPolicy -BodyParameter $params

```
This example enables administrators to use Self-Serve Password Reset feature. To disable this feature, set `allowedToUseSSPR` to `$false`.

### Example 5: Disable user consent to apps for default user role

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	defaultUserRolePermissions = @{
		permissionGrantPoliciesAssigned = @(
		)
	}
}

Update-MgPolicyAuthorizationPolicy -BodyParameter $params

```
This example will disable user consent to apps for default user role

### Example 6: Enable user consent to apps, subject to app consent policy

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	defaultUserRolePermissions = @{
		permissionGrantPoliciesAssigned = @(
		"managePermissionGrantsForSelf.microsoft-user-default-low"
	)
}
}

Update-MgPolicyAuthorizationPolicy -BodyParameter $params

```
This example will enable user consent to apps, subject to app consent policy


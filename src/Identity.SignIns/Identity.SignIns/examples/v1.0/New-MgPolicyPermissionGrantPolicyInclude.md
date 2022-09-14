### Example 1: Using the New-MgPolicyPermissionGrantPolicyInclude Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	PermissionType = "delegated"
	ClientApplicationsFromVerifiedPublisherOnly = $true
}
New-MgPolicyPermissionGrantPolicyInclude -PermissionGrantPolicyId $permissionGrantPolicyId -BodyParameter $params
```
This example shows how to use the New-MgPolicyPermissionGrantPolicyInclude Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the New-MgBetaServicePrincipalDelegatedPermissionClassification Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	PermissionId = "e1fe6dd8-ba31-4d61-89e7-88639da4683d"
	PermissionName = "User.Read"
	Classification = "low"
}
New-MgBetaServicePrincipalDelegatedPermissionClassification -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the New-MgBetaServicePrincipalDelegatedPermissionClassification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

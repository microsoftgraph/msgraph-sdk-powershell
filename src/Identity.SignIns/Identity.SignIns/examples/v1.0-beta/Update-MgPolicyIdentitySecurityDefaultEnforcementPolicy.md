### Example 1: Using the Update-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	IsEnabled = $false
}
Update-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

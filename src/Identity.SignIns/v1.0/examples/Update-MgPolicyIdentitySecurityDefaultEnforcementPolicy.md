### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	isEnabled = $false
}

Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy -BodyParameter $params
```
This example shows how to use the Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


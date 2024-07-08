### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	isEnabled = $false
}

Update-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy Cmdlet.


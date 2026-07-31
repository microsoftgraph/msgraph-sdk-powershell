### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	isEnabled = $false
}

Update-MgPolicyOwnerlessGroupPolicy -BodyParameter $params

```
This example shows how to use the Update-MgPolicyOwnerlessGroupPolicy Cmdlet.


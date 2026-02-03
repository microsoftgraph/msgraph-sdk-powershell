### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

$params = @{
	groupId = "ffffffff-ffff-ffff-ffff-ffffffffffff"
}

Invoke-MgBetaRenewGroupLifecyclePolicy -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaRenewGroupLifecyclePolicy Cmdlet.


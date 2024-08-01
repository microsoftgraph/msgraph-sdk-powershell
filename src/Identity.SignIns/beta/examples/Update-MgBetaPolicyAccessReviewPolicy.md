### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	isGroupOwnerManagementEnabled = $true
}

Update-MgBetaPolicyAccessReviewPolicy -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyAccessReviewPolicy Cmdlet.


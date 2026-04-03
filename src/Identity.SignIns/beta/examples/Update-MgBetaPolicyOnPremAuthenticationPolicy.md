### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	deletedDateTime = $null
	description = "Updates to policy definition to manage and control authentication settings."
	displayName = "Update policy name"
	definition = @(
	'{"Version":1,"LastUpdatedTimestamp":"2025-02-29T22:47:12.7764932Z", "Key1": "Value1", "Key2": {"SubKey1": "SubValue1"}}'
)
}

Update-MgBetaPolicyOnPremAuthenticationPolicy -OnPremAuthenticationPolicyId $onPremAuthenticationPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyOnPremAuthenticationPolicy Cmdlet.


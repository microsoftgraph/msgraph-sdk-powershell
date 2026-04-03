### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	description = "Policy definition to manage and control authentication settings."
	displayName = "Policy name"
	definition = @(
	'{"Version":1,"LastUpdatedTimestamp":"2025-02-29T22:47:12.7764932Z", "Key1": "Value1", "Key2": {"SubKey1": "SubValue1"}}'
)
isOrganizationDefault = $true
}

New-MgBetaPolicyOnPremAuthenticationPolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaPolicyOnPremAuthenticationPolicy Cmdlet.


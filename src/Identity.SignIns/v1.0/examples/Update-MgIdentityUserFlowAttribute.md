### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	description = "Your new hobby"
}

Update-MgIdentityUserFlowAttribute -IdentityUserFlowAttributeId $identityUserFlowAttributeId -BodyParameter $params

```
This example shows how to use the Update-MgIdentityUserFlowAttribute Cmdlet.


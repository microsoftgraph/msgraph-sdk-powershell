### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Hobby"
	description = "Your hobby"
	dataType = "string"
}

New-MgIdentityUserFlowAttribute -BodyParameter $params

```
This example shows how to use the New-MgIdentityUserFlowAttribute Cmdlet.


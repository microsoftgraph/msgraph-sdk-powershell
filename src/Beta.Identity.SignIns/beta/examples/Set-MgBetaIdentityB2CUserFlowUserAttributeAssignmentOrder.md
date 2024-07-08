### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	newAssignmentOrder = @{
		order = @(
		"City"
	"extension_GUID_ShoeSize"
)
}
}

Set-MgBetaIdentityB2CUserFlowUserAttributeAssignmentOrder -B2cIdentityUserFlowId $b2cIdentityUserFlowId -BodyParameter $params

```
This example shows how to use the Set-MgBetaIdentityB2CUserFlowUserAttributeAssignmentOrder Cmdlet.


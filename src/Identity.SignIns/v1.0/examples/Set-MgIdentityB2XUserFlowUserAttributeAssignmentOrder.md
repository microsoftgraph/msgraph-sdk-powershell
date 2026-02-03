### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	newAssignmentOrder = @{
		order = @(
		"City"
	"extension_GUID_ShoeSize"
)
}
}

Set-MgIdentityB2XUserFlowUserAttributeAssignmentOrder -B2xIdentityUserFlowId $b2xIdentityUserFlowId -BodyParameter $params

```
This example shows how to use the Set-MgIdentityB2XUserFlowUserAttributeAssignmentOrder Cmdlet.


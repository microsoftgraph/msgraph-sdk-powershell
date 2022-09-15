### Example 1: Using the Set-MgIdentityB2CUserFlowUserAttributeAssignmentOrder Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	NewAssignmentOrder = @{
		Order = @(
			"City"
			"extension_GUID_ShoeSize"
		)
	}
}
Set-MgIdentityB2CUserFlowUserAttributeAssignmentOrder -B2cIdentityUserFlowId $b2cIdentityUserFlowId -BodyParameter $params
```
This example shows how to use the Set-MgIdentityB2CUserFlowUserAttributeAssignmentOrder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

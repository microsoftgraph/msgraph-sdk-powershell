### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	isOptional = $false
	requiresVerification = $false
	userInputType = "TextBox"
	displayName = "Shoe size"
	userAttributeValues = @(
	)
	userAttribute = @{
		id = "extension_guid_shoeSize"
	}
}

New-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -BodyParameter $params
```
This example shows how to use the New-MgIdentityB2XUserFlowUserAttributeAssignment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


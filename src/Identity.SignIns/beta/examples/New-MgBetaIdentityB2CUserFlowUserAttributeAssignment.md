### Example 1: Using the New-MgBetaIdentityB2CUserFlowUserAttributeAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	IsOptional = $false
	RequiresVerification = $false
	UserInputType = "TextBox"
	DisplayName = "Shoe size"
	UserAttributeValues = @(
	)
	UserAttribute = @{
		Id = "extension_guid_shoeSize"
	}
}
New-MgBetaIdentityB2CUserFlowUserAttributeAssignment -B2cIdentityUserFlowId $b2cIdentityUserFlowId -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityB2CUserFlowUserAttributeAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

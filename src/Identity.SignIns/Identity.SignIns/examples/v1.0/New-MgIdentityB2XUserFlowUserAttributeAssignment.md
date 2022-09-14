### Example 1: Using the New-MgIdentityB2XUserFlowUserAttributeAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
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
New-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -BodyParameter $params
```
This example shows how to use the New-MgIdentityB2XUserFlowUserAttributeAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	UserInputType = "textBox"
}
Update-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId -BodyParameter $params
```

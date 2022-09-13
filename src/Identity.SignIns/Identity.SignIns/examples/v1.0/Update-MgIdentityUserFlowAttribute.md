###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Description = "Your new hobby"
}
Update-MgIdentityUserFlowAttribute -IdentityUserFlowAttributeId $identityUserFlowAttributeId -BodyParameter $params
```

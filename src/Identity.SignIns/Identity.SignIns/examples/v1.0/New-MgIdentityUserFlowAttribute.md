###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "Hobby"
	Description = "Your hobby"
	DataType = "string"
}
New-MgIdentityUserFlowAttribute -BodyParameter $params
```

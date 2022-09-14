### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "Hobby"
	Description = "Your hobby"
	DataType = "string"
}
New-MgIdentityUserFlowAttribute -BodyParameter $params
```

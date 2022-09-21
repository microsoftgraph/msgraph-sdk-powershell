### Example 1: Using the Update-MgIdentityB2CUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	IsLanguageCustomizationEnabled = $true
	DefaultLanguageTag = "en"
}
Update-MgIdentityB2CUserFlow -B2cIdentityUserFlowId $b2cIdentityUserFlowId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityB2CUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	delegatedUserEmail = "String"
	locale = "String"
	protectedContents = @(
		@{
			"@odata.type" = "microsoft.graph.protectedContent"
		}
	)
	supportedContentFormats = @(
	"String"
)
}

Invoke-MgAndSecurityDataSecurityAndGovernanceSensitivityLabel -BodyParameter $params

```
This example shows how to use the Invoke-MgAndSecurityDataSecurityAndGovernanceSensitivityLabel Cmdlet.


### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

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

Invoke-MgBetaAndSecurityDataSecurityAndGovernanceSensitivityLabel -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaAndSecurityDataSecurityAndGovernanceSensitivityLabel Cmdlet.


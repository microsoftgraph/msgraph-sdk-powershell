### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	value = @(
		@{
			assignedTo = "String"
			closedDateTime = [System.DateTime]::Parse("String (timestamp)")
			comments = @(
			"String"
		)
		feedback = @{
			"@odata.type" = "microsoft.graph.alertFeedback"
		}
		id = "String (identifier)"
		status = @{
			"@odata.type" = "microsoft.graph.alertStatus"
		}
		tags = @(
		"String"
	)
	vendorInformation = @{
		provider = "String"
		vendor = "String"
	}
}
)
}

Update-MgBetaSecurityAlertMultiple -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityAlertMultiple Cmdlet.


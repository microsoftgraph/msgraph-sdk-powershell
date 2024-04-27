### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.retentionLabel"
	retentionDuration = @{
		"@odata.type" = "microsoft.graph.security.retentionDurationInDays"
		days = 
	}
}

Update-MgBetaSecurityLabelRetentionLabel -RetentionLabelId $retentionLabelId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityLabelRetentionLabel Cmdlet.


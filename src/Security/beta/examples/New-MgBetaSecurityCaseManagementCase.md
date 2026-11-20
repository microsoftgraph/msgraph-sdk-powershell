### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.caseManagement.genericCase"
	displayName = "Security Breach Investigation"
	status = "active"
	description = "Investigating potential credential compromise."
	assignedTo = "john.doe@contoso.com"
	priority = "high"
	customFields = @{
		"Customer impact" = @{
			"@odata.type" = "#microsoft.graph.security.caseManagement.customFieldStringValue"
			value = "Executive mailbox affected"
		}
		"Affected users" = @{
			"@odata.type" = "#microsoft.graph.security.caseManagement.customFieldNumberValue"
			value = 
		}
		"Review date" = @{
			"@odata.type" = "#microsoft.graph.security.caseManagement.customFieldDateTimeValue"
			valueDateTime = "2026-06-15T09:00:00Z"
		}
		"Affected services" = @{
			"@odata.type" = "#microsoft.graph.security.caseManagement.customFieldOptionsValue"
			values = @(
			"Exchange Online"
		"Microsoft Teams"
	)
}
}
}

New-MgBetaSecurityCaseManagementCase -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityCaseManagementCase Cmdlet.


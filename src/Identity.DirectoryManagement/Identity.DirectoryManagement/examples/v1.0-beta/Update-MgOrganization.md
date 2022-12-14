### Example 1: Using the Update-MgBetaOrganization Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	MarketingNotificationEmails = @(
		"marketing@contoso.com"
	)
	PrivacyProfile = @{
		ContactEmail = "alice@contoso.com"
		StatementUrl = "https://contoso.com/privacyStatement"
	}
	SecurityComplianceNotificationMails = @(
		"security@contoso.com"
	)
	SecurityComplianceNotificationPhones = @(
		"(123) 456-7890"
	)
	TechnicalNotificationMails = @(
		"tech@contoso.com"
	)
}
Update-MgBetaOrganization -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaOrganization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

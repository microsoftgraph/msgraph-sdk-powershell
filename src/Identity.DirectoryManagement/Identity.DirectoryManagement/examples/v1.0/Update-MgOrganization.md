### Example 1: Using the Update-MgOrganization Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
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
Update-MgOrganization -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the Update-MgOrganization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

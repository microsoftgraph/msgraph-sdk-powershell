### Example 1
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

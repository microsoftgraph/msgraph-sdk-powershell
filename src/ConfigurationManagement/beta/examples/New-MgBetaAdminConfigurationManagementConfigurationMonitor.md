### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.ConfigurationManagement

$params = @{
	displayName = "Demo Monitor"
	description = "This is a Demo Monitor"
	baseline = @{
		displayName = "Demo Baseline"
		description = "This is a baseline with resources SharedMailbox, AcceptedDomain and MailContact"
		resources = @(
			@{
				displayName = "TestSharedMailbox Resource"
				resourceType = "microsoft.exchange.sharedmailbox"
				properties = @{
					DisplayName = "TestSharedMailbox"
					Alias = "testSharedMailbox"
					Identity = "TestSharedMailbox"
					Ensure = "Present"
					PrimarySmtpAddress = "testSharedMailbox@contoso.onmicrosoft.com"
					EmailAddresses = @(
					"abc@contoso.onmicrosoft.com"
				)
			}
		}
		@{
			displayName = "Accepted Domain"
			resourceType = "microsoft.exchange.accepteddomain"
			properties = @{
				Identity = "contoso.onmicrosoft.com"
				DomainType = "InternalRelay"
				Ensure = "Present"
			}
		}
		@{
			displayName = "Mail Contact Resource"
			resourceType = "microsoft.exchange.mailcontact"
			properties = @{
				Name = "Chris"
				DisplayName = "Chris"
				ExternalEmailAddress = "SMTP:chris@fabrikam.com"
				Alias = "Chrisa"
				Ensure = "Present"
			}
		}
	)
}
}

New-MgBetaAdminConfigurationManagementConfigurationMonitor -BodyParameter $params

```
This example shows how to use the New-MgBetaAdminConfigurationManagementConfigurationMonitor Cmdlet.


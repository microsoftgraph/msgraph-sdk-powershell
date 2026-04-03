### Example 1: Update the displayName of a configurationMonitor

```powershell

Import-Module Microsoft.Graph.Beta.ConfigurationManagement

$params = @{
	displayName = "Demo Monitor Name Change"
}

Update-MgBetaAdminConfigurationManagementConfigurationMonitor -ConfigurationMonitorId $configurationMonitorId -BodyParameter $params

```
This example will update the displayname of a configurationmonitor

### Example 2: Update the baseline of a configurationMonitor

```powershell

Import-Module Microsoft.Graph.Beta.ConfigurationManagement

$params = @{
	displayName = "Demo Monitor"
	description = "This is a Demo Monitor"
	baseline = @{
		displayName = "Demo Baseline"
		description = "This is a baseline with SharedMailbox, AcceptedDomain and MailContact"
		parameters = @(
			@{
				displayName = "FQDN"
				description = "The Fully Qualified Domain Name of the Tenant"
				parameterType = "String"
			}
		)
		resources = @(
			@{
				displayName = "TestSharedMailbox Resource"
				resourceType = "microsoft.exchange.sharedmailbox"
				properties = @{
					DisplayName = "TestSharedMailbox"
					Identity = "TestSharedMailbox"
					Ensure = "Present"
					PrimarySmtpAddress = "[concat('testSharedMailbox', parameters('FQDN'))]"
					EmailAddresses = @(
					"abc@contoso.onmicrosoft.com"
				"[concat('testSharedMailbox@', parameters('FQDN'))]"
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
parameters = @{
FQDN = "contoso.onmicrosoft.com"
}
}

Update-MgBetaAdminConfigurationManagementConfigurationMonitor -ConfigurationMonitorId $configurationMonitorId -BodyParameter $params

```
This example will update the baseline of a configurationmonitor


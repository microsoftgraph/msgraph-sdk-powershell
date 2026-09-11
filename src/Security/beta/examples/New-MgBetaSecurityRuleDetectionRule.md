### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.detectionRule"
	id = "office-encoded-powershell"
	displayName = "Suspicious encoded PowerShell from Office"
	description = "Detects encoded PowerShell processes launched by Office applications, a common phishing payload pattern."
	status = "enabled"
	queryCondition = @{
		queryText = "DeviceProcessEvents | where InitiatingProcessFileName in~ ('winword.exe','excel.exe','outlook.exe') | where FileName == 'powershell.exe' | where ProcessCommandLine has '-enc'"
	}
	schedule = @{
		frequency = "PT1H"
	}
	detectionAction = @{
		alertTemplate = @{
			title = "Suspicious encoded PowerShell from Office"
			description = "An Office app launched an encoded PowerShell command, which may indicate phishing-driven code execution."
			severity = "high"
			recommendedActions = "Investigate the parent Office document, isolate the device, and review the user's recent email activity."
			entityMappings = @{
				accounts = @(
					@{
						nameColumn = "AccountName"
						ntDomainColumn = "AccountDomain"
						sidColumn = "AccountSid"
					}
				)
				hosts = @(
					@{
						deviceIdColumn = "DeviceId"
						nameColumn = "DeviceName"
					}
				)
				files = @(
					@{
						nameColumn = "FileName"
						sha1Column = "SHA1"
						sha256Column = "SHA256"
					}
				)
			}
			tactics = @(
				@{
					tactic = "Execution"
					techniques = @(
						@{
							technique = "T1059.001"
						}
					)
				}
			)
		}
	}
}

New-MgBetaSecurityRuleDetectionRule -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityRuleDetectionRule Cmdlet.


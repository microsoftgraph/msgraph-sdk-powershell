### Example 1: Create a directory or tenant-level setting

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	templateId = "62375ab9-6b52-47ed-826b-58e47e0e304b"
	values = @(
		@{
			name = "GuestUsageGuidelinesUrl"
			value = "https://privacy.contoso.com/privacystatement"
		}
		@{
			name = "EnableMSStandardBlockedWords"
			value = "true"
		}
		@{
			name = "EnableMIPLabels"
			value = "true"
		}
		@{
			name = "PrefixSuffixNamingRequirement"
			value = "[Contoso-][GroupName]"
		}
	)
}

New-MgBetaDirectorySetting -BodyParameter $params

```
This example will create a directory or tenant-level setting


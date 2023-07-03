### Example 1: Using the New-MgBetaDirectorySetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	TemplateId = "62375ab9-6b52-47ed-826b-58e47e0e304b"
	Values = @(
		@{
			Name = "GuestUsageGuidelinesUrl"
			Value = "https://privacy.contoso.com/privacystatement"
		}
		@{
			Name = "EnableMSStandardBlockedWords"
			Value = "true"
		}
		@{
			Name = "EnableMIPLabels"
			Value = "true"
		}
		@{
			Name = "PrefixSuffixNamingRequirement"
			Value = "[Contoso-][GroupName]"
		}
	)
}
New-MgBetaDirectorySetting -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectorySetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

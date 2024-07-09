### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	displayName = "Rostering source"
	userMatchingSettings = @(
		@{
			matchTarget = @{
				code = "userPrincipalName"
			}
			priorityOrder = 0
			"roleGroup@odata.bind" = "https://graph.microsoft.com/beta/external/industryData/roleGroups/staff"
			sourceIdentifier = @{
				code = "username"
			}
		}
		@{
			matchTarget = @{
				code = "userPrincipalName"
			}
			priorityOrder = 1
			"roleGroup@odata.bind" = "https://graph.microsoft.com/beta/external/industryData/roleGroups('students')"
			sourceIdentifier = @{
				code = "username"
			}
		}
	)
}

New-MgBetaExternalIndustryDataSourceSystem -BodyParameter $params

```
This example shows how to use the New-MgBetaExternalIndustryDataSourceSystem Cmdlet.


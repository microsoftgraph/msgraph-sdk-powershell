### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	B2bCollaborationOutbound = @{
		UsersAndGroups = @{
			AccessType = "blocked"
			Targets = @(
				@{
					Target = "0be493dc-cb56-4a53-936f-9cf64410b8b0"
					TargetType = "group"
				}
			)
		}
		Applications = @{
			AccessType = "blocked"
			Targets = @(
				@{
					Target = "AllApplications"
					TargetType = "application"
				}
			)
		}
	}
}
Update-MgPolicyCrossTenantAccessPolicyDefault -BodyParameter $params
```

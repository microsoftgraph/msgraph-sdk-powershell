### Example 1: Using the Update-MgBetaPolicyCrossTenantAccessPolicyDefault Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
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
Update-MgBetaPolicyCrossTenantAccessPolicyDefault -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyCrossTenantAccessPolicyDefault Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

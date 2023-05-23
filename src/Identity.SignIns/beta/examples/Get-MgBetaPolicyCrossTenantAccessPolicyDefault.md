### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	b2bCollaborationOutbound = @{
		usersAndGroups = @{
			accessType = "blocked"
			targets = @(
				@{
					target = "0be493dc-cb56-4a53-936f-9cf64410b8b0"
					targetType = "group"
				}
			)
		}
		applications = @{
			accessType = "blocked"
			targets = @(
				@{
					target = "AllApplications"
					targetType = "application"
				}
			)
		}
	}
}

Update-MgBetaPolicyCrossTenantAccessPolicyDefault -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaPolicyCrossTenantAccessPolicyDefault Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


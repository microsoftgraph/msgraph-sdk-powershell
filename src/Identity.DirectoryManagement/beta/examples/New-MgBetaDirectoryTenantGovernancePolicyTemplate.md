### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Monitor Entra resource configurations"
	description = "Grants Global reader and provisions a custom multi-tenant application to monitor conditional access policies"
	multiTenantApplicationsToProvision = @(
		@{
			appId = "66667777-aaaa-8888-bbbb-9999cccc0000"
			objectId = "cccccccc-2222-3333-4444-dddddddddddd"
			displayName = "Mega Monitor"
			requiredResourceAccesses = @(
				@{
					resourceAppId = "00000003-0000-0000-c000-000000000000"
					permissions = @(
						@{
							id = "633e0fce-8c58-4cfb-9495-12bbd5a24f7c"
							name = "Policy.Read.ConditionalAccess"
							type = "scope"
						}
						@{
							id = "e1fe6dd8-ba31-4d61-89e7-88639da4683d"
							name = "User.Read"
							type = "scope"
						}
					)
				}
			)
		}
	)
	delegatedAdministrationRoleAssignments = @(
		@{
			roleTemplates = @(
				@{
					id = "f2ef992c-3afb-46b9-b7cf-a126ee74c451"
					name = "Global Reader"
				}
			)
			group = @{
				id = "ffffffff-5555-6666-7777-aaaaaaaaaaaa"
			}
		}
	)
}

New-MgBetaDirectoryTenantGovernancePolicyTemplate -BodyParameter $params

```
This example shows how to use the New-MgBetaDirectoryTenantGovernancePolicyTemplate Cmdlet.


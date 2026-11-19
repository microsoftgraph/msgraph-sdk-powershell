### Example 1: Create a cross-tenant open profile card capability

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.crossTenantOpenProfileCard"
	inboundAccess = @{
		isAllowed = $true
		resourceScopes = @{
			included = @(
				@{
					resourceId = "ad4fc698-74dc-4f62-9e71-ba9b591e8e74"
					resourceType = "group"
				}
			)
			excluded = @(
				@{
					resourceId = "ad4fc698-74dc-4f62-9e71-ba9b591e8e00"
					resourceType = "group"
				}
			)
		}
	}
}

New-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability -BodyParameter $params

```
This example will create a cross-tenant open profile card capability

### Example 2: Create a cross-tenant migration capability

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.crossTenantMigration"
	inboundAccess = @{
		isAllowed = $true
		resourceScopes = @{
			included = @(
				@{
					resourceId = "ad4fc698-74dc-4f62-9e71-ba9b591e8e74"
					resourceType = "group"
				}
			)
			excluded = @(
			)
		}
	}
}

New-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability -BodyParameter $params

```
This example will create a cross-tenant migration capability


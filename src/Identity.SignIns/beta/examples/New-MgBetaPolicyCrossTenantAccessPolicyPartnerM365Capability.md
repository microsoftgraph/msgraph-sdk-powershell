### Example 1: Create a cross-tenant mail tips capability

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.crossTenantMailTipsLimited"
	inboundAccess = @{
		isAllowed = $false
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

New-MgBetaPolicyCrossTenantAccessPolicyPartnerM365Capability -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -BodyParameter $params

```
This example will create a cross-tenant mail tips capability

### Example 2: Create a cross-tenant places room booking capability

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.crossTenantPlacesRoomBooking"
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

New-MgBetaPolicyCrossTenantAccessPolicyPartnerM365Capability -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -BodyParameter $params

```
This example will create a cross-tenant places room booking capability


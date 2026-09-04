### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	inboundAccess = @{
		isAllowed = $false
		resourceScopes = @{
			included = @(
				@{
					resourceId = "ad4fc698-74dc-4f62-9e71-ba9b591e8e74"
					resourceType = "group"
				}
				@{
					resourceId = "070061d7-a98e-43d3-b708-0758d3738ac7"
					resourceType = "group"
				}
			)
			excluded = @(
			)
		}
	}
}

Update-MgBetaPolicyCrossTenantAccessPolicyPartnerM365Capability -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -M365CapabilityBaseName $m365CapabilityBaseName -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyCrossTenantAccessPolicyPartnerM365Capability Cmdlet.


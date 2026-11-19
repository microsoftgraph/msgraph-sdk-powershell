### Example 1: Update only the access setting

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	inboundAccess = @{
		isAllowed = $false
	}
}

Update-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability -M365CapabilityBaseName $m365CapabilityBaseName -BodyParameter $params

```
This example will update only the access setting

### Example 2: Update the access setting and resource scopes

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	inboundAccess = @{
		isAllowed = $true
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
				@{
					resourceId = "ad4fc698-74dc-4f62-9e71-ba9b591e8e00"
					resourceType = "group"
				}
			)
		}
	}
}

Update-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability -M365CapabilityBaseName $m365CapabilityBaseName -BodyParameter $params

```
This example will update the access setting and resource scopes


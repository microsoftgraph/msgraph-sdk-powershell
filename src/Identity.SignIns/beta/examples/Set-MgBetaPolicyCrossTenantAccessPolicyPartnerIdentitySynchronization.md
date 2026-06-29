### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "Fabrikam"
	groupSyncInbound = @{
		isSyncAllowed = $true
	}
	userSyncInbound = @{
		isSyncAllowed = $true
	}
}

Set-MgBetaPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -BodyParameter $params

```
This example shows how to use the Set-MgBetaPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization Cmdlet.


### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Fabrikam"
	userSyncInbound = @{
		isSyncAllowed = $true
	}
}

Set-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -BodyParameter $params

```
This example shows how to use the Set-MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization Cmdlet.


###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	InboundTrust = @{
		IsMfaAccepted = $true
		IsCompliantDeviceAccepted = $true
		IsHybridAzureADJoinedDeviceAccepted = $true
	}
}
Update-MgPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -BodyParameter $params
```

### Example 1: Using the Update-MgPolicyCrossTenantAccessPolicyPartner Cmdlet
```powershell
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
This example shows how to use the Update-MgPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

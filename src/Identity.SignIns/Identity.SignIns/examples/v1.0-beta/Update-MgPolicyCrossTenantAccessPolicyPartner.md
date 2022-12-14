### Example 1: Using the Update-MgBetaPolicyCrossTenantAccessPolicyPartner Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	InboundTrust = @{
		IsMfaAccepted = $true
		IsCompliantDeviceAccepted = $true
		IsHybridAzureADJoinedDeviceAccepted = $true
	}
}
Update-MgBetaPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

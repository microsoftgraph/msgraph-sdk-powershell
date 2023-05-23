### Example 1: Configure inbound trust settings

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	inboundTrust = @{
		isMfaAccepted = $true
		isCompliantDeviceAccepted = $true
		isHybridAzureADJoinedDeviceAccepted = $true
	}
}

Update-MgBetaPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Configure automaticUserConsent settings

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	automaticUserConsentSettings = @{
		inboundAllowed = $true
		outboundAllowed = $true
	}
}

Update-MgBetaPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


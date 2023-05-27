### Example 1: Configure inbound trust settings

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	inboundTrust = @{
		isMfaAccepted = $true
		isCompliantDeviceAccepted = $true
		isHybridAzureADJoinedDeviceAccepted = $true
	}
}

Update-MgPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -BodyParameter $params
```
This example shows how to use the Remove-MgPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Configure automaticUserConsent settings

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	automaticUserConsentSettings = @{
		inboundAllowed = $true
		outboundAllowed = $true
	}
}

Update-MgPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId $crossTenantAccessPolicyConfigurationPartnerTenantId -BodyParameter $params
```
This example shows how to use the Remove-MgPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


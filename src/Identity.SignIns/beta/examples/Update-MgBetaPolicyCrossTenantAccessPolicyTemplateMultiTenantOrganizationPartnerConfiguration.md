### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	inboundTrust = @{
		isMfaAccepted = $true
		isCompliantDeviceAccepted = $true
		isHybridAzureADJoinedDeviceAccepted = $true
	}
	automaticUserConsentSettings = @{
		inboundAllowed = $true
		outboundAllowed = $true
	}
	templateApplicationLevel = "newPartners,existingPartners"
}

Update-MgBetaPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationPartnerConfiguration -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationPartnerConfiguration Cmdlet.


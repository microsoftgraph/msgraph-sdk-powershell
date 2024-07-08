### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	templateApplicationLevel = "newPartners,existingPartners"
	userSyncInbound = @{
		isSyncAllowed = $true
	}
}

Update-MgBetaPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationIdentitySynchronization -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationIdentitySynchronization Cmdlet.


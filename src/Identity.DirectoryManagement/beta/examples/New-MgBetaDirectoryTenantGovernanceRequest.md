### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	governedTenantId = "bbbbcccc-1111-dddd-2222-eeee3333ffff"
	"governancePolicyTemplate@odata.bind" = "https://graph.microsoft.com/beta/directory/tenantGovernance/governancePolicyTemplates/d3d3d3d3-eeee-ffff-aaaa-b4b4b4b4b4b4"
}

New-MgBetaDirectoryTenantGovernanceRequest -BodyParameter $params

```
This example shows how to use the New-MgBetaDirectoryTenantGovernanceRequest Cmdlet.


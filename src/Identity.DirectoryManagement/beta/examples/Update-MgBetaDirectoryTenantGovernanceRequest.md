### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	status = "accepted"
}

Update-MgBetaDirectoryTenantGovernanceRequest -GovernanceRequestId $governanceRequestId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryTenantGovernanceRequest Cmdlet.


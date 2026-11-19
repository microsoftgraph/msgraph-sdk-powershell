### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	status = "terminated"
}

Update-MgBetaDirectoryTenantGovernanceRelationship -GovernanceRelationshipId $governanceRelationshipId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryTenantGovernanceRelationship Cmdlet.


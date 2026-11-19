### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	governingTenantId = "aaaabbbb-0000-cccc-1111-dddd2222eeee"
}

New-MgBetaDirectoryTenantGovernanceInvitation -BodyParameter $params

```
This example shows how to use the New-MgBetaDirectoryTenantGovernanceInvitation Cmdlet.


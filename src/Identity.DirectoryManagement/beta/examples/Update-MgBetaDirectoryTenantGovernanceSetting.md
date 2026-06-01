### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	canReceiveInvitations = $true
}

Update-MgBetaDirectoryTenantGovernanceSetting -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryTenantGovernanceSetting Cmdlet.


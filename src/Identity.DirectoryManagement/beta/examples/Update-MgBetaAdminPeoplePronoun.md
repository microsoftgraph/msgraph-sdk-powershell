### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	isEnabledInOrganization = $true
}

Update-MgBetaAdminPeoplePronoun -BodyParameter $params

```
This example shows how to use the Update-MgBetaAdminPeoplePronoun Cmdlet.


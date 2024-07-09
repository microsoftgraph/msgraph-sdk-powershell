### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	isEnabledInOrganization = $true
}

Update-MgAdminPeoplePronoun -BodyParameter $params

```
This example shows how to use the Update-MgAdminPeoplePronoun Cmdlet.


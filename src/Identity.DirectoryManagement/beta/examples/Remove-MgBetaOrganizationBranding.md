### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	id = "0"
}

Remove-MgBetaOrganizationBranding -OrganizationId $organizationId -BodyParameter $params

```
This example shows how to use the Remove-MgBetaOrganizationBranding Cmdlet.


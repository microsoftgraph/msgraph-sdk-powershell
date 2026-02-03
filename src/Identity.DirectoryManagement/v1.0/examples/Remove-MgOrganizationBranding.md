### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	id = "0"
}

Remove-MgOrganizationBranding -OrganizationId $organizationId -BodyParameter $params

```
This example shows how to use the Remove-MgOrganizationBranding Cmdlet.


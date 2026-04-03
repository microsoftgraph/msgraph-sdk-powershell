### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.organizationalBrandingTheme"
	name = "ContosoTheme"
	isDefaultTheme = $true
}

New-MgBetaOrganizationBrandingTheme -OrganizationId $organizationId -BodyParameter $params

```
This example shows how to use the New-MgBetaOrganizationBrandingTheme Cmdlet.


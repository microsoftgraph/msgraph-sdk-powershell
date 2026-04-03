### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.organizationalBrandingTheme"
	name = "ContosoTheme"
	isDefaultTheme = $true
}

Update-MgBetaOrganizationBrandingTheme -OrganizationId $organizationId -OrganizationalBrandingThemeId $organizationalBrandingThemeId -BodyParameter $params

```
This example shows how to use the Update-MgBetaOrganizationBrandingTheme Cmdlet.


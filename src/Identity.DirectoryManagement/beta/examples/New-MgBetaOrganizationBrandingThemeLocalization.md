### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.organizationalBrandingThemeLocalization"
	locale = "fr-FR"
	headerBackgroundColor = "#3377ffff"
	pageBackgroundColor = "#FFFF33"
	signInPageText = "Welcome to Contoso"
	usernameHintText = "ContosoUsername "
}

New-MgBetaOrganizationBrandingThemeLocalization -OrganizationId $organizationId -OrganizationalBrandingThemeId $organizationalBrandingThemeId -BodyParameter $params

```
This example shows how to use the New-MgBetaOrganizationBrandingThemeLocalization Cmdlet.


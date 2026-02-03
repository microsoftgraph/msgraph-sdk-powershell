### Example 1: Update the backgroundColor and signInPageText for the fr-FR localization using PATCH

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	backgroundColor = "#00000F"
	signInPageText = "Welcome to Contoso France"
}

Update-MgOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params

```
This example will update the backgroundcolor and signinpagetext for the fr-fr localization using patch

### Example 2: Override a default branding value with a blank string

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	signInPageText = "Welcome to Contoso France."
	usernameHintText = " "
}

Update-MgOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params

```
This example will override a default branding value with a blank string


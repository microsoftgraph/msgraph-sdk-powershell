### Example 1: Update the backgroundColor and signInPageText for the fr-FR localization using PATCH

```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	backgroundColor = "#00000F"
	signInPageText = "Welcome to Contoso France"
}

Update-MgOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params
```
This example shows how to use the Update-MgOrganizationBrandingLocalization Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Override a default branding value with a blank string

```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	signInPageText = "Welcome to Contoso France."
	usernameHintText = " "
}

Update-MgOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params
```
This example shows how to use the Update-MgOrganizationBrandingLocalization Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


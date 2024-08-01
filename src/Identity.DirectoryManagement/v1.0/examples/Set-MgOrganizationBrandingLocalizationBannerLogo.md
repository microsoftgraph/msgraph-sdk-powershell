### Example 1: Setting **bannerLogo** for the fr-FR localization using PUT

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = Binary data for the image

Set-MgOrganizationBrandingLocalizationBannerLogo -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params

```
This example shows setting **bannerlogo** for the fr-fr localization using put


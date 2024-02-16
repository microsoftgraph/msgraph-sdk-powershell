### Example 1: Update the default branding

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	signInPageText = "Default"
	usernameHintText = "DefaultHint"
}

Update-MgBetaOrganizationBranding -OrganizationId $organizationId -BodyParameter $params

```
This example will update the default branding


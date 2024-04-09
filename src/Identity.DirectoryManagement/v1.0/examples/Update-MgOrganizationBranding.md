### Example 1: Update the default branding

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	signInPageText = "Default"
	usernameHintText = "DefaultHint"
}

Update-MgOrganizationBranding -OrganizationId $organizationId -BodyParameter $params

```
This example will update the default branding


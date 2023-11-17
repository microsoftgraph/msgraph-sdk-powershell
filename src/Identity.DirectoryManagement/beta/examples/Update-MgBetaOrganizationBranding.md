### Example 1: Update the default branding

```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	signInPageText = "Default"
	usernameHintText = "DefaultHint"
}

Update-MgBetaOrganizationBranding -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaOrganizationBranding Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


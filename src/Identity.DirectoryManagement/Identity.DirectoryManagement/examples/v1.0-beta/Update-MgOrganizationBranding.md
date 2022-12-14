### Example 1: Using the Update-MgBetaOrganizationBranding Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	SignInPageText = "Default"
	UsernameHintText = "DefaultHint"
}
Update-MgBetaOrganizationBranding -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaOrganizationBranding Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

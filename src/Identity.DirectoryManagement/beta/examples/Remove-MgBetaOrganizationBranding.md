### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	SignInPageText = "Default"
	UsernameHintText = "DefaultHint"
}

Update-MgBetaOrganizationBranding -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaOrganizationBranding Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


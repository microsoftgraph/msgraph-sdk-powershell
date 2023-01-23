### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	SignInPageText = "Default"
	UsernameHintText = "DefaultHint"
}

Update-MgOrganizationBranding -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the Remove-MgOrganizationBranding Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


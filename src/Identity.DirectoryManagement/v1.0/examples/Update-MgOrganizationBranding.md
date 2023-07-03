### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	signInPageText = "Default"
	usernameHintText = "DefaultHint"
}

Update-MgOrganizationBranding -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the Update-MgOrganizationBranding Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


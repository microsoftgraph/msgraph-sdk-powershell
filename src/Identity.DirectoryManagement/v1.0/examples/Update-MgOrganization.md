### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	"@odata.type" = "#microsoft.graph.organization"
	mobileDeviceManagementAuthority = "intune"
}

Update-MgOrganization -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the Update-MgOrganization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	roles = @(
	"read"
)
}

Update-MgBetaSitePermission -SiteId $siteId -PermissionId $permissionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSitePermission Cmdlet.


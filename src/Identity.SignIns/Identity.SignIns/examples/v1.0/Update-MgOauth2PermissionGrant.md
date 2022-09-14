### Example 1: Using the Update-MgOauth2PermissionGrant Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Scope = "User.ReadBasic.All Group.ReadWrite.All"
}
Update-MgOauth2PermissionGrant -OAuth2PermissionGrantId $oAuth2PermissionGrantId -BodyParameter $params
```
This example shows how to use the Update-MgOauth2PermissionGrant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

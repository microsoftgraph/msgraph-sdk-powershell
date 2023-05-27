### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	scope = "User.ReadBasic.All Group.ReadWrite.All"
}

Update-MgBetaOauth2PermissionGrant -OAuth2PermissionGrantId $oAuth2PermissionGrantId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaOauth2PermissionGrant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


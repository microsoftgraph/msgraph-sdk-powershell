### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Scope = "User.ReadBasic.All Group.ReadWrite.All"
}
Update-MgOauth2PermissionGrant -OAuth2PermissionGrantId $oAuth2PermissionGrantId -BodyParameter $params
```

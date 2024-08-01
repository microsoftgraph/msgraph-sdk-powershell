### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	scope = "User.ReadBasic.All Group.ReadWrite.All"
}

Update-MgOauth2PermissionGrant -OAuth2PermissionGrantId $oAuth2PermissionGrantId -BodyParameter $params

```
This example shows how to use the Update-MgOauth2PermissionGrant Cmdlet.


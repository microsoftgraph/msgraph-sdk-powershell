### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	DisplayName = "Apple"
}
Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	ClientSecret = "1111111111111"
}
Update-MgIdentityProvider -IdentityProviderId $identityProviderId -BodyParameter $params
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	ClientSecret = "1111111111111"
}
Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```

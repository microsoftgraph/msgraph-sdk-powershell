###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	DisplayName = "Apple"
}
Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	ClientSecret = "1111111111111"
}
Update-MgIdentityProvider -IdentityProviderId $identityProviderId -BodyParameter $params
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	ClientSecret = "1111111111111"
}
Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```

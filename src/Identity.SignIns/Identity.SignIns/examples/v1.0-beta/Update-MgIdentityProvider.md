### Example 1: Using the Update-MgIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	DisplayName = "Apple"
}
Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	ClientSecret = "1111111111111"
}
Update-MgIdentityProvider -IdentityProviderId $identityProviderId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Update-MgIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	ResponseType = "id_token"
}
Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Update-MgIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	ResponseType = "id_token"
}
Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Update-MgIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	ClientSecret = "1111111111111"
}
Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

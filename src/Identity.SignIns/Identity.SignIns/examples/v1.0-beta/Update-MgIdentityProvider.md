### Example 1: Using the Update-MgBetaIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	DisplayName = "Apple"
}
Update-MgBetaIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	ClientSecret = "1111111111111"
}
Update-MgBetaIdentityProvider -IdentityProviderId $identityProviderId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Update-MgBetaIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	ResponseType = "id_token"
}
Update-MgBetaIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Update-MgBetaIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	ResponseType = "id_token"
}
Update-MgBetaIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Update-MgBetaIdentityProvider Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	ClientSecret = "1111111111111"
}
Update-MgBetaIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

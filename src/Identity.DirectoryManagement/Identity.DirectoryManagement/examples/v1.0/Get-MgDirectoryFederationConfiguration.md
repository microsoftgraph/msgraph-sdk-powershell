### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryFederationConfiguration -IdentityProviderBaseId $identityProviderBaseId -Filter "domains/any(x: x/id eq 'contoso.com')" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryFederationConfiguration -IdentityProviderBaseId $identityProviderBaseId
```

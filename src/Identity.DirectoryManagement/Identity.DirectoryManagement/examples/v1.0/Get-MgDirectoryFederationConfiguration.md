###Example 1
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryFederationConfiguration -IdentityProviderBaseId $identityProviderBaseId -Filter "domains/any(x: x/id eq 'contoso.com')" 
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryFederationConfiguration -IdentityProviderBaseId $identityProviderBaseId
```

### Example 1: Using the Get-MgDirectoryFederationConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryFederationConfiguration -IdentityProviderBaseId $identityProviderBaseId -Filter "domains/any(x: x/id eq 'contoso.com')" 
```
This example shows how to use the Get-MgDirectoryFederationConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgDirectoryFederationConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryFederationConfiguration -IdentityProviderBaseId $identityProviderBaseId
```
This example shows how to use the Get-MgDirectoryFederationConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: List all b2xIdentityUserFlow objects

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityB2XUserFlow
```
This example shows how to use the New-MgIdentityB2XUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List all b2xIdentityUserFlow objects and expand identityProviders

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityB2XUserFlow -ExpandProperty "identityProviders"
```
This example shows how to use the New-MgIdentityB2XUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


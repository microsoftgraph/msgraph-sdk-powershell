### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgContact
```
This example shows how to use the New-MgContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgContact -Filter "startswith(displayName,'A')" -CountVariable CountVar -Top 1 -Sort "displayName" -ConsistencyLevel eventual
```
This example shows how to use the New-MgContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgContact -Search "displayName:wa" -CountVariable CountVar -ConsistencyLevel eventual
```
This example shows how to use the New-MgContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


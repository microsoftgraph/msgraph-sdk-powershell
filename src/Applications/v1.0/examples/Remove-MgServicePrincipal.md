### Example 1: Retrieve a service principal by its ID

```powershellImport-Module Microsoft.Graph.Applications

Get-MgServicePrincipal -ServicePrincipalId $servicePrincipalId
```
This example shows how to use the Remove-MgServicePrincipal Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Retrieve the specific properties of a service principal

```powershellImport-Module Microsoft.Graph.Applications

Get-MgServicePrincipal -ServicePrincipalId $servicePrincipalId -Property "id,appId,displayName,appRoles,oauth2PermissionScopes"
```
This example shows how to use the Remove-MgServicePrincipal Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


### Example 1: Using the Remove-MgServicePrincipalAppRoleAssignedTo Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Remove-MgServicePrincipalAppRoleAssignedTo -ServicePrincipalId $servicePrincipalId -AppRoleAssignmentId $appRoleAssignmentId
```
This example shows how to use the Remove-MgServicePrincipalAppRoleAssignedTo Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

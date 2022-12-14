### Example 1: Using the Remove-MgBetaServicePrincipalAppRoleAssignedTo Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
Remove-MgBetaServicePrincipalAppRoleAssignedTo -ServicePrincipalId $servicePrincipalId -AppRoleAssignmentId $appRoleAssignmentId
```
This example shows how to use the Remove-MgBetaServicePrincipalAppRoleAssignedTo Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

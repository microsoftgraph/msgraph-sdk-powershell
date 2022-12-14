### Example 1: Using the Get-MgBetaPrivilegedRoleRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaPrivilegedRoleRoleAssignment -PrivilegedRoleAssignmentId $privilegedRoleAssignmentId
```
This example shows how to use the Get-MgBetaPrivilegedRoleRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaPrivilegedRoleRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaPrivilegedRoleRoleAssignment
```
This example shows how to use the Get-MgBetaPrivilegedRoleRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaPrivilegedRoleRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaPrivilegedRoleRoleAssignment -Filter "isElevated eq true" 
```
This example shows how to use the Get-MgBetaPrivilegedRoleRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaPrivilegedRoleRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaPrivilegedRoleRoleAssignment -Filter "isElevated eq true and expirationDateTime eq null" 
```
This example shows how to use the Get-MgBetaPrivilegedRoleRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgBetaPrivilegedRoleRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaPrivilegedRoleRoleAssignment -Filter "isElevated eq true and expirationDateTime ne null or isElevated eq false" 
```
This example shows how to use the Get-MgBetaPrivilegedRoleRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

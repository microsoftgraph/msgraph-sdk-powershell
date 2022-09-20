### Example 1: Using the Get-MgPrivilegedRoleRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgPrivilegedRoleRoleAssignment -PrivilegedRoleAssignmentId $privilegedRoleAssignmentId
```
This example shows how to use the Get-MgPrivilegedRoleRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgPrivilegedRoleRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgPrivilegedRoleRoleAssignment
```
This example shows how to use the Get-MgPrivilegedRoleRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgPrivilegedRoleRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgPrivilegedRoleRoleAssignment -Filter "isElevated eq true" 
```
This example shows how to use the Get-MgPrivilegedRoleRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgPrivilegedRoleRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgPrivilegedRoleRoleAssignment -Filter "isElevated eq true and expirationDateTime eq null" 
```
This example shows how to use the Get-MgPrivilegedRoleRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgPrivilegedRoleRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgPrivilegedRoleRoleAssignment -Filter "isElevated eq true and expirationDateTime ne null or isElevated eq false" 
```
This example shows how to use the Get-MgPrivilegedRoleRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

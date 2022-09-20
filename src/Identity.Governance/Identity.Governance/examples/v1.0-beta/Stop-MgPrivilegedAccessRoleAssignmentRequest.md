### Example 1: Using the Stop-MgPrivilegedAccessRoleAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Stop-MgPrivilegedAccessRoleAssignmentRequest -PrivilegedAccessId $privilegedAccessId -GovernanceRoleAssignmentRequestId $governanceRoleAssignmentRequestId
```
This example shows how to use the Stop-MgPrivilegedAccessRoleAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

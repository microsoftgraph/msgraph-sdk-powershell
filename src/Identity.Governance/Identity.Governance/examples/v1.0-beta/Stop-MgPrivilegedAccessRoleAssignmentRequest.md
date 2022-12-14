### Example 1: Using the Stop-MgBetaPrivilegedAccessRoleAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Stop-MgBetaPrivilegedAccessRoleAssignmentRequest -PrivilegedAccessId $privilegedAccessId -GovernanceRoleAssignmentRequestId $governanceRoleAssignmentRequestId
```
This example shows how to use the Stop-MgBetaPrivilegedAccessRoleAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Retrieve a principal's requests scoped to a specific group and that are pending approval

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestByCurrentUser -Filter "status eq 'PendingApproval' and groupId eq 'd5f0ad2e-6b34-401b-b6da-0c8fc2c5a3fc'"  -On $onId 

```
This example will retrieve a principal's requests scoped to a specific group and that are pending approval


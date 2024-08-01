### Example 1: Retrieve the approval resources in PIM for groups

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupAssignmentApprovalByCurrentUser -On $onId 

```
This example will retrieve the approval resources in pim for groups


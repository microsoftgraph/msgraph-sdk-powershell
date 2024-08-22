### Example 1: Retrieve all the eligibility requests scoped to a group and a principal

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest -Filter "groupId eq '2b5ed229-4072-478d-9504-a047ebd4b07d' and principalId eq '3cce9d87-3986-4f19-8335-7ed075408ca2'" 

```
This example will retrieve all the eligibility requests scoped to a group and a principal

### Example 2: Retrieve specific properties of all eligibility requests scoped to a group and a principal

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest -Filter "groupId eq '2b5ed229-4072-478d-9504-a047ebd4b07d' and principalId eq '3cce9d87-3986-4f19-8335-7ed075408ca2'" -Property "principalId,action,groupId" 

```
This example will retrieve specific properties of all eligibility requests scoped to a group and a principal


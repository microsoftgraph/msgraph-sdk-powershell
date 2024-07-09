### Example 1: Retrieve eligibility schedules for the calling principal

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleByCurrentUser -On $onId 

```
This example will retrieve eligibility schedules for the calling principal

### Example 2: Retrieve eligibility schedules for the principal and filter by a group and accessId

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleByCurrentUser -Filter "groupId eq 'd5f0ad2e-6b34-401b-b6da-0c8fc2c5a3fc' and accessId eq 'member'"  -On $onId 

```
This example will retrieve eligibility schedules for the principal and filter by a group and accessid


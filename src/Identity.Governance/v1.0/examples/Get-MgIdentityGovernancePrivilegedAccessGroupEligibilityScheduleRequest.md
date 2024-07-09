### Example 1: Get all eligibility schedule requests

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest -PrivilegedAccessGroupEligibilityScheduleRequestId $privilegedAccessGroupEligibilityScheduleRequestId

```
This example will get all eligibility schedule requests

### Example 2: Get specific properties of all eligibility schedule requests

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest -PrivilegedAccessGroupEligibilityScheduleRequestId $privilegedAccessGroupEligibilityScheduleRequestId -Property "principalId,action,groupId" 

```
This example will get specific properties of all eligibility schedule requests


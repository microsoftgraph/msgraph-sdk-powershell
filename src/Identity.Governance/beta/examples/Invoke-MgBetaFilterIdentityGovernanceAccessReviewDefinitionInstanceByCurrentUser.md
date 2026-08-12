### Example 1: List access review instances assigned directly or through delegation to the current user

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceByCurrentUser -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -On $onId 

```
This example will list access review instances assigned directly or through delegation to the current user

### Example 2: List access review instances delegated to the current user

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceByCurrentUser -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -Property "id,displayName,status,delegatedBy" 

```
This example will list access review instances delegated to the current user

### Example 3: List access review instances directly assigned to the current user

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceByCurrentUser -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -Property "id,displayName,status" 

```
This example will list access review instances directly assigned to the current user


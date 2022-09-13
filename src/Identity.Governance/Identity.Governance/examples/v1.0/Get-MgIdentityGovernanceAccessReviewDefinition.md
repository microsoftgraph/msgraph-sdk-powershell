###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAccessReviewDefinition -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAccessReviewDefinition -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAccessReviewDefinition -Filter "contains(scope/microsoft.graph.accessReviewQueryScope/query, './members')" 
```
###Example 4
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAccessReviewDefinition -Top 100 -Skip 0 
```

### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAccessReviewDefinition -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAccessReviewDefinition -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAccessReviewDefinition -Filter "contains(scope/microsoft.graph.accessReviewQueryScope/query, './members')" 
```
### Example 4
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAccessReviewDefinition -Top 100 -Skip 0 
```

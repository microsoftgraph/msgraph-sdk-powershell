### Example 1: List the first one hundred access review definitions

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAccessReviewDefinition -Top 100 -Skip 0 

```
This example will list the first one hundred access review definitions

### Example 2: Retrieve all access review definitions scoped to all Microsoft 365 groups in a tenant

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAccessReviewDefinition -Filter "contains(scope/microsoft.graph.accessReviewQueryScope/query, './members')" 

```
This example will retrieve all access review definitions scoped to all microsoft 365 groups in a tenant


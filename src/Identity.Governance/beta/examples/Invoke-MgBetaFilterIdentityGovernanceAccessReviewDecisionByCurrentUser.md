### Example 1: Retrieve all decision items for which you're a reviewer and expand the definitions

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterIdentityGovernanceAccessReviewDecisionByCurrentUser -ExpandProperty "instance(`$expand=definition)"  -On $onId 

```
This example will retrieve all decision items for which you're a reviewer and expand the definitions


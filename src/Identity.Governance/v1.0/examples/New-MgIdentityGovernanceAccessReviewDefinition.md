### Example 1: List the first one hundred access review definitions

```powershellImport-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAccessReviewDefinition -Top 100 -Skip 0
```
This example shows how to use the New-MgIdentityGovernanceAccessReviewDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Retrieve all access review definitions scoped to all Microsoft 365 groups in a tenant

```powershellImport-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAccessReviewDefinition -Filter "contains(scope/microsoft.graph.accessReviewQueryScope/query, './members')"
```
This example shows how to use the New-MgIdentityGovernanceAccessReviewDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


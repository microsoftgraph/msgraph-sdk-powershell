### Example 1: Get a workflow version

```powershellImport-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion -WorkflowId $workflowId -WorkflowVersionVersionNumber $workflowVersionVersionNumber
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get specific properties of a version of a workflow

```powershellImport-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion -WorkflowId $workflowId -WorkflowVersionVersionNumber $workflowVersionVersionNumber -Property "category,displayName,versionNumber,executionConditions" -ExpandProperty "tasks"
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


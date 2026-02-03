### Example 1: Get a workflow version

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion -WorkflowId $workflowId -WorkflowVersionVersionNumber $workflowVersionVersionNumber

```
This example will get a workflow version

### Example 2: Get specific properties of a version of a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion -WorkflowId $workflowId -WorkflowVersionVersionNumber $workflowVersionVersionNumber -Property "category,displayName,versionNumber,executionConditions" -ExpandProperty "tasks" 

```
This example will get specific properties of a version of a workflow


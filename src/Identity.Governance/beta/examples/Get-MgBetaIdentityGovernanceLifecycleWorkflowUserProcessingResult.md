### Example 1: List the user processing results for a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult -WorkflowId $workflowId

```
This example will list the user processing results for a workflow

### Example 2: List specific properties of user processing results for a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult -WorkflowId $workflowId -Property "id,failedTasksCount,processingStatus,totalTasksCount,totalUnprocessedTasksCount,workflowExecutionType,subject" 

```
This example will list specific properties of user processing results for a workflow


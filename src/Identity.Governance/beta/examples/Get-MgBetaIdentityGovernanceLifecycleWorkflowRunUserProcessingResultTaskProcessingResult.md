### Example 1: Get the task processing results for a user processing result in a run report for a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult -WorkflowId $workflowId -RunId $runId -UserProcessingResultId $userProcessingResultId

```
This example will get the task processing results for a user processing result in a run report for a workflow

### Example 2: Get the specific properties of task processing results for a user processing result in a run report for a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult -WorkflowId $workflowId -RunId $runId -UserProcessingResultId $userProcessingResultId -Property "id,failureReason,processingStatus,subject,task" 

```
This example will get the specific properties of task processing results for a user processing result in a run report for a workflow


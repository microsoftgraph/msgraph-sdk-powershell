### Example 1: Get a user processing result in a run report

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult -WorkflowId $workflowId -RunId $runId -UserProcessingResultId $userProcessingResultId

```
This example will get a user processing result in a run report

### Example 2: Get a user processing results for a workflow run

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult -WorkflowId $workflowId -RunId $runId -UserProcessingResultId $userProcessingResultId -Property "id,failedTasksCount,processingStatus,totalTasksCount,totalUnprocessedTasksCount,subject" 

```
This example will get a user processing results for a workflow run


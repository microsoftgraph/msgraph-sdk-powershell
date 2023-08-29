### Example 1: List the results of the tasks processed for a user in a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult -WorkflowId $workflowId -UserProcessingResultId $userProcessingResultId

```
This example will list the results of the tasks processed for a user in a workflow

### Example 2: List the results of the tasks processed for a user in a workflow and select specific properties

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult -WorkflowId $workflowId -UserProcessingResultId $userProcessingResultId -Property "id,processingStatus,failureReason,subject,task" 

```
This example will list the results of the tasks processed for a user in a workflow and select specific properties


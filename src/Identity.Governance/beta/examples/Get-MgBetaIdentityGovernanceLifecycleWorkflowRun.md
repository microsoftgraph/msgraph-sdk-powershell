### Example 1: List the run reports for a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowRun -WorkflowId $workflowId

```
This example will list the run reports for a workflow

### Example 2: List the run reports for a workflow and select specific properties

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowRun -WorkflowId $workflowId -Property "id,failedTasksCount,failedUsersCount,processingStatus,totalTasksCount,totalUnprocessedTasksCount,totalUsersCount,id" 

```
This example will list the run reports for a workflow and select specific properties


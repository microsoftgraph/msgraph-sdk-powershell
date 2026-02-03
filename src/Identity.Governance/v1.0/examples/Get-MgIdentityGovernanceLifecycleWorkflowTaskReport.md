### Example 1: List the task reports for a workflow

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowTaskReport -WorkflowId $workflowId

```
This example will list the task reports for a workflow

### Example 2: List the task reports for a workflow

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowTaskReport -WorkflowId $workflowId -Property "id,failedUsersCount,processingStatus,successfulUsersCount,totalUsersCount,unprocessedUsersCount,taskDefinition,taskProcessingResults" 

```
This example will list the task reports for a workflow


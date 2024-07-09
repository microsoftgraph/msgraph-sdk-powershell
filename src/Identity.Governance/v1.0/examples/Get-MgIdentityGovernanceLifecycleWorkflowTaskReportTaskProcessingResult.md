### Example 1: List the task processing results that are included in a task report for a workflow

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult -WorkflowId $workflowId -TaskReportId $taskReportId

```
This example will list the task processing results that are included in a task report for a workflow

### Example 2: List the task processing results that are included in a task report for a workflow, and retrieve specific properties

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult -WorkflowId $workflowId -TaskReportId $taskReportId -Property "id,failureReason,processingStatus,subject,task" 

```
This example will list the task processing results that are included in a task report for a workflow, and retrieve specific properties


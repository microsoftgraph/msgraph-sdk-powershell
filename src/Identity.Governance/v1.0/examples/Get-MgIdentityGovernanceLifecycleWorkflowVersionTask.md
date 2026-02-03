### Example 1: Get a task from a workflow version

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowVersionTask -WorkflowId $workflowId -WorkflowVersionVersionNumber $workflowVersionVersionNumber -TaskId $taskId

```
This example will get a task from a workflow version


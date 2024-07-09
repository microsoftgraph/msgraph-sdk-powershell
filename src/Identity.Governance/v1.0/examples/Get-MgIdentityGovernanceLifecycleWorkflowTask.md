### Example 1: Get a task from a workflow

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowTask -WorkflowId $workflowId -TaskId $taskId

```
This example will get a task from a workflow


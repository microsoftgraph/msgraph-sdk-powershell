### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	data = @{
		operationStatus = "Completed"
	}
	source = "sample"
	type = "lifecycleEvent"
}

Resume-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult -WorkflowId $workflowId -TaskId $taskId -TaskProcessingResultId $taskProcessingResultId -BodyParameter $params

```
This example shows how to use the Resume-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult Cmdlet.


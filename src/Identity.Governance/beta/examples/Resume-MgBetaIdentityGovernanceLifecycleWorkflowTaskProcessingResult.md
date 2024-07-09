### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	data = @{
		operationStatus = "Completed"
	}
	source = "sample"
	type = "lifecycleEvent"
}

Resume-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResult -WorkflowId $workflowId -TaskId $taskId -TaskProcessingResultId $taskProcessingResultId -BodyParameter $params

```
This example shows how to use the Resume-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResult Cmdlet.


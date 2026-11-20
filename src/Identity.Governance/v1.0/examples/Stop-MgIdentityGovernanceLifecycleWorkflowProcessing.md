### Example 1: Successfully cancel a workflow run

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	scope = @{
		"@odata.type" = "#microsoft.graph.identityGovernance.cancelRunsScope"
		runs = @(
			@{
				id = "8cdf25a8-c9d2-423e-a03d-3f39f03c3e97"
			}
		)
	}
}

Stop-MgIdentityGovernanceLifecycleWorkflowProcessing -WorkflowId $workflowId -BodyParameter $params

```
This example will successfully cancel a workflow run


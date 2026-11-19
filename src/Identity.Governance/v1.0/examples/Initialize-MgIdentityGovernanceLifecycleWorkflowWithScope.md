### Example 1: Activate a workflow with a specific scope of 2 users

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	subjects = @(
		@{
			id = "8cdf25a8-c9d2-423e-a03d-3f39f03c3e97"
		}
		@{
			id = "ea09ac2e-77e3-4134-85f2-25ccf3c33387"
		}
	)
}

Initialize-MgIdentityGovernanceLifecycleWorkflowWithScope -WorkflowId $workflowId -BodyParameter $params

```
This example will activate a workflow with a specific scope of 2 users

### Example 2: Activate a workflow with a specific scope of 2 users who don't exist

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	subjects = @(
		@{
			id = "2ea4c363-4b85-4529-b2ec-53b64308f39f"
		}
		@{
			id = "44fc5392-9485-4348-871e-2ea17cc0a1b8"
		}
	)
}

Initialize-MgIdentityGovernanceLifecycleWorkflowWithScope -WorkflowId $workflowId -BodyParameter $params

```
This example will activate a workflow with a specific scope of 2 users who don't exist

### Example 3: Activate a workflow with a specific processing result scope

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	scope = @{
		"@odata.type" = "microsoft.graph.identityGovernance.activateProcessingResultScope"
		processingResults = @(
			@{
				id = "abc12345-265a-4e8f-8d61-94a2dcd2d395_1_78799042-265a-4e8f-8d61-94a2dcd2d395_638927021459371237_0cdd8963-aaaa-4632-a1f2-aaaa7230aaaa"
			}
			@{
				id = "abc12345-265a-4e8f-8d61-94a2dcd2d395_1_78799042-265a-4e8f-8d61-94a2dcd2d395_388131231459357126_aaaa8963-1c30-4632-aaaa-ac96723069cb"
			}
		)
		taskScope = "allTasks"
	}
}

Initialize-MgIdentityGovernanceLifecycleWorkflowWithScope -WorkflowId $workflowId -BodyParameter $params

```
This example will activate a workflow with a specific processing result scope


### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	subjects = @(
		@{
			"@odata.type" = "#microsoft.graph.user"
			id = "b59552b8-fa7b-4f68-8496-0a529aace8c0"
		}
		@{
			"@odata.type" = "#microsoft.graph.user"
			id = "a1b2c3d4-e5f6-7890-abcd-ef1234567890"
		}
	)
}

Invoke-MgPreviewIdentityGovernanceLifecycleWorkflow -WorkflowId $workflowId -BodyParameter $params

```
This example shows how to use the Invoke-MgPreviewIdentityGovernanceLifecycleWorkflow Cmdlet.


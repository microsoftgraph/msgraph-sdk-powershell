### Example 1: Using the Initialize-MgIdentityGovernanceLifecycleWorkflow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Subjects = @(
		@{
			Id = "8cdf25a8-c9d2-423e-a03d-3f39f03c3e97"
		}
		@{
			Id = "ea09ac2e-77e3-4134-85f2-25ccf3c33387"
		}
	)
}
Initialize-MgIdentityGovernanceLifecycleWorkflow -WorkflowId $workflowId -BodyParameter $params
```
This example shows how to use the Initialize-MgIdentityGovernanceLifecycleWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Update-MgIdentityGovernanceLifecycleWorkflow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Description = "Configure new hire tasks for onboarding employees on their first day"
	DisplayName = "Australia Onboard new hire employee"
	IsEnabled = $true
	IsSchedulingEnabled = $false
}
Update-MgIdentityGovernanceLifecycleWorkflow -WorkflowId $workflowId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityGovernanceLifecycleWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

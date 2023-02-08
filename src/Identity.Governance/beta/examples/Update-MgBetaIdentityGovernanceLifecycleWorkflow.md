### Example 1: Using the Update-MgBetaIdentityGovernanceLifecycleWorkflow Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	Description = "Configure new hire tasks for onboarding employees on their first day"
	DisplayName = "Australia Onboard new hire employee"
	IsEnabled = $true
	IsSchedulingEnabled = $false
}
Update-MgBetaIdentityGovernanceLifecycleWorkflow -WorkflowId $workflowId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityGovernanceLifecycleWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

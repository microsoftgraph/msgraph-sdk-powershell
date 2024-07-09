### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	description = "Configure new hire tasks for onboarding employees on their first day"
	displayName = "Australia Onboard new hire employee"
	isEnabled = $true
	isSchedulingEnabled = $false
}

Update-MgIdentityGovernanceLifecycleWorkflow -WorkflowId $workflowId -BodyParameter $params

```
This example shows how to use the Update-MgIdentityGovernanceLifecycleWorkflow Cmdlet.


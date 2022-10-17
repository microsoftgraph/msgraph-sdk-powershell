### Example 1: Using the Update-MgIdentityGovernanceLifecycleWorkflowSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	"@odata.context" = "https://graph.microsoft.com/beta/$metadata#identityGovernance/lifecycleWorkflows/settings/$entity"
	WorkflowScheduleIntervalInHours = 3
}
Update-MgIdentityGovernanceLifecycleWorkflowSetting -BodyParameter $params
```
This example shows how to use the Update-MgIdentityGovernanceLifecycleWorkflowSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Update-MgBetaIdentityGovernanceLifecycleWorkflowSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	"@odata.context" = "https://graph.microsoft.com/beta/$metadata#identityGovernance/lifecycleWorkflows/settings/$entity"
	WorkflowScheduleIntervalInHours = 3
}
Update-MgBetaIdentityGovernanceLifecycleWorkflowSetting -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityGovernanceLifecycleWorkflowSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

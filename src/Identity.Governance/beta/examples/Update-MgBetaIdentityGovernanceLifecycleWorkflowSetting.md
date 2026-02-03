### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	"@odata.context" = "https://graph.microsoft.com/beta/$metadata#identityGovernance/lifecycleWorkflows/settings/$entity"
	workflowScheduleIntervalInHours = 3
	emailSettings = @{
		senderDomain = "ContosoIndustries.net"
		useCompanyBranding = $true
	}
}

Update-MgBetaIdentityGovernanceLifecycleWorkflowSetting -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityGovernanceLifecycleWorkflowSetting Cmdlet.


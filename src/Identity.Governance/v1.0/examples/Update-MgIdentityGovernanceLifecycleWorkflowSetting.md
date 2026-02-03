### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	"@odata.context" = "https://graph.microsoft.com/v1.0/$metadata#identityGovernance/lifecycleWorkflows/settings/$entity"
	workflowScheduleIntervalInHours = 3
	emailSettings = @{
		senderDomain = "ContosoIndustries.net"
		useCompanyBranding = $true
	}
}

Update-MgIdentityGovernanceLifecycleWorkflowSetting -BodyParameter $params

```
This example shows how to use the Update-MgIdentityGovernanceLifecycleWorkflowSetting Cmdlet.


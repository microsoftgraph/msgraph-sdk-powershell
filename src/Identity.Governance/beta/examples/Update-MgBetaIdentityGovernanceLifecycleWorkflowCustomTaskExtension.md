### Example 1: Using the Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	DisplayName = "Grant manager access to mailbox and OneDrive"
	Description = "Grant manager access to mailbox and OneDrive"
	EndpointConfiguration = @{
		"@odata.type" = "#microsoft.graph.logicAppTriggerEndpointConfiguration"
		SubscriptionId = "c500b67c-e9b7-4ad2-a90d-77d41385ae55"
		ResourceGroupName = "RG-LCM"
		LogicAppWorkflowName = "ManagerAccess"
	}
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.azureAdTokenAuthentication"
		ResourceId = "542dc01a-0b5d-4edc-b3f9-5cfe6393f557"
	}
	ClientConfiguration = @{
		"@odata.type" = "#microsoft.graph.customExtensionClientConfiguration"
		MaximumRetries = 
		TimeoutInMilliseconds = 1000
	}
	CallbackConfiguration = @{
		"@odata.type" = "#microsoft.graph.identityGovernance.customTaskExtensionCallbackConfiguration"
		TimeoutDuration = "PT20M"
	}
}
Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension -CustomTaskExtensionId $customTaskExtensionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

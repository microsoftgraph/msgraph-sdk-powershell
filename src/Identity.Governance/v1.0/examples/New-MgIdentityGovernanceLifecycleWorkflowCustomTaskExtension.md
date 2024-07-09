### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "Grant manager access to mailbox and OneDrive"
	description = "Grant manager access to mailbox and OneDrive"
	endpointConfiguration = @{
		"@odata.type" = "#microsoft.graph.logicAppTriggerEndpointConfiguration"
		subscriptionId = "c500b67c-e9b7-4ad2-a90d-77d41385ae55"
		resourceGroupName = "RG-LCM"
		logicAppWorkflowName = "ManagerAccess"
	}
	authenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.azureAdTokenAuthentication"
		resourceId = "542dc01a-0b5d-4edc-b3f9-5cfe6393f557"
	}
	clientConfiguration = @{
		"@odata.type" = "#microsoft.graph.customExtensionClientConfiguration"
		maximumRetries = 1
		timeoutInMilliseconds = 1000
	}
	callbackConfiguration = @{
		"@odata.type" = "#microsoft.graph.identityGovernance.customTaskExtensionCallbackConfiguration"
		timeoutDuration = "PT5M"
	}
}

New-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension -BodyParameter $params

```
This example shows how to use the New-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension Cmdlet.


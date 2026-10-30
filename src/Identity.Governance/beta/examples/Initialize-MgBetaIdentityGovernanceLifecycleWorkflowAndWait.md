### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	subject = @{
		"@odata.type" = "#microsoft.graph.identityGovernance.provisioningObjectWorkflowSubject"
		id = "b74f0fae-b1f3-4c96-9bf0-d4d8a8e37cbe"
		attributeSetEntries = @(
			@{
				name = "department"
				value = "Engineering"
			}
			@{
				name = "jobTitle"
				value = "Software Engineer"
			}
		)
	}
}

Initialize-MgBetaIdentityGovernanceLifecycleWorkflowAndWait -WorkflowId $workflowId -BodyParameter $params

```
This example shows how to use the Initialize-MgBetaIdentityGovernanceLifecycleWorkflowAndWait Cmdlet.


### Example 1: Using the New-MgBetaIdentityGovernanceLifecycleWorkflow Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	Category = "joiner"
	Description = "Configure new hire tasks for onboarding employees on their first day"
	DisplayName = "Australia Onboard new hire employee"
	IsEnabled = $true
	IsSchedulingEnabled = $false
	ExecutionConditions = @{
		"@odata.type" = "#microsoft.graph.identityGovernance.triggerAndScopeBasedConditions"
		Scope = @{
			"@odata.type" = "#microsoft.graph.identityGovernance.ruleBasedSubjectSet"
			Rule = "(country eq 'Australia')"
		}
		Trigger = @{
			"@odata.type" = "#microsoft.graph.identityGovernance.timeBasedAttributeTrigger"
			TimeBasedAttribute = "employeeHireDate"
			OffsetInDays = 
		}
	}
	Tasks = @(
		@{
			ContinueOnError = $false
			Description = "Enable user account in the directory"
			DisplayName = "Enable User Account"
			IsEnabled = $true
			TaskDefinitionId = "6fc52c9d-398b-4305-9763-15f42c1676fc"
			Arguments = @(
			)
		}
		@{
			ContinueOnError = $false
			Description = "Send welcome email to new hire"
			DisplayName = "Send Welcome Email"
			IsEnabled = $true
			TaskDefinitionId = "70b29d51-b59a-4773-9280-8841dfd3f2ea"
			Arguments = @(
			)
		}
	)
}
New-MgBetaIdentityGovernanceLifecycleWorkflow -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityGovernanceLifecycleWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Create a new version of a joiner workflow with time based trigger

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	workflow = @{
		category = "joiner"
		description = "Configure new hire tasks for onboarding employees on their first day"
		displayName = "Global onboard new hire employee"
		isEnabled = $true
		isSchedulingEnabled = $false
		executionConditions = @{
			"@odata.type" = "#microsoft.graph.identityGovernance.triggerAndScopeBasedConditions"
			scope = @{
				"@odata.type" = "#microsoft.graph.identityGovernance.ruleBasedSubjectSet"
				rule = "(department eq 'Marketing')"
			}
			trigger = @{
				"@odata.type" = "#microsoft.graph.identityGovernance.timeBasedAttributeTrigger"
				timeBasedAttribute = "employeeHireDate"
				offsetInDays = 
			}
		}
		tasks = @(
			@{
				continueOnError = $false
				description = "Enable user account in the directory"
				displayName = "Enable User Account"
				isEnabled = $true
				taskDefinitionId = "6fc52c9d-398b-4305-9763-15f42c1676fc"
				arguments = @(
				)
			}
			@{
				continueOnError = $false
				description = "Send welcome email to new hire"
				displayName = "Send Welcome Email"
				isEnabled = $true
				taskDefinitionId = "70b29d51-b59a-4773-9280-8841dfd3f2ea"
				arguments = @(
				)
			}
		)
	}
}

New-MgBetaIdentityGovernanceLifecycleWorkflowNewVersion -WorkflowId $workflowId -BodyParameter $params

```
This example will create a new version of a joiner workflow with time based trigger

### Example 2: Create a new version of a task with customized email

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	category = "joiner"
	description = "Configure new hire tasks for onboarding employees on their first day"
	displayName = "custom email marketing API test"
	isEnabled = $true
	isSchedulingEnabled = $false
	executionConditions = @{
		"@odata.type" = "#microsoft.graph.identityGovernance.triggerAndScopeBasedConditions"
		scope = @{
			"@odata.type" = "#microsoft.graph.identityGovernance.ruleBasedSubjectSet"
			rule = "(department eq 'Marketing')"
		}
		trigger = @{
			"@odata.type" = "#microsoft.graph.identityGovernance.timeBasedAttributeTrigger"
			timeBasedAttribute = "employeeHireDate"
			offsetInDays = 
		}
	}
	tasks = @(
		@{
			continueOnError = $false
			description = "Enable user account in the directory"
			displayName = "Enable User Account"
			isEnabled = $true
			taskDefinitionId = "6fc52c9d-398b-4305-9763-15f42c1676fc"
			arguments = @(
			)
		}
		@{
			continueOnError = $false
			description = "Send welcome email to new hire"
			displayName = "Send Welcome Email"
			isEnabled = $true
			taskDefinitionId = "70b29d51-b59a-4773-9280-8841dfd3f2ea"
			arguments = @(
				@{
					name = "cc"
					value = "1baa57fa-3c4e-4526-ba5a-db47a9df95f0"
				}
				@{
					name = "customSubject"
					value = "Welcome to the organization {{userDisplayName}}!"
				}
				@{
					name = "customBody"
					value = "Welcome to our organization {{userGivenName}}!"
				}
				@{
					name = "locale"
					value = "en-us"
				}
			)
		}
	)
}

New-MgBetaIdentityGovernanceLifecycleWorkflowNewVersion -WorkflowId $workflowId -BodyParameter $params

```
This example will create a new version of a task with customized email


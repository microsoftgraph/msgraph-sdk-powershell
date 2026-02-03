### Example 1: Create a joiner workflow using the time based trigger

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	category = "joiner"
	description = "Configure new hire tasks for onboarding employees on their first day"
	displayName = "Australia Onboard new hire employee"
	isEnabled = $true
	isSchedulingEnabled = $true
	executionConditions = @{
		"@odata.type" = "#microsoft.graph.identityGovernance.triggerAndScopeBasedConditions"
		scope = @{
			"@odata.type" = "#microsoft.graph.identityGovernance.ruleBasedSubjectSet"
			rule = "(country eq 'Australia')"
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

New-MgBetaIdentityGovernanceLifecycleWorkflow -BodyParameter $params

```
This example will create a joiner workflow using the time based trigger

### Example 2: Create a mover workflow using the attribute changes trigger

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	category = "mover"
	description = "Configure mover tasks for a user when their job profile changes"
	displayName = "Sales contractor moves to full-time employee"
	isEnabled = $true
	isSchedulingEnabled = $true
	executionConditions = @{
		"@odata.type" = "#microsoft.graph.identityGovernance.triggerAndScopeBasedConditions"
		scope = @{
			"@odata.type" = "#microsoft.graph.identityGovernance.ruleBasedSubjectSet"
			rule = "(department eq 'Sales')"
		}
		trigger = @{
			"@odata.type" = "#microsoft.graph.identityGovernance.attributeChangeTrigger"
			triggerAttributes = @(
				@{
					name = "department"
				}
			)
		}
	}
	tasks = @(
		@{
			continueOnError = $false
			description = "Send email to moving employee's manager"
			displayName = "Notify manager of move"
			isEnabled = $true
			taskDefinitionId = "aab41899-9972-422a-9d97-f626014578b7"
			arguments = @(
			)
		}
	)
}

New-MgBetaIdentityGovernanceLifecycleWorkflow -BodyParameter $params

```
This example will create a mover workflow using the attribute changes trigger

### Example 3: Create a leaver workflow using the group based trigger

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	category = "leaver"
	description = "Configure offboarding tasks for employees on their last day of work"
	displayName = "Offboard an employee"
	isEnabled = $true
	isSchedulingEnabled = $true
	executionConditions = @{
		"@odata.type" = "#microsoft.graph.identityGovernance.triggerAndScopeBasedConditions"
		scope = @{
			"@odata.type" = "#microsoft.graph.identityGovernance.groupBasedSubjectSet"
			groups = @(
				@{
					id = "668e7540-7f8e-4ca4-a207-b7dffbb6d038"
				}
			)
		}
		trigger = @{
			"@odata.type" = "#microsoft.graph.identityGovernance.membershipChangeTrigger"
			changeType = "remove"
		}
	}
	tasks = @(
		@{
			category = "leaver"
			continueOnError = $false
			description = "Remove user from all Teams memberships"
			displayName = "Remove user from all Teams"
			isEnabled = $true
			taskDefinitionId = "81f7b200-2816-4b3b-8c5d-dc556f07b024"
			arguments = @(
			)
		}
		@{
			category = "leaver"
			continueOnError = $false
			description = "Remove user from all Azure AD groups memberships"
			displayName = "Remove user from all groups"
			isEnabled = $true
			taskDefinitionId = "b3a31406-2a15-4c9a-b25b-a658fa5f07fc"
			arguments = @(
			)
		}
	)
}

New-MgBetaIdentityGovernanceLifecycleWorkflow -BodyParameter $params

```
This example will create a leaver workflow using the group based trigger


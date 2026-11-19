### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.BusinessScenario

$params = @{
	editPolicy = @{
		rules = @(
			@{
				userType = @{
					"@odata.type" = "#microsoft.graph.plannerRelationshipBasedUserType"
					selectionKind = "relationship"
					role = "defaultRules"
				}
				defaultRule = "block"
				propertyRule = @{
					ruleKind = "taskRule"
					references = @{
						defaultRules = @(
						"allow"
					)
					overrides = @(
					)
				}
				checkLists = @{
					defaultRules = @(
					"allow"
				)
				overrides = @(
				)
			}
			assignments = @{
				defaultRules = @(
				"allow"
			)
			overrides = @(
				@{
					name = "userCreated"
					rules = @(
					"allow"
				)
			}
			@{
				name = "applicationCreated"
				rules = @(
				"allow"
			)
		}
	)
}
appliedCategories = @{
	defaultRules = @(
	"allow"
)
overrides = @(
)
}
}
}
)
}
}

Update-MgBetaSolutionBusinessScenarioPlannerTaskConfiguration -BusinessScenarioId $businessScenarioId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSolutionBusinessScenarioPlannerTaskConfiguration Cmdlet.


### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

$params = @{
	displayName = "Example Credit Rubric"
	description = @{
		content = "This is an example of a credit rubric (no points)"
		contentType = "text"
	}
	levels = @(
		@{
			displayName = "Good"
			description = @{
				content = ""
				contentType = "text"
			}
		}
		@{
			displayName = "Poor"
			description = @{
				content = ""
				contentType = "text"
			}
		}
	)
	qualities = @(
		@{
			description = @{
				content = "Argument"
				contentType = "text"
			}
			criteria = @(
				@{
					description = @{
						content = "The essay's argument is persuasive."
						contentType = "text"
					}
				}
				@{
					description = @{
						content = "The essay's argument does not make sense."
						contentType = "text"
					}
				}
			)
		}
		@{
			description = @{
				content = "Spelling and Grammar"
				contentType = "text"
			}
			criteria = @(
				@{
					description = @{
						content = "The essay uses proper spelling and grammar with few or no errors."
						contentType = "text"
					}
				}
				@{
					description = @{
						content = "The essay has numerous errors in spelling and/or grammar."
						contentType = "text"
					}
				}
			)
		}
	)
}

New-MgBetaEducationMeRubric -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaEducationUserRubric Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


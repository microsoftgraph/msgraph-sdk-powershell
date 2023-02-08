### Example 1: Using the New-MgBetaEducationMeRubric Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DisplayName = "Example Credit Rubric"
	Description = @{
		Content = "This is an example of a credit rubric (no points)"
		ContentType = "text"
	}
	Levels = @(
		@{
			DisplayName = "Good"
			Description = @{
				Content = ""
				ContentType = "text"
			}
		}
		@{
			DisplayName = "Poor"
			Description = @{
				Content = ""
				ContentType = "text"
			}
		}
	)
	Qualities = @(
		@{
			Description = @{
				Content = "Argument"
				ContentType = "text"
			}
			Criteria = @(
				@{
					Description = @{
						Content = "The essay's argument is persuasive."
						ContentType = "text"
					}
				}
				@{
					Description = @{
						Content = "The essay's argument does not make sense."
						ContentType = "text"
					}
				}
			)
		}
		@{
			Description = @{
				Content = "Spelling and Grammar"
				ContentType = "text"
			}
			Criteria = @(
				@{
					Description = @{
						Content = "The essay uses proper spelling and grammar with few or no errors."
						ContentType = "text"
					}
				}
				@{
					Description = @{
						Content = "The essay has numerous errors in spelling and/or grammar."
						ContentType = "text"
					}
				}
			)
		}
	)
}
New-MgBetaEducationMeRubric -BodyParameter $params
```
This example shows how to use the New-MgBetaEducationMeRubric Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaEducationMeRubric Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DisplayName = "Example Points Rubric"
	Description = @{
		Content = "This is an example of a rubric with points"
		ContentType = "text"
	}
	Levels = @(
		@{
			DisplayName = "Good"
			Description = @{
				Content = ""
				ContentType = "text"
			}
			Grading = @{
				"@odata.type" = "#microsoft.graph.educationAssignmentPointsGradeType"
				MaxPoints = 
			}
		}
		@{
			DisplayName = "Poor"
			Description = @{
				Content = ""
				ContentType = "text"
			}
			Grading = @{
				"@odata.type" = "#microsoft.graph.educationAssignmentPointsGradeType"
				MaxPoints = 
			}
		}
	)
	Qualities = @(
		@{
			Description = @{
				Content = "Argument"
				ContentType = "text"
			}
			Criteria = @(
				@{
					Description = @{
						Content = "The essay's argument is persuasive."
						ContentType = "text"
					}
				}
				@{
					Description = @{
						Content = "The essay's argument does not make sense."
						ContentType = "text"
					}
				}
			)
			Weight = 50.0
		}
		@{
			Description = @{
				Content = "Spelling and Grammar"
				ContentType = "text"
			}
			Criteria = @(
				@{
					Description = @{
						Content = "The essay uses proper spelling and grammar with few or no errors."
						ContentType = "text"
					}
				}
				@{
					Description = @{
						Content = "The essay has numerous errors in spelling and/or grammar."
						ContentType = "text"
					}
				}
			)
			Weight = 50.0
		}
	)
	Grading = @{
		"@odata.type" = "#microsoft.graph.educationAssignmentPointsGradeType"
	}
}
New-MgBetaEducationMeRubric -BodyParameter $params
```
This example shows how to use the New-MgBetaEducationMeRubric Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

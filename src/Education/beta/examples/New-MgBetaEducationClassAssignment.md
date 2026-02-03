### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	dueDateTime = [System.DateTime]::Parse("2025-09-16T00:00:00Z")
	displayName = "Reading test 09.14"
	languageTag = "es-MX"
	instructions = @{
		contentType = "text"
		content = "Read chapter 4"
	}
	grading = @{
		"@odata.type" = "#microsoft.graph.educationAssignmentPointsGradeType"
		maxPoints = 
	}
	assignTo = @{
		"@odata.type" = "#microsoft.graph.educationAssignmentClassRecipient"
	}
	status = "draft"
	allowStudentsToAddResourcesToSubmission = $true
}

New-MgBetaEducationClassAssignment -EducationClassId $educationClassId -BodyParameter $params

```
This example shows how to use the New-MgBetaEducationClassAssignment Cmdlet.


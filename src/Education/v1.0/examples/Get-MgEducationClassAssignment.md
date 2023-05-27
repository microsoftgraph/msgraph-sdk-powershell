### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	displayName = "Reading and review test 09.03 #5"
	instructions = @{
		contentType = "text"
		content = "Read chapter 5 and write your review"
	}
	dueDateTime = [System.DateTime]::Parse("2021-09-10T00:00:00Z")
	addedStudentAction = "none"
}

Update-MgEducationClassAssignment -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the Get-MgEducationClassAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


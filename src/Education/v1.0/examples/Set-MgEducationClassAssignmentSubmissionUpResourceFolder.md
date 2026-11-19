### Example 1: Set up a resource folder for a submission

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
}

Set-MgEducationClassAssignmentSubmissionUpResourceFolder -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params

```
This example will set up a resource folder for a submission

### Example 2: Set up a resource folder when the assignment is no longer open for submission

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
}

Set-MgEducationClassAssignmentSubmissionUpResourceFolder -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params

```
This example will set up a resource folder when the assignment is no longer open for submission

### Example 3: Set up a resource folder when the assignment is already in submitted state

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
}

Set-MgEducationClassAssignmentSubmissionUpResourceFolder -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params

```
This example will set up a resource folder when the assignment is already in submitted state


### Example 1: Get a list of reading assignment submissions from the last 24 hours

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationReportReadingAssignmentSubmission

```
This example will get a list of reading assignment submissions from the last 24 hours

### Example 2: Get a list of the reading assignment submissions for a specific date using $filter

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationReportReadingAssignmentSubmission -Filter "submissionDateTime gt 2023-10-10T00:00:00.000Z and submissionDateTime lt 2023-10-11T00:00:00Z" 

```
This example will get a list of the reading assignment submissions for a specific date using $filter


### Example 1: Get a list of the speaker assignment submissions from the last 24 hours

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationReportSpeakerAssignmentSubmission

```
This example will get a list of the speaker assignment submissions from the last 24 hours

### Example 2: Get a list of the speaker assignment submissions for a specific date using $filter

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationReportSpeakerAssignmentSubmission -Filter "submissionDateTime gt 2025-05-28T00:00:00Z and submissionDateTime lt 2025-05-29T00:00:00Z" 

```
This example will get a list of the speaker assignment submissions for a specific date using $filter


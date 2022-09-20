### Example 1: Using the Update-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	IsReportToMicrosoftEnabled = $false
}
Update-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy -EmailThreatSubmissionPolicyId $emailThreatSubmissionPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

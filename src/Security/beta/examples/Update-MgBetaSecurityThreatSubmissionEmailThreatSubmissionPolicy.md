### Example 1: Using the Update-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	IsReportToMicrosoftEnabled = $false
}
Update-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy -EmailThreatSubmissionPolicyId $emailThreatSubmissionPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the New-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	IsReportToMicrosoftEnabled = $true
}
New-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

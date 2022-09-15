### Example 1: Using the New-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	IsReportToMicrosoftEnabled = $true
}
New-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy -BodyParameter $params
```
This example shows how to use the New-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

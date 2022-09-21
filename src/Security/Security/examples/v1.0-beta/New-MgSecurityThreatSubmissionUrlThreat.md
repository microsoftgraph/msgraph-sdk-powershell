### Example 1: Using the New-MgSecurityThreatSubmissionUrlThreat Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	"@odata.type" = "#microsoft.graph.urlThreatSubmission"
	Category = "phishing"
	WebUrl = "http://phishing.contoso.com"
}
New-MgSecurityThreatSubmissionUrlThreat -BodyParameter $params
```
This example shows how to use the New-MgSecurityThreatSubmissionUrlThreat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

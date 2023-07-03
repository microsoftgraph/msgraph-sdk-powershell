### Example 1: Using the New-MgBetaSecurityThreatSubmissionUrlThreat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	"@odata.type" = "#microsoft.graph.urlThreatSubmission"
	Category = "phishing"
	WebUrl = "http://phishing.contoso.com"
}
New-MgBetaSecurityThreatSubmissionUrlThreat -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityThreatSubmissionUrlThreat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

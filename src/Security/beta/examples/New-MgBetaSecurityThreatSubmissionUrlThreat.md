### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.urlThreatSubmission"
	category = "phishing"
	webUrl = "http://phishing.contoso.com"
}

New-MgBetaSecurityThreatSubmissionUrlThreat -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityThreatSubmissionUrlThreat Cmdlet.


### Example 1: Using the New-MgBetaSecurityThreatSubmissionEmailThreat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	"@odata.type" = "#microsoft.graph.emailUrlThreatSubmission"
	Category = "spam"
	RecipientEmailAddress = "tifc@a830edad9050849EQTPWBJZXODQ.onmicrosoft.com"
	MessageUrl = "https://graph.microsoft.com/beta/users/c52ce8db-3e4b-4181-93c4-7d6b6bffaf60/messages/AAMkADU3MWUxOTU0LWNlOTEt="
}
New-MgBetaSecurityThreatSubmissionEmailThreat -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityThreatSubmissionEmailThreat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

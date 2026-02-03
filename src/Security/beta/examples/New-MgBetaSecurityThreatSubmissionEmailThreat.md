### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.emailUrlThreatSubmission"
	category = "spam"
	recipientEmailAddress = "tifc@contoso.com"
	messageUrl = "https://graph.microsoft.com/beta/users/c52ce8db-3e4b-4181-93c4-7d6b6bffaf60/messages/AAMkADU3MWUxOTU0LWNlOTEt="
}

New-MgBetaSecurityThreatSubmissionEmailThreat -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityThreatSubmissionEmailThreat Cmdlet.


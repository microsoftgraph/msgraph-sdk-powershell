### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "Clean up Phish email"
	description = "Delete email"
	severity = "medium"
	action = "softDelete"
	remediateSendersCopy = "false"
	analyzedEmails = @(
		@{
			networkMessageId = "73ca4154-58d8-43d0-a890-08dc18c52e6d"
			recipientEmailAddress = "hannah.jarvis@contoso.com"
		}
		@{
			networkMessageId = "73ca4154-58d8-43d0-a890-08dc18c52e6d"
			recipientEmailAddress = "preston.morales@contoso.com"
		}
	)
}

Invoke-MgBetaRemediateSecurityCollaborationAnalyzedEmail -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaRemediateSecurityCollaborationAnalyzedEmail Cmdlet.


### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	controlStateUpdates = "controlStateUpdates-value"
}

Update-MgBetaSecuritySecureScoreControlProfile -SecureScoreControlProfileId $secureScoreControlProfileId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecuritySecureScoreControlProfile Cmdlet.


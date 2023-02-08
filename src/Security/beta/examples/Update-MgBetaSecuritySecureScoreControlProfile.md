### Example 1: Using the Update-MgBetaSecuritySecureScoreControlProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	ControlStateUpdates = "controlStateUpdates-value"
}
Update-MgBetaSecuritySecureScoreControlProfile -SecureScoreControlProfileId $secureScoreControlProfileId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecuritySecureScoreControlProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

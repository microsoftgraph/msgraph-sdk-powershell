### Example 1: Using the Update-MgSecuritySecureScoreControlProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	ControlStateUpdates = "controlStateUpdates-value"
}
Update-MgSecuritySecureScoreControlProfile -SecureScoreControlProfileId $secureScoreControlProfileId -BodyParameter $params
```
This example shows how to use the Update-MgSecuritySecureScoreControlProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

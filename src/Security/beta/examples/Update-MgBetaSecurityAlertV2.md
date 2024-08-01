### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	assignedTo = "secAdmin@contoso.com"
	classification = "truePositive"
	determination = "malware"
	status = "inProgress"
}

Update-MgBetaSecurityAlertV2 -AlertId $alertId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityAlertV2 Cmdlet.


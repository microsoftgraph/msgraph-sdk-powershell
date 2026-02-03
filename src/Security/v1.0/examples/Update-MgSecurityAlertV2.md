### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	assignedTo = "secAdmin@contoso.com"
	classification = "truePositive"
	determination = "malware"
	status = "inProgress"
}

Update-MgSecurityAlertV2 -AlertId $alertId -BodyParameter $params

```
This example shows how to use the Update-MgSecurityAlertV2 Cmdlet.


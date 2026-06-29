### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	status = "closed"
}

Update-MgSecurityIdentityHealthIssue -HealthIssueId $healthIssueId -BodyParameter $params

```
This example shows how to use the Update-MgSecurityIdentityHealthIssue Cmdlet.


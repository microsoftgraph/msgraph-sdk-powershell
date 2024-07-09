### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	status = "closed"
}

Update-MgBetaSecurityIdentityHealthIssue -HealthIssueId $healthIssueId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityIdentityHealthIssue Cmdlet.


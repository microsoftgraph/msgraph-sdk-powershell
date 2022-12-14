### Example 1: Using the Set-MgBetaApplicationVerifiedPublisher Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	VerifiedPublisherId = "1234567"
}
Set-MgBetaApplicationVerifiedPublisher -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Set-MgBetaApplicationVerifiedPublisher Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

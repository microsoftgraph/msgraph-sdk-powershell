### Example 1: Using the Set-MgApplicationVerifiedPublisher Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	VerifiedPublisherId = "1234567"
}
Set-MgApplicationVerifiedPublisher -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Set-MgApplicationVerifiedPublisher Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

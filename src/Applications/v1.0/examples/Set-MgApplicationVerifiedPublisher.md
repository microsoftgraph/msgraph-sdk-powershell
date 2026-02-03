### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	verifiedPublisherId = "1234567"
}

Set-MgApplicationVerifiedPublisher -ApplicationId $applicationId -BodyParameter $params

```
This example shows how to use the Set-MgApplicationVerifiedPublisher Cmdlet.


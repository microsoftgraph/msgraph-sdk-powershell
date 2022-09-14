### Example 1
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	VerifiedPublisherId = "1234567"
}
Set-MgApplicationVerifiedPublisher -ApplicationId $applicationId -BodyParameter $params
```

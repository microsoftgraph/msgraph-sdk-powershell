### Example 1
``` powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Role = "viewer"
}
Rename-MgCommunicationCallScreenSharingRole -CallId $callId -BodyParameter $params
```

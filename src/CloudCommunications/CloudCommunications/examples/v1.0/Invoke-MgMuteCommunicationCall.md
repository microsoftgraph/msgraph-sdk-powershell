### Example 1
``` powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Invoke-MgMuteCommunicationCall -CallId $callId -BodyParameter $params
```

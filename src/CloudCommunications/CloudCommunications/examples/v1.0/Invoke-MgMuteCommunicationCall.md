###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Invoke-MgMuteCommunicationCall -CallId $callId -BodyParameter $params
```

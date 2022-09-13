###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Invoke-MgUnmuteCommunicationCall -CallId $callId -BodyParameter $params
```

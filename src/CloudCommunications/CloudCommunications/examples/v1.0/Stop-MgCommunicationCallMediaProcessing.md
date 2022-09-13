###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Stop-MgCommunicationCallMediaProcessing -CallId $callId -BodyParameter $params
```

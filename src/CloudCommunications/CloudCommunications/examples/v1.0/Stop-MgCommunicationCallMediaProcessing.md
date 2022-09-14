### Example 1
``` powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Stop-MgCommunicationCallMediaProcessing -CallId $callId -BodyParameter $params
```

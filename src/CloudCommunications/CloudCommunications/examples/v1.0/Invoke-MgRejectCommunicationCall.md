###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Reason = "none"
}
Invoke-MgRejectCommunicationCall -CallId $callId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Reason = "busy"
}
Invoke-MgRejectCommunicationCall -CallId $callId -BodyParameter $params
```

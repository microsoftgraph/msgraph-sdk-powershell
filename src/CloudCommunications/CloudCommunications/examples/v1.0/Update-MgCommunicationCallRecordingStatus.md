###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
	Status = "notRecording | recording | failed"
}
Update-MgCommunicationCallRecordingStatus -CallId $callId -BodyParameter $params
```

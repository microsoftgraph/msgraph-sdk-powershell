### Example 1
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
	Status = "notRecording | recording | failed"
}
Update-MgCommunicationCallRecordingStatus -CallId $callId -BodyParameter $params
```

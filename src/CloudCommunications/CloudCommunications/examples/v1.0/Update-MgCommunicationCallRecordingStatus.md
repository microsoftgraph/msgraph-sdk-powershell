### Example 1: Using the Update-MgCommunicationCallRecordingStatus Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
	Status = "notRecording | recording | failed"
}
Update-MgCommunicationCallRecordingStatus -CallId $callId -BodyParameter $params
```
This example shows how to use the Update-MgCommunicationCallRecordingStatus Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

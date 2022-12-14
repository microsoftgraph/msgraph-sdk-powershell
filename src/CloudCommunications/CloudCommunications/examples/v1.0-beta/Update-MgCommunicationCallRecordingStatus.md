### Example 1: Using the Update-MgBetaCommunicationCallRecordingStatus Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
	Status = "notRecording | recording | failed"
}
Update-MgBetaCommunicationCallRecordingStatus -CallId $callId -BodyParameter $params
```
This example shows how to use the Update-MgBetaCommunicationCallRecordingStatus Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

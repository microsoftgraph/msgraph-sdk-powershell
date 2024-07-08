### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	clientContext = "clientContext-value"
	status = "notRecording | recording | failed"
}

Update-MgBetaCommunicationCallRecordingStatus -CallId $callId -BodyParameter $params

```
This example shows how to use the Update-MgBetaCommunicationCallRecordingStatus Cmdlet.


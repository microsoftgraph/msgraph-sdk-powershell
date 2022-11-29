### Example 1: Using the Invoke-MgMuteAllCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		""
	)
	ClientContext = "clientContext-value"
}
Invoke-MgMuteAllCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgMuteAllCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Invoke-MgBetaMuteAllCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Participants = @(
		""
	)
	ClientContext = "clientContext-value"
}
Invoke-MgBetaMuteAllCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaMuteAllCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

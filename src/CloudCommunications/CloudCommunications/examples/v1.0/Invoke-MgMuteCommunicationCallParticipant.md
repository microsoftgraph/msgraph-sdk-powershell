### Example 1: Using the Invoke-MgMuteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
}
Invoke-MgMuteCommunicationCallParticipant -CallId $callId -ParticipantId $participantId -BodyParameter $params
```
This example shows how to use the Invoke-MgMuteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

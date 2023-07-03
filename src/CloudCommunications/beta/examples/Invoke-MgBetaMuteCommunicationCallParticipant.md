### Example 1: Using the Invoke-MgBetaMuteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	ClientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
}
Invoke-MgBetaMuteCommunicationCallParticipant -CallId $callId -ParticipantId $participantId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaMuteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	clientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
}

Invoke-MgBetaMuteCommunicationCallParticipant -CallId $callId -ParticipantId $participantId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaMuteCommunicationCallParticipant Cmdlet.


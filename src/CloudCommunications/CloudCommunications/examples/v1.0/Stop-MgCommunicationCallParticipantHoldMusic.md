###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
}
Stop-MgCommunicationCallParticipantHoldMusic -CallId $callId -ParticipantId $participantId -BodyParameter $params
```

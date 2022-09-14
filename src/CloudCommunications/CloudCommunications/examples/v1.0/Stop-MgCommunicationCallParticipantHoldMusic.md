### Example 1: Using the Stop-MgCommunicationCallParticipantHoldMusic Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
}
Stop-MgCommunicationCallParticipantHoldMusic -CallId $callId -ParticipantId $participantId -BodyParameter $params
```
This example shows how to use the Stop-MgCommunicationCallParticipantHoldMusic Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Start-MgCommunicationCallParticipantHoldMusic Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	CustomPrompt = @{
		"@odata.type" = "#microsoft.graph.mediaPrompt"
		MediaInfo = @{
			"@odata.type" = "#microsoft.graph.mediaInfo"
			Uri = "https://bot.contoso.com/onHold.wav"
		}
	}
	ClientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
}
Start-MgCommunicationCallParticipantHoldMusic -CallId $callId -ParticipantId $participantId -BodyParameter $params
```
This example shows how to use the Start-MgCommunicationCallParticipantHoldMusic Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

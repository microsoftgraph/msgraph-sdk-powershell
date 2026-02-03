### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	customPrompt = @{
		"@odata.type" = "#microsoft.graph.mediaPrompt"
		mediaInfo = @{
			"@odata.type" = "#microsoft.graph.mediaInfo"
			uri = "https://bot.contoso.com/onHold.wav"
		}
	}
	clientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
}

Start-MgBetaCommunicationCallParticipantHoldMusic -CallId $callId -ParticipantId $participantId -BodyParameter $params

```
This example shows how to use the Start-MgBetaCommunicationCallParticipantHoldMusic Cmdlet.


### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	callbackUri = "callbackUri-value"
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		blob = "<Media Session Configuration Blob>"
	}
	acceptedModalities = @(
	"audio"
)
callOptions = @{
	"@odata.type" = "#microsoft.graph.incomingCallOptions"
	isContentSharingNotificationEnabled = $true
}
participantCapacity = 200
}

Invoke-MgBetaAnswerCommunicationCall -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaAnswerCommunicationCall Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	callbackUri = "https://bot.contoso.com/api/calls"
	acceptedModalities = @(
	"audio"
)
mediaConfig = @{
	"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
	blob = "<Media Session Configuration Blob>"
}
}

Invoke-MgBetaAnswerCommunicationCall -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaAnswerCommunicationCall Cmdlet.


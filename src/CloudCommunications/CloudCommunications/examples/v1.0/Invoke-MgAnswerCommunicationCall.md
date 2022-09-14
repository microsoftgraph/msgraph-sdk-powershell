### Example 1
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	CallbackUri = "https://bot.contoso.com/api/calls"
	AcceptedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		Blob = "<Media Session Configuration Blob>"
	}
}
Invoke-MgAnswerCommunicationCall -CallId $callId -BodyParameter $params
```
### Example 2
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	CallbackUri = "callbackUri-value"
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		Blob = "<Media Session Configuration Blob>"
	}
	AcceptedModalities = @(
		"audio"
	)
	ParticipantCapacity = 200
}
Invoke-MgAnswerCommunicationCall -CallId $callId -BodyParameter $params
```
### Example 3
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	CallbackUri = "https://bot.contoso.com/api/calls"
	AcceptedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
}
Invoke-MgAnswerCommunicationCall -CallId $callId -BodyParameter $params
```

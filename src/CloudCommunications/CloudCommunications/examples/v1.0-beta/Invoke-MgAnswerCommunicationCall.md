### Example 1: Using the Invoke-MgAnswerCommunicationCall Cmdlet
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
This example shows how to use the Invoke-MgAnswerCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Invoke-MgAnswerCommunicationCall Cmdlet
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
	CallOptions = @{
		"@odata.type" = "#microsoft.graph.incomingCallOptions"
		IsContentSharingNotificationEnabled = $true
	}
	ParticipantCapacity = 200
}
Invoke-MgAnswerCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgAnswerCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

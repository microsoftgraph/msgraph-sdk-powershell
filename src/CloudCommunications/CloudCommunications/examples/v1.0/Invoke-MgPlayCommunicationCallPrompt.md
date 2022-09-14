### Example 1: Using the Invoke-MgPlayCommunicationCallPrompt Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
	Prompts = @(
		@{
			"@odata.type" = "#microsoft.graph.mediaPrompt"
			MediaInfo = @{
				"@odata.type" = "#microsoft.graph.mediaInfo"
				Uri = "https://cdn.contoso.com/beep.wav"
				ResourceId = "1D6DE2D4-CD51-4309-8DAA-70768651088E"
			}
		}
	)
}
Invoke-MgPlayCommunicationCallPrompt -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgPlayCommunicationCallPrompt Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

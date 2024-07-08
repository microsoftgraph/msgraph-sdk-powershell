### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	clientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
	prompts = @(
		@{
			"@odata.type" = "#microsoft.graph.mediaPrompt"
			mediaInfo = @{
				"@odata.type" = "#microsoft.graph.mediaInfo"
				uri = "https://cdn.contoso.com/beep.wav"
				resourceId = "1D6DE2D4-CD51-4309-8DAA-70768651088E"
			}
		}
	)
	loop = $false
}

Invoke-MgBetaPlayCommunicationCallPrompt -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaPlayCommunicationCallPrompt Cmdlet.


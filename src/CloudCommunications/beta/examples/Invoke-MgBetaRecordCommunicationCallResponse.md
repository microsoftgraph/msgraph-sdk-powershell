### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	bargeInAllowed = $true
	clientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
	prompts = @(
		@{
			"@odata.type" = "#microsoft.graph.mediaPrompt"
		}
	)
	maxRecordDurationInSeconds = 10
	initialSilenceTimeoutInSeconds = 5
	maxSilenceTimeoutInSeconds = 2
	playBeep = $true
	stopTones = @(
		"#"
		"1"
		"*"
	)
}

Invoke-MgBetaRecordCommunicationCallResponse -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaRecordCommunicationCallResponse Cmdlet.


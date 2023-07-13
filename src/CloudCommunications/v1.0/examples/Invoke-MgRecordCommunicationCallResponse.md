### Example 1: Using the Invoke-MgRecordCommunicationCallResponse Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	BargeInAllowed = $true
	ClientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
	Prompts = @(
		@{
			"@odata.type" = "#microsoft.graph.mediaPrompt"
		}
	)
	MaxRecordDurationInSeconds = 10
	InitialSilenceTimeoutInSeconds = 5
	MaxSilenceTimeoutInSeconds = 2
	PlayBeep = $true
	StopTones = @(
		"#"
		"1"
		"*"
	)
}
Invoke-MgRecordCommunicationCallResponse -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgRecordCommunicationCallResponse Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

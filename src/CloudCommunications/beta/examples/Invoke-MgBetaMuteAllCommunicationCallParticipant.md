### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	participants = @(
	""
)
clientContext = "clientContext-value"
}

Invoke-MgBetaMuteAllCommunicationCallParticipant -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaMuteAllCommunicationCallParticipant Cmdlet.


### Example 1: Reject an incoming call with 'Busy' reason

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	reason = "busy"
}

Invoke-MgBetaRejectCommunicationCall -CallId $callId -BodyParameter $params

```
This example will reject an incoming call with 'busy' reason

### Example 2: Reject an incoming call with 'None' reason

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	reason = "none"
}

Invoke-MgBetaRejectCommunicationCall -CallId $callId -BodyParameter $params

```
This example will reject an incoming call with 'none' reason


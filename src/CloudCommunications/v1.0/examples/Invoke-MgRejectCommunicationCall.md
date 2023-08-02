### Example 1: Reject an incoming call with 'Busy' reason

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	reason = "busy"
}

Invoke-MgRejectCommunicationCall -CallId $callId -BodyParameter $params

```
This example will reject an incoming call with 'busy' reason

### Example 2: Reject an incoming call with 'None' reason

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	reason = "none"
}

Invoke-MgRejectCommunicationCall -CallId $callId -BodyParameter $params

```
This example will reject an incoming call with 'none' reason


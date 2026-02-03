### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	clientContext = "clientContext-value"
}

Invoke-MgMuteCommunicationCall -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgMuteCommunicationCall Cmdlet.


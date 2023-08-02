### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	clientContext = "fd1c7836-4d84-4e24-b6aa-23188688cc54"
}

Invoke-MgBetaSubscribeCommunicationCallToTone -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaSubscribeCommunicationCallToTone Cmdlet.


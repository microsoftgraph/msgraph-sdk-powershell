### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	clientContext = "clientContext-value"
}

Stop-MgBetaCommunicationCallMediaProcessing -CallId $callId -BodyParameter $params

```
This example shows how to use the Stop-MgBetaCommunicationCallMediaProcessing Cmdlet.


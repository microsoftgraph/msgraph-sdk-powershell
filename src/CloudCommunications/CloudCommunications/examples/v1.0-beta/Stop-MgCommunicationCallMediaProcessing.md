### Example 1: Using the Stop-MgBetaCommunicationCallMediaProcessing Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Stop-MgBetaCommunicationCallMediaProcessing -CallId $callId -BodyParameter $params
```
This example shows how to use the Stop-MgBetaCommunicationCallMediaProcessing Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

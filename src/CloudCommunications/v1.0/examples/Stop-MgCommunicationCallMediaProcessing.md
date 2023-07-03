### Example 1: Using the Stop-MgCommunicationCallMediaProcessing Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Stop-MgCommunicationCallMediaProcessing -CallId $callId -BodyParameter $params
```
This example shows how to use the Stop-MgCommunicationCallMediaProcessing Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

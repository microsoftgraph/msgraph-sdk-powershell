### Example 1: Using the Invoke-MgBetaUnmuteCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Invoke-MgBetaUnmuteCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaUnmuteCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

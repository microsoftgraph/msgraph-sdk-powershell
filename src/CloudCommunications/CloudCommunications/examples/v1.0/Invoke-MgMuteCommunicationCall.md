### Example 1: Using the Invoke-MgMuteCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Invoke-MgMuteCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgMuteCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

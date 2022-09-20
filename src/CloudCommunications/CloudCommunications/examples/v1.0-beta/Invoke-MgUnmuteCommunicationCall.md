### Example 1: Using the Invoke-MgUnmuteCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Invoke-MgUnmuteCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgUnmuteCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

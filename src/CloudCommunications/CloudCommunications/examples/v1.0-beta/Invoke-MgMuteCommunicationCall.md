### Example 1: Using the Invoke-MgBetaMuteCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Invoke-MgBetaMuteCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaMuteCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

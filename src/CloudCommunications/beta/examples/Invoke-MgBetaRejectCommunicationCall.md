### Example 1: Using the Invoke-MgBetaRejectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Reason = "none"
}
Invoke-MgBetaRejectCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaRejectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Invoke-MgBetaRejectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Reason = "busy"
}
Invoke-MgBetaRejectCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaRejectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Invoke-MgRejectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Reason = "none"
}
Invoke-MgRejectCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgRejectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Invoke-MgRejectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Reason = "busy"
}
Invoke-MgRejectCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgRejectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

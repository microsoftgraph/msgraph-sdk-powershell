### Example 1: Using the Invoke-MgSubscribeCommunicationCallToTone Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "fd1c7836-4d84-4e24-b6aa-23188688cc54"
}
Invoke-MgSubscribeCommunicationCallToTone -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgSubscribeCommunicationCallToTone Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

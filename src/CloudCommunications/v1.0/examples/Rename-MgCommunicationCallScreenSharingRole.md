### Example 1: Using the Rename-MgCommunicationCallScreenSharingRole Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Role = "viewer"
}
Rename-MgCommunicationCallScreenSharingRole -CallId $callId -BodyParameter $params
```
This example shows how to use the Rename-MgCommunicationCallScreenSharingRole Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

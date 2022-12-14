### Example 1: Using the Rename-MgBetaCommunicationCallScreenSharingRole Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Role = "viewer"
}
Rename-MgBetaCommunicationCallScreenSharingRole -CallId $callId -BodyParameter $params
```
This example shows how to use the Rename-MgBetaCommunicationCallScreenSharingRole Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

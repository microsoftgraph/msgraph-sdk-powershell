### Example 1: Using the Get-MgBetaCommunicationPresenceByUserId Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Ids = @(
		"fa8bf3dc-eca7-46b7-bad1-db199b62afc3"
		"66825e03-7ef5-42da-9069-724602c31f6b"
	)
}
Get-MgBetaCommunicationPresenceByUserId -BodyParameter $params
```
This example shows how to use the Get-MgBetaCommunicationPresenceByUserId Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

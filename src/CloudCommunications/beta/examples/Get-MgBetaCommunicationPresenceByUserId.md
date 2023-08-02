### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	ids = @(
		"fa8bf3dc-eca7-46b7-bad1-db199b62afc3"
		"66825e03-7ef5-42da-9069-724602c31f6b"
	)
}

Get-MgBetaCommunicationPresenceByUserId -BodyParameter $params

```
This example shows how to use the Get-MgBetaCommunicationPresenceByUserId Cmdlet.


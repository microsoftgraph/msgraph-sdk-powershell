### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	role = "viewer"
}

Rename-MgBetaCommunicationCallScreenSharingRole -CallId $callId -BodyParameter $params

```
This example shows how to use the Rename-MgBetaCommunicationCallScreenSharingRole Cmdlet.


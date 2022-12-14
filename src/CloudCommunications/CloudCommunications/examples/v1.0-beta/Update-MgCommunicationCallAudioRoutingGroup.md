### Example 1: Using the Update-MgBetaCommunicationCallAudioRoutingGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Id = "oneToOne"
	RoutingMode = "oneToOne"
	Sources = @(
		"632899f8-2ea1-4604-8413-27bd2892079f"
	)
	Receivers = @(
		"550fae72-d251-43ec-868c-373732c2704f"
		"72f988bf-86f1-41af-91ab-2d7cd011db47"
	)
}
Update-MgBetaCommunicationCallAudioRoutingGroup -CallId $callId -AudioRoutingGroupId $audioRoutingGroupId -BodyParameter $params
```
This example shows how to use the Update-MgBetaCommunicationCallAudioRoutingGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

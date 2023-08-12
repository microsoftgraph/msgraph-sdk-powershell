### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	id = "oneToOne"
	routingMode = "oneToOne"
	sources = @(
		"632899f8-2ea1-4604-8413-27bd2892079f"
	)
	receivers = @(
		"550fae72-d251-43ec-868c-373732c2704f"
	)
}

New-MgBetaCommunicationCallAudioRoutingGroup -CallId $callId -BodyParameter $params

```
This example shows how to use the New-MgBetaCommunicationCallAudioRoutingGroup Cmdlet.


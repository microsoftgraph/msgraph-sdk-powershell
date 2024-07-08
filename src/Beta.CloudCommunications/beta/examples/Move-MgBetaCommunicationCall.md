### Example 1: Call transfer from a peer-to-peer call

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	transferTarget = @{
		endpointType = "default"
		identity = @{
			user = @{
				id = "550fae72-d251-43ec-868c-373732c2704f"
				tenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47"
				displayName = "Heidi Steen"
			}
		}
		languageId = "languageId-value"
		region = "region-value"
	}
}

Move-MgBetaCommunicationCall -CallId $callId -BodyParameter $params

```
This example will call transfer from a peer-to-peer call

### Example 2: Consultative transfer from a peer-to-peer call

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	transferTarget = @{
		"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
		endpointType = "default"
		identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			user = @{
				"@odata.type" = "#microsoft.graph.identity"
				id = "550fae72-d251-43ec-868c-373732c2704f"
				tenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47"
				displayName = "Heidi Steen"
			}
		}
		languageId = "en-us"
		region = "amer"
		replacesCallId = "e5d39592-99bd-4db8-bca8-30fb894ec51d"
	}
}

Move-MgBetaCommunicationCall -CallId $callId -BodyParameter $params

```
This example will consultative transfer from a peer-to-peer call

### Example 3: Call transfer from a peer-to-peer call to PSTN number

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	transferTarget = @{
		endpointType = "default"
		identity = @{
			phone = @{
				"@odata.type" = "#microsoft.graph.identity"
				id = "+12345678901"
			}
		}
		languageId = "languageId-value"
		region = "region-value"
	}
}

Move-MgBetaCommunicationCall -CallId $callId -BodyParameter $params

```
This example will call transfer from a peer-to-peer call to pstn number

### Example 4: Consultative transfer from a peer-to-peer call to PSTN number

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	transferTarget = @{
		"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
		endpointType = "default"
		identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			phone = @{
				"@odata.type" = "#microsoft.graph.identity"
				id = "+12345678901"
			}
		}
		languageId = "en-us"
		region = "amer"
		replacesCallId = "e5d39592-99bd-4db8-bca8-30fb894ec51d"
	}
}

Move-MgBetaCommunicationCall -CallId $callId -BodyParameter $params

```
This example will consultative transfer from a peer-to-peer call to pstn number

### Example 5: Call transfer from a group call

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	transferTarget = @{
		endpointType = "default"
		identity = @{
			user = @{
				id = "550fae72-d251-43ec-868c-373732c2704f"
				tenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47"
				displayName = "Heidi Steen"
			}
		}
	}
	transferee = @{
		identity = @{
			user = @{
				id = "751f6800-3180-414d-bd94-333364659951"
				tenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47"
			}
		}
		participantId = "909c6581-5130-43e9-88f3-fcb3582cde37"
	}
	languageId = "languageId-value"
	region = "region-value"
}

Move-MgBetaCommunicationCall -CallId $callId -BodyParameter $params

```
This example will call transfer from a group call


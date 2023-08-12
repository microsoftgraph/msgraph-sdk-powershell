### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	transferTarget = @{
		endpointType = "default"
		identity = @{
			user = @{
				id = "550fae72-d251-43ec-868c-373732c2704f"
				displayName = "Heidi Steen"
			}
		}
	}
}

Move-MgCommunicationCall -CallId $callId -BodyParameter $params

```
This example shows how to use the Move-MgCommunicationCall Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	transferTarget = @{
		"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
		endpointType = "default"
		identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			user = @{
				"@odata.type" = "#microsoft.graph.identity"
				id = "550fae72-d251-43ec-868c-373732c2704f"
				displayName = "Heidi Steen"
			}
		}
		replacesCallId = "e5d39592-99bd-4db8-bca8-30fb894ec51d"
	}
}

Move-MgCommunicationCall -CallId $callId -BodyParameter $params

```
This example shows how to use the Move-MgCommunicationCall Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.CloudCommunications

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
	clientContext = "9e90d1c1-f61e-43e7-9f75-d420159aae08"
}

Move-MgCommunicationCall -CallId $callId -BodyParameter $params

```
This example shows how to use the Move-MgCommunicationCall Cmdlet.

### Example 4: Code snippet

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	transferTarget = @{
		endpointType = "default"
		identity = @{
			user = @{
				id = "550fae72-d251-43ec-868c-373732c2704f"
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
}

Move-MgCommunicationCall -CallId $callId -BodyParameter $params

```
This example shows how to use the Move-MgCommunicationCall Cmdlet.


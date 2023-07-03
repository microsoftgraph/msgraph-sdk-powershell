### Example 1: Using the Move-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	TransferTarget = @{
		EndpointType = "default"
		Identity = @{
			User = @{
				Id = "550fae72-d251-43ec-868c-373732c2704f"
				DisplayName = "Heidi Steen"
			}
		}
	}
}
Move-MgCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Move-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Move-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	TransferTarget = @{
		"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
		EndpointType = "default"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			User = @{
				"@odata.type" = "#microsoft.graph.identity"
				Id = "550fae72-d251-43ec-868c-373732c2704f"
				DisplayName = "Heidi Steen"
			}
		}
		ReplacesCallId = "e5d39592-99bd-4db8-bca8-30fb894ec51d"
	}
}
Move-MgCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Move-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Move-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	TransferTarget = @{
		EndpointType = "default"
		Identity = @{
			Phone = @{
				"@odata.type" = "#microsoft.graph.identity"
				Id = "+12345678901"
			}
		}
		LanguageId = "languageId-value"
		Region = "region-value"
	}
	ClientContext = "9e90d1c1-f61e-43e7-9f75-d420159aae08"
}
Move-MgCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Move-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Move-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	TransferTarget = @{
		"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
		EndpointType = "default"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			Phone = @{
				"@odata.type" = "#microsoft.graph.identity"
				Id = "+12345678901"
			}
		}
		LanguageId = "en-us"
		Region = "amer"
		ReplacesCallId = "e5d39592-99bd-4db8-bca8-30fb894ec51d"
	}
	ClientContext = "9e90d1c1-f61e-43e7-9f75-d420159aae08"
}
Move-MgCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Move-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Move-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	TransferTarget = @{
		EndpointType = "default"
		Identity = @{
			User = @{
				Id = "550fae72-d251-43ec-868c-373732c2704f"
				DisplayName = "Heidi Steen"
			}
		}
	}
	Transferee = @{
		Identity = @{
			User = @{
				Id = "751f6800-3180-414d-bd94-333364659951"
				TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47"
			}
		}
		ParticipantId = "909c6581-5130-43e9-88f3-fcb3582cde37"
	}
}
Move-MgCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Move-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the New-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			Application = @{
				"@odata.type" = "#microsoft.graph.identity"
				DisplayName = "Calling Bot"
				Id = "2891555a-92ff-42e6-80fa-6e1300c6b5c6"
			}
		}
		Region = $null
		LanguageId = $null
	}
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					DisplayName = "John"
					Id = "112f7296-5fa4-42ca-bae8-6a692b15d4b8"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		Blob = "<Media Session Configuration>"
	}
}
New-MgCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					DisplayName = "John"
					Id = "112f7296-5fa4-42ca-bae8-6a692b15d4b8"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
	}
}
New-MgCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			ApplicationInstance = @{
				"@odata.type" = "#microsoft.graph.identity"
				DisplayName = "Calling Bot"
				Id = "3d913abb-aec0-4964-8fa6-3c6850c4f278"
			}
		}
		CountryCode = $null
		EndpointType = $null
		Region = $null
		LanguageId = $null
	}
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				Phone = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "+12345678901"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			ApplicationInstance = @{
				"@odata.type" = "#microsoft.graph.identity"
				DisplayName = "Calling Bot"
				Id = "3d913abb-aec0-4964-8fa6-3c6850c4f278"
			}
		}
		CountryCode = $null
		EndpointType = $null
		Region = $null
		LanguageId = $null
	}
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				Phone = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "+12345678901"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		Blob = "<Media Session Configuration>"
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

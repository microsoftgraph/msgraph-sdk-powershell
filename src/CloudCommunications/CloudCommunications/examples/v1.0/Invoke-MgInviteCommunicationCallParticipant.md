### Example 1
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "278405a3-f568-4b3e-b684-009193463064"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
### Example 2
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
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
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
### Example 3
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "7e1b4346-85a6-4bdd-abe3-d11c5d420efe"
					DisplayName = "string"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
### Example 4
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			ParticipantId = "7d501bf1-5ee4-4605-ba92-0ae4513c611c"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "682b6c37-0729-4fab-ace6-d730d5d9137e"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
### Example 5
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "7e1b4346-85a6-4bdd-abe3-d11c5d420efe"
					DisplayName = "string"
				}
			}
		}
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "1e126418-44a0-4a94-a6f8-0efe1ad71acb"
					DisplayName = "string"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
### Example 6
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "278405a3-f568-4b3e-b684-009193463064"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
### Example 7
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "278405a3-f568-4b3e-b684-009193463064"
					DisplayName = "string"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```

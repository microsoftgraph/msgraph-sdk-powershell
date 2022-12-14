### Example 1: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
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
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
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
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
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
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
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
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
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
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
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
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 7: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
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
					IdentityProvider = "AAD"
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
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

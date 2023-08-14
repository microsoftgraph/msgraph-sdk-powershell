### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			replacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "278405a3-f568-4b3e-b684-009193463064"
					identityProvider = "AAD"
				}
			}
		}
	)
	clientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}

Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			replacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "7e1b4346-85a6-4bdd-abe3-d11c5d420efe"
					identityProvider = "AAD"
				}
			}
		}
	)
	clientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}

Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				phone = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "+12345678901"
				}
			}
		}
	)
	clientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}

Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.

### Example 4: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			replacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			participantId = "7d501bf1-5ee4-4605-ba92-0ae4513c611c"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "682b6c37-0729-4fab-ace6-d730d5d9137e"
					identityProvider = "AAD"
				}
			}
		}
	)
	clientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}

Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.


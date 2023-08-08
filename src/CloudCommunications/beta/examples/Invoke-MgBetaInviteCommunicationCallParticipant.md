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


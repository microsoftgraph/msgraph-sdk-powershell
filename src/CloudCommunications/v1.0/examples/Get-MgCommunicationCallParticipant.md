### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.CloudCommunications

Remove-MgCommunicationCallParticipant -CallId $callId -ParticipantId $participantId
```
This example shows how to use the Get-MgCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.CloudCommunications

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

Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```
This example shows how to use the Get-MgCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.CloudCommunications

Remove-MgCommunicationCallParticipant -CallId $callId -ParticipantId $participantId
```
This example shows how to use the Get-MgCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


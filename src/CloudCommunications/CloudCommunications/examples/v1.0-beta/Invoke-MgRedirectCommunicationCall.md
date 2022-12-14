### Example 1: Using the Invoke-MgBetaRedirectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				Application = @{
					"@odata.type" = "#microsoft.graph.identity"
					DisplayName = "test bot 2"
					Id = "22bfd41f-550e-477d-8789-f6f7bd2a5e8b"
				}
			}
		}
	)
	CallbackUri = "https://bot.contoso.com/api/calls/24701998-1a73-4d42-8085-bf46ed0ae039"
}
Invoke-MgBetaRedirectCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaRedirectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Invoke-MgBetaRedirectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
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
	CallbackUri = "https://bot.contoso.com/api/calls/24701998-1a73-4d42-8085-bf46ed0ae039"
}
Invoke-MgBetaRedirectCommunicationCall -CallId $callId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaRedirectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	StartDateTime = [System.DateTime]::Parse("2020-02-06T01:49:21.3524945+00:00")
	EndDateTime = [System.DateTime]::Parse("2020-02-06T02:19:21.3524945+00:00")
	Subject = "Create a meeting with customId provided"
	ExternalId = "7eb8263f-d0e0-4149-bb1c-1f0476083c56"
	Participants = @{
		Attendees = @(
			@{
				Identity = @{
					User = @{
						Id = "1f35f2e6-9cab-44ad-8d5a-b74c14720000"
					}
				}
				Upn = "test1@contoso.com"
			}
		)
	}
}

# A UPN can also be used as -UserId.
Invoke-MgBetaCreateOrGetUserOnlineMeeting -UserId $userId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaCreateOrGetCommunicationOnlineMeeting Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


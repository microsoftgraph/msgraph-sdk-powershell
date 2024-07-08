### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	startDateTime = [System.DateTime]::Parse("2020-02-06T01:49:21.3524945+00:00")
	endDateTime = [System.DateTime]::Parse("2020-02-06T02:19:21.3524945+00:00")
	subject = "Create a meeting with customId provided"
	externalId = "7eb8263f-d0e0-4149-bb1c-1f0476083c56"
	participants = @{
		attendees = @(
			@{
				identity = @{
					user = @{
						id = "1f35f2e6-9cab-44ad-8d5a-b74c14720000"
					}
				}
				upn = "test1@contoso.com"
			}
		)
	}
}

# A UPN can also be used as -UserId.
Invoke-MgCreateOrGetUserOnlineMeeting -UserId $userId -BodyParameter $params

```
This example shows how to use the Invoke-MgCreateOrGetUserOnlineMeeting Cmdlet.


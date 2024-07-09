### Example 1: Create or get an online meeting with an external ID

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

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
				role = "presenter"
				upn = "test1@contoso.com"
			}
		)
	}
}

# A UPN can also be used as -UserId.
Invoke-MgBetaCreateOrGetUserOnlineMeeting -UserId $userId -BodyParameter $params

```
This example will create or get an online meeting with an external id

### Example 2: Create or get an online meeting in a Microsoft Teams channel with an external ID

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	chatInfo = @{
		threadId = "19:7ebda77322dd4505ac4dedb5b67df076@thread.tacv2"
	}
	startDateTime = [System.DateTime]::Parse("2020-02-06T01:49:21.3524945+00:00")
	endDateTime = [System.DateTime]::Parse("2020-02-06T02:19:21.3524945+00:00")
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
	subject = "Create a meeting with customId provided"
}

# A UPN can also be used as -UserId.
Invoke-MgBetaCreateOrGetUserOnlineMeeting -UserId $userId -BodyParameter $params

```
This example will create or get an online meeting in a microsoft teams channel with an external id


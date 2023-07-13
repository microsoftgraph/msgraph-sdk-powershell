### Example 1: Using the Find-MgUserMeetingTime Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Attendees = @(
		@{
			Type = "required"
			EmailAddress = @{
				Name = "Alex Wilbur"
				Address = "alexw@contoso.onmicrosoft.com"
			}
		}
	)
	LocationConstraint = @{
		IsRequired = $false
		SuggestLocation = $false
		Locations = @(
			@{
				ResolveAvailability = $false
				DisplayName = "Conf room Hood"
			}
		)
	}
	TimeConstraint = @{
		ActivityDomain = "work"
		TimeSlots = @(
			@{
				Start = @{
					DateTime = "2019-04-16T09:00:00"
					TimeZone = "Pacific Standard Time"
				}
				End = @{
					DateTime = "2019-04-18T17:00:00"
					TimeZone = "Pacific Standard Time"
				}
			}
		)
	}
	IsOrganizerOptional = "false"
	MeetingDuration = "PT1H"
	ReturnSuggestionReasons = "true"
	MinimumAttendeePercentage = "100"
}
# A UPN can also be used as -UserId.
Find-MgUserMeetingTime -UserId $userId -BodyParameter $params
```
This example shows how to use the Find-MgUserMeetingTime Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	attendees = @(
		@{
			type = "required"
			emailAddress = @{
				name = "Alex Wilbur"
				address = "alexw@contoso.com"
			}
		}
	)
	locationConstraint = @{
		isRequired = "false"
		suggestLocation = "false"
		locations = @(
			@{
				resolveAvailability = "false"
				displayName = "Conf room Hood"
			}
		)
	}
	timeConstraint = @{
		activityDomain = "work"
		timeSlots = @(
			@{
				start = @{
					dateTime = "2019-04-16T09:00:00"
					timeZone = "Pacific Standard Time"
				}
				end = @{
					dateTime = "2019-04-18T17:00:00"
					timeZone = "Pacific Standard Time"
				}
			}
		)
	}
	isOrganizerOptional = "false"
	meetingDuration = "PT1H"
	returnSuggestionReasons = "true"
	minimumAttendeePercentage = 100
}

# A UPN can also be used as -UserId.
Find-MgBetaUserMeetingTime -UserId $userId -BodyParameter $params

```
This example shows how to use the Find-MgBetaUserMeetingTime Cmdlet.


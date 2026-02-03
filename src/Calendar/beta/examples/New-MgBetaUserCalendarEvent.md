### Example 1: Create an event in a specific calendar

```powershell
Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	subject = "Let's go for lunch"
	body = @{
		contentType = "HTML"
		content = "Does next month work for you?"
	}
	start = @{
		dateTime = "2019-03-10T12:00:00"
		timeZone = "Pacific Standard Time"
	}
	end = @{
		dateTime = "2019-03-10T14:00:00"
		timeZone = "Pacific Standard Time"
	}
	location = @{
		displayName = "Harry's Bar"
	}
	attendees = @(
		@{
			emailAddress = @{
				address = "adelev@contoso.onmicrosoft.com"
				name = "Adele Vance"
			}
			type = "required"
		}
	)
	transactionId = "7E163156-7762-4BEB-A1C6-729EA81755A7"
}

# A UPN can also be used as -UserId.
New-MgBetaUserCalendarEvent -UserId $userId -CalendarId $calendarId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserCalendarEvent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Create and enable an event as an online meeting

```powershell
Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	subject = "Let's go for lunch"
	body = @{
		contentType = "HTML"
		content = "Does next month work for you?"
	}
	start = @{
		dateTime = "2019-03-10T12:00:00"
		timeZone = "Pacific Standard Time"
	}
	end = @{
		dateTime = "2019-03-10T14:00:00"
		timeZone = "Pacific Standard Time"
	}
	location = @{
		displayName = "Harry's Bar"
	}
	attendees = @(
		@{
			emailAddress = @{
				address = "adelev@contoso.onmicrosoft.com"
				name = "Adele Vance"
			}
			type = "required"
		}
	)
	isOnlineMeeting = $true
	onlineMeetingProvider = "teamsForBusiness"
}

# A UPN can also be used as -UserId.
New-MgBetaUserCalendarEvent -UserId $userId -CalendarId $calendarId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserCalendarEvent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


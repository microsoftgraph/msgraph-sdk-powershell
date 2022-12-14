### Example 1: Using the New-MgBetaUserCalendarEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
$params = @{
	Subject = "Let's go for lunch"
	Body = @{
		ContentType = "HTML"
		Content = "Does next month work for you?"
	}
	Start = @{
		DateTime = "2019-03-10T12:00:00"
		TimeZone = "Pacific Standard Time"
	}
	End = @{
		DateTime = "2019-03-10T14:00:00"
		TimeZone = "Pacific Standard Time"
	}
	Location = @{
		DisplayName = "Harry's Bar"
	}
	Attendees = @(
		@{
			EmailAddress = @{
				Address = "adelev@contoso.onmicrosoft.com"
				Name = "Adele Vance"
			}
			Type = "required"
		}
	)
	TransactionId = "7E163156-7762-4BEB-A1C6-729EA81755A7"
}
# A UPN can also be used as -UserId.
New-MgBetaUserCalendarEvent -UserId $userId -CalendarId $calendarId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserCalendarEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaUserCalendarEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
$params = @{
	Subject = "Let's go for lunch"
	Body = @{
		ContentType = "HTML"
		Content = "Does next month work for you?"
	}
	Start = @{
		DateTime = "2019-03-10T12:00:00"
		TimeZone = "Pacific Standard Time"
	}
	End = @{
		DateTime = "2019-03-10T14:00:00"
		TimeZone = "Pacific Standard Time"
	}
	Location = @{
		DisplayName = "Harry's Bar"
	}
	Attendees = @(
		@{
			EmailAddress = @{
				Address = "adelev@contoso.onmicrosoft.com"
				Name = "Adele Vance"
			}
			Type = "required"
		}
	)
	IsOnlineMeeting = $true
	OnlineMeetingProvider = "teamsForBusiness"
}
# A UPN can also be used as -UserId.
New-MgBetaUserCalendarEvent -UserId $userId -CalendarId $calendarId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserCalendarEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

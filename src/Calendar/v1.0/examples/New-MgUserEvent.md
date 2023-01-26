### Example 1: Using the New-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Subject = "Plan summer company picnic"
	Body = @{
		ContentType = "HTML"
		Content = "Let's kick-start this event planning!"
	}
	Start = @{
		DateTime = "2017-08-30T11:00:00"
		TimeZone = "Pacific Standard Time"
	}
	End = @{
		DateTime = "2017-08-30T12:00:00"
		TimeZone = "Pacific Standard Time"
	}
	Attendees = @(
		@{
			EmailAddress = @{
				Address = "DanaS@contoso.onmicrosoft.com"
				Name = "Dana Swope"
			}
			Type = "Required"
		}
		@{
			EmailAddress = @{
				Address = "AlexW@contoso.onmicrosoft.com"
				Name = "Alex Wilber"
			}
			Type = "Required"
		}
	)
	Location = @{
		DisplayName = "Conf Room 3; Fourth Coffee; Home Office"
		LocationType = "Default"
	}
	Locations = @(
		@{
			DisplayName = "Conf Room 3"
		}
		@{
			DisplayName = "Fourth Coffee"
			Address = @{
				Street = "4567 Main St"
				City = "Redmond"
				State = "WA"
				CountryOrRegion = "US"
				PostalCode = "32008"
			}
			Coordinates = @{
				Latitude = 47.672
				Longitude = -102.103
			}
		}
		@{
			DisplayName = "Home Office"
		}
	)
	AllowNewTimeProposals = $true
}
# A UPN can also be used as -UserId.
New-MgUserEvent -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Subject = "Let's go for lunch"
	Body = @{
		ContentType = "HTML"
		Content = "Does noon work for you?"
	}
	Start = @{
		DateTime = "2017-04-15T12:00:00"
		TimeZone = "Pacific Standard Time"
	}
	End = @{
		DateTime = "2017-04-15T14:00:00"
		TimeZone = "Pacific Standard Time"
	}
	Location = @{
		DisplayName = "Harry's Bar"
	}
	Attendees = @(
		@{
			EmailAddress = @{
				Address = "samanthab@contoso.onmicrosoft.com"
				Name = "Samantha Booth"
			}
			Type = "required"
		}
	)
	AllowNewTimeProposals = $true
	TransactionId = "7E163156-7762-4BEB-A1C6-729EA81755A7"
}
# A UPN can also be used as -UserId.
New-MgUserEvent -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Subject = "Let's go for lunch"
	Body = @{
		ContentType = "HTML"
		Content = "Does noon work for you?"
	}
	Start = @{
		DateTime = "2017-04-15T12:00:00"
		TimeZone = "Pacific Standard Time"
	}
	End = @{
		DateTime = "2017-04-15T14:00:00"
		TimeZone = "Pacific Standard Time"
	}
	Location = @{
		DisplayName = "Harry's Bar"
	}
	Attendees = @(
		@{
			EmailAddress = @{
				Address = "samanthab@contoso.onmicrosoft.com"
				Name = "Samantha Booth"
			}
			Type = "required"
		}
	)
	AllowNewTimeProposals = $true
	IsOnlineMeeting = $true
	OnlineMeetingProvider = "teamsForBusiness"
}
# A UPN can also be used as -UserId.
New-MgUserEvent -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Subject = "Let's go for lunch"
	Body = @{
		ContentType = "HTML"
		Content = "Does noon time work for you?"
	}
	Start = @{
		DateTime = "2017-09-04T12:00:00"
		TimeZone = "Pacific Standard Time"
	}
	End = @{
		DateTime = "2017-09-04T14:00:00"
		TimeZone = "Pacific Standard Time"
	}
	Recurrence = @{
		Pattern = @{
			Type = "weekly"
			Interval = 1
			DaysOfWeek = @(
				"Monday"
			)
		}
		Range = @{
			Type = "endDate"
			StartDate = "2017-09-04"
			EndDate = "2017-12-31"
		}
	}
	Location = @{
		DisplayName = "Harry's Bar"
	}
	Attendees = @(
		@{
			EmailAddress = @{
				Address = "AdeleV@contoso.onmicrosoft.com"
				Name = "Adele Vance"
			}
			Type = "required"
		}
	)
	AllowNewTimeProposals = $true
}
# A UPN can also be used as -UserId.
New-MgUserEvent -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

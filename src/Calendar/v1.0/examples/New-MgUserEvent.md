### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Calendar

$params = @{
	subject = "Let's go for lunch"
	body = @{
		contentType = "HTML"
		content = "Does noon work for you?"
	}
	start = @{
		dateTime = "2017-04-15T12:00:00"
		timeZone = "Pacific Standard Time"
	}
	end = @{
		dateTime = "2017-04-15T14:00:00"
		timeZone = "Pacific Standard Time"
	}
	location = @{
		displayName = "Harry's Bar"
	}
	attendees = @(
		@{
			emailAddress = @{
				address = "samanthab@contoso.onmicrosoft.com"
				name = "Samantha Booth"
			}
			type = "required"
		}
	)
	allowNewTimeProposals = $true
	transactionId = "7E163156-7762-4BEB-A1C6-729EA81755A7"
}

# A UPN can also be used as -UserId.
New-MgUserEvent -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserEvent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershell
Import-Module Microsoft.Graph.Calendar

$params = @{
	subject = "Let's go for lunch"
	body = @{
		contentType = "HTML"
		content = "Does noon time work for you?"
	}
	start = @{
		dateTime = "2017-09-04T12:00:00"
		timeZone = "Pacific Standard Time"
	}
	end = @{
		dateTime = "2017-09-04T14:00:00"
		timeZone = "Pacific Standard Time"
	}
	recurrence = @{
		pattern = @{
			type = "weekly"
			interval = 1
			daysOfWeek = @(
				"Monday"
			)
		}
		range = @{
			type = "endDate"
			startDate = "2017-09-04"
			endDate = "2017-12-31"
		}
	}
	location = @{
		displayName = "Harry's Bar"
	}
	attendees = @(
		@{
			emailAddress = @{
				address = "AdeleV@contoso.onmicrosoft.com"
				name = "Adele Vance"
			}
			type = "required"
		}
	)
	allowNewTimeProposals = $true
}

# A UPN can also be used as -UserId.
New-MgUserEvent -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserEvent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershell
Import-Module Microsoft.Graph.Calendar

$params = @{
	subject = "Let's go for lunch"
	body = @{
		contentType = "HTML"
		content = "Does noon work for you?"
	}
	start = @{
		dateTime = "2017-04-15T12:00:00"
		timeZone = "Pacific Standard Time"
	}
	end = @{
		dateTime = "2017-04-15T14:00:00"
		timeZone = "Pacific Standard Time"
	}
	location = @{
		displayName = "Harry's Bar"
	}
	attendees = @(
		@{
			emailAddress = @{
				address = "samanthab@contoso.onmicrosoft.com"
				name = "Samantha Booth"
			}
			type = "required"
		}
	)
	allowNewTimeProposals = $true
	isOnlineMeeting = $true
	onlineMeetingProvider = "teamsForBusiness"
}

# A UPN can also be used as -UserId.
New-MgUserEvent -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserEvent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


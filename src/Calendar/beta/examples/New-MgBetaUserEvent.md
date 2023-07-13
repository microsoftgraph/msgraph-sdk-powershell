### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Calendar

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
New-MgBetaUserEvent -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


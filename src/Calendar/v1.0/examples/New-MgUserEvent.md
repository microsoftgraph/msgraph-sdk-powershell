### Example 1: Create a new event and a single-value extended property

```powershell
Import-Module Microsoft.Graph.Calendar

$params = @{
	subject = "Celebrate Thanksgiving"
	body = @{
		contentType = "HTML"
		content = "Let's get together!"
	}
	start = @{
		dateTime = "2015-11-26T18:00:00"
		timeZone = "Pacific Standard Time"
	}
	end = @{
		dateTime = "2015-11-26T23:00:00"
		timeZone = "Pacific Standard Time"
	}
	attendees = @(
		@{
			emailAddress = @{
				address = "Terrie@contoso.com"
				name = "Terrie Barrera"
			}
			type = "Required"
		}
	)
	singleValueExtendedProperties = @(
		@{
			id = "String {66f5a359-4659-4830-9070-00040ec6ac6e} Name Fun"
			value = "Food"
		}
	)
}

# A UPN can also be used as -UserId.
New-MgUserEvent -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserEvent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


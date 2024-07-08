### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Calendar

$params = @{
	subject = "Let's go for lunch"
	body = @{
		contentType = "HTML"
		content = "Does late morning work for you?"
	}
	start = @{
		dateTime = "2019-06-16T12:00:00"
		timeZone = "Pacific Standard Time"
	}
	end = @{
		dateTime = "2019-06-16T14:00:00"
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
}

New-MgGroupEvent -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgGroupEvent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


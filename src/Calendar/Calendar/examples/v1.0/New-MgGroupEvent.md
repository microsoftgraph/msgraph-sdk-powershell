### Example 1: Using the New-MgGroupEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Subject = "Let's go for lunch"
	Body = @{
		ContentType = "HTML"
		Content = "Does late morning work for you?"
	}
	Start = @{
		DateTime = "2019-06-16T12:00:00"
		TimeZone = "Pacific Standard Time"
	}
	End = @{
		DateTime = "2019-06-16T14:00:00"
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
}
New-MgGroupEvent -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgGroupEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

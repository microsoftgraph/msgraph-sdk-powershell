### Example 1: Using the New-MgBetaGroupEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
$params = @{
	Subject = "Let's go for lunch"
	Body = @{
		ContentType = "HTML"
		Content = "Does late morning work for you?"
	}
	Start = @{
		DateTime = "2019-06-15T12:00:00"
		TimeZone = "Pacific Standard Time"
	}
	End = @{
		DateTime = "2019-06-15T14:00:00"
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
New-MgBetaGroupEvent -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgBetaGroupEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	userId = "a3601044-a1b5-438e-b742-f78d01d68a67"
	clockInEvent = @{
		dateTime = [System.DateTime]::Parse("2019-03-18T00:00:00.000Z")
		isAtApprovedLocation = $true
		notes = @{
			content = "Started late due to traffic in CA 237"
			contentType = "text"
		}
	}
	notes = @{
		content = "8 To 5 Inventory management"
		contentType = "text"
	}
	breaks = @(
		@{
			breakId = "string"
			notes = @{
				content = "Lunch break"
				contentType = "text"
			}
			start = @{
				dateTime = [System.DateTime]::Parse("2019-03-18T02:00:00.000Z")
				isAtApprovedLocation = $true
				notes = @{
					content = "Reduced break to make up for lost time"
					contentType = "text"
				}
			}
		}
	)
}

New-MgBetaTeamScheduleTimeCard -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgBetaTeamScheduleTimeCard Cmdlet.


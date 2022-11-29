### Example 1: Using the New-MgTeamTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "Finance"
	Members = @(
		@{
			UserId = "92f6952f-61ca-4a94-8910-508a240bc167"
		}
		@{
			UserId = "085d800c-b86b-4bfc-a857-9371ad1caf29"
		}
	)
}
New-MgTeamTag -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgTeamTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

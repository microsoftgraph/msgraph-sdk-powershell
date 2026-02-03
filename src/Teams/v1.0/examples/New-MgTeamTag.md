### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	displayName = "Finance"
	members = @(
		@{
			userId = "92f6952f-61ca-4a94-8910-508a240bc167"
		}
		@{
			userId = "085d800c-b86b-4bfc-a857-9371ad1caf29"
		}
	)
}

New-MgTeamTag -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgTeamTag Cmdlet.


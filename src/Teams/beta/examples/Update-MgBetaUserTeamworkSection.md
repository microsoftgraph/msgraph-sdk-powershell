### Example 1: Update the display name of a section

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "Important Conversations"
}

Update-MgBetaUserTeamworkSection -UserId $userId -TeamworkSectionId $teamworkSectionId -BodyParameter $params

```
This example will update the display name of a section

### Example 2: Update the sort order of a section

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	sortType = "unreadThenMostRecent"
}

Update-MgBetaUserTeamworkSection -UserId $userId -TeamworkSectionId $teamworkSectionId -BodyParameter $params

```
This example will update the sort order of a section


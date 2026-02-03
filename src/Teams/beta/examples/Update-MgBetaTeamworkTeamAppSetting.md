### Example 1: Enable installation of apps that require resource-specific consent in chats/meetings.

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.teamsAppSettings"
	isChatResourceSpecificConsentEnabled = "true"
}

Update-MgBetaTeamworkTeamAppSetting -BodyParameter $params

```
This example will enable installation of apps that require resource-specific consent in chats/meetings.

### Example 2: Allow Teams users to request admins for access to certain Teams Apps.

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.teamsAppSettings"
	allowUserRequestsForAppAccess = "true"
}

Update-MgBetaTeamworkTeamAppSetting -BodyParameter $params

```
This example will allow teams users to request admins for access to certain teams apps.


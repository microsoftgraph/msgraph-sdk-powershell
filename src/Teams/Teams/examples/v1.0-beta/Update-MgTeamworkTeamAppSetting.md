### Example 1: Enable installation of apps that require resource-specific consent in chats/meetings

```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.teamsAppSettings"
	IsChatResourceSpecificConsentEnabled = "true"
}
Update-MgTeamworkTeamAppSetting -BodyParameter $params
```

This example shows how to use the Update-MgTeamworkTeamAppSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


### Example 2: Allow Teams users to request admins for access to certain Teams Apps

```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.teamsAppSettings"
	AllowUserRequestsForAppAccess = "true"
}

Update-MgTeamworkTeamAppSetting -BodyParameter $params
```

This example shows how to use the Update-MgTeamworkTeamAppSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
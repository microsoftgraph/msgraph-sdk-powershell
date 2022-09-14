### Example 1: Using the Copy-MgTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "Library Assist"
	Description = "Self help community for library"
	MailNickname = "libassist"
	PartsToClone = "apps,tabs,settings,channels,members"
	Visibility = "public"
}
Copy-MgTeam -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Copy-MgTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

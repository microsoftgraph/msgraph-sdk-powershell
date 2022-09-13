###Example 1
```
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

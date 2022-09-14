### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('8b081ef6-4792-4def-b2c9-c363a1bf41d5')"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Teams
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('jacob@contoso.com')"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
### Example 4
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/beta/users('jacob@contoso.com')"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
### Example 5
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users/8b081ef6-4792-4def-b2c9-c363a1bf41d5"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
### Example 6
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users/24b3819b-4e1d-4f3e-86bd-e42b54d0b2b4"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
### Example 7
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users/bc3598dd-cce4-4742-ae15-173429951408"
	TenantId = "a18103d1-a6ef-4f66-ac64-e4ef42ea8681"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```

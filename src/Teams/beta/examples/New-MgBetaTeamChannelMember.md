### Example 1: Using the New-MgBetaTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
	"User@odata.bind" = "https://graph.microsoft.com/beta/users('8b081ef6-4792-4def-b2c9-c363a1bf41d5')"
}
New-MgBetaTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('8b081ef6-4792-4def-b2c9-c363a1bf41d5')"
}
New-MgBetaTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
	"User@odata.bind" = "https://graph.microsoft.com/beta/users('jacob@contoso.com')"
}
New-MgBetaTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgBetaTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/beta/users('jacob@contoso.com')"
}
New-MgBetaTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the New-MgBetaTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/beta/users/24b3819b-4e1d-4f3e-86bd-e42b54d0b2b4"
}
New-MgBetaTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the New-MgBetaTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/beta/users/bc3598dd-cce4-4742-ae15-173429951408"
	TenantId = "a18103d1-a6ef-4f66-ac64-e4ef42ea8681"
}
New-MgBetaTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the New-MgChatMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users/jacob@contoso.com"
	VisibleHistoryStartDateTime = [System.DateTime]::Parse("2019-04-18T23:51:43.255Z")
	Roles = @(
		"owner"
	)
}
New-MgChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgChatMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users/8b081ef6-4792-4def-b2c9-c363a1bf41d5"
	VisibleHistoryStartDateTime = [System.DateTime]::Parse("0001-01-01T00:00:00Z")
	Roles = @(
		"owner"
	)
}
New-MgChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgChatMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users/8b081ef6-4792-4def-b2c9-c363a1bf41d5"
	Roles = @(
		"owner"
	)
}
New-MgChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgChatMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users/8b081ef6-4792-4def-b2c9-c363a1bf41d5"
	VisibleHistoryStartDateTime = [System.DateTime]::Parse("2019-04-18T23:51:43.255Z")
	Roles = @(
		"owner"
	)
}
New-MgChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Add a single member to a chat and specify the timespan for the conversation history

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/8b081ef6-4792-4def-b2c9-c363a1bf41d5"
	visibleHistoryStartDateTime = [System.DateTime]::Parse("2019-04-18T23:51:43.255Z")
	roles = @(
		"owner"
	)
}

New-MgChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Add a single member to a Microsoft Teams chat, sharing no chat history

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/8b081ef6-4792-4def-b2c9-c363a1bf41d5"
	roles = @(
		"owner"
	)
}

New-MgChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Add a single member to a Microsoft Teams chat, sharing the whole history of the chat

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/8b081ef6-4792-4def-b2c9-c363a1bf41d5"
	visibleHistoryStartDateTime = [System.DateTime]::Parse("0001-01-01T00:00:00Z")
	roles = @(
		"owner"
	)
}

New-MgChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Add a single member to a chat using user principal name

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/jacob@contoso.com"
	visibleHistoryStartDateTime = [System.DateTime]::Parse("2019-04-18T23:51:43.255Z")
	roles = @(
		"owner"
	)
}

New-MgChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Add an in-tenant guest user to a chat, sharing no chat history

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/8ba98gf6-7fc2-4eb2-c7f2-aef9f21fd98g"
	roles = @(
		"guest"
	)
}

New-MgChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 6: Add a out-of-tenant external user to a chat, sharing no chat history

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/82af01c5-f7cc-4a2e-a728-3a5df21afd9d"
	roles = @(
		"owner"
	)
	tenantId = "4dc1fe35-8ac6-4f0d-904a-7ebcd364bea1"
}

New-MgChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


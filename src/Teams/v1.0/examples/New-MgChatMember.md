### Example 1: Code snippet

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

### Example 2: Code snippet

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

### Example 3: Code snippet

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

### Example 4: Code snippet

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

### Example 5: Code snippet

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


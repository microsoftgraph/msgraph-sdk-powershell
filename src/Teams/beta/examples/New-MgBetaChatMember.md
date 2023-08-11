### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/8b081ef6-4792-4def-b2c9-c363a1bf41d5"
	visibleHistoryStartDateTime = [System.DateTime]::Parse("2019-04-18T23:51:43.255Z")
	roles = @(
		"owner"
	)
}

New-MgBetaChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/8b081ef6-4792-4def-b2c9-c363a1bf41d5"
	visibleHistoryStartDateTime = [System.DateTime]::Parse("0001-01-01T00:00:00Z")
	roles = @(
		"owner"
	)
}

New-MgBetaChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/jacob@contoso.com"
	visibleHistoryStartDateTime = [System.DateTime]::Parse("2019-04-18T23:51:43.255Z")
	roles = @(
		"owner"
	)
}

New-MgBetaChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/8ba98gf6-7fc2-4eb2-c7f2-aef9f21fd98g"
	roles = @(
		"guest"
	)
}

New-MgBetaChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	"user@odata.bind" = "https://graph.microsoft.com/v1.0/users/82af01c5-f7cc-4a2e-a728-3a5df21afd9d"
	roles = @(
		"owner"
	)
	tenantId = "4dc1fe35-8ac6-4f0d-904a-7ebcd364bea1"
}

New-MgBetaChatMember -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


### Example 1: Send a new reply to a chatMessage

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	body = @{
		contentType = "html"
		content = "Hello World"
	}
}

New-MgBetaTeamChannelMessageReply -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params

```
This example will send a new reply to a chatmessage

### Example 2: Import messages

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	createdDateTime = [System.DateTime]::Parse("2019-02-04T19:58:15.511Z")
	from = @{
		user = @{
			id = "8c0a1a67-50ce-4114-bb6c-da9c5dbcf6ca"
			displayName = "John Doe"
		}
	}
	body = @{
		contentType = "html"
		content = "Hello World"
	}
}

New-MgBetaTeamChannelMessageReply -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params

```
This example will import messages


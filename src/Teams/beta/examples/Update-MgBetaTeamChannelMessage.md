### Example 1: Using the Update-MgBetaTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	PolicyViolation = @{
		PolicyTip = @{
			GeneralText = "This item has been blocked by the administrator."
			ComplianceUrl = "https://contoso.com/dlp-policy-page"
			MatchedConditionDescriptions = @(
				"Credit Card Number"
			)
		}
		VerdictDetails = "AllowOverrideWithoutJustification,AllowFalsePositiveOverride"
		DlpAction = "BlockAccess"
	}
}
Update-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	MessageType = "message"
	Subject = $null
	Summary = $null
	Importance = "normal"
	Locale = "en-us"
	From = @{
		Application = $null
		Device = $null
		User = @{
			Id = "3b102402-813e-4e17-a6b2-f841aef1fdfc"
			DisplayName = "Sumit Gupta"
			UserIdentityType = "aadUser"
		}
		Conversation = $null
	}
	Body = @{
		ContentType = "text"
		Content = "Edit text only"
	}
	Attachments = @(
	)
	Mentions = @(
	)
	Reactions = @(
	)
}
Update-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Update-MgBetaTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	MessageType = "message"
	DeletedDateTime = $null
	Subject = $null
	Summary = $null
	Importance = "normal"
	Locale = "en-us"
	From = @{
		Application = $null
		Device = $null
		Conversation = $null
		User = @{
			Id = "6b3f3c54-d09c-4fdd-b146-9b514a8a4f40"
			DisplayName = "Sumit Gupta"
			UserIdentityType = "aadUser"
		}
	}
	Body = @{
		ContentType = "html"
		Content = "<div><div>
<div>
<div>
<div>
<div><at id="0">Raghav</at><at id="1">TestGlobalBot</at> YEAH"
	}
	Attachments = @(
	)
	Mentions = @(
		@{
			Id = 0
			MentionText = "Raghav"
			Mentioned = @{
				Application = $null
				Device = $null
				Conversation = $null
				User = @{
					Id = "f1b66449-b46d-49b0-9c3c-53c10234c818e"
					DisplayName = "Raghav Mankad"
					UserIdentityType = "aadUser"
				}
			}
		}
		@{
			Id = 1
			MentionText = "TestGlobalBot"
			Mentioned = @{
				Application = @{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					DisplayName = "TestGlobalBot"
					ApplicationIdentityType = "bot"
				}
				Device = $null
				Conversation = $null
				User = $null
			}
		}
	)
	Reactions = @(
	)
}
Update-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Update-MgBetaTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	MessageType = "message"
	Subject = $null
	Summary = $null
	Importance = "normal"
	Locale = "en-us"
	From = @{
		Application = $null
		Device = $null
		User = @{
			Id = "3b102402-813e-4e17-a6b2-f841aef1fdfc"
			DisplayName = "Sumit Gupta"
			UserIdentityType = "aadUser"
		}
		Conversation = $null
	}
	Body = @{
		ContentType = "html"
		Content = "<p><em>text</em></p><attachment id="e8f78756199240b88448ae0fc6db112d"></attachment><attachment id="638464e32834471ea202007da60a5ae6"></attachment>"
	}
	Attachments = @(
		@{
			Id = "e8f78756199240b88448ae0fc6db112d"
			ContentType = "application/vnd.microsoft.card.hero"
			ContentUrl = $null
			Content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here’s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "openUrl",
      "image": "https://urlp.asm.skype.com/v1/url/content?url=https%3a%2f%2fcdn2.iconfinder.com%2fdata%2ficons%2fsocial-icons-33%2f128%2fTrello-128.png",
      "title": "😃😃 click me 😃😃",
      "value": "http://microsoft.com"
    },
    {
      "type": "imback",
      "title": "&i am back& <>= \"",
      "value": "&i am back& <>= \""
    },
    {
      "type": "openUrl",
      "title": "Open URL",
      "value": "http://google.com"
    }
  ]
}"
			Name = $null
			ThumbnailUrl = $null
		}
		@{
			Id = "638464e32834471ea202007da60a5ae6"
			ContentType = "application/vnd.microsoft.card.hero"
			ContentUrl = $null
			Content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here’s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "messageBack",
      "title": "&message back& <>= \"",
      "text": "text = &message back& <>= \"",
      "displayText": "displayText = &message back& <>= \"",
      "value": {
        "text": "some text 2"
      }
    }
  ]
}"
			Name = $null
			ThumbnailUrl = $null
		}
	)
	Mentions = @(
	)
	Reactions = @(
	)
}
Update-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Update-MgBetaTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	MessageType = "message"
	Subject = $null
	Summary = $null
	Importance = "normal"
	Locale = "en-us"
	From = @{
		Application = $null
		Device = $null
		User = @{
			Id = "3b102402-813e-4e17-a6b2-f841aef1fdfc"
			DisplayName = "Sumit Gupta"
			UserIdentityType = "aadUser"
		}
		Conversation = $null
	}
	Body = @{
		ContentType = "html"
		Content = "<p><em>text</em></p><attachment id="e8f78756199240b88448ae0fc6db112d"></attachment><attachment id="638464e32834471ea202007da60a5ae6"></attachment>"
	}
	Attachments = @(
		@{
			Id = "e8f78756199240b88448ae0fc6db112d"
			ContentType = "application/vnd.microsoft.card.hero"
			ContentUrl = $null
			Content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here’s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "openUrl",
      "image": "https://urlp.asm.skype.com/v1/url/content?url=https%3a%2f%2fcdn2.iconfinder.com%2fdata%2ficons%2fsocial-icons-33%2f128%2fTrello-128.png",
      "title": "😃😃 click me 😃😃",
      "value": "http://microsoft.com"
    },
    {
      "type": "imback",
      "title": "&i am back& <>= \"",
      "value": "&i am back& <>= \""
    },
    {
      "type": "openUrl",
      "title": "Open URL",
      "value": "http://google.com"
    }
  ]
}"
			Name = $null
			ThumbnailUrl = $null
		}
		@{
			Id = "638464e32834471ea202007da60a5ae6"
			ContentType = "application/vnd.microsoft.card.hero"
			ContentUrl = $null
			Content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here’s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "messageBack",
      "title": "&message back& <>= \"",
      "text": "text = &message back& <>= \"",
      "displayText": "displayText = &message back& <>= \"",
      "value": {
        "text": "some text 2"
      }
    }
  ]
}"
			Name = $null
			ThumbnailUrl = $null
		}
	)
	Mentions = @(
	)
	Reactions = @(
		@{
			ReactionType = "angry"
			CreatedDateTime = [System.DateTime]::Parse("2018-10-21T08:10:30.489Z")
			User = @{
				Application = $null
				Device = $null
				User = @{
					Id = "f1b66449-b46d-49b0-9c3c-53c10a5c818e"
					DisplayName = $null
					UserIdentityType = "aadUser"
				}
			}
		}
		@{
			ReactionType = "laugh"
			CreatedDateTime = [System.DateTime]::Parse("2018-10-21T08:10:32.489Z")
			User = @{
				Application = $null
				Device = $null
				User = @{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					DisplayName = $null
					UserIdentityType = "aadUser"
				}
			}
		}
		@{
			ReactionType = "like"
			CreatedDateTime = [System.DateTime]::Parse("2018-10-21T02:17:14.67Z")
			User = @{
				Application = $null
				Device = $null
				User = @{
					Id = "f1b66449-b46d-49b0-9c3c-53c10a5c818e"
					DisplayName = $null
					UserIdentityType = "aadUser"
				}
			}
		}
		@{
			ReactionType = "like"
			CreatedDateTime = [System.DateTime]::Parse("2018-10-21T02:34:40.3Z")
			User = @{
				Application = $null
				Device = $null
				User = @{
					Id = "4c9041b7-449a-40f7-8855-56da239b9fd1"
					DisplayName = $null
					UserIdentityType = "aadUser"
				}
			}
		}
		@{
			ReactionType = "like"
			CreatedDateTime = [System.DateTime]::Parse("2018-10-21T08:10:25.489Z")
			User = @{
				Application = $null
				Device = $null
				User = @{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					DisplayName = $null
					UserIdentityType = "aadUser"
				}
			}
		}
		@{
			ReactionType = "heart"
			CreatedDateTime = [System.DateTime]::Parse("2018-10-21T08:10:31.489Z")
			User = @{
				Application = $null
				Device = $null
				User = @{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					DisplayName = $null
					UserIdentityType = "aadUser"
				}
			}
		}
		@{
			ReactionType = "sad"
			CreatedDateTime = [System.DateTime]::Parse("2018-10-21T08:10:33.489Z")
			User = @{
				Application = $null
				Device = $null
				User = @{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					DisplayName = $null
					UserIdentityType = "aadUser"
				}
			}
		}
		@{
			ReactionType = "surprised"
			CreatedDateTime = [System.DateTime]::Parse("2018-10-21T08:10:34.489Z")
			User = @{
				Application = $null
				Device = $null
				User = @{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					DisplayName = $null
					UserIdentityType = "aadUser"
				}
			}
		}
	)
}
Update-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Update policyViolation property using application permissions

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	policyViolation = @{
		policyTip = @{
			generalText = "This item has been blocked by the administrator."
			complianceUrl = "https://contoso.com/dlp-policy-page"
			matchedConditionDescriptions = @(
				"Credit Card Number"
			)
		}
		verdictDetails = "AllowOverrideWithoutJustification,AllowFalsePositiveOverride"
		dlpAction = "BlockAccess"
	}
}

Update-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Update any property of a message using delegated permissions

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	messageType = "message"
	subject = $null
	summary = $null
	importance = "normal"
	locale = "en-us"
	from = @{
		application = $null
		device = $null
		user = @{
			id = "3b102402-813e-4e17-a6b2-f841aef1fdfc"
			displayName = "Lam Cong"
			userIdentityType = "aadUser"
		}
		conversation = $null
	}
	body = @{
		contentType = "text"
		content = "Edit text only"
	}
	attachments = @(
	)
	mentions = @(
	)
	reactions = @(
	)
}

Update-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Update the mentions of a message using delegated permissions

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	messageType = "message"
	deletedDateTime = $null
	subject = $null
	summary = $null
	importance = "normal"
	locale = "en-us"
	from = @{
		application = $null
		device = $null
		conversation = $null
		user = @{
			id = "6b3f3c54-d09c-4fdd-b146-9b514a8a4f40"
			displayName = "Lam Cong"
			userIdentityType = "aadUser"
		}
	}
	body = @{
		contentType = "html"
		content = "&lt;div&gt;&lt;div&gt;
&lt;div&gt;
&lt;div&gt;
&lt;div&gt;
&lt;div&gt;&lt;at id="0"&gt;Raghav&lt;/at&gt;&lt;at id="1"&gt;TestGlobalBot&lt;/at&gt; YEAH"
	}
	attachments = @(
	)
	mentions = @(
		@{
			id = 0
			mentionText = "Raghav"
			mentioned = @{
				application = $null
				device = $null
				conversation = $null
				user = @{
					id = "f1b66449-b46d-49b0-9c3c-53c10234c818e"
					displayName = "Lam Cong"
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			id = 1
			mentionText = "TestGlobalBot"
			mentioned = @{
				application = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = "TestGlobalBot"
					applicationIdentityType = "bot"
				}
				device = $null
				conversation = $null
				user = $null
			}
		}
	)
	reactions = @(
	)
}

Update-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Update the content with attachments of a message using delegated permissions

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	messageType = "message"
	subject = $null
	summary = $null
	importance = "normal"
	locale = "en-us"
	from = @{
		application = $null
		device = $null
		user = @{
			id = "3b102402-813e-4e17-a6b2-f841aef1fdfc"
			displayName = "Lam Cong"
			userIdentityType = "aadUser"
		}
		conversation = $null
	}
	body = @{
		contentType = "html"
		content = "&lt;p&gt;&lt;em&gt;text&lt;/em&gt;&lt;/p&gt;&lt;attachment id="e8f78756199240b88448ae0fc6db112d"&gt;&lt;/attachment&gt;&lt;attachment id="638464e32834471ea202007da60a5ae6"&gt;&lt;/attachment&gt;"
	}
	attachments = @(
		@{
			id = "e8f78756199240b88448ae0fc6db112d"
			contentType = "application/vnd.microsoft.card.hero"
			contentUrl = $null
			content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here???s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "openUrl",
      "image": "https://urlp.asm.skype.com/v1/url/content?url=https%3a%2f%2fcdn2.iconfinder.com%2fdata%2ficons%2fsocial-icons-33%2f128%2fTrello-128.png",
      "title": "???????? click me ????????",
      "value": "http://microsoft.com"
    },
    {
      "type": "imback",
      "title": "&amp;i am back&amp; &lt;&gt;= \"",
      "value": "&amp;i am back&amp; &lt;&gt;= \""
    },
    {
      "type": "openUrl",
      "title": "Open URL",
      "value": "http://google.com"
    }
  ]
}"
			name = $null
			thumbnailUrl = $null
		}
		@{
			id = "638464e32834471ea202007da60a5ae6"
			contentType = "application/vnd.microsoft.card.hero"
			contentUrl = $null
			content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here???s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "messageBack",
      "title": "&amp;message back&amp; &lt;&gt;= \"",
      "text": "text = &amp;message back&amp; &lt;&gt;= \"",
      "displayText": "displayText = &amp;message back&amp; &lt;&gt;= \"",
      "value": {
        "text": "some text 2"
      }
    }
  ]
}"
			name = $null
			thumbnailUrl = $null
		}
	)
	mentions = @(
	)
	reactions = @(
	)
}

Update-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Update the reactions in a message using delegated permissions

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	messageType = "message"
	subject = $null
	summary = $null
	importance = "normal"
	locale = "en-us"
	from = @{
		application = $null
		device = $null
		user = @{
			id = "3b102402-813e-4e17-a6b2-f841aef1fdfc"
			displayName = "Lam Cong"
			userIdentityType = "aadUser"
		}
		conversation = $null
	}
	body = @{
		contentType = "html"
		content = "&lt;p&gt;&lt;em&gt;text&lt;/em&gt;&lt;/p&gt;&lt;attachment id="e8f78756199240b88448ae0fc6db112d"&gt;&lt;/attachment&gt;&lt;attachment id="638464e32834471ea202007da60a5ae6"&gt;&lt;/attachment&gt;"
	}
	attachments = @(
		@{
			id = "e8f78756199240b88448ae0fc6db112d"
			contentType = "application/vnd.microsoft.card.hero"
			contentUrl = $null
			content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here???s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "openUrl",
      "image": "https://urlp.asm.skype.com/v1/url/content?url=https%3a%2f%2fcdn2.iconfinder.com%2fdata%2ficons%2fsocial-icons-33%2f128%2fTrello-128.png",
      "title": "???????? click me ????????",
      "value": "http://microsoft.com"
    },
    {
      "type": "imback",
      "title": "&amp;i am back&amp; &lt;&gt;= \"",
      "value": "&amp;i am back&amp; &lt;&gt;= \""
    },
    {
      "type": "openUrl",
      "title": "Open URL",
      "value": "http://google.com"
    }
  ]
}"
			name = $null
			thumbnailUrl = $null
		}
		@{
			id = "638464e32834471ea202007da60a5ae6"
			contentType = "application/vnd.microsoft.card.hero"
			contentUrl = $null
			content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here???s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "messageBack",
      "title": "&amp;message back&amp; &lt;&gt;= \"",
      "text": "text = &amp;message back&amp; &lt;&gt;= \"",
      "displayText": "displayText = &amp;message back&amp; &lt;&gt;= \"",
      "value": {
        "text": "some text 2"
      }
    }
  ]
}"
			name = $null
			thumbnailUrl = $null
		}
	)
	mentions = @(
	)
	reactions = @(
		@{
			reactionType = "angry"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:30.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "f1b66449-b46d-49b0-9c3c-53c10a5c818e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "laugh"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:32.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "like"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T02:17:14.67Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "f1b66449-b46d-49b0-9c3c-53c10a5c818e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "like"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T02:34:40.3Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "4c9041b7-449a-40f7-8855-56da239b9fd1"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "like"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:25.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "heart"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:31.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "sad"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:33.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "surprised"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:34.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
	)
}

Update-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


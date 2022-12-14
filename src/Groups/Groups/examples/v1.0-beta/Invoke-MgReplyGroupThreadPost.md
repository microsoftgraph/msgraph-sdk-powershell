### Example 1: Using the Invoke-MgBetaReplyGroupThreadPost Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	Post = @{
		Body = @{
			ContentType = "html"
			Content = "<html><body><div><div><div><div>When and where? </div></div></div></div></body></html>"
		}
		Extensions = @(
			@{
				"@odata.type" = "microsoft.graph.openTypeExtension"
				ExtensionName = "Com.Contoso.HR"
				CompanyName = "Contoso"
				ExpirationDate = "2015-07-03T13:04:00.000Z"
				TopPicks = @(
					"Employees only"
					"Add spouse or guest"
					"Add family"
				)
			}
		)
	}
}
Invoke-MgBetaReplyGroupThreadPost -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaReplyGroupThreadPost Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Invoke-MgBetaReplyGroupThreadPost Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	Post = @{
		Body = @{
			ContentType = ""
			Content = "content-value"
		}
		ReceivedDateTime = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
		HasAttachments = $true
		From = @{
			EmailAddress = @{
				Name = "name-value"
				Address = "address-value"
			}
		}
		Sender = @{
			EmailAddress = @{
				Name = "name-value"
				Address = "address-value"
			}
		}
		ConversationThreadId = "conversationThreadId-value"
		NewParticipants = @(
			@{
				EmailAddress = @{
					Name = "name-value"
					Address = "address-value"
				}
			}
		)
		ConversationId = "conversationId-value"
		CreatedDateTime = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
		LastModifiedDateTime = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
		ChangeKey = "changeKey-value"
		Categories = @(
			"categories-value"
		)
		Id = "id-value"
		InReplyTo = @{
		}
		Attachments = @(
			@{
				"@odata.type" = "#microsoft.graph.fileAttachment"
				LastModifiedDateTime = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
				Name = "name-value"
				ContentType = "contentType-value"
				Size = 99
				IsInline = $true
				Id = "id-value"
			}
		)
	}
}
Invoke-MgBetaReplyGroupThreadPost -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaReplyGroupThreadPost Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

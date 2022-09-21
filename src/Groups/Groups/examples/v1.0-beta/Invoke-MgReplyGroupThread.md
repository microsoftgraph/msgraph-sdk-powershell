### Example 1: Using the Invoke-MgReplyGroupThread Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	Post = @{
		Body = @{
			ContentType = ""
			Content = "content-value"
		}
	}
}
Invoke-MgReplyGroupThread -GroupId $groupId -ConversationThreadId $conversationThreadId -BodyParameter $params
```
This example shows how to use the Invoke-MgReplyGroupThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Invoke-MgReplyGroupThread Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	Post = @{
		Body = @{
			ContentType = "text"
			Content = "Which quarter does that file cover? See my attachment."
		}
		Attachments = @(
			@{
				"@odata.type" = "#microsoft.graph.fileAttachment"
				Name = "Another file as attachment"
				ContentBytes = "VGhpcyBpcyBhIGZpbGUgdG8gYmUgYXR0YWNoZWQu"
			}
		)
	}
}
Invoke-MgReplyGroupThread -GroupId $groupId -ConversationThreadId $conversationThreadId -BodyParameter $params
```
This example shows how to use the Invoke-MgReplyGroupThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Invoke-MgReplyGroupThread Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	Post = @{
		Body = @{
			ContentType = "text"
			Content = "I attached an event."
		}
		Attachments = @(
			@{
				"@odata.type" = "#microsoft.graph.itemAttachment"
				Name = "Holiday event"
				Item = @{
					"@odata.type" = "microsoft.graph.event"
					Subject = "Discuss gifts for children"
				}
			}
		)
	}
}
Invoke-MgReplyGroupThread -GroupId $groupId -ConversationThreadId $conversationThreadId -BodyParameter $params
```
This example shows how to use the Invoke-MgReplyGroupThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Invoke-MgReplyGroupThread Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	Post = @{
		Body = @{
			ContentType = "text"
			Content = "I attached a reference to a file on OneDrive."
		}
		Attachments = @(
			@{
				"@odata.type" = "#microsoft.graph.referenceAttachment"
				Name = "Personal pictures"
				SourceUrl = "https://contoso.com/personal/mario_contoso_net/Documents/Pics"
				ProviderType = "oneDriveConsumer"
				Permission = "Edit"
				IsFolder = "True"
			}
		)
	}
}
Invoke-MgReplyGroupThread -GroupId $groupId -ConversationThreadId $conversationThreadId -BodyParameter $params
```
This example shows how to use the Invoke-MgReplyGroupThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

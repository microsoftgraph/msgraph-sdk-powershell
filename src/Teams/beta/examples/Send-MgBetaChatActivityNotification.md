### Example 1: Using the Send-MgBetaChatActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/chats/{chatId}"
	}
	ActivityType = "taskCreated"
	PreviewText = @{
		Content = "New Task Created"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "taskId"
			Value = "Task 12322"
		}
	)
}
Send-MgBetaChatActivityNotification -ChatId $chatId -BodyParameter $params
```
This example shows how to use the Send-MgBetaChatActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Send-MgBetaChatActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/chats/{chatId}/messages/{messageId}"
	}
	ActivityType = "approvalRequired"
	PreviewText = @{
		Content = "Deployment requires your approval"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "approvalTaskId"
			Value = "2020AAGGTAPP"
		}
	)
}
Send-MgBetaChatActivityNotification -ChatId $chatId -BodyParameter $params
```
This example shows how to use the Send-MgBetaChatActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Send-MgBetaChatActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	Topic = @{
		Source = "text"
		Value = "Deployment Approvals Channel"
		WebUrl = "https://teams.microsoft.com/l/message/19:448cfd2ac2a7490a9084a9ed14cttr78c@thread.skype/1605223780000?tenantId=c8b1bf45-3834-4ecf-971a-b4c755ee677d&groupId=d4c2a937-f097-435a-bc91-5c1683ca7245&parentMessageId=1605223771864&teamName=Approvals&channelName=Azure%20DevOps&createdTime=1605223780000"
	}
	ActivityType = "deploymentApprovalRequired"
	PreviewText = @{
		Content = "New deployment requires your approval"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "deploymentId"
			Value = "6788662"
		}
	)
}
Send-MgBetaChatActivityNotification -ChatId $chatId -BodyParameter $params
```
This example shows how to use the Send-MgBetaChatActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Send-MgBetaChatActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/chats/19:1c3af46e9e0f4a5293343c8813c47619@thread.v2"
	}
	ActivityType = "taskCreated"
	PreviewText = @{
		Content = "New Task Created"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.chatMembersNotificationRecipient"
		ChatId = "19:1c3af46e9e0f4a5293343c8813c47619@thread.v2"
	}
	TemplateParameters = @(
		@{
			Name = "taskId"
			Value = "Task 12322"
		}
	)
}
Send-MgBetaChatActivityNotification -ChatId $chatId -BodyParameter $params
```
This example shows how to use the Send-MgBetaChatActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Send-MgBetaChatActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/chats/{chatId}/messages/{messageId}"
	}
	ActivityType = "approvalRequired"
	PreviewText = @{
		Content = "Deployment requires your approval"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "jacob@contoso.com"
	}
	TemplateParameters = @(
		@{
			Name = "approvalTaskId"
			Value = "2020AAGGTAPP"
		}
	)
}
Send-MgBetaChatActivityNotification -ChatId $chatId -BodyParameter $params
```
This example shows how to use the Send-MgBetaChatActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

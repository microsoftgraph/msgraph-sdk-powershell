### Example 1: Using the Send-MgTeamActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/teams/{teamId}"
	}
	ActivityType = "pendingFinanceApprovalRequests"
	PreviewText = @{
		Content = "Internal spending team has a pending finance approval requests"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "pendingRequestCount"
			Value = "5"
		}
	)
}
Send-MgTeamActivityNotification -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Send-MgTeamActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Send-MgTeamActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/teams/{teamId}/channels/{channelId}/tabs/{tabId}"
	}
	ActivityType = "reservationUpdated"
	PreviewText = @{
		Content = "You have moved up the queue"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "reservationId"
			Value = "TREEE433"
		}
		@{
			Name = "currentSlot"
			Value = "23"
		}
	)
}
Send-MgTeamActivityNotification -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Send-MgTeamActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Send-MgTeamActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
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
Send-MgTeamActivityNotification -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Send-MgTeamActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Send-MgTeamActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/teams/e8bece96-d393-4b9b-b8da-69cedef1a7e7"
	}
	ActivityType = "pendingFinanceApprovalRequests"
	PreviewText = @{
		Content = "Internal spending team has a pending finance approval requests"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.channelMembersNotificationRecipient"
		TeamId = "e8bece96-d393-4b9b-b8da-69cedef1a7e7"
		ChannelId = "19:3d61a2309f094f4a9310b20f1db37520@thread.tacv2"
	}
	TemplateParameters = @(
		@{
			Name = "pendingRequestCount"
			Value = "5"
		}
	)
}
Send-MgTeamActivityNotification -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Send-MgTeamActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Send-MgTeamActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/teams/{teamId}/channels/{channelId}/tabs/{tabId}"
	}
	ActivityType = "reservationUpdated"
	PreviewText = @{
		Content = "You have moved up the queue"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "reservationId"
			Value = "TREEE433"
		}
		@{
			Name = "currentSlot"
			Value = "23"
		}
	)
}
Send-MgTeamActivityNotification -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Send-MgTeamActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the Send-MgTeamActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/teams/{teamId}"
	}
	ActivityType = "pendingFinanceApprovalRequests"
	PreviewText = @{
		Content = "Internal spending team has a pending finance approval requests"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "pendingRequestCount"
			Value = "5"
		}
	)
}
Send-MgTeamActivityNotification -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Send-MgTeamActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 7: Using the Send-MgTeamActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/teams/e8bece96-d393-4b9b-b8da-69cedef1a7e7"
	}
	ActivityType = "pendingFinanceApprovalRequests"
	PreviewText = @{
		Content = "Internal spending team has a pending finance approval requests"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.teamMembersNotificationRecipient"
		TeamId = "e8bece96-d393-4b9b-b8da-69cedef1a7e7"
	}
	TemplateParameters = @(
		@{
			Name = "pendingRequestCount"
			Value = "5"
		}
	)
}
Send-MgTeamActivityNotification -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Send-MgTeamActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 8: Using the Send-MgTeamActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
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
Send-MgTeamActivityNotification -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Send-MgTeamActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 9: Using the Send-MgTeamActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/teams/{teamId}/channels/{channelId}/tabs/{tabId}"
	}
	ActivityType = "reservationUpdated"
	PreviewText = @{
		Content = "You have moved up the queue"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "jacob@contoso.com"
	}
	TemplateParameters = @(
		@{
			Name = "reservationId"
			Value = "TREEE433"
		}
		@{
			Name = "currentSlot"
			Value = "23"
		}
	)
}
Send-MgTeamActivityNotification -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Send-MgTeamActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

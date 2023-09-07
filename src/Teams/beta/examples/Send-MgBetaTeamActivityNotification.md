### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	topic = @{
		source = "entityUrl"
		value = "https://graph.microsoft.com/beta/teams/{teamId}/channels/{channelId}/tabs/{tabId}"
	}
	activityType = "reservationUpdated"
	previewText = @{
		content = "You have moved up the queue"
	}
	recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		userId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	templateParameters = @(
		@{
			name = "reservationId"
			value = "TREEE433"
		}
		@{
			name = "currentSlot"
			value = "23"
		}
	)
}

Send-MgBetaTeamActivityNotification -TeamId $teamId -BodyParameter $params

```
This example shows how to use the Send-MgBetaTeamActivityNotification Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	topic = @{
		source = "entityUrl"
		value = "https://graph.microsoft.com/beta/teams/{teamId}/channels/{channelId}/tabs/{tabId}"
	}
	activityType = "reservationUpdated"
	previewText = @{
		content = "You have moved up the queue"
	}
	recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		userId = "jacob@contoso.com"
	}
	templateParameters = @(
		@{
			name = "reservationId"
			value = "TREEE433"
		}
		@{
			name = "currentSlot"
			value = "23"
		}
	)
}

Send-MgBetaTeamActivityNotification -TeamId $teamId -BodyParameter $params

```
This example shows how to use the Send-MgBetaTeamActivityNotification Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	topic = @{
		source = "text"
		value = "Deployment Approvals Channel"
		webUrl = "https://teams.microsoft.com/l/message/19:448cfd2ac2a7490a9084a9ed14cttr78c@thread.skype/1605223780000?tenantId=c8b1bf45-3834-4ecf-971a-b4c755ee677d&groupId=d4c2a937-f097-435a-bc91-5c1683ca7245&parentMessageId=1605223771864&teamName=Approvals&channelName=Azure%20DevOps&createdTime=1605223780000"
	}
	activityType = "deploymentApprovalRequired"
	previewText = @{
		content = "New deployment requires your approval"
	}
	recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		userId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	templateParameters = @(
		@{
			name = "deploymentId"
			value = "6788662"
		}
	)
}

Send-MgBetaTeamActivityNotification -TeamId $teamId -BodyParameter $params

```
This example shows how to use the Send-MgBetaTeamActivityNotification Cmdlet.

### Example 4: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	topic = @{
		source = "entityUrl"
		value = "https://graph.microsoft.com/beta/teams/e8bece96-d393-4b9b-b8da-69cedef1a7e7"
	}
	activityType = "pendingFinanceApprovalRequests"
	previewText = @{
		content = "Internal spending team has a pending finance approval requests"
	}
	recipient = @{
		"@odata.type" = "microsoft.graph.teamMembersNotificationRecipient"
		teamId = "e8bece96-d393-4b9b-b8da-69cedef1a7e7"
	}
	templateParameters = @(
		@{
			name = "pendingRequestCount"
			value = "5"
		}
	)
}

Send-MgBetaTeamActivityNotification -TeamId $teamId -BodyParameter $params

```
This example shows how to use the Send-MgBetaTeamActivityNotification Cmdlet.

### Example 5: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	topic = @{
		source = "entityUrl"
		value = "https://graph.microsoft.com/beta/teams/e8bece96-d393-4b9b-b8da-69cedef1a7e7"
	}
	activityType = "pendingFinanceApprovalRequests"
	previewText = @{
		content = "Internal spending team has a pending finance approval requests"
	}
	recipient = @{
		"@odata.type" = "microsoft.graph.channelMembersNotificationRecipient"
		teamId = "e8bece96-d393-4b9b-b8da-69cedef1a7e7"
		channelId = "19:3d61a2309f094f4a9310b20f1db37520@thread.tacv2"
	}
	templateParameters = @(
		@{
			name = "pendingRequestCount"
			value = "5"
		}
	)
}

Send-MgBetaTeamActivityNotification -TeamId $teamId -BodyParameter $params

```
This example shows how to use the Send-MgBetaTeamActivityNotification Cmdlet.


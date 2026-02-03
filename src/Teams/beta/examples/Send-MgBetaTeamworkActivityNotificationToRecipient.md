### Example 1: Notify multiple users about pending finance approval requests

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	topic = @{
		source = "entityUrl"
		value = "https://graph.microsoft.com/beta/appCatalogs/teamsApps/{teamsAppId}"
	}
	activityType = "pendingFinanceApprovalRequests"
	previewText = @{
		content = "Internal spending team has a pending finance approval requests"
	}
	recipients = @(
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			userId = "569363e2-4e49-4661-87f2-16f245c5d66a"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			userId = "ab88234e-0874-477c-9638-d144296ed04f"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			userId = "01c64f53-69aa-42c7-9b7f-9f75195d6bfc"
		}
	)
	templateParameters = @(
		@{
			name = "pendingRequestCount"
			value = "5"
		}
	)
}

Send-MgBetaTeamworkActivityNotificationToRecipient -BodyParameter $params

```
This example will notify multiple users about pending finance approval requests

### Example 2: Notify multiple users about an event using a custom topic

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
	templateParameters = @(
		@{
			name = "deploymentId"
			value = "6788662"
		}
	)
	recipients = @(
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			userId = "569363e2-4e49-4661-87f2-16f245c5d66a"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			userId = "ab88234e-0874-477c-9638-d144296ed04f"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			userId = "01c64f53-69aa-42c7-9b7f-9f75195d6bfc"
		}
	)
}

Send-MgBetaTeamworkActivityNotificationToRecipient -BodyParameter $params

```
This example will notify multiple users about an event using a custom topic


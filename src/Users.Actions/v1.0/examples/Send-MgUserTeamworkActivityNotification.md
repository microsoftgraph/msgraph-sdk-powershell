### Example 1: Send notification to a user for a task created

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	topic = @{
		source = "entityUrl"
		value = "https://graph.microsoft.com/v1.0/users/{userId}/teamwork/installedApps/{installationId}"
	}
	activityType = "taskCreated"
	previewText = @{
		content = "New Task Created"
	}
	templateParameters = @(
		@{
			name = "taskId"
			value = "Task 12322"
		}
	)
}

Send-MgUserTeamworkActivityNotification -UserId $userId -BodyParameter $params

```
This example will send notification to a user for a task created

### Example 2: Notify a user about an event using a custom topic

```powershell

Import-Module Microsoft.Graph.Users.Actions

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
}

Send-MgUserTeamworkActivityNotification -UserId $userId -BodyParameter $params

```
This example will notify a user about an event using a custom topic


### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Groups

$params = @{
	originalStartTimeZone = "originalStartTimeZone-value"
	originalEndTimeZone = "originalEndTimeZone-value"
	iCalUId = "iCalUId-value"
	reminderMinutesBeforeStart = 
	isReminderOn = $true
}

Update-MgBetaGroupThread -GroupId $groupId -ConversationThreadId $conversationThreadId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaBetaGroupThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


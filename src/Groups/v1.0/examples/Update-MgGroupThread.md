### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Groups

$params = @{
	originalStartTimeZone = "originalStartTimeZone-value"
	originalEndTimeZone = "originalEndTimeZone-value"
	iCalUId = "iCalUId-value"
	reminderMinutesBeforeStart = 
	isReminderOn = $true
}

Update-MgGroupThread -GroupId $groupId -ConversationThreadId $conversationThreadId -BodyParameter $params
```
This example shows how to use the Update-MgGroupThread Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


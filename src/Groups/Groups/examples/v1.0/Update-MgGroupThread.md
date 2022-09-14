### Example 1
``` powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	OriginalStartTimeZone = "originalStartTimeZone-value"
	OriginalEndTimeZone = "originalEndTimeZone-value"
	ICalUId = "iCalUId-value"
	ReminderMinutesBeforeStart = 
	IsReminderOn = $true
}
Update-MgGroupThread -GroupId $groupId -ConversationThreadId $conversationThreadId -BodyParameter $params
```

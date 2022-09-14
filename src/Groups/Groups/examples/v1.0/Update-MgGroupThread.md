### Example 1: Using the Update-MgGroupThread Cmdlet
```powershell
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
This example shows how to use the Update-MgGroupThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: Using the Update-MgBetaGroupThread Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	OriginalStartTimeZone = "originalStartTimeZone-value"
	OriginalEndTimeZone = "originalEndTimeZone-value"
	Uid = "iCalUId-value"
	ReminderMinutesBeforeStart = 
	IsReminderOn = $true
}
Update-MgBetaGroupThread -GroupId $groupId -ConversationThreadId $conversationThreadId -BodyParameter $params
```
This example shows how to use the Update-MgBetaGroupThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

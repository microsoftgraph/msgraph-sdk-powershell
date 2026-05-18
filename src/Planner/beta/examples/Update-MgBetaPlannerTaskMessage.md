### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	content = "<div>Updated message with <span itemid="0" itemtype="https://schema.skype.com/Mention/Person"></span> mention</div>"
	mentions = @(
		@{
			mentioned = "6463a5ce-2119-4198-9f2a-628761df4a62"
			position = 0
			mentionType = "user"
		}
	)
}

Update-MgBetaPlannerTaskMessage -PlannerTaskId $plannerTaskId -PlannerTaskChatMessageId $plannerTaskChatMessageId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPlannerTaskMessage Cmdlet.


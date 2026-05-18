### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	reactionType = "like"
}

Set-MgBetaPlannerTaskMessageReaction -PlannerTaskId $plannerTaskId -PlannerTaskChatMessageId $plannerTaskChatMessageId -BodyParameter $params

```
This example shows how to use the Set-MgBetaPlannerTaskMessageReaction Cmdlet.


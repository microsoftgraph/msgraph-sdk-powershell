### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	reactionType = "like"
}

Clear-MgBetaPlannerTaskMessageReaction -PlannerTaskId $plannerTaskId -PlannerTaskChatMessageId $plannerTaskChatMessageId -BodyParameter $params

```
This example shows how to use the Clear-MgBetaPlannerTaskMessageReaction Cmdlet.


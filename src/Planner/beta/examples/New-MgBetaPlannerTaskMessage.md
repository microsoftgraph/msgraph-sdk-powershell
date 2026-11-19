### Example 1: Create a message

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	content = "This is a new chat message"
}

New-MgBetaPlannerTaskMessage -PlannerTaskId $plannerTaskId -BodyParameter $params

```
This example will create a message

### Example 2: Create a message with mentions

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	content = "<div><span itemid="0" itemtype="https://schema.skype.com/Mention/Person"></span> Please review this task</div>"
	mentions = @(
		@{
			mentioned = "6463a5ce-2119-4198-9f2a-628761df4a62"
			position = 0
			mentionType = "user"
		}
	)
}

New-MgBetaPlannerTaskMessage -PlannerTaskId $plannerTaskId -BodyParameter $params

```
This example will create a message with mentions


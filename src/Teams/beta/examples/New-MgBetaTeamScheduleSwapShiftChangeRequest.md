### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	senderShiftId = "5ad10161-6524-4c7c-9beb-4e8677ba2f6d"
	senderMessage = "I can't make my shift, any chance we can swap?"
	recipientUserId = "567c8ea5-9e32-422a-a663-8270201699cd"
	recipientShiftId = "e73408ca-3ea5-4bbf-96a8-2e06c95f7a2c"
}

New-MgBetaTeamScheduleSwapShiftChangeRequest -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamScheduleSwapShiftChangeRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


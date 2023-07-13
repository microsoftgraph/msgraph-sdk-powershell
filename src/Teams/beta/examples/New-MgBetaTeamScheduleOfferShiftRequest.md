### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	senderShiftId = "SHFT_f7e484ed-fdd6-421c-92d9-0bc9e62e2c29"
	senderMessage = "Having a family emergency, could you take this shift for me?"
	recipientUserId = "fe278b61-21ac-4872-8b41-1962bbb98e3c"
}

New-MgBetaTeamScheduleOfferShiftRequest -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamScheduleOfferShiftRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


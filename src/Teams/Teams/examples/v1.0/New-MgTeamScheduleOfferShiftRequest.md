### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	SenderShiftId = "SHFT_f7e484ed-fdd6-421c-92d9-0bc9e62e2c29"
	SenderMessage = "Having a family emergency, could you take this shift for me?"
	RecipientUserId = "fe278b61-21ac-4872-8b41-1962bbb98e3c"
}
New-MgTeamScheduleOfferShiftRequest -TeamId $teamId -BodyParameter $params
```

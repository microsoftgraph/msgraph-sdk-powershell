### Example 1: Using the Update-MgTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	PolicyViolation = @{
		PolicyTip = @{
			GeneralText = "This item has been blocked by the administrator."
			ComplianceUrl = "https://contoso.com/dlp-policy-page"
			MatchedConditionDescriptions = @(
				"Credit Card Number"
			)
		}
		VerdictDetails = "AllowOverrideWithoutJustification,AllowFalsePositiveOverride"
		DlpAction = "BlockAccess"
	}
}
Update-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the Update-MgTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

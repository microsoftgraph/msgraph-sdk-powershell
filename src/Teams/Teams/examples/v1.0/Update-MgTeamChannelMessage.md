###Example 1
```
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

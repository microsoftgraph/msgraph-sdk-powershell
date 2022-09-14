### Example 1
``` powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	"@odata.type" = "Microsoft.OutlookServices.OpenTypeExtension"
	ExtensionName = "Com.Contoso.Estimate"
	CompanyName = "Contoso"
	ExpirationDate = "2016-07-30T11:00:00.000Z"
	DealValue = 
	TopPicks = @(
		"Employees only"
		"Add spouse or guest"
		"Add family"
	)
}
Update-MgGroupThreadPostExtension -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -ExtensionId $extensionId -BodyParameter $params
```

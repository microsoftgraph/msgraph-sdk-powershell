### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Groups

$params = @{
	"@odata.type" = "Microsoft.OutlookServices.OpenTypeExtension"
	extensionName = "Com.Contoso.Estimate"
	companyName = "Contoso"
	expirationDate = "2016-07-30T11:00:00.000Z"
	DealValue = 
	topPicks = @(
		"Employees only"
		"Add spouse or guest"
		"Add family"
	)
}

Update-MgGroupThreadPostExtension -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -ExtensionId $extensionId -BodyParameter $params
```
This example shows how to use the Get-MgGroupThreadPostExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


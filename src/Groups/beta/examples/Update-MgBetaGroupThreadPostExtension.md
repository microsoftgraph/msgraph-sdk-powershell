### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Groups

$params = @{
	"@odata.type" = "#microsoft.outlookServices.openTypeExtension"
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

Update-MgBetaGroupThreadPostExtension -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -ExtensionId $extensionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaGroupThreadPostExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


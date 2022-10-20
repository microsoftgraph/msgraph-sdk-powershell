### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users.Actions

$params = @{
	DestinationId = "deleteditems"
}

# A UPN can also be used as -UserId.
Move-MgUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Move-MgUserMailFolderMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


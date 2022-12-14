### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	DestinationId = "deleteditems"
}

# A UPN can also be used as -UserId.
Move-MgBetaUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Move-MgBetaUserMailFolderMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


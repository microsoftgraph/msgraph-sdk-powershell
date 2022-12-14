### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	DestinationId = "destinationId-value"
}

# A UPN can also be used as -UserId.
Copy-MgBetaUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Copy-MgBetaUserMailFolderMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


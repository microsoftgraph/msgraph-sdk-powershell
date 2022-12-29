### Example 1: Using the Move-MgBetaUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	DestinationId = "deleteditems"
}
# A UPN can also be used as -UserId.
Move-MgBetaUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Move-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

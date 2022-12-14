### Example 1: Using the Copy-MgBetaUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	DestinationId = "destinationId-value"
}
# A UPN can also be used as -UserId.
Copy-MgBetaUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Copy-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

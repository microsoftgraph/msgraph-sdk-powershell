### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	destinationId = "deleteditems"
}

# A UPN can also be used as -UserId.
Move-MgBetaUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params

```
This example shows how to use the Move-MgBetaUserMessage Cmdlet.


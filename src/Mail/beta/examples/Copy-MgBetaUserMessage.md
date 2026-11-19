### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Mail

$params = @{
	destinationId = "destinationId-value"
}

# A UPN can also be used as -UserId.
Copy-MgBetaUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params

```
This example shows how to use the Copy-MgBetaUserMessage Cmdlet.


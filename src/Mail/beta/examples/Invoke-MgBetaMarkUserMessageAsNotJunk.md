### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Mail

$params = @{
	moveToInbox = $true
}

# A UPN can also be used as -UserId.
Invoke-MgBetaMarkUserMessageAsNotJunk -UserId $userId -MessageId $messageId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaMarkUserMessageAsNotJunk Cmdlet.


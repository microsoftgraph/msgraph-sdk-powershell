### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Mail

$params = @{
	moveToJunk = $true
}

# A UPN can also be used as -UserId.
Invoke-MgBetaMarkUserMessageAsJunk -UserId $userId -MessageId $messageId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaMarkUserMessageAsJunk Cmdlet.


### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	comment = "comment-value"
	toRecipients = @(
		@{
			emailAddress = @{
				name = "name-value"
				address = "address-value"
			}
		}
	)
}

# A UPN can also be used as -UserId.
Invoke-MgForwardUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params

```
This example shows how to use the Invoke-MgForwardUserMessage Cmdlet.


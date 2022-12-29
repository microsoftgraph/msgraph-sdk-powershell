### Example 1: Using the Invoke-MgBetaForwardUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	Message = @{
		IsDeliveryReceiptRequested = $true
		ToRecipients = @(
			@{
				EmailAddress = @{
					Address = "danas@contoso.onmicrosoft.com"
					Name = "Dana Swope"
				}
			}
		)
	}
	Comment = "Dana, just want to make sure you get this."
}
# A UPN can also be used as -UserId.
Invoke-MgBetaForwardUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaForwardUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

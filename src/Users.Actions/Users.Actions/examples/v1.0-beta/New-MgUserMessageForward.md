### Example 1: Using the New-MgUserMessageForward Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
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
	Comment = "Dana, just want to make sure you get this; you'll need this if the project gets approved."
}
# A UPN can also be used as -UserId.
New-MgUserMessageForward -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgUserMessageForward Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

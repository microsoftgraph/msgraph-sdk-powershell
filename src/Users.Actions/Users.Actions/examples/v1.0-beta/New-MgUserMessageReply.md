### Example 1: Using the New-MgBetaUserMessageReply Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	Message = @{
		ToRecipients = @(
			@{
				EmailAddress = @{
					Address = "samanthab@contoso.onmicrosoft.com"
					Name = "Samantha Booth"
				}
			}
			@{
				EmailAddress = @{
					Address = "randiw@contoso.onmicrosoft.com"
					Name = "Randi Welch"
				}
			}
		)
	}
	Comment = "Samantha, Randi, would you name the group if the project is approved, please?"
}
# A UPN can also be used as -UserId.
New-MgBetaUserMessageReply -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessageReply Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

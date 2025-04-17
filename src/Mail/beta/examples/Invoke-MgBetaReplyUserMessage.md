### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Mail

$params = @{
	message = @{
		toRecipients = @(
			@{
				emailAddress = @{
					address = "samanthab@contoso.com"
					name = "Samantha Booth"
				}
			}
			@{
				emailAddress = @{
					address = "randiw@contoso.com"
					name = "Randi Welch"
				}
			}
		)
	}
	comment = "Samantha, Randi, would you name the group please?"
}

# A UPN can also be used as -UserId.
Invoke-MgBetaReplyUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaReplyUserMessage Cmdlet.


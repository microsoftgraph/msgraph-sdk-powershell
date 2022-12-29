### Example 1: Reply in JSON format to an existing message

```powershellImport-Module Microsoft.Graph.Users.Actions

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
	Comment = "Samantha, Randi, would you name the group please?"
}

# A UPN can also be used as -UserId.
Invoke-MgReplyUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Invoke-MgReplyUserMailFolderChildFolderMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users.Actions

$params = @{
	Comment = "comment-value"
	ToRecipients = @(
		@{
			EmailAddress = @{
				Name = "name-value"
				Address = "address-value"
			}
		}
	)
}

# A UPN can also be used as -UserId.
Invoke-MgForwardUserMessage -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the Invoke-MgForwardUserMailFolderMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


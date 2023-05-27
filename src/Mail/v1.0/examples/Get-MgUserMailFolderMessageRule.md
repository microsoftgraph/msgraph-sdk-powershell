### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Mail

$params = @{
	displayName = "Important from partner"
	actions = @{
		markImportance = "high"
	}
}

# A UPN can also be used as -UserId.
Update-MgUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId -MessageRuleId $messageRuleId -BodyParameter $params
```
This example shows how to use the Get-MgUserMailFolderMessageRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


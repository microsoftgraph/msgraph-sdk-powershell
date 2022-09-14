### Example 1
``` powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	DisplayName = "Important from partner"
	Actions = @{
		MarkImportance = "high"
	}
}
# A UPN can also be used as -UserId.
Update-MgUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId -MessageRuleId $messageRuleId -BodyParameter $params
```

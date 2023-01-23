### Example 1: Using the Update-MgUserMailFolderMessageRule Cmdlet
```powershell
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
This example shows how to use the Update-MgUserMailFolderMessageRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

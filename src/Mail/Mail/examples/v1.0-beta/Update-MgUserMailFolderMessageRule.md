### Example 1: Using the Update-MgBetaUserMailFolderMessageRule Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	DisplayName = "Important from partner"
	Actions = @{
		MarkImportance = "high"
	}
}
# A UPN can also be used as -UserId.
Update-MgBetaUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId -MessageRuleId $messageRuleId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserMailFolderMessageRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

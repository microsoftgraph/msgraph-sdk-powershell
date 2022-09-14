### Example 1
``` powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	DisplayName = "displayName-value"
}
# A UPN can also be used as -UserId.
Update-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	"@odata.type" = "microsoft.graph.mailSearchFolder"
	FilterQuery = "contains(subject, 'Analytics')"
}
# A UPN can also be used as -UserId.
Update-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```

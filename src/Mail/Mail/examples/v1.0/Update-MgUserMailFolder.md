###Example 1
```
Import-Module Microsoft.Graph.Mail
$params = @{
	DisplayName = "displayName-value"
}
# A UPN can also be used as -UserId.
Update-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Mail
$params = @{
	"@odata.type" = "microsoft.graph.mailSearchFolder"
	FilterQuery = "contains(subject, 'Analytics')"
}
# A UPN can also be used as -UserId.
Update-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```

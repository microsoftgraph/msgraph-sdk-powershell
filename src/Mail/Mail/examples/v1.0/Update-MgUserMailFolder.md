### Example 1: Using the Update-MgUserMailFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	DisplayName = "displayName-value"
}
# A UPN can also be used as -UserId.
Update-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the Update-MgUserMailFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgUserMailFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	"@odata.type" = "microsoft.graph.mailSearchFolder"
	FilterQuery = "contains(subject, 'Analytics')"
}
# A UPN can also be used as -UserId.
Update-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the Update-MgUserMailFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

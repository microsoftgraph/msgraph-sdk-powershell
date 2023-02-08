### Example 1: Using the New-MgUserMailFolderChildFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	DisplayName = "displayName-value"
	IsHidden = $true
}
# A UPN can also be used as -UserId.
New-MgUserMailFolderChildFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the New-MgUserMailFolderChildFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgUserMailFolderChildFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	"@odata.type" = "microsoft.graph.mailSearchFolder"
	DisplayName = "Weekly digests"
	IncludeNestedFolders = $true
	SourceFolderIds = @(
		"AQMkADYAAAIBDAAAAA=="
	)
	FilterQuery = "contains(subject, 'weekly digest')"
}
# A UPN can also be used as -UserId.
New-MgUserMailFolderChildFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the New-MgUserMailFolderChildFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

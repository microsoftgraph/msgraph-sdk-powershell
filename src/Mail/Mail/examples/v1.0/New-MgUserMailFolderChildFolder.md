###Example 1
```
Import-Module Microsoft.Graph.Mail
$params = @{
	DisplayName = "displayName-value"
	IsHidden = $true
}
# A UPN can also be used as -UserId.
New-MgUserMailFolderChildFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
###Example 2
```
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

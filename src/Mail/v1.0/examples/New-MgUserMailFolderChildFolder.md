### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Mail

$params = @{
	"@odata.type" = "microsoft.graph.mailSearchFolder"
	displayName = "Weekly digests"
	includeNestedFolders = $true
	sourceFolderIds = @(
		"AQMkADYAAAIBDAAAAA=="
	)
	filterQuery = "contains(subject, 'weekly digest')"
}

# A UPN can also be used as -UserId.
New-MgUserMailFolderChildFolder -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the New-MgUserMailFolderChildFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


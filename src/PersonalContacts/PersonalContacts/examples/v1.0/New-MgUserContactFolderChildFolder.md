### Example 1
```powershell
Import-Module Microsoft.Graph.PersonalContacts
$params = @{
	DisplayName = "Family"
}
# A UPN can also be used as -UserId.
New-MgUserContactFolderChildFolder -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```

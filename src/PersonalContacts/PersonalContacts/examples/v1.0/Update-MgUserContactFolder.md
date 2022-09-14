### Example 1
```powershell
Import-Module Microsoft.Graph.PersonalContacts
$params = @{
	ParentFolderId = "parentFolderId-value"
	DisplayName = "displayName-value"
}
# A UPN can also be used as -UserId.
Update-MgUserContactFolder -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```

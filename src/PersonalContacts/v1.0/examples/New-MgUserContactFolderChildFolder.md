### Example 1: Using the New-MgUserContactFolderChildFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.PersonalContacts
$params = @{
	DisplayName = "Family"
}
# A UPN can also be used as -UserId.
New-MgUserContactFolderChildFolder -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```
This example shows how to use the New-MgUserContactFolderChildFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

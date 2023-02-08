### Example 1: Using the Update-MgUserContactFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.PersonalContacts
$params = @{
	ParentFolderId = "parentFolderId-value"
	DisplayName = "displayName-value"
}
# A UPN can also be used as -UserId.
Update-MgUserContactFolder -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```
This example shows how to use the Update-MgUserContactFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

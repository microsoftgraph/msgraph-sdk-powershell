### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.PersonalContacts

$params = @{
	displayName = "Family"
}

# A UPN can also be used as -UserId.
New-MgUserContactFolderChildFolder -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```
This example shows how to use the New-MgUserContactFolderChildFolder Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


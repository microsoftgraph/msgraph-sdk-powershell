### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.PersonalContacts

$params = @{
	parentFolderId = "parentFolderId-value"
	displayName = "displayName-value"
}

# A UPN can also be used as -UserId.
Update-MgUserContactFolder -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```
This example shows how to use the Remove-MgUserContactFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


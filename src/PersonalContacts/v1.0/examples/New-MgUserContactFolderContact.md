### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.PersonalContacts

$params = @{
	parentFolderId = "parentFolderId-value"
	birthday = [System.DateTime]::Parse("datetime-value")
	fileAs = "fileAs-value"
	displayName = "displayName-value"
	givenName = "givenName-value"
	initials = "initials-value"
}

# A UPN can also be used as -UserId.
New-MgUserContactFolderContact -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```
This example shows how to use the New-MgUserContactFolderContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).


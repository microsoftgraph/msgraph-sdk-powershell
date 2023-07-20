### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.PersonalContacts

$params = @{
	parentFolderId = "parentFolderId-value"
	birthday = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
	fileAs = "fileAs-value"
	displayName = "displayName-value"
	givenName = "givenName-value"
	initials = "initials-value"
}

# A UPN can also be used as -UserId.
New-MgBetaUserContactFolderContact -UserId $userId -ContactFolderId $contactFolderId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserContactFolderContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

